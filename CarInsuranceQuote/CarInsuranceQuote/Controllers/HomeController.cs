using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CarInsuranceQuote.Models;
using System.Data.SqlClient;
using System.Data;

namespace CarInsuranceQuote.Controllers
{
    public class HomeController : Controller
    {
        private readonly string connectionString = @"Server=localhost,1433;Database=Quote;User=sa;Password=<YourStrong@Passw0rd>;";

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetQuote(string firstName, string lastName, string email,
            DateTime DOB, int CarYear, string CarMake, string CarModel, bool DUIbool,
            int Speeding, bool InsuranceType)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(email))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {

                int QuotePrice = 50;
                var today = DateTime.Today;
                int age = Convert.ToInt32((today - DOB).Days / 365.25);
                if (age < 18)
                {
                    QuotePrice = QuotePrice + 100;
                }
                else if (age < 25 || age > 100)
                {
                    QuotePrice = QuotePrice + 25;
                }

                if (CarYear < 2000 || CarYear > 2015)
                {
                    QuotePrice = QuotePrice + 25;
                }

                if (CarMake == "Porsche")
                {
                    QuotePrice += 25;
                    if (CarModel == "911 Carrera")
                    {
                        QuotePrice += 25;
                    }
                }

                int addPrice = 10 * Speeding;
                QuotePrice += addPrice;

                if (DUIbool)
                {
                    QuotePrice = Convert.ToInt32(1.25 * QuotePrice);
                }

                if (InsuranceType)
                {
                    QuotePrice = Convert.ToInt32(1.50 * QuotePrice);
                }

                string queryString = @"INSERT INTO UserData (FirstName, LastName, Email, DOB,
                    CarYear, CarMake, CarModel, DUIbool, Speeding, InsuranceType, QuotePrice) VALUES
                    (@FirstName, @LastName, @Email, @DOB,
                    @CarYear, @CarMake, @CarModel, @DUIbool, @Speeding, @InsuranceType, @QuotePrice)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                    command.Parameters.Add("@LastName", SqlDbType.VarChar);
                    command.Parameters.Add("@Email", SqlDbType.VarChar);
                    command.Parameters.Add("@DOB", SqlDbType.Date);
                    command.Parameters.Add("@CarYear", SqlDbType.Int);
                    command.Parameters.Add("@CarMake", SqlDbType.VarChar);
                    command.Parameters.Add("@CarModel", SqlDbType.VarChar);
                    command.Parameters.Add("@DUIbool", SqlDbType.Bit);
                    command.Parameters.Add("@Speeding", SqlDbType.Int);
                    command.Parameters.Add("@InsuranceType", SqlDbType.Bit);
                    command.Parameters.Add("@QuotePrice", SqlDbType.Int);

                    command.Parameters["@FirstName"].Value = firstName;
                    command.Parameters["@LastName"].Value = lastName;
                    command.Parameters["@Email"].Value = email;
                    command.Parameters["@DOB"].Value = DOB;
                    command.Parameters["@CarYear"].Value = CarYear;
                    command.Parameters["@CarMake"].Value = CarMake;
                    command.Parameters["@CarModel"].Value = CarModel;
                    command.Parameters["@DUIbool"].Value = DUIbool;
                    command.Parameters["@Speeding"].Value = Speeding;
                    command.Parameters["@InsuranceType"].Value = InsuranceType;
                    command.Parameters["@QuotePrice"].Value = QuotePrice;

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                return View("Success");
            }

        }

        public IActionResult Admin()
        {
            string queryString = @"Select * From UserData";
            var listQuotes = new List<Quote>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var temp = new Quote();
                    temp.FirstName = reader["FirstName"].ToString();
                    temp.LastName = reader["LastName"].ToString();
                    temp.Email = reader["Email"].ToString();
                    temp.QuotePrice = Convert.ToInt32(reader["QuotePrice"]);
                    listQuotes.Add(temp);
                }

                connection.Close();

            }
            return View(listQuotes);

        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

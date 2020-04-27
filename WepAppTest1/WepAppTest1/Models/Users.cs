using System;
namespace WepAppTest1.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
        public int CarYear { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public bool DUIbool { get; set; }
        public int Speeding { get; set; }
        public string InsuranceType { get; set; }

        public Users(int id, string FirstName, string LastName)
        {
            this.Id = id;
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

        public string FullName()
        {
            return FirstName + " " + LastName;
        }
    }
}

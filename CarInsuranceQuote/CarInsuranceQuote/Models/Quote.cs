using System;
namespace CarInsuranceQuote.Models
{
    public class Quote
    {
        public int? Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime? DOB { get; set; }
        public int? CarYear { get; set; }
        public string? CarMake { get; set; }
        public string? CarModel { get; set; }
        public bool? DUIbool { get; set; }
        public int? Speeding { get; set; }
        public bool? InsuranceType { get; set; }
        public int QuotePrice { get; set; }

    }
}

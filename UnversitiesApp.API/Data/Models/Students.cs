using UnversitiesApp.API.Data.Base;

namespace UnversitiesApp.API.Data.Models
{
    public class Students:EntityBase
    {
        public string FirstName { get; set; } // First name of the student
        public string LastName { get; set; } // Last name of the student
        public string Email { get; set; } // Email of the student
        public DateTime DOB { get; set; } // Date of birth of the student
        public string Gender { get; set; } // Gender of the student
        public string Citizenship { get; set; } // Citizenship of the student
    }
}


﻿namespace UnversitiesApp.API.Data.DTOs
{
    public class PutStudentDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string Citizenship { get; set; }
    }
}

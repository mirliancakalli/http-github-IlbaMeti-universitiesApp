using System.Reflection;
using UnversitiesApp.API.Data.Models;

namespace UnversitiesApp.API.Data
{
    public static class FakeDb
    {
        public static List<University> UniversitiesDb = new List<University>()
        {
            new University()
            {
                UniversityName="Beder",
                EstablishedYear= 2011,
                Address="Jordan Misja street, Tirana",
                ProgramsOffered=new List<string> { "Computer Science", "LAW", "Communication Sciences" , "Education and English Language", "Economics and Business"},
                Facilities=new List<string> { "Library", "Laboratories", "Sports Center" , "Auditorium" ,"Canteen", "Service Office" }
            },
             new University()
            {
                UniversityName="Epoka",
                EstablishedYear= 2007,
                Address="Tiranë-Rinas Highway",
                ProgramsOffered=new List<string> { "Computer Engineering", "LAW", "Architecture", "Software Engineering", "Economics and Business"},
                Facilities=new List<string> { "Library", "Laboratories", "Sports Center" , "Auditorium" ,"Canteen" ,"Parking", "Service Office" }
            },
              new University()
            {
                UniversityName="New York Tirana",
                EstablishedYear= 2002,
                Address="Kavaja street",
                ProgramsOffered=new List<string> { "Psychology", "LAW", "Accounting", "Architecture", "Computer Sciences","Interior Design"},
                Facilities=new List<string> { "Library", "Laboratories", "Sports Center" , "Auditorium" ,"Canteen", "Service Office" }
            },
                new University()
            {
                UniversityName="Zoja e Këshillit të Mirë",
                EstablishedYear= 2004,
                Address="Dritan Hoxha street",
                ProgramsOffered=new List<string> { "Medicine", "Dentistry", "Physiotherapy", "Nursing", "Economics", "Political Sciences"},
                Facilities=new List<string> { "Center for Rehabilitation and Sports Medicine", "Library", "Laboratories", "Sports Center" , "Auditorium" , "Dental clinic", "Service Office" }
            },
        };
        public static List<University> GetAllUniversities()
        {
            return UniversitiesDb;
        }

        public static List<Students> StudentsDb = new List<Students>()
        {
            new Students()
            {
                FirstName="Ilba",
                LastName="Meti",
                Email="imeti21@beder.edu.al",
                DOB=new DateTime(2002, 10, 24),
                Gender="Female",
                Citizenship="Albanian"
            },
             new Students()
            {
                FirstName="Sarah",
                LastName="Smith",
                Email="ssmith@gmail.com",
                DOB=new DateTime(2000, 09, 14),
                Gender="Female",
                Citizenship="American"
            },
              new Students()
            {
                FirstName="Wang ",
                LastName="Li Mei",
                Email="wangli@gmail.com",
                DOB=new DateTime(2001, 12, 27),
                Gender="Male",
                Citizenship="Chinese"
            },
               new Students()
            {
                FirstName="Aisha",
                LastName="Patel",
                Email="apatel@beder.edu.al",
                DOB=new DateTime(2003, 11, 25),
                Gender="Female",
                Citizenship="South African"
            },
        };
        public static List<Students> GetAllStudents()
        {
            return StudentsDb;
        }
    }
}
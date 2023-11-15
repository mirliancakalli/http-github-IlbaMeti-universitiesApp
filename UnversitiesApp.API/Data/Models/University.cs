using UnversitiesApp.API.Data.Base;

namespace UnversitiesApp.API.Data.Models
{
    public class University : EntityBase
    {
        public string UniversityName { get; set; } //Represents the name of the university.
        public int EstablishedYear { get; set; } //Represents the year in which the university was established.
        public string Address { get; set; }// Represents the physical address of the university.
        public List<string> ProgramsOffered { get; set; } //Represents a list of programs or degrees offered by the university.
        public List<string> Facilities { get; set; } //Represents a list of facilities available at the university.
    }
}

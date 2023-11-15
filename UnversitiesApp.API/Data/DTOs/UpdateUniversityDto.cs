namespace UnversitiesApp.API.Data.DTOs
{
    public class UpdateUniversityDto
    {
        public string UniversityName { get; set; }
        public int EstablishedYear { get; set; }
        public string Address { get; set; }
        public List<string> ProgramsOffered { get; set; }
        public List<string> Facilities { get; set; }
    }
}

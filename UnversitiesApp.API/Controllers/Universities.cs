using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnversitiesApp.API.Data;
using UnversitiesApp.API.Data.DTOs;
using UnversitiesApp.API.Data.Models;

namespace UnversitiesApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Universities : ControllerBase
    {
        //Marrim te gjitha universitetet nga databaza
        [HttpGet]
        public IActionResult GetAllUniversities()
        {
            var universitiesDb = FakeDb.UniversitiesDb.ToList();
            return Ok(universitiesDb);
        }

        [HttpGet("{id}")]
        public IActionResult GetUniversityById(int id)
        {
            var universityDb = FakeDb.UniversitiesDb.FirstOrDefault(x => x.Id == id);

            if (universityDb == null)
            {
                return NotFound($"University with id = {id} not found");
            }
            else
            {
                return Ok(universityDb);
            }
        }
        [HttpDelete("Delete/{id}")]
        public IActionResult DeleteUniversityById(int id)
        {
            var universityDb = FakeDb.UniversitiesDb.FirstOrDefault(x => x.Id == id);
            if (universityDb == null)
            {
                return NotFound($"University with id = {id} not found");
            }
            else
            {
                FakeDb.UniversitiesDb.Remove(universityDb);
                return Ok($"University with id = {id} was removed");
            }
        }
        [HttpPost]
        public IActionResult PostUniversity([FromBody] PostUniversityDto payload)
        {
            //1. Create the object
            var newStudent = new University()
            {
				
				
				
                //Generate Id for new employee 10-99
                Id = new Random().Next(10, 100),
                UniversityName = payload.UniversityName,
                EstablishedYear = payload.EstablishedYear,
            };

            //2.Adds the object in DB
            FakeDb.UniversitiesDb.Add(newStudent);

            //3.Returns response
            return Ok("New student created");
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUniversityById(int id, [FromBody] UpdateUniversityDto payload)
        {
            var universityDb = FakeDb.UniversitiesDb.FirstOrDefault(x => x.Id == id);

            if (universityDb == null)
            {
                return NotFound($"University with id = {id} not found");
            }
            else
            {
                universityDb.UniversityName = payload.UniversityName;
                universityDb.EstablishedYear = payload.EstablishedYear;

                return Ok($"Company with id = {id} was updated");
            }
        }
    }
}

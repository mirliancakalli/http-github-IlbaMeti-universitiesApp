using UnversitiesApp.API.Data;
using UnversitiesApp.API.Data.DTOs;
using UnversitiesApp.API.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UniversitiesApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        //Marrim te gjithe punonjesit nga databaza
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            var allStudentsFromDb = FakeDb.StudentsDb.ToList();
            return Ok(allStudentsFromDb);
        }

        [HttpGet("{id}")]
        public IActionResult GetStudentById(int id)
        {
            var studentFromDb = FakeDb.StudentsDb.FirstOrDefault(x => x.Id == id);

            if (studentFromDb == null)
            {
                return NotFound($"Student with id = {id} not found");
            }
            else
            {
                return Ok(studentFromDb);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStudentById(int id)
        {
            var studentFromDb = FakeDb.StudentsDb.FirstOrDefault(x => x.Id == id);

            if (studentFromDb == null)
            {
                return NotFound($"Student with id = {id} not found");
            }
            else
            {
                FakeDb.StudentsDb.Remove(studentFromDb);

                var latestList = FakeDb.StudentsDb.ToList();
                return Ok($"Student with id = {id} was removed");
            }
        }
        [HttpPost]
        public IActionResult PostStudent([FromBody] PostStudentDto payload)
        {
            //1.Creates the object
            var newStudent = new Students()
            {
                //Generate Id for new employee 10-99
                Id = new Random().Next(10, 100),

                FirstName = payload.FirstName,
                LastName = payload.LastName,
                DOB = payload.DOB,
                Email = payload.Email,
                Gender = payload.Gender,
                Citizenship = payload.Citizenship
            };

            //2.Adds the object in DB
            FakeDb.StudentsDb.Add(newStudent);

            return Ok("PostStudent");
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStudent([FromBody] PutStudentDto newData, int id)
        {
            //1. Get the data from DB
            var studentFromDb = FakeDb.StudentsDb.FirstOrDefault(x => x.Id == id);

            if (studentFromDb == null)
            {
                return NotFound("Student could not be updated");
            }

            //2.Updates data
            studentFromDb.FirstName = newData.FirstName;
            studentFromDb.LastName = newData.LastName;
            studentFromDb.DOB = newData.DOB;
            studentFromDb.Email = newData.Email;
            studentFromDb.Gender = newData.Gender;
            studentFromDb.Citizenship = newData.Citizenship;

            return Ok("Student updated");
        }

    }
}

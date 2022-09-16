using LecturereRestApi.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace LecturereRestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LecturerController : ControllerBase
    {
        //Dummy Data
        public List<Lecturer> _lectureres = new List<Lecturer>()
        {
            new Lecturer(1, "Ron", "ronocheri@gmail.com", 
                new List<Language>(){ new Language(1, "Java"),new Language(2, ".NET")}),
            new Lecturer(2, "Sean", "sean@gmail.com",  
                new List<Language>(){ new Language(3, "NodeJS"),new Language(4, "Advanced Vanilla JS")}),
            new Lecturer(3, "Mor",null,null),
            new Lecturer(4, "Yan", "yan@gmail.com",
                new List<Language>(){ new Language(1, "Java"), new Language(5, "React"),new Language(6, "Angular") })
        };


        // GET api/Lecturer/GetLectureres
        [HttpGet("GetLectureres")]
        [EnableCors("CorePolicy")]
        public List<Lecturer> GetLectureres()
        {
            return _lectureres;
        }

        // GET api/Lecturer/GetLecturere/{id}
        [HttpGet("GetLecturer")]
        [EnableCors("CorePolicy")]
        public Lecturer GetLecturer(int id)
        {
            var lecturer = _lectureres.FirstOrDefault(x => x.Id == id);

            if (lecturer != null)
                return lecturer;
            return null;
        }

        // POST api/Lecturer - TO DO (not in the scope of the assignment)
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/Lecturer/5 - TO DO (not in the scope of the assignment)
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/Lecturer/5 - TO DO (not in the scope of the assignment)
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
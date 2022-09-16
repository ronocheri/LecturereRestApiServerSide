using LecturereRestApi.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LecturereRestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LanguageController : ControllerBase
    {
        //Dummy Data
        public List<Language> _languages = new List<Language>() {
            new Language(1, "Java"),
            new Language(2, ".NET"),
            new Language(3, "NodeJS"),
            new Language(4, "Advanced Vanilla JS"),
            new Language(5, "React"),
            new Language(6, "Angular")};


        // GET api/Language/GetLanguages
        [HttpGet("GetLanguages")]
        [EnableCors("CorePolicy")]
        public List<Language> GetLanguages()
        {
            return _languages;
        }

        // GET api/Language/GetLanguage\{id}
        [HttpGet("GetLanguage")]
        [EnableCors("CorePolicy")]
        public Language GetLanguage(int id)
        {
            var language = _languages.FirstOrDefault(x => x.Id == id);

            if (language != null)
                return language;
            return null;
        }
    }
}

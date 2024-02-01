using Microsoft.AspNetCore.Mvc;

namespace WordService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WordController : ControllerBase
    {
        private Database database = Database.CreateInstance();

        [HttpGet]
        public Dictionary<string, int> Get()
        {
            return database.GetAllWords();
        }

        [HttpPost]
        public void Post([FromBody] Dictionary<string, int> res)
        {
            database.InsertAllWords(res);
        }
    }
}

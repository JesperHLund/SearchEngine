using Microsoft.AspNetCore.Mvc;

namespace WordService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OccurrenceController : ControllerBase
    {
        private Database database = Database.CreateInstance();

        [HttpPost]
        public void Post(int docId, [FromBody] ISet<int> wordIds)
        {
            database.InsertAllOcc(docId, wordIds);
        }
    }
}

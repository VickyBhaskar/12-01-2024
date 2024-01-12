using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiDocker.Models;

namespace WebApiDocker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private static List<Movies> tasks = new List<Movies>();

        // GET: api/tasks
        [HttpGet]
        public IEnumerable<Movies> Get()
        {
            return tasks;
        }

        // GET: api/tasks/1
        [HttpGet("{id}")]
        public Movies Get(int id)
        {
            return tasks.Find(task => task.MId == id);
        }

        // POST: api/tasks
        [HttpPost]
        public void Post([FromBody] Movies task)
        {
            tasks.Add(task);
        }

        // PUT: api/tasks/1
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Movies updatedTask)
        {
            var index = tasks.FindIndex(task => task.MId == id);
            if (index != -1)
            {
                tasks[index] = updatedTask;
            }
        }

        // DELETE: api/tasks/1
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            tasks.RemoveAll(task => task.MId == id);
        }
    }

}

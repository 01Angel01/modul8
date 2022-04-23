using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace modul8_1302202095.Controllers
{
    [Route("api/[controller]")]
    public class MoviesController : Controller
    {
        private string[] SemuaMovies = new[]
        {
            "The Shawshank Redemption", "The Godfather", " The Dark Knight "
        };

        [HttpGet]
        public IEnumerable<string> Get()
        {

            return SemuaMovies;
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return SemuaMovies[id];
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
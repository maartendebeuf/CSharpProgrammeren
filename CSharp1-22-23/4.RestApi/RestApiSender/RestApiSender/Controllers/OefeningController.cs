using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace RestApiSender.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OefeningController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hello world";
        }

        //[HttpGet] zal foutmelding geven omdat het geen uniek pad is 
        /// <summary>
        /// geeft de gegeven id terug
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "waarde" + id;
        }

        //[HttpGet]
        //public IEnumerable<string> Get(string? token)
        //{
        //    return new string[] { "value1", "value2" };
        //}

        [HttpGet]
        [Route("GetWithToken")]
        public string GetWithToken(int id, string token)
        {
            string waarde = "waarde " + id + " met token " + token;
            return waarde;
        }

        [HttpPost]
        public void Post()
        {
            Debug.WriteLine("Succes!!!");
        }
        [HttpPost]
        [Route("PostFromBody")]
        public void Post2([FromBody] string value)
        {

            Debug.WriteLine("Succes!!!" + value);
        }
        [HttpPost]
        [Route("PostActionResult")]
        public IActionResult PostActionResult([FromBody] Tekst value)
        {
            //vb kan aparte foutmelding gegeven worden als geen item gevonden is
            return Ok(value);
        }
        [HttpPut]
        public void Put()
        {
            Debug.WriteLine("Succes!!!");
        }


    }
}

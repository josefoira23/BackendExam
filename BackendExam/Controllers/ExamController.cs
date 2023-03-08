using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackendExam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamController : ControllerBase
    {

        // GET api/<ExamController>/5
        [HttpGet("Converter")]
        public string Converter(string value)
        {
            byte[] bit = System.Text.Encoding.UTF8.GetBytes(value);
            string converted = Convert.ToBase64String(bit);

            return converted;
        }


        // GET: api/<ExamController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // POST api/<ExamController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ExamController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ExamController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

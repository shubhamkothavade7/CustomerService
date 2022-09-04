using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NamesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> get()
        {
            return new string[] {"ram","shyam","anil"};
        }
        /*[HttpGet]
        public string get(int id)
        {
            return "value";
        }*/
    }
}

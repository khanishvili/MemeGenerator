using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MemeGenerator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemesController : ControllerBase
    {
        static private List<List<string>> all = new List<List<string>>()
        {
            new List<string>(){"one", "two"}, new List<string>(){"onsvdxcvze", "tzxcvzxcvwo"}
        };

        [HttpGet]
        public ActionResult<List<List<string>>> Get()
        {
            return all;
        }
    }
}
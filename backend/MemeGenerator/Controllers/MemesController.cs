using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MemeGenerator.Models;
using MemeGenerator.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace MemeGenerator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemesController : ControllerBase
    {
        IMemeRepository repo;

        public MemesController(IMemeRepository repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Meme>> Get()
        {
            var memeList = repo.GetAll().ToArray();
            return memeList;
        }

        [HttpPost]
        public ActionResult<bool> Post([FromBody] Meme newMeme)
        {
            repo.Add(newMeme);
            return true;
        }
    }
}
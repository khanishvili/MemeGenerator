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
        static private List<Meme> all = new List<Meme>() {

            new Meme () {
            Id = 1,
            Top = "Js on my tree",
            Bottom = "Yo git like me",
            Image = "./Images/4.jpg"
            },

            new Meme () {
            Id = 2,

            Top = "I will look for you and I will find you",
            Bottom = "\"Cross-Origin Request Blocked\"",
            Image = "./Images/Taken.jpg"
            },
            new Meme () { Id = 3, Top = "International Man", Bottom = "of MVC", Image = "./Images/9.jpg" },
            new Meme () {
            Id = 4,
            Top = "When a new test passes",
            Bottom = "but old ones start failing",
            Image = "./Images/5.jpg"
            },
            new Meme () {
            Id = 5,
            Top = "WHY THE FUNCTION",
            Bottom = "is it called a method and an action?",
            Image = "./Images/StarTrek.png"
            },
            new Meme () {
            Id = 6,
            Top = "When you've been holding a fart in the whole interview,",
            Bottom = "and you feel a sneeze coming",
            Image = "./Images/2.jpg"
            }

        };

        MemeRepository repo;
        public MemesController(MemeRepository repo)
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
            all.Add(newMeme);
            return true;
        }
    }
}
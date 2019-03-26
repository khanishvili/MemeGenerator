using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MemeGenerator.Models;
namespace MemeGenerator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemesController : ControllerBase
    {
        static private List<Meme> all = new List<Meme>()
        {
            new Meme(){ Id =1 , Top = "Top Text" , Bottom = "Bottom Text" , Image = "./Images/0.jpg"},
            new Meme(){ Id =2 , Top = "Top Temporary " , Bottom = "Bottom Text" , Image = "./Images/1.jpg"},
            new Meme(){ Id =3 , Top = "Top Text" , Bottom = "Bottom Text" , Image = "./Images/2.jpg"}
        };

        [HttpGet]
        public ActionResult<List<Meme>> Get()
        {
            return all;
        }
    }
}
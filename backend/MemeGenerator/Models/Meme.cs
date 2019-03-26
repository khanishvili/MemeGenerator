using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MemeGenerator.Models
{
    public class Meme
    {
        public int Id { get; set; }

        public string Top { get; set; }

       public string Bottom { get; set; }

       public string Image { get; set; }   
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MemeGenerator.Models;
namespace MemeGenerator.Repositories
{
  public   interface IMemeRepository
    {
        IEnumerable<Meme> GetAll();
        void Add(Meme meme);
    }
}

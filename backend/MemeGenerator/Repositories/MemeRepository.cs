using MemeGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MemeGenerator.Repositories
{
    public class MemeRepository
    {
        MemeContext db;

        public MemeRepository(MemeContext db)
        {
            this.db = db;
        }

        public IEnumerable<Meme> GetAll()
        {
            return db.Memes.ToList();
        }
    }
}

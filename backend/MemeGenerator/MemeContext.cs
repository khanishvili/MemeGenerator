using MemeGenerator.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MemeGenerator
{
    public class MemeContext : DbContext
    {
        public DbSet<Meme> Memes { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=aakMemeGenerator;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Meme>().HasData
                (

                    new Meme()
                    {
                        Id = 1,
                        Top = "Js on my tree",
                        Bottom = "Yo git like me",
                        Image = "./Images/4.jpg"
                    },
                    new Meme()
                    {
                        Id = 2,

                        Top = "I will look for you and I will find you",
                        Bottom = "\"Cross-Origin Request Blocked\"",
                        Image = "./Images/Taken.jpg"
                    },
                    new Meme() { Id = 3, Top = "International Man", Bottom = "of MVC", Image = "./Images/9.jpg" },
                    new Meme()
                    {
                        Id = 4,
                        Top = "When a new test passes",
                        Bottom = "but old ones start failing",
                        Image = "./Images/5.jpg"
                    },
                    new Meme()
                    {
                        Id = 5,
                        Top = "WHY THE FUNCTION",
                        Bottom = "is it called a method and an action?",
                        Image = "./Images/StarTrek.png"
                    },
                    new Meme()
                    {
                        Id = 6,
                        Top = "When you've been holding a fart in the whole interview,",
                        Bottom = "and you feel a sneeze coming",
                        Image = "./Images/2.jpg"
                    }
                );

            base.OnModelCreating(modelBuilder);


        }
    }
}

﻿// <auto-generated />
using MemeGenerator;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MemeGenerator.Migrations
{
    [DbContext(typeof(MemeContext))]
    [Migration("20190328133852_changedOrder")]
    partial class changedOrder
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MemeGenerator.Models.Meme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bottom");

                    b.Property<string>("Image");

                    b.Property<string>("Top");

                    b.HasKey("Id");

                    b.ToTable("Memes");

                    b.HasData(
                        new { Id = 1, Bottom = "and you feel a sneeze coming", Image = "./Images/2.jpg", Top = "When you've been holding a fart in the whole interview," },
                        new { Id = 2, Bottom = "is it called a method and an action?", Image = "./Images/StarTrek.png", Top = "WHY THE FUNCTION" },
                        new { Id = 3, Bottom = "but old ones start failing", Image = "./Images/5.jpg", Top = "When a new test passes" },
                        new { Id = 4, Bottom = "of MVC", Image = "./Images/9.jpg", Top = "International Man" },
                        new { Id = 5, Bottom = "\"Cross-Origin Request Blocked\"", Image = "./Images/Taken.jpg", Top = "I will look for you and I will find you" },
                        new { Id = 6, Bottom = "Yo git like me", Image = "./Images/4.jpg", Top = "Js on my tree" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}

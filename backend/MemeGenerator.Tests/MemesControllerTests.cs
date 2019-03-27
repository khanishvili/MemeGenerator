using System;
using System.Linq;

using MemeGenerator.Controllers;
using MemeGenerator.Models;
using MemeGenerator.Repositories;

using Xunit;
using NSubstitute;
using System.Collections.Generic;

namespace MemeGenerator.Tests
{
    public class MemesControllerTests
    {
        IMemeRepository repo;
        MemesController underTest;

        public MemesControllerTests()
        {
            repo = Substitute.For<IMemeRepository>();
            underTest = new MemesController(repo);
        }

        [Fact]
        public void GET_Returns_List_of_Memes()
        {
            var expectedmodel = new List<Meme>() { new Meme() };
            repo.GetAll().Returns(expectedmodel);

            var result = underTest.Get();

            Assert.Equal(1, result.Value.Count());
        }

        [Fact]
        public void Post_Saves_A_Meme()
        {
            var result = underTest.Post(new Meme()
            {
                Id = 2,
                Top = "I will look for you and I will find you",
                Bottom = "\"Cross-Origin Request Blocked\"",
                Image = "./Images/Taken.jpg"
            });

            Assert.True(result.Value);
        }
    }
}

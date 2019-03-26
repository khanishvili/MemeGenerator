using MemeGenerator.Controllers;
using System;
using System.Linq;
using Xunit;

namespace MemeGenerator.Tests
{
    public class MemesControllerTests
    {
        [Fact]
        public void GET_Returns_List_of_Memes()
        {
            var underTest = new MemesController();

            var result = underTest.Get();

            Assert.Equal(6, result.Value.Count());
        }
      

    }
}

using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        ValuesController controller = new ValuesController();

        [Fact]
        public void GetReturnsValues()
        {
            var returnValue = controller.Get();
            Assert.Equal("Test", returnValue.Value);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}

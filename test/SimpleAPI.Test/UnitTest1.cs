using System;
using Xunit;
using SimpleAPI.Controllers;


namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test2()
        {
            ValuesController controller = new ValuesController();
            var returnValue = controller.Get(1);
            Assert.Equal("Aleksandar Popov", returnValue.Value);
        }
        [Fact]
        public void Test1()
        {
            
        }
    }
}

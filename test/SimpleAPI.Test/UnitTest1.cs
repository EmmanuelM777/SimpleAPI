using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        ValuesController valuesController = new ValuesController();

        [Fact]
        public void GetShouldReturnExpectedValue()
        {
            var result = valuesController.Get(1);
            Assert.Equal("value", result.Value);
        }
    }
}

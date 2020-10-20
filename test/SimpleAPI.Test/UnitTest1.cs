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
            const int id = 1;
            var result = valuesController.Get(id);
            Assert.Equal($"value {id}", result.Value);
        }
    }
}

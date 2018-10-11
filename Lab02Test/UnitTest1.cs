using System;
using Xunit;
using static Lab02-UnitTesting.Program;

namespace Lab02Test
{
    public class UnitTest1
    {
        [Fact]
        public void CanReturnBalance()
        {
            Assert.Equal(1000, CheckBalance());
        }
        [Theory]
        [InlineData(1000)]
        [InlineData(356)]
        [InlineData(50)]
        [InlineData(95)]
        public void canReturnCorrectBalance(int money)
        {
            Assert.Equal(2000,)
        }
    }
}

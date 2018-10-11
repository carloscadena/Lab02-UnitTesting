using System;
using Xunit;
using static Lab02_UnitTesting.Program;

namespace Lab02Test
{
    public class UnitTest1
    {
        [Fact]
        public void CanReturnBalance()
        {
            Assert.Equal(1000, CheckBalance());
        }
        [Fact]
        public void Deposit1000()
        {
            Assert.Equal(2000, DepositMoney(1000));
        }
        [Fact]
        //public void Withdraw1000()
        //{
        //    Assert.Equal(0, Withdraw(1000));
        //}
    }
}

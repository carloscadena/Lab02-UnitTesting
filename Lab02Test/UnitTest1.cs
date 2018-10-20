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
            bankBalance = 1000;
            Assert.Equal(1000, CheckBalance());
        }

        [Fact]
        public void CanReturnBalanceAfterDeposit()
        {
            bankBalance = 1000;
            DepositMoney(1000);
            Assert.Equal(2000, CheckBalance());
        }

        [Fact]
        public void Deposit1000()
        {
            bankBalance = 1000;
            Assert.Equal(2000, DepositMoney(1000));
        }

        [Fact]
        public void Deposit5000()
        {
            bankBalance = 1000;
            Assert.Equal(6000, DepositMoney(5000));
        }

        [Theory]
        [InlineData(1000, 0)]
        [InlineData(500, 500)]

        public void Withdraw1000(int val, int expected)
        {
            bankBalance = 1000;
            Assert.Equal(expected, Withdraw(val));
        }
    }
}

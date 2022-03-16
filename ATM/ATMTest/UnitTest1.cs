using System;
using Xunit;
using BankATM;
namespace ATMTest
{
    public class BankATMTest
    {
        [Fact]
        public void ViewBalance_Balance1000_500_Pass() //Test that balance is shown correctly
        {
            Program.balance = 1000.500M;
            Assert.Equal(1000.500M, Program.ViewBalance());
        }
        [Fact]
        public void CanWithdraw5Dollars() //Test that balance is Withdraw success
        {
            //arrange
            Program.balance = 1000.500M;
            //act
            //assert
            Assert.Equal((decimal)995.500, Program.Withdraw(5.00M));
        }
        [Fact]
        public void CanDeposit50Dollars() //Test that balance is Deposit success
        {
            //arrange
            Program.balance = 1000.500M;
            //act
            //assert
            Assert.Equal((decimal)1050.500, Program.Deposit(50.00M));
        }
        // this test if deposit nagative but I'm in code make if user insert negative repet enter new deposit,
        // for that I'm comment test if you run test not have result. and also WithdrawNegative

        /* [Fact]
           public void CanWithdrawNegative() 
            {
                Program.balance = 1000.500M;
                Assert.Equal((decimal)1000.500, Program.Withdraw(-1));
            }*/
        /* [Fact]
           public void CanWithdrawGreterThanBalance() 
            {
                Program.balance = 1000.500M;
                Assert.Equal((decimal)1000.500, Program.Withdraw(20000));
            }*/

        /* [Fact]
           public void CanDepositNegative() 
            {
                Program.balance = 1000.500M;
                Assert.Equal((decimal)1000.500, Program.Deposit(-1));
            }*/
    }
}

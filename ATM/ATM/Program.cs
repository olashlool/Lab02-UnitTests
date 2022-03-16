using System;

namespace BankATM
{
    public class Program
    {
        static public decimal balance = 1000.500M;
        static void Main(string[] args)
        {
            try {
                UserInterface();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Oops, you have error {e.Message}");
            }
        }

        public static void UserInterface()
        {
            Console.WriteLine("Welcome to Cairo Amman Bank. Thank you for choosing us for your financial needs.");
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine();
            bool transaction = true;
            while (transaction)
            {
            Console.WriteLine("What would  you like to do? ");
            Console.WriteLine("                          1. View Balance");
            Console.WriteLine("                          2. Withdraw");
            Console.WriteLine("                          3. Deposit");
            Console.WriteLine("                          4. Exit");
            Console.Write("Please select an option above: ");
            int choose = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine();
            //Console.WriteLine(choose);
                switch (choose)
                {
                    case 1 :
                        {
                            Console.WriteLine($"Your current balance is: {ViewBalance()}$");
                            Console.WriteLine();
                            Console.WriteLine("-------------------------------------------------------------------------------");
                            Console.Write("Do you want to make another transaction? (Y/N) ");
                            string anotherchoose = Console.ReadLine();
                            Console.WriteLine("-------------------------------------------------------------------------------");
                            if (anotherchoose == "N" || anotherchoose == "n")
                            {
                                Console.Write("Thank you for using Cairo Amman Bank, see you next time ^-^ ");
                                Console.WriteLine();
                                transaction = false;
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.Write("How much would you like to withdraw ? ");
                            decimal withdraw = Convert.ToDecimal(Console.ReadLine());
                            Console.WriteLine($"Your NEW balance is: {Withdraw(withdraw)}$");
                            Console.WriteLine();
                            Console.WriteLine("-------------------------------------------------------------------------------");
                            Console.Write("Do you want to make another transaction? (Y/N) ");
                            string anotherchoose = Console.ReadLine();
                            Console.WriteLine("-------------------------------------------------------------------------------");
                            if (anotherchoose == "N" || anotherchoose == "n")
                            {
                                Console.Write("Thank you for using Cairo Amman Bank, see you next time ^-^ ");
                                Console.WriteLine();
                                transaction = false;
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.Write("How much would you like to Deposit ? ");
                            decimal deposit = Convert.ToDecimal(Console.ReadLine());
                            Console.WriteLine($"Your NEW balance is: {Deposit(deposit)}$");
                            Console.WriteLine();
                            Console.WriteLine("-------------------------------------------------------------------------------");
                            Console.Write("Do you want to make another transaction? (Y/N) ");
                            string anotherchoose = Console.ReadLine();
                            Console.WriteLine("-------------------------------------------------------------------------------");
                            if (anotherchoose == "N" || anotherchoose == "n")
                            {
                                Console.Write("Thank you for using Cairo Amman Bank, see you next time ^-^ ");
                                Console.WriteLine();
                                transaction = false;
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.Write("Thank you for using Cairo Amman Bank, see you next time ^-^ ");
                            Console.WriteLine();
                            transaction = false;
                            break;
                        }
                    default:
                        Console.WriteLine("Not an option!");
                        Console.WriteLine();
                        Console.WriteLine("-------------------------------------------------------------------------------");
                        Console.WriteLine();
                        break;
                }
            }

            
        }
        public static decimal ViewBalance()
        {
            return balance;
        }
        public static decimal Withdraw(decimal withdraw)
        {
            if (withdraw < 0 || withdraw > balance)
            {
                while (withdraw < 0)
                {
                    Console.WriteLine("You cannot enter Withdraw less than 0 ");
                    Console.Write("How much would you like to withdrawl? ");
                    withdraw = Convert.ToDecimal(Console.ReadLine());
                }
                while (withdraw > balance)
                {
                    Console.WriteLine("You cannot enter Withdraw more than balance ");
                    Console.Write("How much would you like to withdrawl? ");
                    withdraw = Convert.ToDecimal(Console.ReadLine());
                }
            }
            balance -= withdraw;
            return balance;
        }
        public static decimal Deposit(decimal deposit)
        {
            if (deposit < 0 )
            {
                while (deposit < 0)
                {
                    Console.WriteLine("You cannot enter deposit less than 0 ");
                    Console.Write("How much would you like to deposit? ");
                    deposit = Convert.ToDecimal(Console.ReadLine());
                }
            }
            balance += deposit;
            return balance;
        }

    }
}

using System;

namespace Lab02_UnitTesting
{
    public class Program
    {
        public static int bankBalance = 1000;

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            UserMenu();
            
        }

        public static void UserMenu()
        {
            // inital prompt to user
            Console.WriteLine("Welcome to Cadena Bank. What would you like to do?");
            Console.WriteLine("1) Check your BALANCE");
            Console.WriteLine("2) Make a DEPOSIT");
            Console.WriteLine("3) Make a WITHDRAWAL");
            Console.WriteLine("4) EXIT");
            HandleUserChoice();
        }
        
        public static void HandleUserChoice()
        {
            string picked = Console.ReadLine();
            // Determine which method to run based on user input
            switch (picked)
            {
                case "1":
                    CheckBalance();
                    AfterTransaction();
                    break;
                case "2":
                    Console.WriteLine("How much money will you be depositing today?");
                    try
                    {
                        int amountToDeposit = int.Parse(Console.ReadLine());
                        DepositMoney(amountToDeposit);
                        AfterTransaction();

                    }
                    catch (FormatException)
                    {

                        Console.WriteLine("Please enter only numbers.");
                        UserMenu();
                    }
                    
                    break;
                case "3":
                    Console.WriteLine($"How much of your money would you like today? Your balance is ${bankBalance}.");
                    int amountToWithdraw = int.Parse(Console.ReadLine());
                    Withdraw(amountToWithdraw);
                    AfterTransaction();
                    break;
                case "4":
                    Console.WriteLine("Thanks for banking!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid Choice.");
                    UserMenu();
                    break;
            }
        }
        public static int CheckBalance()
        {
            Console.WriteLine($"Your balance is ${bankBalance}");
            return bankBalance;
            
        }
        public static void AfterTransaction()
        {
            Console.WriteLine("Would you like to make another transaction? Y or N");
            if (Console.ReadLine().ToLower() == "y")
            {
                UserMenu();
            }
            else
            {
                Console.WriteLine("Thanks for banking!");
                Environment.Exit(0);
            }
        }
        public static int DepositMoney(int amount)
        {
            bankBalance += amount;
            Console.WriteLine($"Your balance is now ${bankBalance}");
            return bankBalance;                    
        }
        public static int Withdraw(int amount)
        {
            if (amount > bankBalance)
            {
                Console.WriteLine("Insufficient Funds.");
                return bankBalance;
            }
            else
            {
                bankBalance -= amount;
                return bankBalance;
            }
        }
    }
}

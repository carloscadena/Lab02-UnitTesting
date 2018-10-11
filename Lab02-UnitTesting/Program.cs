using System;

namespace Lab02_UnitTesting
{
    class Program
    {
        public static int bankBalance = 1000;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            UserMenu();
            
        }

        static void UserMenu()
        {
            Console.WriteLine("Welcome to Cadena Bank. What would you like to do?");
            Console.WriteLine("1) Check your BALANCE");
            Console.WriteLine("2) Make a DEPOSIT");
            Console.WriteLine("3) Make a WITHDRAWAL");
            Console.WriteLine("4) EXIT");
            HandleUserChoice();
        }
        
        static void HandleUserChoice()
        {
            string picked = Console.ReadLine();
            switch (picked)
            {
                case "1":
                    CheckBalance();
                    break;
                case "2":
                    ManageBalance(DepositMoney());
                    break;
                case "3":
                    ManageBalance(Withdraw());
                    break;
                case "4":
                    Console.WriteLine("Thanks for banking!");
                    Environment.Exit(0);
                    break;
            }
        }
        static void CheckBalance()
        {
            Console.WriteLine($"Your balance is ${bankBalance}");
            Console.WriteLine("Would you like to make another transaction? Y or N");
            if(Console.ReadLine().ToLower() == "y")
            {
                UserMenu();
            }
            else
            {
                Console.WriteLine("Thanks for banking!");
                Environment.Exit(0);
            }
        }
        static void ManageBalance(int money)
        {
            bankBalance += money;
            if(money <= 0)
            {
                Console.WriteLine($"Your balance is now ${bankBalance}");
            }
            else
            {
                Console.WriteLine($"Thank you for your deposit. Your new balance is ${bankBalance}");
            }
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
        static int DepositMoney()
        {
            Console.WriteLine("How much money will you be depositing today?");
            int amountToDeposit = int.Parse(Console.ReadLine());
            return amountToDeposit;                    
        }
        static int Withdraw()
        {
            Console.WriteLine($"How much of your money would you like today? Your balance is ${bankBalance}.");
            int amountToWithdraw = int.Parse(Console.ReadLine());
            if (amountToWithdraw > bankBalance)
            {
                Console.WriteLine("Insufficient Funds.");
                return 0;
            }
            else
            {
                return -amountToWithdraw;
            }
        }
    }
}

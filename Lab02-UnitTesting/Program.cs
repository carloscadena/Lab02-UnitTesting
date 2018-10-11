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
        
        
    }
}

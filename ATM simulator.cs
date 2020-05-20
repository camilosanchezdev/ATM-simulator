using System;

namespace ATM_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int options = 0;
            double withdraw;
            double deposit;
            double balance = 100000;
            
            
            
            while (options != 4)
            {
                // Main Menu
                Console.WriteLine("A T M   S E R V I C E S");
                Console.WriteLine("======================");
                Console.WriteLine("1 - Check Account Balance");
                Console.WriteLine("2 - Withdraw");
                Console.WriteLine("3 - Deposit");
                Console.WriteLine("4 - Exit");
                options = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (options)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("A T M   S E R V I C E S");
                        Console.WriteLine("======================");
                        Console.Write("Account Balance: $" + balance);
                        Console.WriteLine("\n\nPress any key to back to Main Menu");
                        Console.ReadKey();
                        Console.Clear();

                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("A T M   S E R V I C E S");
                        Console.WriteLine("======================");
                        Console.Write("How much do you want to withdraw? ");
                        withdraw = double.Parse(Console.ReadLine());
                        balance -= withdraw;
                        Console.WriteLine("\nNew Account Balance " + balance);
                        Console.WriteLine("\nPress any key to back to Main Menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("A T M   S E R V I C E S");
                        Console.WriteLine("======================");
                        Console.Write("How much do you want to deposit? ");
                        deposit = double.Parse(Console.ReadLine());
                        balance += deposit;
                        Console.WriteLine("\nNew Account Balance " + balance);
                        Console.WriteLine("\nPress any key to back to Main Menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;
   
                    default:
                        break;
                }
            }
            Console.Clear();
            Console.WriteLine("A T M   S E R V I C E S");
            Console.WriteLine("======================");
            Console.WriteLine("Good bye!");
            Console.ReadKey();
        }
    }
}

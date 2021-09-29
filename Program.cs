using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Create a Bank menu
namespace BankMenu
{
    class Program
    {
        static void Main(string[] args)
        {
          try
          {

            Console.WriteLine("Hello, Welcome to the coders bank!");
            Console.WriteLine("Choose a option:");
            Console.WriteLine("1.- Show Balance");
            Console.WriteLine("2.- Deposite money");
            Console.WriteLine("3.- Withdraw");
            Console.WriteLine("4.- Exit");


            int option = int.Parse(Console.ReadLine());
            double balance = 100;


            switch (option)
            {
                case 1:
                    Console.WriteLine("Your balance is: " + balance);
                    break;
                case 2:
                    Console.WriteLine("How much are you depositing?: ");
                    double deposite = double.Parse(Console.ReadLine());
                    balance += deposite;
                    Console.WriteLine("You have deposited: $" + deposite +" and your balance is: $" + balance);
                    break;
                case 3:
                    Console.WriteLine("How much would you like to take out?: ");
                    double withdraw = double.Parse(Console.ReadLine());
                    if(withdraw > balance)
                    {
                        Console.WriteLine("You can't take out more money than your balance. Your balance is $ " +balance);
                    }
                    else
                    {
                        balance -= withdraw;
                        Console.WriteLine("You have withdraw: $" + withdraw + " and your balance is: $" + balance);
                    }     
                    break;
                case 4:
                    Console.WriteLine("Goodbye, Thank you for using the Coders Bank! ");
                    break;
                default:
                    Console.WriteLine("ERROR! Please select option between 1 - 4");
                    break;
            }
          }

            catch (Exception e)
            {
                Console.WriteLine("No valid!" + e);
            }

            Console.Read();

 
        }
    }
}

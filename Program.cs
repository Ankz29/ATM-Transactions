using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMTransactions
{
   public class Program
    {
        static void Main(string[] args)
        {
            int Amount = 1000, WithDrawl, Deposit;
            int choice, pin = 0;
            Console.WriteLine("Enter the ATM Pin ");
            pin = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                Console.WriteLine(" To check for Balance, press 1");
                Console.WriteLine(" For cash withdrawl, presss 2");
                Console.WriteLine(" For cash deposit, press 3");
                Console.WriteLine(" To Quit, press 4");

                Console.WriteLine("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Your balance amount is :" + Amount);
                        break;

                    case 2:
                        Console.WriteLine(" Enter the withdrawl amount: ");
                        WithDrawl = int.Parse(Console.ReadLine());
                        if (WithDrawl % 100 != 0)
                        {
                            Console.WriteLine("Enter the amount in denominations of 100. ");
                        }
                        else if (WithDrawl > (Amount - 500))
                        {
                            Console.WriteLine("Insufficent balance ");
 
                        }
                        else
                        {
                            Amount = Amount - WithDrawl;
                            Console.WriteLine("Amount deposited succesfully");
                            Console.WriteLine("Your balance now is :" + Amount);
                        }
                        break;

                    case 3:
                        Console.WriteLine("enter the amount to depoit in Bank");
                        Deposit = int.Parse(Console.ReadLine());
                        Amount = Amount + Deposit;
                        Console.WriteLine("Your total balance is :"+ Amount);
                        break;

                    case 4:
                        Console.WriteLine("You choose to quit, thank you visit again.");
                        break;
                }
                Console.WriteLine("Thank you for banking with us, Visit again.");
                Console.ReadLine();
            }
        }
    }
}

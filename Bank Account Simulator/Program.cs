using System.ComponentModel.Design;
using System.Reflection.Metadata;
namespace BankSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = 1000;
            string pin = "1234";
            string username = "student";
            bool running = true;
            int attempts = 0;
            string history = "";


            //while part 
            while (attempts < 0)
            {
                Console.WriteLine("Write your login: ");
                string usercheck = Console.ReadLine();
                Console.WriteLine("Write your password: ");
                string pincheck = Console.ReadLine();

                //if part
                if (username == usercheck && pin == pincheck)
                {
                    break;
                }

                else
                {
                    attempts++;
                }

                //second while
                while (running)
                {
                    //menu console
                    Console.WriteLine("==== MENU ====");
                    Console.WriteLine("1 - Check balance ");
                    Console.WriteLine("2 - Deposit ");
                    Console.WriteLine("3 - Withdraw ");
                    Console.WriteLine("4 - Transaction history ");
                    Console.WriteLine("5 - Exit");
                    Console.WriteLine("Choose option: ");
                    int choice = Convert.ToInt32(Console.ReadLine());


                    // balance
                    if (choice == 1)
                    {
                        Console.WriteLine("Balance: " + balance);
                    }


                    // deposit
                    if (choice == 2)
                    {
                        Console.WriteLine("Amount to deposit: ");

                        double deposit = Convert.ToDouble(Console.ReadLine());
                        if (deposit <= 0)
                        {
                            Console.WriteLine("Invalid amount");
                        }
                        else
                        {
                            balance = balance + deposit;
                            Console.WriteLine("Operation successful");
                        }
                    }


                    // withdraw
                    if (choice == 3)
                    {
                        Console.WriteLine("Amount to withdraw: ");
                        int widthdraw = Convert.ToInt32(Console.ReadLine());
                        if ((widthdraw < 0) || (widthdraw > balance))
                        {
                            Console.WriteLine("Invalid amount");
                        }

                        else
                        {
                            balance = balance - widthdraw;
                            Console.WriteLine("Operation successful");
                        }


                        // transaction history
                        history += "Deposited= " + deposit  + "\n";
                        history += "Widthrawed: " + widthdraw + "\n";

                        //exit
                        if (choice == 4)
                        {
                            Console.WriteLine("Are you sure (yes/no): ");
                            string exitcheck = Console.ReadLine();
                            if (exitcheck == "yes")
                            {
                                running = false;
                                Console.WriteLine("Goodbye!");
                            }
                            else
                            {
                                Console.WriteLine("Returning to menu...");
                            }
                        }

                    }
                }


            }
        }
    }
}

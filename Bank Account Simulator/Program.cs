using System.ComponentModel.Design;
namespace BankSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = 1000;
            bool running = true;

            while (running)
            {
                Console.WriteLine("===== BANK MENU =====");
                Console.WriteLine("1 - Check balance ");
                Console.WriteLine("2 - Deposit ");
                Console.WriteLine("3 - WithDraw ");
                Console.WriteLine("4 - Exit ");

                Console.WriteLine("Choose option: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                //if part 
                if (choice == 1)
                {
                    Console.WriteLine("Balance: " + balance);
                }

                else if (choice == 2)
                {
                    Console.WriteLine("Enter amount to deposit: ");
                    double deposit = Convert.ToDouble(Console.ReadLine());
                    balance = balance + deposit;
                }

                else if (choice == 3)
                {
                    Console.WriteLine("Enter amount to withdraw: ");
                    double withdraw = Convert.ToDouble(Console.ReadLine());
                    if (withdraw > balance)
                    {
                        Console.WriteLine("Not enough funds");
                    }
                    else
                    {
                        balance = balance - withdraw;

                    }
                }
            }
        }
    }

}
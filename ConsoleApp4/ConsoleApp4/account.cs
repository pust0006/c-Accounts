using System;
using System.Collections.Generic;
using System.Linq;
namespace lab4
{
    class bank
    {
        static void Main(string[] args)
        {
            var accounts = new List<account>();
            Console.Write("Enter the number of months to deposit: ");
            int months = Int32.Parse(Console.ReadLine());
            int i = 0;
            while (true)
            {
                Console.WriteLine("Opening new account.\n Name: ");
                string name = Console.ReadLine();
                if (name == "")
                {
                    for (i = 0; i < accounts.Count; i++)
                    {
                        for (int c = 0; c < months; c++)
                        {
                            accounts[i].decreaseBalance(accounts[i].monthlyFee); // fee
                            double a = accounts[i].monthlyInterest * accounts[i].Balance; //interest calculator
                            accounts[i].increaseBalance(a); // interest 
                            accounts[i].increaseBalance(accounts[i].depM); // monthly deposit
                        }
                        Console.WriteLine("After " + months + " months, " + accounts[i].ownerName + "'s account (" + accounts[i].accountNumber + "), has a balance of: $" + Math.Round((accounts[i].Balance), 2));
                    }
                }

                // initial
                Console.WriteLine("First deposit: ");
                int dep1 = Int32.Parse(Console.ReadLine());
                bool checker = true;
                while (checker == true)
                {
                    if (dep1 >= account.minInitialBalance)
                    {
                        accounts.Add(new account(name, dep1));
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Try again. First deposit: ");
                        dep1 = Int32.Parse(Console.ReadLine());
                    }
                }


                // monthly
                Console.WriteLine("Monthly deposit: ");
                int depMo = Int32.Parse(Console.ReadLine());
                while (checker == true)
                {
                    if (depMo >= account.minimumMonthDeposit)
                    {
                        accounts[i].depM = depMo;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Try again. Monthly: ");
                        depMo = Int32.Parse(Console.ReadLine());
                    }
                }





            }
        }
    }
}


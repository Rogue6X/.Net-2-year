using System;
using lab1.cards;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            double spent;
            Till client = new Till();
            while(true)
            {
                Console.WriteLine($"Enter the amount to spend:");
                try
                {
                    spent=client.Spend(Convert.ToDouble(Console.ReadLine()));
                    if (spent <= 0)
                        throw new ArgumentException();
                    Console.WriteLine($"You spent {spent}m\n");
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Please, enter a valid number\n");
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("You can't spend minus number or 0\n");
                }
                if (client.CardCheck())
                {
                    Console.WriteLine("You achieved new card level!\n");
                }
            }
        }
    }
}
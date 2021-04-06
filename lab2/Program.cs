using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            CPU inteli5 = new CPU("i5", "12345", 6000, 3.4, 4);
            CPU inteli7 = new CPU("i7", "12346", 9600, 4.6, 8);
            GPU nvidia920 = new GPU("920", "23456", 9000, 3, "gpr4");
            GPU nvidia970 = new GPU("970", "23457", 17000, 8, "gpr5");
            Monitor acer30 = new Monitor("a300", "34567", 5000, 1920, 22);
            Monitor acer45 = new Monitor("a450", "34568", 8000, 1920, 27);
            PC weakBuild = new PC(inteli5, nvidia920);
            PC strongBuild = new PC(inteli7, nvidia970);
            Console.WriteLine("Do you want to buy parts or already assembled PC?(1,2)");
            if (Console.ReadLine() == "2")
            {
                Console.WriteLine("Would you like to buy monitor to your PC?(Y/N)");
                if (Console.ReadLine().ToUpper() == "Y")
                {
                    Console.WriteLine("Okay, we have such sets:");
                }
            }
        }
    }
}
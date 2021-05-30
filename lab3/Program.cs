using System;
using System.Collections.Generic;
using lab3.Races;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IVisitable> Races = new List<IVisitable>
            {
            new Orcs(),
            new Elfs(),
            new Harpys(),
            new Pegasus(),
            new Trolls(),
            new Vampires()
            };

        IVisitor visitorWalk = new Walk();
        IVisitor visitorFly = new Fly();
        Call.ClientCode(Races,visitorWalk);
        Console.WriteLine();
        Call.ClientCode(Races,visitorFly);
        }

    }

}

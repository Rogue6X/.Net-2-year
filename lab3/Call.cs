using System;
using System.Collections.Generic;

namespace lab3
{
    public class Call
    {
        public static void ClientCode(List<IVisitable> races, IVisitor visitor)
            {
                foreach (var r in races)
                {
                    Console.WriteLine(r.Accept(visitor));
                }
            }
    }
}
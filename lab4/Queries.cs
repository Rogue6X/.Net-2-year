using System;
using System.Collections.Generic;
using System.Linq;

namespace lab4
{
    public static class Queries
    {
        private static List<User> people = new List<User>
        {
            new User("Lena", "Harlamova"),
            new User("Kirill", "Taynov"),
            new User("Denis", "Kursov"),
            new User("Nikita", "Butenko"),
            new User("Karina", "Rebrischeva"),
            new User("Ruslan", "Galushka"),
            new User("Natalia", "Burskaya"),
            new User("Alexander", "Gonilov")
        };

        private static readonly List<TechInfo> devices = new List<TechInfo>
        {
            new TechInfo("Mk248A", 5600, 140, "basement", people[1]),
            new TechInfo("Toshiba1245", 9800, 200, "attic", people[2]),
            new TechInfo("AR19T", 12500, 300, "attic", people[1]),
            new TechInfo("NQ134", 11200, 260, "basement", people[3]),
            new TechInfo("Jn350", 4899, 180, "attic", people[3]),
            new TechInfo("Asus15-t", 7689, 220, "server room", people[2]),
            new TechInfo("MS23qr", 6700, 200, "basement", people[0]),
            new TechInfo("BarT27", 15000, 315, "attic", people[5]),
            new TechInfo("TK1395", 1700, 70, "attic", people[7]),
            new TechInfo("TiFl4", 9650, 230, "server room", people[6]),
            new TechInfo("FN41", 9500, 210, "attic", people[5]),
            new TechInfo("Korni43", 12531, 280, "basement", people[4])
        };

        private static readonly List<TechInfo> devices1 = new List<TechInfo>
        {
            new TechInfo("Dt11", 9457, 200, "basement", people[4]),
            new TechInfo("GdD6", 12670, 282, "attic", people[5]),
            new TechInfo("Pt167", 3344, 140, "attic", people[0]),
            new TechInfo("UA3", 1238, 60, "basement", people[7])
        };

        public static void SimpleQ()
        {
            Console.WriteLine("1.Simple selection");
            var q1 = from x in devices
                select x;
            foreach (var x in q1)
                Console.WriteLine(x);

            Console.WriteLine("2.Proection of device's name");
            var q2 = from x in devices
                select x.Name;
            foreach (var x in q2)
                Console.WriteLine(x);

            Console.WriteLine("3.Creating new anonymous object");
            var q3 = from x in devices
                select new {name = x.Name, power = x.CompPower};
            foreach (var x in q3)
                Console.WriteLine(x);

            Console.WriteLine("4.Where");
            var q4 = from x in devices
                where x.Price > 7000 && x.CompPower > 180
                select x;
            foreach (var x in q4)
                Console.WriteLine(x);

            Console.WriteLine("5.Sort");
            var q5 = from x in devices
                where x.Price > 7000 && x.CompPower > 180
                orderby x.Price descending, x.Location descending
                select x;
            foreach (var x in q5)
                Console.WriteLine(x);

            Console.WriteLine("6.Skip Take");
            var q6 = devices.Skip(3).Take(2);
            foreach (var x in q6)
                Console.WriteLine(x);

            Console.WriteLine("7.Distinct");
            var q7 = (from x in devices select x.Location).Distinct();
            foreach (var x in q7)
                Console.WriteLine(x);
            Console.WriteLine("8.Group by\n");
            var q8 = from x in devices
                group x by x.Location;
            foreach (var x in q8)
            {
                Console.WriteLine(x.Key);
                foreach (var t in x)
                    Console.WriteLine(t);
            }

            Console.WriteLine("9.First");
            var q9 = (from x in devices select x).FirstOrDefault(x => x.Price == 12500);
            Console.WriteLine(q9);
        }

        public static void JoinQ()
        {
            Console.WriteLine("10.Inner Join with where");
            var q10 = from p in people
                from d in devices
                where p == d.Owner
                select new {User = p.name, device = d.Name};
            foreach (var x in q10)
                Console.WriteLine(x);

            Console.WriteLine("11.Group Join");
            var q11 = from p in people
                join d in devices on p equals d.Owner into temp
                select new {v1 = p, Group = temp};
            foreach (var x in q11)
            {
                Console.WriteLine(x.v1);
                foreach (var y in x.Group)
                    Console.WriteLine(" " + y);
            }

            Console.WriteLine("12.Outer Join"); //left join
            var q12 = from p in people
                join d in devices on p equals d.Owner into temp
                from t in temp.DefaultIfEmpty()
                select new {v1 = p, v2 = t == null ? "null" : t.Name};
            foreach (var x in q12)
                Console.WriteLine(x);

            Console.WriteLine("13.Union");
            foreach (var x in devices.Union(devices1))
                Console.WriteLine(x);

            Console.WriteLine("14.Group - Any");
            var q14 = from x in devices.Union(devices1)
                group x by x.Price
                into g
                where g.Any(x => x.Price > 12000)
                select new {g.Key, Values = g};
            foreach (var x in q14)
            {
                Console.WriteLine(x.Key);
                foreach (var y in x.Values)
                    Console.WriteLine(" " + y);
            }

            Console.WriteLine("15.Count with condition");
            var q15 = devices.Count(d => d.Location == "attic");
            Console.WriteLine(q15);
        }
    }
}
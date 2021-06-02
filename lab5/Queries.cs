using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace lab5
{
    public static class Queries
    {
        #region Initializing data
        public static List<User> people = new List<User>
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

        public static readonly List<TechInfo> devices = new List<TechInfo>
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
        
        
        
        public static void CreateXMLfromTable(IEnumerable<User> users,string ufileName,IEnumerable<TechInfo> devices ,string dfileName)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            using (XmlWriter writer = XmlWriter.Create(ufileName+".xml", settings))
            {
                writer.WriteStartElement("people");
                foreach (User user in users)
                {
                    writer.WriteStartElement("person");
                    writer.WriteElementString("name", user.name);
                    writer.WriteElementString("surname", user.surname);
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
            }
            
            using (XmlWriter writer = XmlWriter.Create(dfileName+".xml", settings))
            {
                writer.WriteStartElement("devices");
                foreach (TechInfo device in devices)
                {
                    writer.WriteStartElement("device");
                    writer.WriteElementString("name", device.Name);
                    writer.WriteElementString("price", device.Price.ToString(CultureInfo.CurrentCulture));
                    writer.WriteElementString("compPower", device.CompPower.ToString(CultureInfo.CurrentCulture));
                    writer.WriteElementString("location", device.Location);
                    writer.WriteElementString("owner", device.Owner.name);
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
            }
        }
        #endregion

        #region Queries

        

        
        public static void SimpleQ()
        {
            XmlDocument users = new XmlDocument();
            users.Load("users.xml");
            var devices = XDocument.Load("devices.xml");
            var xusers = XDocument.Load("users.xml");

            foreach (XmlNode node in users.DocumentElement)
            {
                string name = node["name"].InnerText;
                string surname = node["surname"].InnerText;
                Console.WriteLine("Name={0}; Surname= {1}", name, surname);
            }

            //simple selection
            var q1 = devices.Descendants("device")
                .Select(d => d.Elements("name"));

            //where
            var q2 = from device in devices.Root.Elements("device")
                where (int) device.Element("price") < 7000
                select device;

            var q3 = from device in devices.Root.Elements("device")
                where (int) device.Element("compPower") > 200
                select new
                {
                    name = device.Element("name"),
                    power = device.Element("compPower")
                };


            var q4 = devices.Descendants("device")
                .FirstOrDefault(d => d.Element("name").Value == "BarT27");

            var q5 = devices.Descendants("device")
                .Count(d => d.Element("location").Value == "basement");

            var q6 = devices.Descendants("device")
                .Select(d => d.Elements("name"))
                .OrderBy(d => d.Elements("owner"));

            var q7 = devices.Descendants("device")
                .Join(xusers.Descendants("name"),
                    dn => dn.Element("owner"),
                    ow => ow.Element("name"),
                    (ow, dn) => new
                    {
                        owner = ow.Value,
                        device = dn.Value
                    }
                );
            var q81 = devices.Descendants("device").Take(4);
            var q82 = devices.Descendants("device").TakeLast(4);
            var q9 = q81.Elements("name").Union(q82.Elements("name"));
        }
        #endregion
    }
}
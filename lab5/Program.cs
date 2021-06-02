
namespace lab5
{
    class Program
    {
        private static void Main(string[] args)
        {
            Queries.CreateXMLfromTable(Queries.people, "users", Queries.devices, "devices");
            Queries.SimpleQ();
        }
    }
}
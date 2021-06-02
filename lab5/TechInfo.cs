namespace lab5
{
    public class TechInfo
    {
        public string Name { get; }
        public string Location { get; }
        public double Price{ get; }
        public double CompPower { get; }
        public User Owner { get; }
        

        public TechInfo(string name, double price, double compPower, string location, User owner)
        {
            this.Name = name;
            this.Price = price;
            this.CompPower = compPower;
            this.Location = location;
            this.Owner = owner;
        }
        public override string ToString()
        {
            return "(name=" + Name + "; price=" + Price + "; power=" + CompPower + "; location=" + Location +
                   "; owner=" +Owner+")";
        }
    }
}
namespace lab2
{
    public abstract class Parts
    {
        private string name { get; set; }
        private string code { get; set; }
        private double price { get; set; }

        public Parts(string name, string code, double price)
        {
            this.code = code;
            this.name = name;
            this.price = price;
        }
    }
}
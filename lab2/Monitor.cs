namespace lab2
{
    public class Monitor:Parts
    {
        private const string category = "Monitor";
        public string name { get; set; }
        public string code { get; set; }
        public double price { get; set; }
        public double resolution { get; set; }
        public double diagonal { get; set; }

        public Monitor(string name, string code, double price,double resolution,double diagonal)
            :base(name, code, price)
        {
            this.resolution = resolution;
            this.diagonal = diagonal;
        }
    }
}
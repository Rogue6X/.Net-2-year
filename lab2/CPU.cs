namespace lab2
{
    public class CPU:Parts
    {
        private const string category = "CPU";
        public string name { get; set; }
        public string code { get; set; }
        public double price { get; set; }
        public double clockFrequency { get; set; }
        public int numberOfCores { get; set; }

        public CPU(string name, string code, double price,double clockFrequency,int numberOfCores)
        :base(name, code, price)
        {
            this.clockFrequency = clockFrequency;
            this.numberOfCores = numberOfCores;
        }
    }
}
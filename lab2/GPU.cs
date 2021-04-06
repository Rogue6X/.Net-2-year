namespace lab2
{
    public class GPU:Parts
    {
        private const string category = "GPU";
        public string name { get; set; }
        public string code { get; set; }
        public double price { get; set; }
        public int memoryAmount { get; set; }
        public string memoryType { get; set; }
        public int[] mas = new int[5];

        public GPU(string name, string code, double price,int memoryAmount,string memoryType, int[] mas)
            :base(name, code, price)
        {
            this.memoryAmount = memoryAmount;
            this.memoryType = memoryType;
        }
    }
}
namespace lab2
{
    public class PC
    {
        private CPU CPU { get; set; }
        private GPU GPU { get; set; }

        public PC(CPU cpu,GPU gpu)
        {
            CPU = cpu;
            GPU = gpu;
        }
    }
}
namespace ContainerOptimization.Models
{
    public class Container
    {
        public int Volume { get; set; }
        public int? ArmazemOrigem { get; set; }

        public Container(int volume)
        {
            Volume = volume;
        }

        public override string ToString()
        {
            return ArmazemOrigem.HasValue ? $"Armazém {ArmazemOrigem}({Volume})" : Volume.ToString();
        }
    }
}

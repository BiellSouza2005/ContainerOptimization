using ContainerOptimization.Models;

namespace ContainerOptimization.Models
{
    public class Armazem
    {
        public int Id { get; set; }
        public List<Container> Itens { get; set; } = new();
        public int Total { get; set; }
    }
}

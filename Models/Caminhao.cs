using ContainerOptimization.Models;

namespace ContainerOptimization.Models
{
    public class Caminhao
    {
        public List<Container> Itens { get; set; } = new();
        public int Total { get; set; }
    }
}
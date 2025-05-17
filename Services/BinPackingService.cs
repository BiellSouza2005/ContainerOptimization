using ContainerOptimization.Models;

namespace ContainerOptimization.Services
{
    public static class BinPackingService
    {
        public static List<Armazem> Pack(List<Container> containers, int capacidadeMaxima, bool marcarArmazemOrigem = false)
        {
            List<Armazem> armazens = new();
            int proximoId = 1;

            foreach (var container in containers.OrderByDescending(c => c.Volume))
            {
                var armazem = armazens.FirstOrDefault(a => a.Total + container.Volume <= capacidadeMaxima);

                if (armazem == null)
                {
                    armazem = new Armazem();
                    if (marcarArmazemOrigem)
                        armazem.Id = proximoId++;
                    armazens.Add(armazem);
                }

                armazem.Itens.Add(container);
                armazem.Total += container.Volume;

                if (marcarArmazemOrigem)
                    container.ArmazemOrigem = armazem.Id;
            }

            return armazens;
        }

        public static List<Caminhao> PackCaminhoes(List<Container> containers, int capacidadeCaminhao)
        {
            List<Caminhao> caminhoes = new();

            foreach (var container in containers.OrderByDescending(c => c.Volume))
            {
                var caminhao = caminhoes.FirstOrDefault(c => c.Total + container.Volume <= capacidadeCaminhao);

                if (caminhao == null)
                {
                    caminhao = new Caminhao();
                    caminhoes.Add(caminhao);
                }

                caminhao.Itens.Add(container);
                caminhao.Total += container.Volume;
            }

            return caminhoes;
        }
    }
}

using ContainerOptimization.Models;
using ContainerOptimization.Services;
using ContainerOptimization.Utils;

List<int> volumes = InputHelper.ReadIntList("Digite os volumes dos containers separados por vírgula:");
int maiorVolume = volumes.Max();

int capacidadeArmazem = InputHelper.ReadValidCapacity("Capacidade dos armazéns:", maiorVolume);
int capacidadeCaminhao = InputHelper.ReadValidCapacity("Capacidade dos caminhões:", maiorVolume);

List<Container> containers = volumes.Select(v => new Container(v)).ToList();

// Etapa 1: Alocação em armazéns (com ID dos armazéns registrados nos containers)
var armazens = BinPackingService.Pack(containers, capacidadeArmazem, marcarArmazemOrigem: true);

Console.WriteLine($"\nArmazéns necessários: {armazens.Count}");
for (int i = 0; i < armazens.Count; i++)
{
    var itens = string.Join(" + ", armazens[i].Itens.Select(c => c.Volume));
    Console.WriteLine($"Armazém {i + 1}: {itens} = {armazens[i].Total}");
}

// Etapa 2: Reempacotamento para caminhões
var todosContainers = armazens.SelectMany(a => a.Itens).ToList();
var caminhoes = BinPackingService.PackCaminhoes(todosContainers, capacidadeCaminhao);

Console.WriteLine($"\nCaminhões necessários: {caminhoes.Count}");
for (int i = 0; i < caminhoes.Count; i++)
{
    var itens = string.Join(" + ", caminhoes[i].Itens.Select(c => c.ToString()));
    Console.WriteLine($"Caminhão {i + 1}: {itens} = {caminhoes[i].Total}");
}

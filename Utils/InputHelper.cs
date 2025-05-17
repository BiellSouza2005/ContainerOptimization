namespace ContainerOptimization.Utils
{
    public static class InputHelper
    {
        public static List<int> ReadIntList(string mensagem)
        {
            Console.WriteLine(mensagem);
            while (true)
            {
                try
                {
                    var entrada = Console.ReadLine();
                    return entrada.Split(',').Select(int.Parse).ToList();
                }
                catch
                {
                    Console.WriteLine("Entrada inválida. Digite números separados por vírgula.");
                }
            }
        }

        public static int ReadInt(string mensagem)
        {
            Console.Write(mensagem + " ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int valor))
                    return valor;
                Console.WriteLine("Valor inválido. Tente novamente:");
            }
        }

        public static int ReadValidCapacity(string mensagem, int minimo)
        {
            int valor;
            do
            {
                valor = ReadInt(mensagem);
                if (valor < minimo)
                {
                    Console.WriteLine($"Erro: O valor informado ({valor}) não pode ser menor que o valor mínimo exigido ({minimo}). Tente novamente.");
                }
            } while (valor < minimo);

            return valor;
        }
    }
}

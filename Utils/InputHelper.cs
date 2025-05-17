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
    }
}

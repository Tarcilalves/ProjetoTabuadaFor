using ProjetoTabuadaFor.Models;

internal class Program
{
    static void Main(string[] args)
        {
            // Coloca o encoding para UTF8 para exibir acentuação
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Seja bem vindo ao sistema de Cálculo de tabuada!\n");
            
            // Instanciando: craindo o objeto Tabuada
            Tabuada tab = new();

            // Realizar o loop do Menu
            bool exibirMenu = true;

            while (exibirMenu)
            {
                Console.Clear();
                Console.WriteLine("Digite a sua opção:");
                Console.WriteLine("1 - Calcular Tabuada");
                Console.WriteLine("2 - Listar tabuada");
                Console.WriteLine("3 - Limpar lista de tabuadas");
                Console.WriteLine("4 - Encerrar");

                switch (Console.ReadLine())
                {
                    case "1":
                        tab.AdicionarTabuada();
                        tab.Multiplicar();
                        break;                    

                    case "2":
                        tab.ListarTabuadas();
                        break;

                    case "3":
                        tab.LimparLista();
                        break;

                    case "4":
                        exibirMenu = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                Console.WriteLine("Pressione uma tecla para continuar");
                Console.ReadLine();
            }

            Console.WriteLine("O programa foi encerrado.");
        }
}


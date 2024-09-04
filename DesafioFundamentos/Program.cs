using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Digite o preço inicial:");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
int opcaoSaida = 2;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            Console.WriteLine("Deseja sair do sistema?");
            Console.WriteLine();
            Console.WriteLine("Digite 1 para sim e 2 para não.");
            string respostaOpcaoSaida = Console.ReadLine();
            if(int.TryParse(respostaOpcaoSaida, out opcaoSaida))
            {
                if(opcaoSaida == 1)
                {
                    Console.WriteLine("Sua sessão foi encerrada com sucesso. Continue sendo incrível!");
                    Environment.Exit(0);
                    //exibirMenu = false;
                }
                else if (opcaoSaida == 2)
                {
                    exibirMenu = true;
                }
                else
                {
                    Console.WriteLine("Opção inválida. Pressione qualquer tecla para continuar.");
                    Console.ReadKey();
                    exibirMenu = true;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Pressione qualquer tecla para continuar.");
                Console.ReadKey();
            }

            // exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida. Pressione qualquer tecla para continuar.");
            Console.ReadKey();
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");

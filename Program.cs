using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace ProjetoEstacionamentoDio
{
    internal class Program
    {
        static void Main()
        {
            int opcao = 0;
            
            bool encerrar = true;

                       
            VagaEstacionamento vagaEstacionamento = new VagaEstacionamento();

            Cobranca valorCobranca = new Cobranca();



            Console.WriteLine("Digite o valor do Estacionamento:");
            valorCobranca.ValorParaEstacionar  = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor por HORA:");
            valorCobranca.ValorPorHora = Convert.ToDouble(Console.ReadLine());


            do
            {

                Console.WriteLine("______________________\n" +
                                  "        TABELA        \n" +
                                  "______________________\n" +
                                  "1- Cadastrar Veiculo. \n" +
                                  "______________________\n" +
                                  "2- Remover Veiculo.   \n" +
                                  "______________________\n" +
                                  "3- Lista de Veículos. \n" +
                                  "______________________\n" +
                                  "4- Encerrar.          \n" +
                                  "______________________\n");

                Console.WriteLine("Digite a opção: ");

                opcao = Convert.ToInt16(Console.ReadLine());

                switch(opcao)
                {
                    case 1:
                       
                        Console.WriteLine("Digite a Placa do carro:");
                        vagaEstacionamento.Placa = Console.ReadLine().ToLower();
                        vagaEstacionamento.AdicionarCarro();

                        Console.Clear();

                        break;

                    case 2:
                        Console.WriteLine("Digite a placa do carro que deseja remover: ");
                        string placaRemover = Console.ReadLine().ToLower();

                        if (vagaEstacionamento.RemoverCarro(placaRemover, valorCobranca))
                        {
                            Console.WriteLine("Carro removido com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Carro não encontrado.");
                        }

                        Console.ReadKey();

                        Console.Clear();

                        break;

                    case 3:

                        vagaEstacionamento.ApresentarCarros();

                        Console.ReadKey();

                        Console.Clear();
                        break;

                    case 4:
                        Console.WriteLine("Encerrando programa...");
                        encerrar = false;
                        break;

                    default:
                        Console.WriteLine("Opção invalida, escolha uma opção do MENU");
                        break;
                }
                Console.WriteLine();

            } while (encerrar);
            

        }
    }
}

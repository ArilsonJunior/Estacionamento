using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstacionamentoDio
{
    public class VagaEstacionamento
    {
        private List<string> carros = new List<string>();

        public string Placa { get; set; }

        public void AdicionarCarro()
        {
            if (!string.IsNullOrEmpty(Placa))
            {
                carros.Add(Placa);
                Console.WriteLine($"Carro {Placa} adicionado à vaga.");
            }
            else
            {
                Console.WriteLine("Placa não pode ser vazia.");
            }
        }

        public void ApresentarCarros()
        {
            if (carros.Count == 0)
            {
                Console.WriteLine("Não há carros cadastrados.");
                return;
            }

            Console.WriteLine("\nCARROS CADASTRADOS\n" +
                              "__________________");
            foreach (var carro in carros)
            {
                Console.WriteLine("\nPlaca: " + carro);
            }
        }
        public bool RemoverCarro(string placa, Cobranca cobranca)
        {
            if (carros.Remove(placa)) 
            {
                Console.WriteLine("Quantas horas permaneceu no estacionamento?: ");
                cobranca.HorasEstacionadas = Convert.ToDouble(Console.ReadLine());
                cobranca.Calcular();
                return true;
            }
            return false;
        }
    }
}

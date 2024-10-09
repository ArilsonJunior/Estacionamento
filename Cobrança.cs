using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstacionamentoDio
{
    public class Cobranca
    {
        
        public double ValorParaEstacionar { get; set; }
        public double ValorPorHora { get; set; }
        public double HorasEstacionadas { get; set; }

        public void Calcular()
        {
            double valorTotal = ValorParaEstacionar + (ValorPorHora * HorasEstacionadas);
            Console.WriteLine("O valor total são: R$ " + valorTotal.ToString("F2") + "\nObrigado, volte sempre!");
        }
    }
}


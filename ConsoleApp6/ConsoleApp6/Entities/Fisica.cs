using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6.Entities
{
    class Fisica : Pessoa
    {
        public double GastoSaude { get; set; }

        public Fisica(string nome, double rendaAnual, double gastoSaude) : base(nome, rendaAnual)
        {
            GastoSaude = gastoSaude;
        }

        public override double CalculaImposto()
        {
            if (RendaAnual < 20000.0)
            {
                return RendaAnual * 0.15 - GastoSaude * 0.5;
            }
            else
            {
                return RendaAnual * 0.25 - GastoSaude * 0.5;
            }
        }

    }
}

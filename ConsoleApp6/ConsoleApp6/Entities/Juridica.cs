
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6.Entities
{
    class Juridica : Pessoa
    {

        public int NumeroFunc { get; set; }

        public Juridica(string nome, double rendaAnual, int numeroFunc) : base(nome, rendaAnual)
        {
            NumeroFunc = numeroFunc;
        }

        public override double CalculaImposto()
        {
            if (NumeroFunc > 10)
            {
                return RendaAnual * 0.14;
            }
            else
            {
                return RendaAnual * 0.16;
            }
        }
    }
}

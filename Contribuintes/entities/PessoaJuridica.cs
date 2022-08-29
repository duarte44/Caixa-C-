using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contribuintes.entities
{
    internal class PessoaJuridica : Pessoa
    {
        public int NumeroFuncionarios { get; set; }
       

        public PessoaJuridica(int numeroFuncionarios, string nome, double rendaAnual) : base(nome, rendaAnual)
        {
            NumeroFuncionarios = numeroFuncionarios;
          
        }

        public override double ValorImposto()
        {
            if ( NumeroFuncionarios > 10)
            {
               return RendaAnual * 0.14;
            }
            else
            {
                return RendaAnual * 0.14;
            }
        }
        public override string ToString()
        {
            return Nome + ": $ " + ValorImposto().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

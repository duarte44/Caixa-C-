using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contribuintes.entities;

namespace Contribuintes.entities
{
    class PessoaFisica : Pessoa
    {
        public double GastosComSaude { get; set; }
              

        public PessoaFisica(double gastosComSaude, string nome, double rendaAnual) : base(nome, rendaAnual)
        {
           this.GastosComSaude = gastosComSaude;
          
        }

        public override double ValorImposto()
        {
            if( RendaAnual < 20000.00)
            {
               return (RendaAnual * 0.15) - (GastosComSaude * 0.50);
            }
            else
            {
               return (RendaAnual * 0.25) - (GastosComSaude * 0.50);
            }           
            
        }

        public override string ToString()
        {
            return Nome + ": $ " + ValorImposto().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}

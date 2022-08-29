using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contribuintes.entities
{
    abstract class Pessoa
    {
        public string Nome { get; set; }    
        public double RendaAnual { get; set; }    

       
        public Pessoa(string nome, double rendaAnual){

            this.Nome = nome;
            this.RendaAnual = rendaAnual;
           
        }
        

        public abstract double ValorImposto();
        
    }
}

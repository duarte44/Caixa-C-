using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quartos
{
    internal class Cadastro
    {
        public string Nome { get; set; }
        public string Email { get; set; }       


        public Cadastro(string Nome, string Email)
        {
            this.Nome = Nome;
            this.Email = Email; 
        }
           
    }   

}

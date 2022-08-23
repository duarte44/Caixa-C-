
namespace Primeiros
{
    internal class Pessoa
    {
        public string nome;
        public string nome2;
        public int idade;
        public int idade2;
        public double salario;
        public double salario2;

        public string Result()
        {
            if(idade > idade2)
            {
                return this.nome + " Tem a idade Maior";
            }
            else if(idade2 > idade)
            {
                return this.nome2 + " Tem a idade Maior";
            }
            else
            {
                return "Idades iguais";
            }
        }

        public double SalarioMedia()
        {
           return (this.salario + this.salario2) / 2;
        }
    }
}

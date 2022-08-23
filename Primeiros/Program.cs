using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeiros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            Console.WriteLine("Dados Primeira Pessoa");

            Console.Write("Nome: ");
            pessoa.nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa.idade = int.Parse(Console.ReadLine());
            Console.Write("Salario: ");
            pessoa.salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("\nDados Segunda Pessoa");

            Console.Write("Nome: ");
            pessoa.nome2 = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa.idade2 = int.Parse(Console.ReadLine());
            Console.Write("Salario: ");
            pessoa.salario2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\n"+pessoa.Result());
            Console.WriteLine("\nMedia dos salários: "+ pessoa.SalarioMedia().ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}

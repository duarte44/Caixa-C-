using Contribuintes.entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Registro
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<Pessoa> pessoa = new();

           Console.WriteLine("Digite quantos contribuintes vai inserir");
            int num = int.Parse(Console.ReadLine());

            double sum = 0;

            for (int i = 0; i < num; i++)
            {   
                Console.Write("Fisica ou Juridica: (f/j) ");
                char alt = char.Parse(Console.ReadLine());

                if (alt == 'f')
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();

                    Console.Write("Renda anual: ");
                    double rendaAnual = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));

                    Console.Write("Gasto com saude: ");
                    double gastoComSaude = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));

                    Console.WriteLine();

                    PessoaFisica pessoaFisica = new PessoaFisica(gastoComSaude, nome, rendaAnual);

                    pessoa.Add(pessoaFisica);
                }
                else
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();

                    Console.Write("Renda anual: ");
                    double rendaAnual = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));

                    Console.Write("Numero de Funcionarios: ");
                    int func = int.Parse(Console.ReadLine());

                    Console.WriteLine();

                    PessoaJuridica pessoaJuridica = new PessoaJuridica(func, nome, rendaAnual);

                    pessoa.Add(pessoaJuridica);
                }
                
                
            }

            foreach (Pessoa p in pessoa)
            {
                Console.WriteLine(p);
                sum += p.ValorImposto();
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}


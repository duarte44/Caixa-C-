using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Quartos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos ? ");
            int num = int.Parse(Console.ReadLine());
              

            Cadastro[] vect = new Cadastro[10];

            for(int i = 0; i < num; i++)
            {
                Console.WriteLine();

                Console.WriteLine("Cadstro " + (i + 1));
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                vect[quarto] = new Cadastro(nome, email); 
              

            }

            Console.WriteLine();
            Console.WriteLine("Quartos Alugados: ");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.Write(i + ": " + vect[i].Nome + ", " + vect[i].Email);
                    Console.WriteLine();
                }
            }
        }
    }
}

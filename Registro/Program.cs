using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered ? ");
            int nm = int.Parse(Console.ReadLine());


            List<Dados> list = new List<Dados>();


            for (int i = 0; i < nm; i++)
            {
                Console.WriteLine("Emplyoee #" + (i + 1));

                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
                 
                Dados dados = new Dados(id, name, salary);
                list.Add(dados);

                Console.WriteLine();
               
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int inc = int.Parse(Console.ReadLine());



            Dados emp = list.Find(x => x.id == inc);

            if (emp != null)
                {
                    Console.Write("Enter the percentage: ");
                    double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    emp.increaseSalary(percentage);
                }
            else
            {
                Console.WriteLine("This id does not exist!");
            }



            Console.WriteLine();

            Console.WriteLine("Updated list of employees:");
            
            foreach(Dados dados in list)
            {
                Console.WriteLine(dados);
            }
            
            

        }
    }
}

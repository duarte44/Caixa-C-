using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro
{
    internal class Dados
    {
        public int id { get; set; }
        public string name { get; set; }
        public double salary { get; private set; }

        public Dados(int id, string name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        public void increaseSalary(double percentage)
        {
            this.salary = this.salary + (this.salary * (percentage / 100));
        }

        public override string ToString()
        {
            return this.id + ", " + this.name + ", "+ this.salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

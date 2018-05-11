using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sueldo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            float salario, valorHora;
            
            //5*8 = 40 *4 = 160
            
            Console.WriteLine("CALCULAR VALOR HORA");
            Console.WriteLine("********************");
            Console.WriteLine("Ingrese Salario: ");
            Console.WriteLine("******************");
            salario = float.Parse(Console.ReadLine());
            valorHora = salario / 160;
            Console.WriteLine("Costo calculado por hora: $" + valorHora);

            Console.ReadLine();

        }
    }
}

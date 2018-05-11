using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetalleFac
{
    class Program
    {
        static void Main(string[] args)
        {

            float valor1, valor2, valor3, valor4;
            Console.WriteLine("FACTURA");
            Console.WriteLine("*******************************");
            Console.WriteLine("Ingrese Valor Producto 1 ");valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Valor Producto 2 "); valor2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Valor Producto 3 "); valor3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Valor Producto 4 "); valor4 = float.Parse(Console.ReadLine());
            Console.WriteLine("IMPRIMIENDO VALORES ADICIONALES");
            float sumVal = valor1 + valor2 + valor3 + valor4;
            Console.WriteLine("SUBTOTAL : " + sumVal);
            float iva = (sumVal) * (0.12); 
            Console.WriteLine("IVA : " +iva);
            Console.WriteLine("TOTAL : " + (sumVal +iva));

        }
    }
}

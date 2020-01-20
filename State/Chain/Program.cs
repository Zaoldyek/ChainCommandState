using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteHandler1 a = new ConcreteHandler1();
            ConcreteHandler2 b = new ConcreteHandler2();
            a.setNext(b);
            while (true)
            {
                Console.WriteLine("Ingresa Solicitud:");
                string solicitud = Console.ReadLine();
                Console.WriteLine("Ingresa Cantidad:");
                int cantidad = Convert.ToInt32(Console.ReadLine());

                a.handle(cantidad,solicitud);
                Console.ReadLine();
            }
        }
    }
}

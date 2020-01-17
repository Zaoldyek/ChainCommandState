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
    public interface Handler
    {
        void setNext(Handler h);
        void handle(int iImporte, string concepto);
    }

    public abstract class BaseHandler : Handler
    {
        public Handler next {get;set;}

        public abstract void handle(int iImporte, string concepto);

        public void setNext(Handler h)
        {
            next = h;
        }
    }

    public class ConcreteHandler1 : BaseHandler
    {
        public ConcreteHandler1() {}

        public override void handle(int iImporte, string concepto)
        {
            if (iImporte <= 5000)
            {
                Console.WriteLine(concepto+" AUTORIZADA Por Coordinador");
            }
            else
            {
                base.next.handle(iImporte,concepto);
            }
        }
    }

    public class ConcreteHandler2 : BaseHandler
    {
        public ConcreteHandler2() { }

        public override void handle(int iImporte, string concepto)
        {
            if (iImporte > 5000 && iImporte <= 10000)
            {
                Console.WriteLine(concepto+ " AUTORIZADA Por Gerente");
            }
            else
            {
                base.next.handle(iImporte,concepto);
            }
        }
    }
    public class ConcreteHandler3 : BaseHandler
    {
        public ConcreteHandler3() { }

        public override void handle(int iImporte, string concepto)
        {
            if (iImporte > 10000 && iImporte <= 15000)
            {
                Console.WriteLine(concepto+ " AUTORIZADA Por Subdirector");
            }
            else
            {
                base.next.handle(iImporte,concepto);
            }
        }
    }
    public class ConcreteHandler4 : BaseHandler
    {
        public ConcreteHandler4() { }

        public override void handle(int iImporte, string concepto)
        {
            if (iImporte > 15000 && iImporte <= 50000)
            {
                Console.WriteLine(concepto+" AUTORIZADA Por Director");
            }
            else
            {
                base.next.handle(iImporte,concepto);
            }
        }
    }
}

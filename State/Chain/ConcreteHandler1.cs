using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain
{
    public class ConcreteHandler1 : BaseHandler
    {
        public ConcreteHandler1() { }

        public override void handle(int iImporte, string concepto)
        {
            if (iImporte <= 5000)
            {
                Console.WriteLine(concepto + " AUTORIZADA Por Coordinador");
            }
            else
            {
                base.next.handle(iImporte, concepto);
            }
        }
    }
}

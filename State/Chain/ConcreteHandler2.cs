using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain
{
    public class ConcreteHandler2 : BaseHandler
    {
        public ConcreteHandler2() { }

        public override void handle(int iImporte, string concepto)
        {
            if (iImporte > 5000 && iImporte <= 10000)
            {
                Console.WriteLine(concepto + " AUTORIZADA Por Gerente");
            }
            else
            {
                base.next.handle(iImporte, concepto);
            }
        }
    }
}

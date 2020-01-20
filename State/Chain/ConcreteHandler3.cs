using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain
{
    public class ConcreteHandler3 : BaseHandler
    {
        public ConcreteHandler3() { }

        public override void handle(int iImporte, string concepto)
        {
            if (iImporte > 10000 && iImporte <= 15000)
            {
                Console.WriteLine(concepto + " AUTORIZADA Por Subdirector");
            }
            else
            {
                base.next.handle(iImporte, concepto);
            }
        }
    }
}

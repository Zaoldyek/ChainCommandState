using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain
{
    public class ConcreteHandler4 : BaseHandler
    {
        public ConcreteHandler4() { }

        public override void handle(int iImporte, string concepto)
        {
            if (iImporte > 15000 && iImporte <= 50000)
            {
                Console.WriteLine(concepto + " AUTORIZADA Por Director");
            }
            else
            {
                base.next.handle(iImporte, concepto);
            }
        }
    }
}

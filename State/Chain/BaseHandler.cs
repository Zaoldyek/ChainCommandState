using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain
{
    public abstract class BaseHandler : lHandler
    {
        public lHandler next { get; set; }

        public abstract void handle(int iImporte, string concepto);

        public void setNext(lHandler h)
        {
            next = h;
        }
    }
}

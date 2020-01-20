using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain
{
    public interface lHandler
    {
        void setNext(lHandler h);
        void handle(int iImporte, string concepto);
    }
}

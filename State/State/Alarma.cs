using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public interface Alarma
    {
        void ActivarAlarma();

        void DesactivarAlarma();

        void setContext(Context context);
    }
}

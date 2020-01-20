using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class ActivarState : Alarma
    {
        Context context { get; set; }

        public void setContext(Context context)
        {
            this.context = context;
        }
        public void ActivarAlarma()
        {
            Console.WriteLine("La alarma ya esta Activada");
        }

        public void DesactivarAlarma()
        {
            Console.WriteLine("Alarma Desactivada");
            DesactivarState DesactivarAlarma = new DesactivarState();
            DesactivarAlarma.setContext(context);
            context.changeState(DesactivarAlarma);
        }
    }
}

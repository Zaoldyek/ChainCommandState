using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{

    public class DesactivarState : Alarma
    {
        Context context { get; set; }

        public void setContext(Context context)
        {
            this.context = context;
        }
        public void ActivarAlarma()
        {
            Console.WriteLine("Alarma Activada");
            ActivarState ActivarAlarma = new ActivarState();
            ActivarAlarma.setContext(context);
            context.changeState(ActivarAlarma);
        }

        public void DesactivarAlarma()
        {
            Console.WriteLine("Alarma ya esta Desactivada");

        }
    }

}

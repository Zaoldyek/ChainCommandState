using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Context
    {
        Alarma state { get; set; }

        public Context(Alarma AlarmaState)
        {
            this.state = AlarmaState;
            state.setContext(this);
        }

        public void changeState(Alarma Alarmastate)
        {
            this.state = Alarmastate;
        }

        public void ActivarAlarma()
        {
            state.ActivarAlarma();
        }

        public void DesactivarAlarma()
        {
            state.DesactivarAlarma();
        }

    }
}

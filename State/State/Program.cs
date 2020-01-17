using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Alarma initialState = new ActivarState();
            Context context = new Context(initialState);
            initialState.setContext(context);
           
            while (true)
            {
                Console.Write("1º) Activar Alarma " + "\n" + "2º) Desactivar Alarma " + "\n" + "3º) Salir del Prograna");
                Console.Write("Seleccione una opción: \n");

                switch (Console.Read())
                {
                    case '1':
                        context.ActivarAlarma();
                        break;
                    case '2':
                        context.DesactivarAlarma();
                        break;
                    case '3':
                        Environment.Exit(-1);
                        break;                       
                    
                }
                Console.ReadLine();
            }
        }
    }

    public interface Alarma
    {
        void ActivarAlarma();

        void DesactivarAlarma();

        void setContext(Context context);
    }

    public class ActivarState : Alarma
    {
        Context context { get; set; }
       
        public void setContext(Context context) {
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

    public class Context
    {
        Alarma state {get;set;}

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

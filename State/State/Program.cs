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
}

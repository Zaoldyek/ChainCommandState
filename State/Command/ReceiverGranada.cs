using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class ReceiverGranada
    {
        public void operation(int _iStatus,Personaje entPersonaje)
        {
            Console.WriteLine(_iStatus == 0 ?
                entPersonaje.cNombre+" Agrego Lanza Granadas" 
                :
                entPersonaje.cNombre + " " + entPersonaje.cAccion + " con potencia de " + entPersonaje.iPotencia

                );
        }
    }
}

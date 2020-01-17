using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class ReceiverPlasma
    {
        public void operation(int _iStatus, Personaje entPersonaje)
        {
            Console.WriteLine(_iStatus == 0 ? entPersonaje.cNombre + " Agrego Rifle de Plasma" : entPersonaje.cNombre + " " + entPersonaje.cAccion + " con potencia de " + entPersonaje.iPotencia);
        }
    }
}

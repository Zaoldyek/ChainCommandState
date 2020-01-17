using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Golpear : Command
    {
        public void Execute(Personaje entPersonaje)
        {
            Console.WriteLine(entPersonaje.cNombre + " " + entPersonaje.cAccion + " con potencia de " + entPersonaje.iPotencia);
        }
    }
}

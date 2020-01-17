using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Saltar : Command
    {
        public void Execute(Personaje entPersonaje)
        {
            Console.WriteLine(entPersonaje.cNombre + " " + entPersonaje.cAccion + " con altura de " + entPersonaje.iPotencia);

        }
    }
}

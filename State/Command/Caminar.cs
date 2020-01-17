using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Caminar : Command
    {
        public void Execute(Personaje entPersonaje)
        {
            Console.WriteLine(entPersonaje.cNombre+" "+ entPersonaje.cAccion+" Con velocidad de "+ entPersonaje.iPotencia);
        }
    }
}

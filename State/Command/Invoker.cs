using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Invoker
    {
        Personaje entPersonaje { get; set; }

        Command comando { get; set; }

        public void setComando(Command _comando,Personaje _entPersonaje)
        {
            comando = _comando;
            entPersonaje = _entPersonaje;
        }

        public void ExcecuteCommand()
        {
            comando.Execute(entPersonaje);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            ReceiverGranada receiverGranada = new ReceiverGranada();
            ConseguirGranadas conseguirGranadas = new ConseguirGranadas(receiverGranada, 0) ;
            ReceiverPlasma receiverPlasma = new ReceiverPlasma();
            ConseguirPlasma conseguirPlasma = new ConseguirPlasma(receiverPlasma, 0) ;
            Personaje entPersonaje = new Personaje();

            Console.WriteLine("Escoge tu personaje : \n 1°) Guerrero Clase Baja \n 2°) Guerrero Clase Media \n 3°) Guerrero Clase Alta");
            entPersonaje.iTipo = Convert.ToInt32(Console.ReadLine());
            switch (entPersonaje.iTipo) {
                case 1:
                    entPersonaje.iPotencia = 10;
                    break;
                case 2:
                    entPersonaje.iPotencia = 20;
                    break;
                case 3:
                    entPersonaje.iPotencia = 30;
                    break;
            }
           

            Console.WriteLine("Introduce el nombre de tu personaje");
            entPersonaje.cNombre = Console.ReadLine();
            Console.WriteLine();

            while (true) {
                Console.WriteLine("Escoge tu acción : \n 1°) Caminar \n 2°) Saltar \n 3°) Golpear \n 4°) Disparar \n 5°) "+(conseguirGranadas.iStatus==0? "Conseguir lanza granada": "Usar lanza granada") +" \n 6°) " + (conseguirPlasma.iStatus == 0 ? "Conseguir rifle plasma" : "Usar rifle plasma"));
                entPersonaje.cAccion = Console.ReadLine();

                Invoker invocador = new Invoker();
                
                Command comando;
                switch (entPersonaje.cAccion) {
                    case "1":
                        entPersonaje.cAccion = "Camina";
                        comando = new Caminar();
                        invocador.setComando(comando, entPersonaje);
                        invocador.ExcecuteCommand();
                        break;
                    case "2":
                        entPersonaje.cAccion = "Salta";
                        comando = new Saltar();
                        invocador.setComando(comando, entPersonaje);
                        invocador.ExcecuteCommand();
                        break;
                    case "3":
                        entPersonaje.cAccion = "Golpea";
                        comando = new Golpear();
                        invocador.setComando(comando, entPersonaje);
                        invocador.ExcecuteCommand();
                        break;
                    case "4":
                        entPersonaje.cAccion = "Dispara";
                        comando = new Disparar();
                        invocador.setComando(comando, entPersonaje);
                        invocador.ExcecuteCommand();
                        break;
                    case "5":
                        entPersonaje.cAccion = "Dispara Lanza Granadas";
                        comando = conseguirGranadas;
                        invocador.setComando(comando, entPersonaje);
                        invocador.ExcecuteCommand();
                        conseguirGranadas.iStatus = 1;
                        break;
                    case "6":
                        entPersonaje.cAccion = "Dispara Rifle de Plasma";
                        comando = conseguirPlasma;
                        invocador.setComando(comando, entPersonaje);
                        invocador.ExcecuteCommand();
                        conseguirPlasma.iStatus = 1;
                        break;
                    default:
                        Console.WriteLine("No es una opcion válida");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}

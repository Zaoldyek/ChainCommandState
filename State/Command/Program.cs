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
            Command2 comando = new Command2();
            Invoker invocador = new Invoker();
            Receiver receiver = new Receiver();
            invocador.setComando(comando);
            invocador.ExcecuteCommand();

            Command1 comando1 = new Command1(receiver,new List<string>() { "Parametro1","Parametro2"});
            invocador.setComando(comando1);
            invocador.ExcecuteCommand();

            Console.ReadLine();
        }
    }

    public interface Command
    {
        void Execute();
    }

    public class Invoker
    {
        Command comando { get; set; }

        public void setComando(Command _comando)
        {
            comando = _comando;
        }

        public void ExcecuteCommand() {
            comando.Execute();
        }
    }

    public class Command1 : Command
    {
        Receiver receiver { get; set; }
        List<string> parametros { get; set; }
        public Command1(Receiver _receiver, List<string> _lstParams) {
            receiver = _receiver;
            parametros = _lstParams;
        }
        
        public void Execute()
        {
            receiver.operation(parametros);
        }
    }

    public class Receiver
    {
        public void operation(List<string> lstParams) {
            Console.WriteLine("Accion del Receiver");
        }
    }

    public class Command2 : Command
    {
        public void Execute()
        {
            Console.WriteLine("Comando 2 Ejecutado");
        }
    }
}

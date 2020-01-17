using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class ConseguirGranadas : Command
    {
        ReceiverGranada receiver { get; set; }

        public int iStatus { get;set; }
        
        public ConseguirGranadas(ReceiverGranada _receiver,int _iStatus)
        {
            receiver = _receiver;
            iStatus = _iStatus;
        }

        public void Execute(Personaje entPersonaje)
        {
            receiver.operation(iStatus, entPersonaje);
        }
    }
}

using assOOP05;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assOOP03
{
    internal class Cinema:Iprintable
    {
        public string CinemaName { get; set; }
        private Projector proj=new Projector();
        private Iprintable[] tickets =new Iprintable[20];
        public bool AddTicket(Iprintable t)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] == null)
                {
                    tickets[i] = t;
                    return true;
                }
            }
            return false;
        }
        public void Print()
        {
            Console.WriteLine("====All Tickets====");
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] == null)
                {
                    break;
                }
                tickets[i].Print();
            }
        }

        public void OpenCinema()
        {
            Console.WriteLine("========Cinema Opened========");
            proj.startprojector();
        }
        public void CloseCinema()
        {
            Console.WriteLine("========Cinema closed========");
            proj.stopprojector();
        }

      
    }
}

using assOOP05;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace assOOP03
{
    internal class IMAXTicket:Ticket,ICloneable,Iprintable
    {
        private bool Is3d;
        public IMAXTicket(string moviename, decimal pri, bool _Is3D):base(moviename,pri)
        {
            Is3d = _Is3D;
            if (Is3d)
            {
                price += 30;
            }
        }

        public object Clone()
        {
            return new IMAXTicket(MovieName,price,Is3d);
        }

        public void Print()
        {
            Console.WriteLine($"[Ticket # {TicketId}] | Imax | Imax 3D : {Is3d} | Price : {price} EGP | After Tax : {PriceAfterTax} EGP | Book : {(isbooked ? "Yes" : "No")}");
        }
    }
}

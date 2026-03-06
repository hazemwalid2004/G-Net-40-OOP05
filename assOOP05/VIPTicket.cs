using assOOP05;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assOOP03
{
    internal class VIPTicket:Ticket,ICloneable,Iprintable
    {
        private decimal serviesfee;
        public bool LoungeAccess { get; set; }
        public VIPTicket(string moviename, decimal pri,bool _LoungAcess):base(moviename,pri)
        {
            LoungeAccess = _LoungAcess;
            serviesfee = 50;
        }

        public void Print()
        {
            Console.WriteLine($"[Ticket # {TicketId}] | VIP | Lounge : {LoungeAccess} | ServiceFee : {serviesfee} EGP | Price : {price} EGP | After Tax : {PriceAfterTax} EGP | Book : {(isbooked ? "Yes" : "No")}" );
        }

        public object Clone()
        {
            return new VIPTicket(MovieName, price, LoungeAccess);
        }
    }
}

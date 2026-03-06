using assOOP05;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assOOP03
{
    internal class StandardTicket:Ticket,ICloneable,Iprintable
    {
        public string seatNumber { get; set; }
        public StandardTicket(string moviename,decimal pri,string _seatnumber) : base(moviename, pri)
        {
            seatNumber=_seatnumber;
        }
        public void Print()
        {
            Console.WriteLine($"[Ticket # {TicketId}] | Standard | seat : {seatNumber} | Price : {price} EGP | After Tax : {PriceAfterTax} EGP | Book : {(isbooked ? "Yes" : "No")}");
        }

        public object Clone()
        {
            return new StandardTicket(MovieName,price,seatNumber);
        }
    }
}

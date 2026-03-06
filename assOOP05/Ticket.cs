using assOOP05;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace assOOP03
{
    internal class Ticket
    {
        private String moviename;
        private  decimal Price;
        private static int totalTicket = 0;
        protected bool isbooked=false;
        public String MovieName 
        { 
            get { return moviename; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    moviename = value;
                }
            }
        }
        public decimal price
        {
            get { return Price; }
            set
            {
                if (Price > 0)
                {
                    Price = value;
                }
            }
        }
        public void SetPrice(decimal _price)
        {
            price = _price;
        }
        public void SetPrice(decimal _price,decimal multiplier)
        {
            price= _price*multiplier;
        }
        public int TicketId { get; }
        public Ticket (String _moviename,decimal _price)
        {
            MovieName = _moviename;
            Price = _price;
            totalTicket++;
            TicketId=totalTicket;
            
        }
        
        
        public decimal PriceAfterTax => Price + (Price * 14 / 100);
      
        
        public static int GetTotalTickets()
        {
            return totalTicket;
        }

        public void book()
        {
            if (isbooked) { return; }
             isbooked = true; 
        }
        public void cancel()
        {
            if (!isbooked) { return; }
             isbooked = false; 
        }
    }
}

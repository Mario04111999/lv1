using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class TimeNote : Biljeska
    {

        private DateTime date;

        public DateTime Date

        {
            get 
            {
                return this.date;
            }
            set
            { 
                this.date = value; 
            }
        }


        public TimeNote(String autor, String tekst, int vaznost) : base ( autor, tekst, vaznost)
        {
            Date = DateTime.Now;
        }

        
    
        public override string ToString()
        {
            return base.ToString() + date.ToShortDateString();
        }
    }
}

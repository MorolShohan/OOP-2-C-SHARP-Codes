using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Chef
    {
        public string chefname;
        public string chefnumber;
        private int item;

        public int Item
        {
            get { return item; }  
            set { item = value; }
        }
        
        
        public Chef()
        { }

        public Chef(string cname, string cnumber, int item)
        {
            this.chefname = cname;
            this.chefnumber = cnumber;
            this.item = item;
        }
        public void Makechicken()
        {
            Console.WriteLine("The chef makes chicken");

        }
        public void Makesalad()
        {
            Console.WriteLine("The chef makes salad");
        }
        public virtual void Makespecialdish()
        {
            Console.WriteLine("The chef makes bbq ribes");
        }
    }

}

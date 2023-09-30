using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flimfare
{
    class Movielist
    {
        public string name;
        public int budget;
        private string hero;

        public Movielist(string mname, int mbudget, string mhero)
        {
            name = mname;
            budget = mbudget;
            Hero = mhero;

        }

        public string Hero
        {
            get { return hero; }
            set
            {
                if (value == "RDJ" || value == "IRONMAN" || value == "TONY")
                {
                    hero = value;
                }
                else
                {
                    hero = "No one";
                }
            }
        }

    }

}




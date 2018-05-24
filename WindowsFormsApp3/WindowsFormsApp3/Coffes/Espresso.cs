using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.Coffes;

namespace WindowsFormsApp3.Coffes
{
    public class Espresso:Bevarage
    {
        public Espresso()
        {
            description = "Espresso ";
        }

        public override double price()
        {
            return 3.50;
        }
    }
}

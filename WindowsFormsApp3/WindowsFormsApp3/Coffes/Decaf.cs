using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.Coffes;

namespace WindowsFormsApp3.Coffes
{
    public class Decaf:Bevarage
    {
        public Decaf()
        {
            description = "Decaf ";
        }

        public override double price()
        {
            return 2.0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.Coffes;

namespace WindowsFormsApp3.Coffes
{
    public class Americano : Bevarage
    {
        public Americano()
        {
            description = "Americano ";
        }
        public override double price()
        {
            return 1.70;
        }
    }
}

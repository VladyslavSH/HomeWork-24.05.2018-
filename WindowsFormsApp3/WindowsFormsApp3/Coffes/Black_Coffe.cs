using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.Coffes;

namespace WindowsFormsApp3.Coffes
{
    public class Black_Coffe : Bevarage
    {
        public Black_Coffe()
        {
            description = "Black Coffe ";
        }
        public override double price()
        {
            return 1.0;
        }
    }
}

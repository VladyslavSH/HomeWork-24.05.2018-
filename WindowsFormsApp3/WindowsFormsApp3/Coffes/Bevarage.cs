using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.Coffes
{
    public abstract class Bevarage
    {
        public string description = "Unknown Bevarege";
        public abstract double price();
        public virtual string GetDescription()
        {
            return description;
        }
    }
}

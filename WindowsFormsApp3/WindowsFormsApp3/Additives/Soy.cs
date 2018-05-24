using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.Coffes;

namespace WindowsFormsApp3.Additives
{
    public class Soy : ConditionDecorator
    {
        public Soy(Bevarage bevarege) : base(bevarege)
        {
        }

        public override double price()
        {
            return .65 + bevarege.price();
        }
        public override string GetDescription()
        {
            return bevarege.GetDescription()+ "+ Soy ";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.Coffes;

namespace WindowsFormsApp3.Additives
{
    public class Milk : ConditionDecorator
    {
        public Milk(Bevarage bevarege) : base(bevarege)
        {
        }

        public override double price()
        {
            return .20 + bevarege.price();
        }
        public override string GetDescription()
        {
            return bevarege.GetDescription() + "+ Milk ";
        }
    }
}

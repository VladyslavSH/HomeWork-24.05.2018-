using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.Coffes;

namespace WindowsFormsApp3.Additives
{
    public class Mocha : ConditionDecorator
    {
        public Mocha(Bevarage bevarege) : base(bevarege) { }

        public override double price()
        {
            return .50 + bevarege.price();
        }
        public override string GetDescription()
        {
            return bevarege.GetDescription() + "+ Mocha ";
        }
    }
}

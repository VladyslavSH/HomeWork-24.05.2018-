using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.Coffes;

namespace WindowsFormsApp3.Additives
{
    public abstract class ConditionDecorator : Bevarage
    {
        protected Bevarage bevarege = null;
        public ConditionDecorator(Bevarage bevarege)
        {
            this.bevarege = bevarege;
        }
    }
}

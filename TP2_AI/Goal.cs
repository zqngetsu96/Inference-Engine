using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RT4_GRP1_TP1_AI
{
    class Goal : DataHolder
    {
        private bool demandable;
        public bool Demandable { get => demandable; set => demandable = value; }
        public Goal(string name, bool negated) : base(name, negated){}
    }
}

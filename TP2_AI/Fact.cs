using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RT4_GRP1_TP1_AI
{
    class Fact : DataHolder
    {
        private int _resultedFrom;
        public Fact(int resultedFrom, string name, bool negated) : base(name, negated)
        {
            resultedFrom = ResultedFrom;
        }

        public int ResultedFrom { get => _resultedFrom; set => _resultedFrom = value; }
    }
}

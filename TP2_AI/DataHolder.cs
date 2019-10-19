using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RT4_GRP1_TP1_AI
{
    class DataHolder
    {
        // A data holder can be either: fact, a rule's premise, conclusion or the goal.
        // the name && whether it's postive or negated [not operator]
        private string _name;
        private bool _negated;
        public string Name { get => _name; set => _name = value; }
        public bool Negated { get => _negated; set => _negated = value; }
        public DataHolder(string name, bool negated)
        {
            _name = name;
            _negated = negated;
        }
        public bool IsNegated()
        {
            return _negated;
        }
    }
}

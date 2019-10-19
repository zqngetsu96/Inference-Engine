using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RT4_GRP1_TP1_AI
{
    class Rule
    {
        private List<Premise> _premises = new List<Premise>();
        public List<Premise> GetPremises()
        {
            return _premises;
        }
        private List<Conclusion> _conclusion = new List<Conclusion>();
        public List<Conclusion> GetConclusion()
        {
            return _conclusion;
        }
        private int _number;
        public int Number { get => _number; set => _number = value; }
        private bool used = false;
        public bool Used { get => used; set => used = value; }

        
        public Rule(int number, string[] premises, string[] conclusion) //le numéro, les premises et conclusion sont lus du fichier BC.txt [1 ligne]
        {
            _number = number;
            bool neg;
            foreach (string premise in premises)
            {
                neg = false;
                if (premise.StartsWith("non ")) // on test si le premise est négatif
                {
                    neg = true;
                    _premises.Add(new Premise(premise.Substring(4), neg)); //on enleve le not et on le converte vers un boolean
                }
                else
                {
                    _premises.Add(new Premise(premise, neg));
                }   
            }
            foreach (string c in conclusion)
            {
                neg = false;
                if (c.StartsWith("non ")) // on test si la condition est négative
                {
                    neg = true;
                    _conclusion.Add(new Conclusion(c.Substring(4), neg));
                }
                else
                {
                    _conclusion.Add(new Conclusion(c, neg));
                }
            }
        }
        public bool Match(List<Premise> premises, List<Fact> facts)
        {
            // on verifie la presence de tout les premises dans la base des faits
            foreach (var premise in premises)
            {
                bool found = false;
                foreach (var fact in facts)
                {
                    if (fact.Name == premise.Name && fact.Negated == premise.Negated)
                    {
                        found = true;
                    }
                }
                if (!found)
                    return false;
            }
            return true;
        }
    }
}

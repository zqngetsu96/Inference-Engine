using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RT4_GRP1_TP1_AI
{
    class EnferenceEngine_ForwardChaining
    { 
        public List<Rule> Filtrage(List<Rule> rules, List<Fact> facts)
        {
            List<Rule> BRF = new List<Rule>();
            foreach (Rule rule in rules)
            {
                if (!rule.Used) // on verifie si la régle était utilsée.
                {
                    if (rule.Match(rule.GetPremises(), facts))
                    {
                        BRF.Add(rule);
                    }
                }
            }
            return BRF;
        }
        public bool SearchGoal(Goal goal, List<Fact> facts) // pour chercher but dans la base des faits
        {
            if (goal == null) return false;
            foreach (Fact f in facts)
            {
                if (f.Name == goal.Name && !f.Negated^goal.Negated) // ^ opérateur xor.
                {
                    return true;    //but trouvé
                }
            }
            return false; //on a parcouru la base des faits mais sans trouvé le but
        }
        public bool SearchError(Conclusion conclusion, List<Fact> facts)
        {
            foreach (Fact fact in facts) // validation du contraire
            {
                if (fact.Name == conclusion.Name && fact.Negated ^ conclusion.Negated) // !c existe dans la BF. ^ opérateur xor.
                {
                    return true; //il y'a une ambiguité entre la BF et la conclusion à ajouter
                }
            }
            return false; // il y'a pas d'erreur dans la BF
        }
        public string ForwardChainingWithConflict(TP2_AI.Form1 form,List<Rule> rules, List<Fact> facts, Goal goal, bool saturate, bool save_trace)
        {
            StreamWriter file = new StreamWriter(@"" + Path.GetDirectoryName(form.Bc_path) +"/TRACE.txt");
            file.AutoFlush = true;
            bool goal_reached=false; 
            bool error = false; //on suppose qu'il y aura pas d'erreur jusqu'à la présence du cas
            string result=String.Empty;
            List<Rule> BRF = new List<Rule>();
            while ((BRF=Filtrage(rules,facts)).Count != 0)
            {
                if (saturate) //chainage avant en largeur
                {
                    foreach (Rule rule in BRF)
                    {
                        List<Conclusion> c = rule.GetConclusion();
                        foreach (Conclusion c_ in c)
                        {
                            if (SearchError(c_, facts)) error = true;
                            if (error) goto error;
                            facts.Add(new Fact(rule.Number, c_.Name, c_.Negated));
                        }
                        rule.Used = true;
                        form.updateText("Rule: "+rule.Number+ " used");
                        if (save_trace) file.Write(rule.Number + " | ");
                    }
                    if (save_trace) file.WriteLine();
                    string f= null;
                    foreach (Fact fact in facts)
                    {
                        f += "[" + fact.Name + " Négation: " + fact.Negated + "] ";
                        if (save_trace) file.Write("[" + fact.Name + " Négation: " + fact.Negated + "] ");
                    }
                    form.updateText(f);
                    if (save_trace) file.WriteLine();
                }
                else // Chainage avant en profendeur avec conflit
                {
                    Rule rule = BRF.First<Rule>(); // choix règle FIFO
                    List<Conclusion> c = rule.GetConclusion(); // on extrait la conclusion de la régle
                    foreach (Conclusion c_ in c)
                    {
                        if (SearchError(c_, facts)) error = true;
                        if (error) goto error; // on specifie qu'il y'avait une erreur 
                        facts.Add(new Fact(rule.Number, c_.Name, c_.Negated));
                    }
                    form.updateText("Rule " + rule.Number + " used.");
                    if (save_trace) file.WriteLine("Rule used " + rule.Number);
                    string f = null;
                    foreach  (Fact fact in facts)
                    {
                        f += "[" + fact.Name + "  Négation: " + fact.Negated + "] ";
                        if (save_trace) file.Write("[" + fact.Name + " Négation: " + fact.Negated + "] ");
                    }
                    form.updateText(f);
                    if (save_trace) file.WriteLine();
                    rule.Used = true;
                    if (SearchGoal(goal, facts))
                    {
                        goal_reached = true;
                        goto foundgoal;
                    }
                }
            }
            if(saturate) // en cas de saturation on cherche la presence du but après avoir déduit tout les régles
            {
                goal_reached = SearchGoal(goal, facts);
            }
            foundgoal: //label
            error: //label
            file.Close();
            if (goal == null)
                return "Deduction des faits términée";
            if (goal_reached)
                result = "Le but est atteint dans la BF";
            else if (error)
                result = "Il y'avait une erreur [ambuguité dans les conclusion des régles et la BF]";
            else if (!goal_reached)
                result = "Le but n'est pas atteint";
            return result;
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RT4_GRP1_TP1_AI
{
    class EnferenceEngine_BackwardChaining
    {
        StreamWriter file;
        
        #region fonctions recherche et filtrage dans BF
        public bool SearchGoal(Goal goal, List<Fact> facts) // pour chercher but dans la base des faits
        {
            if (goal == null) return false;
            foreach (Fact f in facts)
            {
                if (f.Name == goal.Name && !f.Negated ^ goal.Negated) // ^ opérateur xor.
                {
                    return true;    //but trouvé
                }
            }
            return false; //on a parcouru la base des faits mais sans trouvé le but
        }
        //deducting rules
        
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
        #endregion
        
        public Tuple<bool, List<Rule>> DeductableGoal(TP2_AI.Form1 form, Goal goal, List<Fact> facts, List<Rule> rules, bool save_trace, StreamWriter file) //on retroune si on a des règles qui peuvent déduire le but et les règles
        {
            List<Rule> deductingRules = new List<Rule>();
         
            foreach (Rule r in rules)
            {
                foreach (Conclusion c in r.GetConclusion())
                {
                    if (goal.Name == c.Name && goal.Negated == c.Negated)
                    {
                        deductingRules.Add(r);
                    }
                }
            }
            form.updateText("Deducting rules : " + deductingRules.Count);
            if (save_trace) file.WriteLine("Deducting rules : " + deductingRules.Count);

            if (deductingRules.Count() != 0)
            { 
                deductingRules.OrderBy(o => o.GetPremises().Count);
                return Tuple.Create<bool, List<Rule>>(true, deductingRules);
            }
            else
            {
                return Tuple.Create<bool,List<Rule>>(false,null); // no rules && no list
            }
        }
        #region fonctions trace,askQuestion,Response
        public void AskQuestion(Goal goal)
        {

            // console shit;
        }
        public bool Response(Goal goal)
        {
            return true;
        }
        #endregion
        public bool Verif(TP2_AI.Form1 form, Rule rule, List<Fact> facts, List<Rule> rules, bool save_trace,StreamWriter file)
        {
            form.updateText("Verifying rule number " + rule.Number+"'s premises");
            if (save_trace) file.WriteLine("Verifying rule number " + rule.Number + "'s premises");
            bool ver = true;
            List<Premise> list = rule.GetPremises();
            for (int i = 0; i < list.Count && ver; i++)
            {
                Premise p = list[i];
                ver = Demo(form, new Goal(p.Name, p.Negated), facts, rules, save_trace, false);
            }
            return ver;
        }
        public void cleanList(List<Fact> dt)
        {
            for (int i = 0; (i < dt.Count-1 && dt[i]!=null); i++)
            {
                if (dt[i].Name == dt[i+1].Name)
                {
                    dt.RemoveAt(i);
                }
            }
        }
        public bool Demo(TP2_AI.Form1 form,Goal goal, List<Fact> facts, List<Rule> rules, bool save_trace,bool first_time)
        {
            if (first_time)
            {
                file = new StreamWriter(@"" + Path.GetDirectoryName(form.Bc_path) + "/TRACE.txt", !first_time);
                file.AutoFlush = true;
            }

            bool butDemontre = false;
            if (butDemontre = SearchGoal(goal, facts)) return butDemontre;
            else
            {
                Tuple<bool, List<Rule>> t = DeductableGoal(form,goal, facts, rules,save_trace,file);
                form.updateText("----------------------------------------");
                while (!butDemontre && t.Item1)
                {
                    foreach (Rule r in t.Item2)
                    {
                        butDemontre = Verif(form, r, facts, rules, save_trace,file);
                        if (butDemontre)
                        {
                            cleanList(facts); // on elimine les duplications: erreure due à la structure des données et la récursivité
                            if (save_trace) file.WriteLine("before adding a new fact");
                            form.updateText("before adding a new fact");
                            string fc = null;
                            foreach (Fact f in facts)
                            {
                                fc+=f.Name + "|" + f.Negated + "|| ";
                            }
                            form.updateText(fc);
                            if (save_trace) file.WriteLine(fc);

                            string cc = null;
                            foreach (Conclusion c in r.GetConclusion())
                            {
                                cc += "Added new fact: " + c.Name + " nagetion: " + c.Negated + Environment.NewLine;
                                facts.Add(new Fact(r.Number, c.Name, c.Negated));  
                            }
                            form.updateText(cc);
                            if (save_trace) file.WriteLine(cc);
                            form.updateText("new facts base");
                            if (save_trace) file.WriteLine("new facts base");

                            fc = null;
                            foreach (Fact f in facts)
                            {
                                fc += f.Name + "|" + f.Negated + "|| ";
                            }
                            form.updateText(fc);
                            if (save_trace) file.WriteLine(fc);
                            goto Flag2;
                        }
                    }
                    form.updateText("Reseting deducting rules List");
                    if (save_trace) file.WriteLine("Reseting deducting rules list");
                    
                    t = DeductableGoal(form,goal, facts, rules,save_trace,file);
                }
                if (!butDemontre & goal.Demandable == true)
                {
                    form.updateText("I asked you a question");
                    if (save_trace) file.WriteLine("Iasked you a question");
                    AskQuestion(goal);
                    butDemontre = Response(goal);
                }
            }
        Flag2:
            if (butDemontre) facts.Add(new Fact(0, goal.Name, goal.Negated));
            return butDemontre;
        }
    }
}

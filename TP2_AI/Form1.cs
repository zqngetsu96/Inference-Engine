using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RT4_GRP1_TP1_AI;
using MetroFramework.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace TP2_AI
{   
    public partial class Form1 : MetroForm
    {
        EnferenceEngine_ForwardChaining EnfEngine = new EnferenceEngine_ForwardChaining();
        EnferenceEngine_BackwardChaining EnfEngineBack = new EnferenceEngine_BackwardChaining();
        List<Rule> rules = new List<Rule>();
        Goal goal;
        List<Fact> facts = new List<Fact>();
        bool ForwardBackward = true; //if true then Forward if false then Backward
        bool save_trace = true;
        bool saturer = false;
        string bc_path = null;
        string bf_path = null;

        public string Bc_path { get => bc_path; set => bc_path = value; }
        public string Bf_path { get => bf_path; set => bf_path = value; }

        public Form1()
        {
            InitializeComponent();

        }
        public void updateText (string text)
        {
            this.TraceText.Text += text + Environment.NewLine;
        }
        private void Form1_Load(object sender, EventArgs e)
        { 
        }

        private void Chaining_Changed(object sender, EventArgs e)
        {
            if (ForwardChaining.Checked)
            {
                ForwardBackward = true;
                Saturate.Enabled = true;
            }
            else if (BackwardChaining.Checked)
            {
                ForwardBackward = false;
                Saturate.Enabled = false;
            }
        }


        private void TraceSave_Changed(object sender, EventArgs e)
        {
            if (YesTrace.Checked)
            {
                save_trace = true;
            }
            else if (NoTrace.Checked)
            {
                save_trace = false;
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (BcPath.Text.Length == 0 || BfPath.Text.Length ==0) goto nofile;

            this.TraceText.Text = "";
            this.TraceText.Text += "Trace d'inference:" + Environment.NewLine;
            this.TraceText.Text += "--------------------------------------------------------------" + Environment.NewLine;
            rules = new List<Rule>();
            facts = new List<Fact>();
            #region lecture des données à partir des fichiers
            string[] BC_rules = System.IO.File.ReadAllLines(@"" + bc_path);
            string BF_facts = System.IO.File.ReadAllLines(@"" + bf_path)[0]; // il y'aura qu'une seule ligne
            string given_goal = GoalTextBox.Text;
            int counter = 1;
            updateText("Liste des régles");
            foreach (string rule in BC_rules)
            {
                if (rule == String.Empty)
                    continue;
                Console.WriteLine(rule);
                //on divise la regle par "si" [on prend la partie à droite] puis on redivise la ligne par "et" puis on extrait la conclusion
                string[] first_last = Regex.Split(rule, "(si )")[2].Split('>'); //on sépare les premisses et les conclusions
                string[] premises = first_last[0].Split(',');
                string[] conclusion = first_last[1].Split(',');
                rules.Add(new Rule(counter, premises, conclusion)); // on crée l'objet regle
                counter++;
            }
            updateText("Lecture de la base des connaissances est faite");
            foreach (string fact in BF_facts.Split(','))
            {
                bool negated = false;
                if (fact.StartsWith("non "))
                {
                    negated = true;
                    facts.Add(new Fact(0, fact.Substring(4), negated)); //un fait connu est attribué un 0             
                }
                else
                {
                    facts.Add(new Fact(0, fact, negated));
                }
            }
            if (GoalTextBox.Text.Length != 0)
            {
                if(NonBut.Checked)
                {
                    goal = new Goal(GoalTextBox.Text, false);
                }else
                {
                    goal = new Goal(GoalTextBox.Text, true);
                }
                updateText("Goal set!!!"+goal.Name + " Negation: " + goal.Negated);
            }
            else
            {
                goal = null;
            }
            #endregion
            if (ForwardBackward)
            {
                string result = EnfEngine.ForwardChainingWithConflict(this, rules, facts, goal, Saturate.Checked, save_trace);
                updateText(result);
                if (save_trace)
                {
                    StreamWriter file = new StreamWriter(@"" + Path.GetDirectoryName(Bc_path) + "/TRACE.txt", true);
                    file.WriteLine(result);
                    file.Close();
                }
                
            }
            else
            {
                if (goal == null)
                {
                    updateText("Specify a goal!!");
                    goto done;
                }
                else
                {
                    bool result = EnfEngineBack.Demo(this, goal, facts, rules, save_trace, true);
                    if (result)
                    {
                        updateText("But atteint");
                    }
                    else
                    {
                        updateText("But non attient");
                    }
                }
            }
            goto done;
        
        nofile:
            updateText("No file specified");
        done:
            updateText("-");
        }

        private void BcBrowse_Click(object sender, EventArgs e)
        {
            BcDialog.ShowDialog();
        }

        private void BfBrowse_Click(object sender, EventArgs e)
        {
            BfDialog.ShowDialog();
        }

        private void BcFileChosen(object sender, CancelEventArgs e)
        {
            BcPath.Text += BcDialog.FileName;
            bc_path = BcDialog.FileName;
        }

        private void BfFileChosen(object sender, CancelEventArgs e)
        {
            BfPath.Text += BfDialog.FileName;
            bf_path = BfDialog.FileName;
        }

        private void Saturate_CheckedChanged(object sender, EventArgs e)
        {
            if (Saturate.Checked)
            {
                saturer = true;
            }
            else
            {
                saturer = false;
            }
        }
    }
}

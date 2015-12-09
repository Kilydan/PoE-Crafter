using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class PoeCrafter : Form
    {
        public PoeCrafter()
        {
            InitializeComponent();
        }

        private void loadItem_Click(object sender, EventArgs e)
        {
           

        }

        private void calculate_Click(object sender, EventArgs e)
        {

        }

        private void weaponCalculationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void calculatingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string IncPhysDmg = "";
            string AddPhysDmg = "";
            string BasePhysDmg = "";
            string IncAtckSpeed = "";
            string IncCritMulti = "";
            string IncCritChance = "";
            string IncGlblCritChance = "";
            string AddFireDmg = "";
            string AddColdDmg = "";
            string AddLightDmg = "";
            string Quality = "";
            string test1 = "";
            foreach (String Lijn in WepBox.Lines)
            {
                if (Lijn.Contains("increased Physical Damage"))
                {
                    IncPhysDmg = Lijn;
                    double IncPhysDmgResult = Filter(IncPhysDmg);

                }
                else if (Lijn.Contains("Physical Damage")&&(Lijn.Contains("Adds")))
                {
                    AddPhysDmg = Lijn;
                    double[] AddPhysDmgResult = AverageFilter(AddPhysDmg);
                }
                else if (Lijn.Contains("Physical Damage"))
                {
                    BasePhysDmg = Lijn;
                    double[] BasePhysDmgResult = AverageFilter(BasePhysDmg);
                }
                else if (Lijn.Contains("increased Attack Speed"))
                {
                    IncAtckSpeed = Lijn;
                    double IncAtckSpeedResult = Filter(IncAtckSpeed);
                }
                else if (Lijn.Contains("increased Global Critical Strike Multiplier"))
                {
                    IncCritMulti = Lijn;
                    double IncCritMultiResult = Filter(IncCritMulti);
                }
                else if (Lijn.Contains("increased Global Critical Strike Chance"))
                {
                    IncGlblCritChance = Lijn;
                    double IncGlblCritChanceResult = Filter(IncGlblCritChance);
                }
                else if (Lijn.Contains("increased Critical Strike Chance"))
                {
                    IncCritChance = Lijn;
                    double IncCritChanceResult = Filter(IncCritChance);
                }
                else if (Lijn.Contains("Fire Damage")&&(Lijn.Contains("Adds")))
                {
                    AddFireDmg = Lijn;
                    double[] AddFireDmgResult = AverageFilter(AddFireDmg);

                }
                else if (Lijn.Contains("Cold Damage") && (Lijn.Contains("Adds")))
                {
                    AddColdDmg = Lijn;
                    double[] AddColdDmgResult = AverageFilter(AddColdDmg);
                }
                else if (Lijn.Contains("Lightning Damage") && (Lijn.Contains("Adds")))
                {
                    AddLightDmg = Lijn;
                    double[] AddLightDmgResult = AverageFilter(AddLightDmg);
                }
                else if (Lijn.Contains("Quality"))
                {
                    Quality = Lijn;
                }
            }
        }
        private static double Filter(string Sentence)
        {
            Sentence = Regex.Match(Sentence, @"\d+").Value;
            int Number = int.Parse(Sentence);
            double Answer = (double)Number / 100.0 + 1;
            return Answer;
        }
        private static double[] AverageFilter(string Sentence)
        {
            string[] Splitser = Sentence.Split('-');
            string Gesplits1 = Regex.Match(Splitser[0], @"\d+").Value;
            string Gesplits2 = Regex.Match(Splitser[1], @"\d+").Value;
            double Number1 = double.Parse(Gesplits1);
            double Number2 = double.Parse(Gesplits2);
            double Gemiddelde = (Number1 + Number2) / 2;
            double[] ReturnArray = { Number1,Gemiddelde,Number2 };
            return ReturnArray;
        }

             
    }

}

// Rarity: Rare
//Dire Edge
//Ambusher
//--------
//Dagger
//Quality: +20% (augmented)
//Physical Damage: 50-141 (augmented)
//Elemental Damage: 19-40 (augmented)
//Critical Strike Chance: 8.35% (augmented)
//Attacks per Second: 1.81 (augmented)
//--------
//Requirements:
//Level: 63
//Dex: 113
//Int: 113
//--------
//Sockets: G-G-B 
//--------
//Itemlevel: 61
//--------
//40% increased Global Critical Strike Chance
//--------
//37% increased Physical Damage
//Adds 16-27 Physical Damage
//Adds 19-40 Lightning Damage
//13% increased Attack Speed
//18% increased Global Critical Strike Multiplier
//25% increased Critical Strike Chance


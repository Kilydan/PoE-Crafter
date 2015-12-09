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
        private string[] comboBox1Range = new[] { "Axe, One-Handed", "Axe, Two-Handed", "Bow", "Claw", "Dagger", "Mace, One Handed", "Mace, Two Handed", "Mace, Sceptre", "Staff", "Sword, One-Handed", "Sword, Two-Handed", "Sword, Thrusting", "wand"};
        private string[] comboBox2RangeA = new[] { "Karui Axe", "Siege Axe", "Reaver Axe", "Butcher Axe", "Vaal Hatchet", "Royal Axe", "Infernal Axe" };
        private string[] comboBox2RangeB = new[] { "Karui Chopper", "Sundering Axe", "Ezomyte Axe", "Vaal Axe", "Despot Axe", "Void Axe" };
        private string[] comboBox2RangeC = new[] { "Thicket Bow", "Citadel Bow", "Ranger Bow", "Maraketh Bow", "Spine Bow", "Imperial Bow", "Harbinger Bow" };
        private string[] comboBox2RangeD = new[] { "Great White Claw", "Throat Stabber", "Hellion's Paw", "Eye Gouger", "Vaal Claw", "Imperial Claw", "Terror Claw" };
        private string[] comboBox2RangeE = new[] { "Gutting Knife", "Slaughter Knife", "Ambusher", "Ezomyte Dagger", "Platinum Kris", "Imperial Skean", "Demon Dagger" };
        private string[] comboBox2RangeF = new[] { "Ancestral Club", "Tenderizer", "Gavel", "Legion Hammer", "Pernarch", "Auric Mace", "Nightmare Mace"};
        private string[] comboBox2RangeG = new[] { "Karui Maul", "Colossus Mallet", "Piledriver", "Meatgrinder", "Imperial Maul", "Terror Maul" };
        private string[] comboBox2RangeH = new[] { "Karui Sceptre", "Tyrant's Sekhem", "Opal Sceptre", "Platinum Sceptre", "Carnal Sceptre", "Vaal Sceptre", "Void Sceptre" };
        private string[] comboBox2RangeI = new[] { "Primordial Staff", "Lathi", "Ezomyte Staff", "Maelström Staff", "Imperial Staff", "Judgement Staff" };
        private string[] comboBox2RangeJ = new[] { "Gemstone Sword", "Corsair Sword", "Gladius", "Legion Sword", "Vaal Blade", "Eternal Sword", "Midnight Blade" };
        private string[] comboBox2RangeK = new[] { "Headman's Sword", "Reaver Sword", "Ezomyte Blade", "Vaal Greatsword", "Lion Sword", "Infernal Sword" };
        private string[] comboBox2RangeL = new[] { "Dragonbone Rapier", "Tempered Foil", "Pecoraro", "Spiraled Foil", "Vaal Rapier", "Jewelled Foil", "Harpy Rapier" };
        private string[] comboBox2RangeM = new[] { "Demon's Horn", "Imbued Wand", "Opal Wand", "Tornado Wand", "Prophecy Wand" };
        public PoeCrafter()
        {
            InitializeComponent();
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.Items.AddRange(comboBox1Range);
        }

        private void calculatingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string IncPhysDmg = "";
            double IncPhysDmgResult = 0;
            string AddPhysDmg = "";
            double[] AddPhysDmgResult = new double[3];
            string BasePhysDmg = "";
            double[] BasePhysDmgResult = new double[3];
            string IncAtckSpeed = "";
            double IncAtckSpeedResult = 0;
            string TotalAtckSpeed = "";
            double TotalAtckSpeedResult = 0;
            string IncCritMulti = "";
            double IncCritMultiResult = 0;
            string IncCritChance = "";
            double IncCritChanceResult = 0;
            string IncGlblCritChance = "";
            double IncGlblCritChanceResult = 0;
            string AddFireDmg = "";
            double[] AddFireDmgResult = new double[3];
            string AddColdDmg = "";
            double[] AddColdDmgResult = new double[3];
            string AddLightDmg = "";
            double[] AddLightDmgResult = new double[3];
            string Quality = "";

            if (WepBox.Text == "")
            {

            }

            foreach (String Lijn in WepBox.Lines)
            {
                if (Lijn.Contains("increased Physical Damage"))
                {
                    IncPhysDmg = Lijn;
                    IncPhysDmgResult = Filter(IncPhysDmg);
                }
                else if (Lijn.Contains("Physical Damage")&&(Lijn.Contains("Adds")))
                {
                    AddPhysDmg = Lijn;
                    AddPhysDmgResult = AverageFilter(AddPhysDmg);
                }
                else if (Lijn.Contains("Physical Damage"))
                {
                    BasePhysDmg = Lijn;
                    BasePhysDmgResult = AverageFilter(BasePhysDmg);
                }
                else if (Lijn.Contains("increased Attack Speed"))
                {
                    IncAtckSpeed = Lijn;
                    IncAtckSpeedResult = Filter(IncAtckSpeed);
                }
                else if (Lijn.Contains("Attacks per Second"))
                {
                    TotalAtckSpeed = Lijn;
                    TotalAtckSpeed = TotalAtckSpeed.Split(' ')[3];
                    TotalAtckSpeedResult = Convert.ToDouble(TotalAtckSpeed);
                }
                else if (Lijn.Contains("increased Global Critical Strike Multiplier"))
                {
                    IncCritMulti = Lijn;
                    IncCritMultiResult = Filter(IncCritMulti);
                }
                else if (Lijn.Contains("increased Global Critical Strike Chance"))
                {
                    IncGlblCritChance = Lijn;
                    IncGlblCritChanceResult = Filter(IncGlblCritChance);
                }
                else if (Lijn.Contains("increased Critical Strike Chance"))
                {
                    IncCritChance = Lijn;
                    IncCritChanceResult = Filter(IncCritChance);
                }
                else if (Lijn.Contains("Fire Damage")&&(Lijn.Contains("Adds")))
                {
                    AddFireDmg = Lijn;
                    AddFireDmgResult = AverageFilter(AddFireDmg);

                }
                else if (Lijn.Contains("Cold Damage") && (Lijn.Contains("Adds")))
                {
                    AddColdDmg = Lijn;
                    AddColdDmgResult = AverageFilter(AddColdDmg);
                }
                else if (Lijn.Contains("Lightning Damage") && (Lijn.Contains("Adds")))
                {
                    AddLightDmg = Lijn;
                    AddLightDmgResult = AverageFilter(AddLightDmg);
                }
                else if (Lijn.Contains("Quality"))
                {
                    Quality = Lijn;
                }
            }
            double Pdps = BasePhysDmgResult[1] * TotalAtckSpeedResult;
            double Edps = (AddLightDmgResult[1] + AddFireDmgResult[1] + AddColdDmgResult[1]) * TotalAtckSpeedResult;
            double TotalDps = Pdps + Edps;

            WepBoxCalc.Text = Convert.ToString("Physical Dps: " + Pdps + Environment.NewLine + "Elemental Dps: " + Edps + Environment.NewLine + "Total Dps: " + TotalDps);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBox1.SelectedItem as string;

            switch (selectedValue)
            {
                case "Axe, One-Handed":
                    comboBox2.Items.Clear();
                    comboBox2.Items.AddRange(comboBox2RangeA);
                    break;
                case "Axe, Two-Handed":
                    comboBox2.Items.Clear();
                    comboBox2.Items.AddRange(comboBox2RangeB);
                    break;
                case "Bow":
                    comboBox2.Items.Clear();
                    comboBox2.Items.AddRange(comboBox2RangeC);
                    break;
                case "Claw":
                    comboBox2.Items.Clear();
                    comboBox2.Items.AddRange(comboBox2RangeD);
                    break;
                case "Dagger":
                    comboBox2.Items.Clear();
                    comboBox2.Items.AddRange(comboBox2RangeE);
                    break;
                case "Mace, One Handed":
                    comboBox2.Items.Clear();
                    comboBox2.Items.AddRange(comboBox2RangeF);
                    break;
                case "Mace, Two Handed":
                    comboBox2.Items.Clear();
                    comboBox2.Items.AddRange(comboBox2RangeG);
                    break;
                case "Mace, Sceptre":
                    comboBox2.Items.Clear();
                    comboBox2.Items.AddRange(comboBox2RangeH);
                    break;
                case "Staff":
                    comboBox2.Items.Clear();
                    comboBox2.Items.AddRange(comboBox2RangeI);
                    break;
                case "Sword, One-Handed":
                    comboBox2.Items.Clear();
                    comboBox2.Items.AddRange(comboBox2RangeJ);
                    break;
                case "Sword, Two-Handed":
                    comboBox2.Items.Clear();
                    comboBox2.Items.AddRange(comboBox2RangeK);
                    break;
                case "Sword, Thrusting":
                    comboBox2.Items.Clear();
                    comboBox2.Items.AddRange(comboBox2RangeL);
                    break;
                case "Wand":
                    comboBox2.Items.Clear();
                    comboBox2.Items.AddRange(comboBox2RangeM);
                    break;
                    
            }

        }

        private void WepBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            WepBox.Text = "";
            WepBoxCalc.Text = "Physical Dps: 0,0" + Environment.NewLine + "Elemental Dps: 0,0" + Environment.NewLine + "Total Dps: 0,0";
        }

        private void WepBoxCalc_TextChanged(object sender, EventArgs e)
        {
            //WepBoxCalc.ReadOnly = true;
            //WepBoxCalc.BackColor = System.Drawing.SystemColors.Window;
        }

        private void axeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void WepBoxCalc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }

}

//Rarity: Rare
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


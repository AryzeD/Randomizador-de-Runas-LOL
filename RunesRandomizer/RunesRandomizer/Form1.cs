using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RunesRandomizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random pick = new Random(); 
        string[] Paths = new string[] { "Precision", "Domination", "Sorcery", "Resolve", "Inspiration" };
        string[] Precision = new string[] { "Press The Attack", "Lethal Tempo", "Fleet Footwork", "Conqueror" };
        string[] PSlot1 = new string[] { "Overheal", "Triumph", "Presence of Mind" };
        string[] PSlot2 = new string[] { "Legend:Alacrity", "Legend:Tenacity", "Legend:Bloodline" };
        string[] PSlot3 = new string[] { "Coup de Grace", "Cut Down", "Last Stand" };
        string[] Domination = new string[] { "Electrocute", "Predator", "Dark Havest", "Hail of Blades" };
        string[] DSlot1 = new string[] { "Cheap Shot", "Taste of Blood", "Sudden Impact" };
        string[] DSlot2 = new string[] { "Zombie Ward", "Ghost Poro", "Eyeball Collection" };
        string[] DSlot3 = new string[] { "Treasure Hunter", "Ingenious Hunter", "Relentless Hunter", "Ultimate Hunter" };
        string[] Sorcery = new string[] { "Summon Aery", "Arcane Comet", "Phase Rush" };
        string[] SSlot1 = new string[] { "Nullifying Orb", "Manaflow Band", "Nimbus Cloak" };
        string[] SSlot2 = new string[] { "Transcendence", "Celerity", "Absolute Focus" };
        string[] SSlot3 = new string[] { "Scorch", "Waterwalking", "Gathering Storm" };
        string[] Resolve = new string[] { "Grasp of the Undying", "Aftershock", "Guardian" };
        string[] RSlot1 = new string[] { "Demolish", "Font of Life", "Shield Bash" };
        string[] RSlot2 = new string[] { "Conditioning", "Second Wind", "Bone Plating" };
        string[] RSlot3 = new string[] { "Unflinching", "Revitalize", "Overgrowth" };
        string[] Inspiration = new string[] { "Glacial Augment", "Unsealed Speelbook", "First Strike" };
        string[] ISlot1 = new string[] { "Hextech Flashtraption", "Magical Footwear", "Perfect Timing" };
        string[] ISlot2 = new string[] { "Bisuct Delivery", "Minion Demateralizer", "Future's Market" };
        string[] ISlot3 = new string[] { "Time Warp Tonic", "Approach Velocity", "Cosmic Insight" };

        private void btnRandom_Click(object sender, EventArgs e)
        {

            lblPath.Text = Paths[pick.Next(0, 4)];
            switch (lblPath.Text) {
                case "Precision":
                    lblKeystone.Text = Precision[pick.Next(0, 3)];
                    lblSlot1.Text = PSlot1[pick.Next(0, 2)];
                    lblSlot2.Text = PSlot2[pick.Next(0, 2)];
                    lblSlot3.Text = PSlot3[pick.Next(0, 2)];
                    this.BackgroundImage = Properties.Resources.Precisão;
                    break;
                case "Domination":
                    lblKeystone.Text = Domination[pick.Next(0, 3)];
                    lblSlot1.Text =  DSlot1[pick.Next(0, 2)];
                    lblSlot2.Text = DSlot2[pick.Next(0, 2)];
                    lblSlot3.Text = DSlot3[pick.Next(0, 3)];
                    this.BackgroundImage = Properties.Resources.Dominação;
                    break;
                case "Sorcery":
                    lblKeystone.Text = Sorcery[pick.Next(0, 2)];
                    lblSlot1.Text = SSlot1[pick.Next(0, 2)];
                    lblSlot2.Text = SSlot2[pick.Next(0, 2)];
                    lblSlot3.Text = SSlot3[pick.Next(0, 2)];
                    this.BackgroundImage = Properties.Resources.Feitiçaria;
                    break;
                case "Resolve":
                    lblKeystone.Text = Resolve[pick.Next(0, 2)];
                    lblSlot1.Text = RSlot1[pick.Next(0, 2)];
                    lblSlot2.Text = RSlot2[pick.Next(0, 2)];
                    lblSlot3.Text = RSlot3[pick.Next(0, 2)];
                    this.BackgroundImage = Properties.Resources.Resolve;
                    break;
                case "Inspiration":
                    lblKeystone.Text = Inspiration[pick.Next(0, 2)];
                    lblSlot1.Text = ISlot1[pick.Next(0, 2)];
                    lblSlot2.Text = ISlot2[pick.Next(0, 2)];
                    lblSlot3.Text = ISlot3[pick.Next(0, 2)];
                    this.BackgroundImage = Properties.Resources.Inspiração;
                    break;
            }
        }
    }
}
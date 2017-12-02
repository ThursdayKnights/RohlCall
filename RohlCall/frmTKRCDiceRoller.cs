using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RohlCall
{
    public partial class frmTKRCDiceRoller : Form
    {
        public frmTKRCDiceRoller()
        {
            InitializeComponent();
        }

        /*
         * Author: Peter Adam 
         * Date: Dec 1, 2017
         * This program simulates dice rolls of various sizes and quantities
         * It displays individual results as well as a log of all rolls made
         * The user may save frequently used dice rolls for quick access
         */

        private string DRDiceRoll(decimal numDice, decimal numSides, decimal modifier)
        {
            Random rand = new Random();
            int sides = (int)numSides, sum = 0;
            string logResults = "\r\n(", logModifier = "", rollName;
            for (int i = (int)numDice; i > 0; i--)
            {
                int roll = rand.Next(1, (int)numSides + 1);
                sum += roll;
                if (i == 1) //last entry
                {
                    if (modifier >= 0)  //positive modifier
                    {
                        logModifier = " + " + modifier;
                    }
                    else    //negative modifier
                    {
                        logModifier = " - " + modifier;
                    }
                    logResults += roll + ")" + logModifier;
                }
                else
                {
                    logResults += roll + ", ";
                }
            }
            sum += (int)modifier;
            rollName = " = " + numDice + "d" + numSides + logModifier;
            logResults =  sum + rollName + logResults + "\r\n\r\n";
            txtLog.Text = logResults + txtLog.Text;
            return sum.ToString();
        }

        private void btnRollD4_Click(object sender, EventArgs e)
        {
            //Call DiceRoll as a D4
            lblD4Sum.Text = DRDiceRoll(nudD4.Value, 4, nudD4Mod.Value);
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            //Clear Log
            txtLog.Text = "";
        }

        private void btnRollD6_Click(object sender, EventArgs e)
        {
            //Call DiceRoll as a D6
            lblD6Sum.Text = DRDiceRoll(nudD6.Value, 6, nudD6Mod.Value);
        }

        private void btnRollD8_Click(object sender, EventArgs e)
        {
            //Call DiceRoll as a D8
            lblD8Sum.Text = DRDiceRoll(nudD8.Value, 8, nudD8Mod.Value);
        }

        private void btnRollD10_Click(object sender, EventArgs e)
        {
            //Call DiceRoll as a D10
            lblD10Sum.Text = DRDiceRoll(nudD10.Value, 10, nudD10Mod.Value);
        }

        private void btnRollD12_Click(object sender, EventArgs e)
        {
            //Call DiceRoll as a D12
            lblD12Sum.Text = DRDiceRoll(nudD12.Value, 12, nudD12Mod.Value);
        }

        private void btnRollD20_Click(object sender, EventArgs e)
        {
            //Call DiceRoll as a D20
            lblD20Sum.Text = DRDiceRoll(nudD20.Value, 20, nudD20Mod.Value);
        }

        private void btnRollD100_Click(object sender, EventArgs e)
        {
            //Call DiceRoll as a D100
            lblD100Sum.Text = DRDiceRoll(nudD100.Value, 100, nudD100Mod.Value);
        }

        private void btnRollCustom1_Click(object sender, EventArgs e)
        {
            //Call DiceRoll with custom input
            lblCustomSum1.Text = DRDiceRoll(nudCustom1.Value, nudDX1.Value, nudDXMod1.Value);
        }

        private void btnRollCustom2_Click(object sender, EventArgs e)
        {
            //Call DiceRoll with custom input
            lblCustomSum2.Text = DRDiceRoll(nudCustom2.Value, nudDX2.Value, nudDXMod2.Value);
        }

        private void btnRollCustom3_Click(object sender, EventArgs e)
        {
            //Call DiceRoll with custom input
            lblCustomSum3.Text = DRDiceRoll(nudCustom3.Value, nudDX3.Value, nudDXMod3.Value);
        }
    }
}

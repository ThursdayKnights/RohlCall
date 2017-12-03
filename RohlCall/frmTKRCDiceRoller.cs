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

        //2d array contains information for custom dice rolls
        //0 - Name of roll
        //1 - number of dice to roll
        //2 - number of sides on die
        //3 - modifer to add to total result
        string[,] customDice = new string[99,4];

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
            string entry = cboCustom1.Text;
            lblCustomSum1.Text = DRDiceRoll(nudCustom1.Value, nudDX1.Value, nudDXMod1.Value);
          
            if (chkSave1.Checked)
            {
                if (!cboCustom1.Items.Contains(entry))
                {
                    cboCustom1.Items.Add(entry);
                    cboCustom2.Items.Add(entry);
                    cboCustom3.Items.Add(entry);
                }
                
                chkSave1.Checked = false;
                int index = cboCustom1.Items.IndexOf(entry);
                if (index <= 98)
                {
                    customDice[index, 0] = entry;
                    customDice[index, 1] = nudCustom1.Value.ToString();
                    customDice[index, 2] = nudDX1.Value.ToString();
                    customDice[index, 3] = nudDXMod1.Value.ToString();
                }
            }
        }

        private void btnRollCustom2_Click(object sender, EventArgs e)
        {
            
            string entry = cboCustom2.Text;
            //Call DiceRoll with custom input
            lblCustomSum2.Text = DRDiceRoll(nudCustom2.Value, nudDX2.Value, nudDXMod2.Value);
            if (chkSave2.Checked)   //user wishes to save an entry
            {
                if (!cboCustom2.Items.Contains(entry))  //New entry
                {
                    cboCustom1.Items.Add(entry);
                    cboCustom2.Items.Add(entry);
                    cboCustom3.Items.Add(entry);
                }
                //toggle chkSave
                chkSave2.Checked = false;
                //add custom roll information to array
                int index = cboCustom2.Items.IndexOf(entry);
                if (index <= 98)
                {
                    customDice[index, 0] = entry;
                    customDice[index, 1] = nudCustom2.Value.ToString();
                    customDice[index, 2] = nudDX2.Value.ToString();
                    customDice[index, 3] = nudDXMod2.Value.ToString();
                }
            }
        }

        private void btnRollCustom3_Click(object sender, EventArgs e)
        {
            //Call DiceRoll with custom input
            string entry = cboCustom3.Text;
            lblCustomSum3.Text = DRDiceRoll(nudCustom3.Value, nudDX3.Value, nudDXMod3.Value);
            if (chkSave3.Checked)
            {
                if (!cboCustom3.Items.Contains(entry))
                {
                    cboCustom1.Items.Add(entry);
                    cboCustom2.Items.Add(entry);
                    cboCustom3.Items.Add(entry);
                }

                chkSave3.Checked = false;
                int index = cboCustom1.Items.IndexOf(entry);
                if (index <= 98)
                {
                    customDice[index, 0] = entry;
                    customDice[index, 1] = nudCustom3.Value.ToString();
                    customDice[index, 2] = nudDX3.Value.ToString();
                    customDice[index, 3] = nudDXMod3.Value.ToString();
                }
            }
        }

        private void EnableSave1()
        {
            //Enable save button
            if (cboCustom1.Text != "")
            {
                chkSave1.Enabled = true;
            }
            else
            {
                chkSave1.Enabled = false;
            }
        }

        private void EnableSave2()
        {
            //Enable save button
            if (cboCustom2.Text != "")
            {
                chkSave2.Enabled = true;
            }
            else
            {
                chkSave2.Enabled = false;
            }
        }

        private void EnableSave3()
        {
            //Enable save button
            if (cboCustom3.Text != "")
            {
                chkSave3.Enabled = true;
            }
            else
            {
                chkSave3.Enabled = false;
            }
        }

        private void cboCustom1_TextChanged(object sender, EventArgs e)
        {
            EnableSave1();
        }

        private void cboCustom1_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableSave1();
            int index = cboCustom1.SelectedIndex;
            if (index >= 0 && index <= 98)
            {
                nudCustom1.Value = Convert.ToDecimal(customDice[index, 1]);
                nudDX1.Value = Convert.ToDecimal(customDice[index, 2]);
                nudDXMod1.Value = Convert.ToDecimal(customDice[index, 3]);
            }
            
        }

        private void cboCustom2_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableSave2();
            int index = cboCustom2.SelectedIndex;
            if (index >= 0 && index <= 98)
            {
                nudCustom2.Value = Convert.ToDecimal(customDice[index, 1]);
                nudDX2.Value = Convert.ToDecimal(customDice[index, 2]);
                nudDXMod2.Value = Convert.ToDecimal(customDice[index, 3]);
            }
        }

        private void cboCustom2_TextChanged(object sender, EventArgs e)
        {
            EnableSave2();
        }

        private void cboCustom3_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableSave3();
            int index = cboCustom3.SelectedIndex;
            if (index >= 0 && index <= 98)
            {
                nudCustom3.Value = Convert.ToDecimal(customDice[index, 1]);
                nudDX3.Value = Convert.ToDecimal(customDice[index, 2]);
                nudDXMod3.Value = Convert.ToDecimal(customDice[index, 3]);
            }
        }

        private void cboCustom3_TextChanged(object sender, EventArgs e)
        {
            EnableSave3();
        }
    }
}

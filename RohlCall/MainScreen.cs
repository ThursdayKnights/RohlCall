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
    public partial class frmMainScreen : Form
    {
        public frmMainScreen()
        {
            InitializeComponent();
        }

        TKRCDiceRollers DiceRoll = new TKRCDiceRollers();

        private void rohlCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 frm = new AboutBox1();
            frm.Show();
            
        }

        //Debug button, necessary for beta.
        private void debugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DiceRoll.DiceRoll(3,12), "test");
        }

        
    }
}

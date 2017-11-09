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
            //Open About Box
            AboutBox1 frm = new AboutBox1();
            frm.Show();
            
        }

        //Debug button, necessary for beta.
        private void debugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DiceRoll.DiceRoll(3,12), "test");
        }

        private void btnInitTrack_Click(object sender, EventArgs e)
        {
            //Open Initiative Tracker
            frmInitTrack frm = new RohlCall.frmInitTrack();
            frm.Show();
        }

        private void btnCharSheet_Click(object sender, EventArgs e)
        {
            //Open Character Sheet
            frmTKRCCharacterSheet frm = new frmTKRCCharacterSheet();
            frm.Show();
        }
    }
}

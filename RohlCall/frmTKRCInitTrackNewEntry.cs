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
    public partial class frmTKRCInitTrackNewEntry : Form
    {
        public frmTKRCInitTrackNewEntry(bool isFormShown)
        {
            InitializeComponent();
        }

        public static bool isValid;
        frmTKRCInitTrack frmInitTrack = new frmTKRCInitTrack(isValid);
        
        public void btnCancel_Click(object sender, EventArgs e)
        {
            //Close form without saving changes
            Close();
            
        }

        private void frmTKRCInitTrackNewEntry_FormClosing(object sender, FormClosingEventArgs e)
        {
            //call ToggleNewEntry to allow the form to be opened again
            frmInitTrack.ToggleNewEntry();
        }
    }
}

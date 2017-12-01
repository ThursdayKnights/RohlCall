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
        public frmTKRCInitTrackNewEntry(bool isFormShown, string[] savedEntries, object listedEntries)
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
            frmTKRCInitTrack.savedEntries = new string[cboEntry.Items.Count];
            int i = 0;
            foreach (string item in cboEntry.Items)
            {
                frmTKRCInitTrack.savedEntries[i] = item;
                i++;
            }

        }

        private void btnAddEntry_Click(object sender, EventArgs e)
        {
            //Adds entry to InitTrack listbox
            string name = cboEntry.Text;
            int init;
            if (!int.TryParse(txtInit.Text, out init))  //Invalid input
            {
                MessageBox.Show("Please enter a valid number", "Missing Input");
                txtInit.Focus();
            }
            else
            {
                if (chkSave.Checked
                    && !cboEntry.Items.Contains(cboEntry.Text))
                    {
                        cboEntry.Items.Add(cboEntry.Text);
                    }
                frmTKRCInitTrack.listedEntries.Add(name);
                this.Close();
            }
            
        }

        private void frmTKRCInitTrackNewEntry_Load(object sender, EventArgs e)
        {
            //populate drop-down with saved entries
            foreach (string item in frmTKRCInitTrack.savedEntries)
            {
                cboEntry.Items.Add(item);
                
            }
        }
    }
}

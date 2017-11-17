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
    public partial class frmInitTrack : Form
    {
        /********************************************************************
         *  Initiative Tracker                                              *
         *  Nov 8, 2017                                                     *
         *  Thursday Knights                                                *
         *  Authors: Peter Adam                                             *
         *                                                                  *
         *  This application keeps track of player turn order. The user     *
         *  may add creatures to the table, assign them a score, and        *
         *  have the list be automatically sorted. They may also keep       *
         *  track of ongoing effects                                        *
         *                                                                  *
         *******************************************************************/


        public frmInitTrack()
        {
            InitializeComponent();
        }

        InitTrackPA PA = new InitTrackPA();

        private void btnNextTurn_Click(object sender, EventArgs e)
        {
            /*
             * 
             *  REPLACE ME WITH A "SELECT ALL" BUTTON
             * 
             */

            //select all items. If all items are selected, deselect instead
            bool areAllSelected = false;

            for (int i = 0; i < lstEntries.Items.Count; i++)
            {
                if (!lstEntries.GetItemChecked(i))
                {
                    areAllSelected = true;
                    break;
                }
            }

            for (int i = 0; i < lstEntries.Items.Count; i++)
            {
                lstEntries.SetItemChecked(i, areAllSelected);
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clears score of selected entry
            foreach (object selected in lstEntries.CheckedItems.OfType<string>().ToList())
            {
                lstEntries.Items.Add("");
                lstEntries.Items.Remove(selected);
                
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //Remove all selected
            foreach (object selected in lstEntries.CheckedItems.OfType<string>().ToList())
            {
                lstEntries.Items.Remove(selected);
            }
        }

        private void btnNewEntry_Click(object sender, EventArgs e)
        {

        }
    }

}

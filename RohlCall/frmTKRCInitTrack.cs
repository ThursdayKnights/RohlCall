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
    public partial class frmTKRCInitTrack : Form
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


        public frmTKRCInitTrack(bool isInitTrackOpen)
        {
            InitializeComponent();
        }

        
        public static bool isNewEntryShown = false;         //tracks if frmInitTrackNewEntry is open
        public static string[] savedEntries = new string[] {"Hazard", "Monster", "NPC"};
        public static List<string> listedEntries = new List<string>();

        //declare classes to be used
        InitTrackPA PA = new InitTrackPA();
        frmMainScreen MainScreen = new frmMainScreen();
        

        public void ToggleNewEntry()
        {
            //change isNewEntryShown to opposite value
            isNewEntryShown = !isNewEntryShown;
            if (!isNewEntryShown)
            {
                lstEntries.Items.Add(listedEntries[listedEntries.Count - 1]);
            }
        }

        private void btnNextTurn_Click(object sender, EventArgs e)
        {
            

          


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
            //show New Entry Dialogue
            if (!isNewEntryShown)
            {
                frmTKRCInitTrackNewEntry frmNewEntry = new frmTKRCInitTrackNewEntry(isNewEntryShown, savedEntries, listedEntries);
                frmNewEntry.ShowDialog();
                ToggleNewEntry();       //Declares frmInitTrackNewEntry is open
            }
            
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
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

        private void frmTKRCInitTrack_FormClosing(object sender, FormClosingEventArgs e)
        {
            //allow form to be opened again after closing
            MainScreen.ToggleInitTrack();
        }

        private void frmTKRCInitTrack_Load(object sender, EventArgs e)
        {

        }
    }

}

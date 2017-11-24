namespace RohlCall
{
    partial class frmTKRCInitTrackNewEntry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboEntry = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkSave = new System.Windows.Forms.CheckBox();
            this.btnAddEntry = new System.Windows.Forms.Button();
            this.btnAddMore = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cboEntry
            // 
            this.cboEntry.FormattingEnabled = true;
            this.cboEntry.Location = new System.Drawing.Point(56, 16);
            this.cboEntry.Name = "cboEntry";
            this.cboEntry.Size = new System.Drawing.Size(121, 21);
            this.cboEntry.Sorted = true;
            this.cboEntry.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // chkSave
            // 
            this.chkSave.AutoSize = true;
            this.chkSave.Location = new System.Drawing.Point(197, 20);
            this.chkSave.Name = "chkSave";
            this.chkSave.Size = new System.Drawing.Size(51, 17);
            this.chkSave.TabIndex = 1;
            this.chkSave.Text = "Save";
            this.chkSave.UseVisualStyleBackColor = true;
            // 
            // btnAddEntry
            // 
            this.btnAddEntry.Location = new System.Drawing.Point(13, 84);
            this.btnAddEntry.Name = "btnAddEntry";
            this.btnAddEntry.Size = new System.Drawing.Size(75, 23);
            this.btnAddEntry.TabIndex = 3;
            this.btnAddEntry.Text = "Add Entry";
            this.btnAddEntry.UseVisualStyleBackColor = true;
            this.btnAddEntry.Click += new System.EventHandler(this.btnAddEntry_Click);
            // 
            // btnAddMore
            // 
            this.btnAddMore.Location = new System.Drawing.Point(105, 83);
            this.btnAddMore.Name = "btnAddMore";
            this.btnAddMore.Size = new System.Drawing.Size(75, 23);
            this.btnAddMore.TabIndex = 4;
            this.btnAddMore.Text = "Add More";
            this.btnAddMore.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(197, 83);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Initiative:";
            // 
            // txtInit
            // 
            this.txtInit.Location = new System.Drawing.Point(77, 50);
            this.txtInit.Name = "txtInit";
            this.txtInit.Size = new System.Drawing.Size(100, 20);
            this.txtInit.TabIndex = 2;
            // 
            // frmTKRCInitTrackNewEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 122);
            this.Controls.Add(this.txtInit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddMore);
            this.Controls.Add(this.btnAddEntry);
            this.Controls.Add(this.chkSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboEntry);
            this.Name = "frmTKRCInitTrackNewEntry";
            this.Text = "Initiative Tracker - New Entry";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTKRCInitTrackNewEntry_FormClosing);
            this.Load += new System.EventHandler(this.frmTKRCInitTrackNewEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkSave;
        private System.Windows.Forms.Button btnAddEntry;
        private System.Windows.Forms.Button btnAddMore;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInit;
    }
}
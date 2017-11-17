namespace RohlCall
{
    partial class frmTKRCInitTrackAddEffect
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboEffect = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtfDescription = new System.Windows.Forms.RichTextBox();
            this.chkExpire = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudRounds = new System.Windows.Forms.NumericUpDown();
            this.btnAddEntry = new System.Windows.Forms.Button();
            this.btnAddMore = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkSave = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudRounds)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // cboEffect
            // 
            this.cboEffect.FormattingEnabled = true;
            this.cboEffect.Location = new System.Drawing.Point(56, 10);
            this.cboEffect.Name = "cboEffect";
            this.cboEffect.Size = new System.Drawing.Size(121, 21);
            this.cboEffect.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description:";
            // 
            // rtfDescription
            // 
            this.rtfDescription.Location = new System.Drawing.Point(12, 60);
            this.rtfDescription.Name = "rtfDescription";
            this.rtfDescription.Size = new System.Drawing.Size(260, 96);
            this.rtfDescription.TabIndex = 3;
            this.rtfDescription.Text = "";
            // 
            // chkExpire
            // 
            this.chkExpire.AutoSize = true;
            this.chkExpire.Location = new System.Drawing.Point(12, 173);
            this.chkExpire.Name = "chkExpire";
            this.chkExpire.Size = new System.Drawing.Size(66, 17);
            this.chkExpire.TabIndex = 4;
            this.chkExpire.Text = "Expires?";
            this.chkExpire.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rounds:";
            // 
            // nudRounds
            // 
            this.nudRounds.Location = new System.Drawing.Point(215, 170);
            this.nudRounds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRounds.Name = "nudRounds";
            this.nudRounds.Size = new System.Drawing.Size(57, 20);
            this.nudRounds.TabIndex = 6;
            this.nudRounds.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddEntry
            // 
            this.btnAddEntry.Location = new System.Drawing.Point(12, 215);
            this.btnAddEntry.Name = "btnAddEntry";
            this.btnAddEntry.Size = new System.Drawing.Size(75, 23);
            this.btnAddEntry.TabIndex = 7;
            this.btnAddEntry.Text = "Add Entry";
            this.btnAddEntry.UseVisualStyleBackColor = true;
            // 
            // btnAddMore
            // 
            this.btnAddMore.Location = new System.Drawing.Point(104, 215);
            this.btnAddMore.Name = "btnAddMore";
            this.btnAddMore.Size = new System.Drawing.Size(75, 23);
            this.btnAddMore.TabIndex = 8;
            this.btnAddMore.Text = "Add More";
            this.btnAddMore.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(196, 215);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // chkSave
            // 
            this.chkSave.AutoSize = true;
            this.chkSave.Location = new System.Drawing.Point(221, 12);
            this.chkSave.Name = "chkSave";
            this.chkSave.Size = new System.Drawing.Size(51, 17);
            this.chkSave.TabIndex = 10;
            this.chkSave.Text = "Save";
            this.chkSave.UseVisualStyleBackColor = true;
            // 
            // frmTKRCInitTrackAddEffect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 252);
            this.Controls.Add(this.chkSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddMore);
            this.Controls.Add(this.btnAddEntry);
            this.Controls.Add(this.nudRounds);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkExpire);
            this.Controls.Add(this.rtfDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboEffect);
            this.Controls.Add(this.label1);
            this.Name = "frmTKRCInitTrackAddEffect";
            this.Text = "Initiative Tracker - Add Effect";
            ((System.ComponentModel.ISupportInitialize)(this.nudRounds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboEffect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtfDescription;
        private System.Windows.Forms.CheckBox chkExpire;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudRounds;
        private System.Windows.Forms.Button btnAddEntry;
        private System.Windows.Forms.Button btnAddMore;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkSave;
    }
}
namespace Asg2_Analytics
{
    partial class Form1
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
            this.Browse = new System.Windows.Forms.Button();
            this.FileLocation = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.NoRecordslbl = new System.Windows.Forms.Label();
            this.MinEntryLBL = new System.Windows.Forms.Label();
            this.MaxEntryLBL = new System.Windows.Forms.Label();
            this.AvgEntryLBL = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NoOfRecord = new System.Windows.Forms.TextBox();
            this.MinEntry = new System.Windows.Forms.TextBox();
            this.MaxEntry = new System.Windows.Forms.TextBox();
            this.AvgEntry = new System.Windows.Forms.TextBox();
            this.Min_Inter = new System.Windows.Forms.TextBox();
            this.MaxInter = new System.Windows.Forms.TextBox();
            this.AvgInter = new System.Windows.Forms.TextBox();
            this.Total_Time = new System.Windows.Forms.TextBox();
            this.BackSpaceCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(518, 72);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(75, 23);
            this.Browse.TabIndex = 2;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // FileLocation
            // 
            this.FileLocation.Location = new System.Drawing.Point(49, 72);
            this.FileLocation.Name = "FileLocation";
            this.FileLocation.Size = new System.Drawing.Size(437, 22);
            this.FileLocation.TabIndex = 20;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1_FileOk);
            // 
            // NoRecordslbl
            // 
            this.NoRecordslbl.AutoSize = true;
            this.NoRecordslbl.Location = new System.Drawing.Point(46, 104);
            this.NoRecordslbl.Name = "NoRecordslbl";
            this.NoRecordslbl.Size = new System.Drawing.Size(99, 17);
            this.NoRecordslbl.TabIndex = 2;
            this.NoRecordslbl.Text = "No of Records";
            // 
            // MinEntryLBL
            // 
            this.MinEntryLBL.AutoSize = true;
            this.MinEntryLBL.Location = new System.Drawing.Point(46, 145);
            this.MinEntryLBL.Name = "MinEntryLBL";
            this.MinEntryLBL.Size = new System.Drawing.Size(135, 17);
            this.MinEntryLBL.TabIndex = 3;
            this.MinEntryLBL.Text = "Minimum Entry Time";
            // 
            // MaxEntryLBL
            // 
            this.MaxEntryLBL.AutoSize = true;
            this.MaxEntryLBL.Location = new System.Drawing.Point(46, 186);
            this.MaxEntryLBL.Name = "MaxEntryLBL";
            this.MaxEntryLBL.Size = new System.Drawing.Size(105, 17);
            this.MaxEntryLBL.TabIndex = 4;
            this.MaxEntryLBL.Text = "Max Entry Time";
            // 
            // AvgEntryLBL
            // 
            this.AvgEntryLBL.AutoSize = true;
            this.AvgEntryLBL.Location = new System.Drawing.Point(46, 218);
            this.AvgEntryLBL.Name = "AvgEntryLBL";
            this.AvgEntryLBL.Size = new System.Drawing.Size(133, 17);
            this.AvgEntryLBL.TabIndex = 5;
            this.AvgEntryLBL.Text = "Average Entry TIme";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Minimum inter-record time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Maximum inter-record time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Average inter-record time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Total time";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 389);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Backspace count";
            // 
            // NoOfRecord
            // 
            this.NoOfRecord.Location = new System.Drawing.Point(229, 101);
            this.NoOfRecord.Name = "NoOfRecord";
            this.NoOfRecord.Size = new System.Drawing.Size(100, 22);
            this.NoOfRecord.TabIndex = 11;
            // 
            // MinEntry
            // 
            this.MinEntry.Location = new System.Drawing.Point(229, 139);
            this.MinEntry.Name = "MinEntry";
            this.MinEntry.Size = new System.Drawing.Size(100, 22);
            this.MinEntry.TabIndex = 12;
            // 
            // MaxEntry
            // 
            this.MaxEntry.Location = new System.Drawing.Point(229, 186);
            this.MaxEntry.Name = "MaxEntry";
            this.MaxEntry.Size = new System.Drawing.Size(100, 22);
            this.MaxEntry.TabIndex = 13;
            // 
            // AvgEntry
            // 
            this.AvgEntry.Location = new System.Drawing.Point(229, 218);
            this.AvgEntry.Name = "AvgEntry";
            this.AvgEntry.Size = new System.Drawing.Size(100, 22);
            this.AvgEntry.TabIndex = 14;
            // 
            // Min_Inter
            // 
            this.Min_Inter.Location = new System.Drawing.Point(229, 285);
            this.Min_Inter.Name = "Min_Inter";
            this.Min_Inter.Size = new System.Drawing.Size(100, 22);
            this.Min_Inter.TabIndex = 15;
            // 
            // MaxInter
            // 
            this.MaxInter.Location = new System.Drawing.Point(229, 257);
            this.MaxInter.Name = "MaxInter";
            this.MaxInter.Size = new System.Drawing.Size(100, 22);
            this.MaxInter.TabIndex = 16;
            // 
            // AvgInter
            // 
            this.AvgInter.Location = new System.Drawing.Point(229, 317);
            this.AvgInter.Name = "AvgInter";
            this.AvgInter.Size = new System.Drawing.Size(100, 22);
            this.AvgInter.TabIndex = 17;
            // 
            // Total_Time
            // 
            this.Total_Time.Location = new System.Drawing.Point(229, 355);
            this.Total_Time.Name = "Total_Time";
            this.Total_Time.Size = new System.Drawing.Size(100, 22);
            this.Total_Time.TabIndex = 18;
            // 
            // BackSpaceCount
            // 
            this.BackSpaceCount.Location = new System.Drawing.Point(229, 389);
            this.BackSpaceCount.Name = "BackSpaceCount";
            this.BackSpaceCount.Size = new System.Drawing.Size(100, 22);
            this.BackSpaceCount.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Output File Name";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(229, 30);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(133, 22);
            this.fname.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 450);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackSpaceCount);
            this.Controls.Add(this.Total_Time);
            this.Controls.Add(this.AvgInter);
            this.Controls.Add(this.MaxInter);
            this.Controls.Add(this.Min_Inter);
            this.Controls.Add(this.AvgEntry);
            this.Controls.Add(this.MaxEntry);
            this.Controls.Add(this.MinEntry);
            this.Controls.Add(this.NoOfRecord);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AvgEntryLBL);
            this.Controls.Add(this.MaxEntryLBL);
            this.Controls.Add(this.MinEntryLBL);
            this.Controls.Add(this.NoRecordslbl);
            this.Controls.Add(this.FileLocation);
            this.Controls.Add(this.Browse);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.TextBox FileLocation;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label NoRecordslbl;
        private System.Windows.Forms.Label MinEntryLBL;
        private System.Windows.Forms.Label MaxEntryLBL;
        private System.Windows.Forms.Label AvgEntryLBL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NoOfRecord;
        private System.Windows.Forms.TextBox MinEntry;
        private System.Windows.Forms.TextBox MaxEntry;
        private System.Windows.Forms.TextBox AvgEntry;
        private System.Windows.Forms.TextBox Min_Inter;
        private System.Windows.Forms.TextBox MaxInter;
        private System.Windows.Forms.TextBox AvgInter;
        private System.Windows.Forms.TextBox Total_Time;
        private System.Windows.Forms.TextBox BackSpaceCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fname;
    }
}


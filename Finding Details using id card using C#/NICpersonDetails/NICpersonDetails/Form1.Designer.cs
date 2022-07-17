namespace NICpersonDetails
{
    partial class FrmMain
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
            this.txtNic = new Nictext.Nictext();
            this.lblNic = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblVote = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtVote = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNic
            // 
            this.txtNic.BackColor = System.Drawing.Color.Silver;
            this.txtNic.ForeColor = System.Drawing.Color.Black;
            this.txtNic.Location = new System.Drawing.Point(119, 31);
            this.txtNic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNic.Name = "txtNic";
            this.txtNic.Size = new System.Drawing.Size(125, 20);
            this.txtNic.TabIndex = 0;
            this.txtNic.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNic_KeyDown);
            // 
            // lblNic
            // 
            this.lblNic.AutoSize = true;
            this.lblNic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNic.Location = new System.Drawing.Point(40, 34);
            this.lblNic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNic.Name = "lblNic";
            this.lblNic.Size = new System.Drawing.Size(75, 13);
            this.lblNic.TabIndex = 1;
            this.lblNic.Text = "NIC Number";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(67, 111);
            this.lblGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(48, 13);
            this.lblGender.TabIndex = 2;
            this.lblGender.Text = "Gender";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(36, 150);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(79, 13);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date of Birth";
            // 
            // lblVote
            // 
            this.lblVote.AutoSize = true;
            this.lblVote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVote.Location = new System.Drawing.Point(28, 193);
            this.lblVote.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVote.Name = "lblVote";
            this.lblVote.Size = new System.Drawing.Size(87, 13);
            this.lblVote.TabIndex = 4;
            this.lblVote.Text = "Vote Eligibility";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(92, 64);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(107, 28);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next Person";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            this.btnNext.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnNext_KeyDown);
            // 
            // txtGender
            // 
            this.txtGender.BackColor = System.Drawing.SystemColors.Control;
            this.txtGender.Enabled = false;
            this.txtGender.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtGender.Location = new System.Drawing.Point(123, 108);
            this.txtGender.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGender.Name = "txtGender";
            this.txtGender.ReadOnly = true;
            this.txtGender.Size = new System.Drawing.Size(86, 20);
            this.txtGender.TabIndex = 6;
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.SystemColors.Control;
            this.txtDate.Enabled = false;
            this.txtDate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDate.Location = new System.Drawing.Point(123, 147);
            this.txtDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(86, 20);
            this.txtDate.TabIndex = 7;
            // 
            // txtVote
            // 
            this.txtVote.BackColor = System.Drawing.SystemColors.Control;
            this.txtVote.Enabled = false;
            this.txtVote.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtVote.Location = new System.Drawing.Point(123, 190);
            this.txtVote.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtVote.Name = "txtVote";
            this.txtVote.ReadOnly = true;
            this.txtVote.Size = new System.Drawing.Size(86, 20);
            this.txtVote.TabIndex = 8;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(310, 296);
            this.Controls.Add(this.txtVote);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblVote);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblNic);
            this.Controls.Add(this.txtNic);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmMain";
            this.Text = "NIC-PersonalDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Nictext.Nictext txtNic;
        private System.Windows.Forms.Label lblNic;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblVote;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtVote;
    }
}


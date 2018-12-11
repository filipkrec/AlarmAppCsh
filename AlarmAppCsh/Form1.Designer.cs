namespace AlarmAppCsh
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
            this.lbClock = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbClock
            // 
            this.lbClock.AutoSize = true;
            this.lbClock.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClock.Location = new System.Drawing.Point(60, 29);
            this.lbClock.Name = "lbClock";
            this.lbClock.Size = new System.Drawing.Size(215, 58);
            this.lbClock.TabIndex = 0;
            this.lbClock.Text = "00:00:00";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "UTC (London)",
            "UTC +1 (Zagreb)",
            "UTC +2 (Athens)",
            "UTC +3 (Moscow)",
            "UTC +4 (Dubai)",
            "UTC +5  (Karachi)",
            "UTC +6 (Dhaka)",
            "UTC +7 (Bangkok)",
            "UTC +8 (Beijing)",
            "UTC +9 (Tokyo)",
            "UTC +10 (Sydney)",
            "UTC +11 (Noumea)",
            "UTC + 12 (Auckland)",
            "UTC + 13 (Phoenix Islands)",
            "UTC + 14 (Line Islands)",
            "UTC -1 ",
            "UTC -2 (South Georgia)",
            "UTC -3 (Buenos Aires)",
            "UTC -4 (Santo Domingo)",
            "UTC -5 (New York)",
            "UTC -6 (Chicago)",
            "UTC -7 (Phoenix)",
            "UTC -8 (Los Angeles)",
            "UTC -9 (Anchorage)",
            "UTC - 10 (Honolulu)",
            "UTC - 11  (American Samoa)",
            "UTC - 12 (Howland Island)"});
            this.comboBox1.Location = new System.Drawing.Point(70, 152);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(191, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(131, 119);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(73, 13);
            this.lbDate.TabIndex = 2;
            this.lbDate.Text = "00 . 00 . 0000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 228);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbClock);
            this.Name = "Form1";
            this.Text = "Clock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbClock;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbDate;
    }
}


namespace _4calGUI
{
    partial class History_Record
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
            this.record = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.correct_rate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // record
            // 
            this.record.AutoSize = true;
            this.record.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.record.Location = new System.Drawing.Point(69, 32);
            this.record.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.record.Name = "record";
            this.record.Size = new System.Drawing.Size(90, 33);
            this.record.TabIndex = 0;
            this.record.Text = "History";
            this.record.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(658, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // correct_rate
            // 
            this.correct_rate.AutoSize = true;
            this.correct_rate.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correct_rate.Location = new System.Drawing.Point(579, 38);
            this.correct_rate.Name = "correct_rate";
            this.correct_rate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.correct_rate.Size = new System.Drawing.Size(123, 27);
            this.correct_rate.TabIndex = 2;
            this.correct_rate.Text = "Correct Rate:";
            // 
            // History_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.correct_rate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.record);
            this.Font = new System.Drawing.Font("隶书", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "History_Record";
            this.Text = "History_Record";
            this.Load += new System.EventHandler(this.History_Record_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label record;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label correct_rate;
    }
}
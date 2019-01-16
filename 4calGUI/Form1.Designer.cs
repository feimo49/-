namespace _4calGUI
{
    partial class cal4
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
    private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.Ans = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.Submit = new System.Windows.Forms.Button();
            this.History = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Label();
            this.ggrade = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ques = new System.Windows.Forms.Label();
            this.Quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(163, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(421, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "FOUR OPERATIONS STEP";
            // 
            // Ans
            // 
            this.Ans.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Ans.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Ans.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ans.Location = new System.Drawing.Point(295, 158);
            this.Ans.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Ans.Multiline = true;
            this.Ans.Name = "Ans";
            this.Ans.Size = new System.Drawing.Size(100, 30);
            this.Ans.TabIndex = 2;
            this.Ans.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Start.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Start.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Start.Location = new System.Drawing.Point(295, 167);
            this.Start.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(102, 47);
            this.Start.TabIndex = 3;
            this.Start.Text = "START";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Submit.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Submit.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Submit.Location = new System.Drawing.Point(284, 228);
            this.Submit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(113, 34);
            this.Submit.TabIndex = 4;
            this.Submit.Text = "SUBMIT";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // History
            // 
            this.History.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.History.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.History.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.History.Location = new System.Drawing.Point(116, 228);
            this.History.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(118, 34);
            this.History.TabIndex = 5;
            this.History.Text = "HISTORY";
            this.History.UseVisualStyleBackColor = false;
            this.History.Click += new System.EventHandler(this.History_Click);
            // 
            // Timer
            // 
            this.Timer.AutoSize = true;
            this.Timer.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timer.Location = new System.Drawing.Point(110, 26);
            this.Timer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(81, 35);
            this.Timer.TabIndex = 6;
            this.Timer.Text = "Timer:";
            this.Timer.Click += new System.EventHandler(this.label3_Click);
            // 
            // ggrade
            // 
            this.ggrade.AutoSize = true;
            this.ggrade.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggrade.Location = new System.Drawing.Point(480, 26);
            this.ggrade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ggrade.Name = "ggrade";
            this.ggrade.Size = new System.Drawing.Size(82, 35);
            this.ggrade.TabIndex = 7;
            this.ggrade.Text = "Grade:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ques
            // 
            this.ques.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ques.AutoSize = true;
            this.ques.Font = new System.Drawing.Font("Lucida Handwriting", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ques.ForeColor = System.Drawing.Color.Firebrick;
            this.ques.Location = new System.Drawing.Point(244, 99);
            this.ques.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ques.Name = "ques";
            this.ques.Size = new System.Drawing.Size(193, 37);
            this.ques.TabIndex = 8;
            this.ques.Text = "3+5*6/7^8";
            this.ques.Click += new System.EventHandler(this.ques_Click);
            // 
            // Quit
            // 
            this.Quit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Quit.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Quit.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Quit.Location = new System.Drawing.Point(449, 228);
            this.Quit.Margin = new System.Windows.Forms.Padding(2);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(113, 34);
            this.Quit.TabIndex = 9;
            this.Quit.Text = "QUIT";
            this.Quit.UseVisualStyleBackColor = false;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // cal4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(692, 302);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.ques);
            this.Controls.Add(this.ggrade);
            this.Controls.Add(this.Timer);
            this.Controls.Add(this.History);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Ans);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "cal4";
            this.Text = "四则运算挑战题";
            this.Load += new System.EventHandler(this.四则运算挑战题_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Ans;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button History;
        private System.Windows.Forms.Label Timer;
        private System.Windows.Forms.Label ggrade;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label ques;
        private System.Windows.Forms.Button Quit;
    }
}


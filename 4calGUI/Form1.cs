using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace _4calGUI
{
    public partial class cal4 : Form
    {

        public int[] save = new int[100];
        public static Random rand = new Random();
        Solve solve = new Solve();
        G_Exp Generate = new G_Exp();
        private bool IsFirstRound = true;
        private int grade = 0;
        int totaltime = 20;
        History_Record f3 = new History_Record();
        public int cnt=0;
        public int correct_cnt = 0;


        public cal4()
        {
            InitializeComponent();
            ques.Visible = false;
            Timer.Visible = false;
            ggrade.Visible = false;
            Submit.Visible = false;
            History.Visible = false;
            Ans.Visible = false;
            Quit.Visible = false;
        }

        private void 四则运算挑战题_Load(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            if(IsFirstRound)
            {
                Ans.Visible = true; //点击开始答题按钮后显示答题文本框
                Start.Visible = false;
                label2.Visible = false;
                Submit.Visible = true;
                History.Visible = true;
                ques.Visible = true;
                Timer.Visible = true;
                ggrade.Visible = true;
                Quit.Visible = true;
                ggrade.Text = "Grade: "+grade.ToString();
                timer1.Start();
            }
            Ans.Focus();
            for(int i=0;i<1;i++)
            {
                save = Generate.BuildExp(3);
                Generate.PrintExp();
                cnt++;
                ques.Text = Generate.strsave;
                int len = ques.Width;
                int flen = this.Width;
                int x = (flen - len) / 2;
                int y = 100;
                ques.Location = new Point(x, y);
            } 
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public string correct_ans_str;
        public string timu;
        private void Submit_Click(object sender, EventArgs e)
        {
            if(Ans.Text=="")
            {
                Ans.Focus();
                return;
            }
            Judge ans = new Judge();
            Num correct_ans = solve.get_ans(save, Generate.p);
            int ansflag = ans.judge(correct_ans, this.Ans.Text);
            correct_ans_str = correct_ans.c_Tostring();
            timu = Generate.C_Tostring();
            f3.History_Add(timu, correct_ans_str);
            if (ansflag==1)
            {
                timer1.Stop();
                MessageBox.Show("Bingo!");
                timer1.Start();
                grade+=1;
                correct_cnt++;
                ggrade.Text = "Grade: "+grade.ToString();
                Start_Click(null, null);
                this.Ans.Text = "";
                totaltime = 20;
            }
            else if(ansflag==0)
            {
                timer1.Stop();
                MessageBox.Show("Wrong!\n" + "Correct Answer:" + correct_ans_str);
                timer1.Start();
                Start_Click(null, null);
                this.Ans.Text = "";
                totaltime = 20;
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Error:Please input the correct form!");
                timer1.Start();
                this.Ans.Text = "";
                this.Ans.Focus();
            }
            f3.Correct_Rate(correct_cnt, cnt-1);
        }

        private void History_Click(object sender, EventArgs e)
        {
            f3.Show();
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Timer.Text = "Time Remain : " + (totaltime--).ToString();
            timer1.Interval = 1000;
            if(totaltime==-1)
            {
                timer1.Stop();
                Timer.Text = "Time Remain : 0";
                MessageBox.Show("Time Up!");
                Start_Click(null, null);
                totaltime = 20;
            }
        }

        private void ques_Click(object sender, EventArgs e)
        {
        
        }
    }
}

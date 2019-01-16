using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4calGUI
{
    public partial class History_Record : Form
    {

        public History_Record()
        {
            InitializeComponent();
            record.Text += ":\r\n";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void History_Record_Load(object sender, EventArgs e)
        {
           
        }
        public void History_Add(String Text1,String Text2)
        {
            record.Text += Text1 + "=" + Text2+"\r\n";
        }

        public void Correct_Rate(int c_cnt, int cnt)
        {
            correct_rate.Text = "Correct Rate : " + c_cnt + "/" + cnt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

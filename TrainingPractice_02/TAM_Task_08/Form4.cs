using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAM_Task_08
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();         
            MaximizeBox = false;
           
        }

        public Form4(Form1 f)
        {
            InitializeComponent();
            label2.Visible = false;
            
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\TAM_Task_08_labirint2.exe");
            button1.Enabled = false;
            button2.Enabled = true;
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\TAM_Task_08_labirint1.exe");
            button3.Enabled = false;
            button4.Enabled = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\TAM_Task_08_labirint4.exe");
            
            button4.Enabled = false;
            button5.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\TAM_Task_08_labirint3.exe");
            button2.Enabled = false;
            button3.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\TAM_Tasl_08_BOSSS.exe");
            button5.Enabled = false;
            label2.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}

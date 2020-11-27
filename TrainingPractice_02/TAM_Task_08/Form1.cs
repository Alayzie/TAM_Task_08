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
    public partial class Form1 : Form
        
    {
        public Form1()
        {
            InitializeComponent();
            MaximizeBox = false;          

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2(this);
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3(this);
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4(this);
            newForm.Show();
        }
    }
}

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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            MaximizeBox = false;
        }
        public Form2(Form1 f)
        {
            InitializeComponent();           
        }

    }

}

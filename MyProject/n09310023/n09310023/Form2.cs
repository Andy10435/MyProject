using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace n09310023
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btn.Text == "請按我一下")
                btn.Text = "我已經被按過了";
            else if (btn.Text == "我已經被按過了")
                btn.Text = "請按我一下";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

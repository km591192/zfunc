using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zfunc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        zfunc zf = new zfunc();

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem.Equals("Z-func"))
            zf.zf(richTextBox1, textBox1);
            if (comboBox1.SelectedItem.Equals("Prefix-func"))
            zf.preff(richTextBox1, textBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            richTextBox1.Clear();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Form4 : Form
    {
        public string _textBox1
        {
            get { return textBox2.Text; }
        }
        public string name1
        {
            get { return textBox1.Text; }
        }
        public Form4()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button2.Visible = false;
            button1.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int Num;
            bool isNum = int.TryParse(textBox2.Text, out Num);
            if (textBox1.Text != null && isNum && Num != 0)
            { 
                Form3 frm = new Form3();
                frm._textBox = _textBox1;
                frm.namee = name1;
                this.Hide();
                frm.Show();
            }
            else label3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
           
            int Num;
            bool isNum = int.TryParse(textBox2.Text, out Num);

            if (textBox1.Text != null && isNum && Num!=0)
            {
                Form2 frm = new Form2();
                frm._textBox = _textBox1;
                frm.nuts = name1;
                this.Hide();
                frm.Show();
            }
            else label3.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Form5 : Form
    {
        
        
        int lele;
        public string flynn1
        {
            set { lele = Convert.ToInt32(value); }
        }
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
           
            label1.Text = "Благодаря ти, че игра, !\n Ако ти е харесала играта\n приемам плащане в кеш - \n тъкмо имаш " + lele + " кинта за \n харчене - или в отлични оценки.";

        }
    }
}

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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int p;
        public string _textBox
        {
            set { p = int.Parse(value); }
        }
        string k;
        public string namee
        {
            set { k = value; }
        }
        public string __textBox1
        {
            get { return Convert.ToString(p); }
        }
        public string deez
        {
            get { return k; }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = " Имаш право да изтеглиш една карта от всяка боя. \n Изтегли толкова карти, колкото желаеш.\n Всяка карта има определена стойност: \n \n Стойността на Асака може да бъде 1 или 11, по твой избор. \n \n Картите с числа от 2 до 10 имат стойност, равна на номера им. \n \n Дворцовите карти имат стойност 10. \n \n Целта на играта е да доближиш \n сбора от стойностите на изтеглените карти възможно\n най-много до числото 21, без да го надхвърляш. \n Ако го надхвърлиш си 'Busted!' и губиш. \n Състезаваш се срещу дилър (бот), който играе по същите правила. \n Трябва да си по-близо до 21 от него, за да спечелиш. \n Преди всяка нова игра трябва да определиш залог. \n При печалба го получаваш двойно, иначе го губиш. \n Играта приключва, когато натиснеш бутона 'Приключи!', \n или когато свършат средствата ти. ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Form2 frm = new Form2();
            frm.__textBox = __textBox1;
            frm.nuts = deez;
            this.Hide();
            frm.Show();
        }
    }
}

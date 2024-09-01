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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Player chovek = new Player();
        Dealer dilur = new Dealer();
        public string _textBox
        {
            set { chovek.funds = int.Parse(value); }
        }
        public string candice1
        {
            get { return Convert.ToString(chovek.funds); }
        }
        public string nuts
        {
            set { chovek.name = value; }
        }
        public string __textBox
        {
            set { chovek.funds = int.Parse(value); }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (kr == false)
            {
                Random r = new Random();
                int a = r.Next(13);
                switch (a)
                {
                    case 0: { pictureBox2.Visible = true;
                            groupBox1.Visible = true;
                            button1.Visible = false;
                            button2.Visible = false;
                            button3.Visible = false;
                            button4.Visible = false;
                            button5.Visible = false;
                            button6.Visible = false;
                            button8.Visible = false;
                            label3.Visible = false;
                            textBox1.Visible = false;
                            label1.Visible = false;
                            label4.Visible = false;
                        } break;
                    case 1: { pictureBox6.Visible = true; sum += 2; } break;
                    case 2: { pictureBox10.Visible = true; sum += 3; } break;
                    case 3: { pictureBox14.Visible = true; sum += 4; } break;
                    case 4: { pictureBox18.Visible = true; sum += 5; } break;
                    case 5: { pictureBox22.Visible = true; sum += 6; } break;
                    case 6: { pictureBox26.Visible = true; sum += 7; } break;
                    case 7: { pictureBox30.Visible = true; sum += 8; } break;
                    case 8: { pictureBox34.Visible = true; sum += 9; } break;
                    case 9: { pictureBox38.Visible = true; sum += 10; } break;
                    case 10: { pictureBox42.Visible = true; sum += 10; } break;
                    case 11: { pictureBox46.Visible = true; sum += 10; } break;
                    case 12: { pictureBox50.Visible = true; sum += 10; } break;
                }
                kr = true;
            }
            else label1.Text = "Вече си изтеглил каро!";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        int sum = 0;
        bool sp = false, kr = false, kp = false, pk = false;

        private void button4_Click(object sender, EventArgs e)
        {

            if (pk == false)
            {
                Random r = new Random();
                int a = r.Next(13);
                switch (a)
                {
                    case 0: { pictureBox4.Visible = true;
                            groupBox1.Visible = true;
                            button1.Visible = false;
                            button2.Visible = false;
                            button3.Visible = false;
                            button4.Visible = false;
                            button5.Visible = false;
                            button6.Visible = false;
                            button8.Visible = false;
                            label3.Visible = false;
                            textBox1.Visible = false;
                            label1.Visible = false;
                            label4.Visible = false;
                        } break;
                    case 1: { pictureBox8.Visible = true; sum += 2; } break;
                    case 2: { pictureBox12.Visible = true; sum += 3; } break;
                    case 3: { pictureBox16.Visible = true; sum += 4; } break;
                    case 4: { pictureBox20.Visible = true; sum += 5; } break;
                    case 5: { pictureBox24.Visible = true; sum += 6; } break;
                    case 6: { pictureBox28.Visible = true; sum += 7; } break;
                    case 7: { pictureBox32.Visible = true; sum += 8; } break;
                    case 8: { pictureBox36.Visible = true; sum += 9; } break;
                    case 9: { pictureBox40.Visible = true; sum += 10; } break;
                    case 10: { pictureBox44.Visible = true; sum += 10; } break;
                    case 11: { pictureBox48.Visible = true; sum += 10; } break;
                    case 12: { pictureBox52.Visible = true; sum += 10; } break;
                }
                pk = true;
            }
            else label1.Text = "Вече си изтеглил пика!";
        }

        private void button7_Click(object sender, EventArgs e)
        {

            this.Hide();
            (new Form3()).Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox19.Visible = false;
            pictureBox20.Visible = false;
            pictureBox21.Visible = false;
            pictureBox21.Visible = false;
            pictureBox22.Visible = false;
            pictureBox23.Visible = false;
            pictureBox24.Visible = false;
            pictureBox25.Visible = false;
            pictureBox26.Visible = false;
            pictureBox27.Visible = false;
            pictureBox28.Visible = false;
            pictureBox29.Visible = false;
            pictureBox30.Visible = false;
            pictureBox31.Visible = false;
            pictureBox32.Visible = false;
            pictureBox33.Visible = false;
            pictureBox34.Visible = false;
            pictureBox35.Visible = false;
            pictureBox36.Visible = false;
            pictureBox37.Visible = false;
            pictureBox38.Visible = false;
            pictureBox39.Visible = false;
            pictureBox40.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox47.Visible = false;
            pictureBox48.Visible = false;
            pictureBox49.Visible = false;
            pictureBox50.Visible = false;
            pictureBox51.Visible = false;
            pictureBox52.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button8.Visible = false;
            label3.Visible = false;
            textBox1.Visible = false;
            label1.Visible = false;
            label4.Visible = false;
            groupBox2.Visible = true;
            string uno = "Сигурни ли сте, че искате да напуснете, ";
            string tres = "?";
            string g = chovek.name;
            label2.Text = String.Format("{0}{1}{2} ", uno, g, tres);
   
            label2.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button5.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            
            bool playBust = false;
            if(sum>21) playBust = true;
            bool dealBust = false;
            int sumDeal = 0;
            Random r1 = new Random();
            int a1 = r1.Next(2, 21);
            if (a1 < 17)
             {
                 Random r2 = new Random();
                 int a2 = r2.Next(1, 11);
                 if (a1 + a2 < 17)
                 {
                     Random r3 = new Random();
                     int a3 = r3.Next(1, 11);
                     sumDeal = a1 + a2 + a3;
                  }
                 else sumDeal = a1 + a2;
            }
            else sumDeal = a1;
            if (sumDeal > 21) dealBust = true;
            if (playBust == false && dealBust == false)
            {
                if (sumDeal < sum)
                {
                    chovek.funds += 2 * chovek.zalog;
                    label1.Text = "Сумата от картите на дилъра ти " + dilur.name + " е " + sumDeal + ". \nТвоята сума е " + sum + ". Ти спечели!";
                    textBox1.Text = null;
                    button8.Visible = true;
                    button6.Visible = false;
                    button5.Visible = true;
                    if (chovek.funds == 0)
                    {
                        button6.Visible = false;
                        button5.Visible = false;
                        label3.Visible = false;
                        textBox1.Visible = false;
                        button7.Visible = true;
                    }
                }
                else if (sumDeal > sum)
                {
                    chovek.funds -= chovek.zalog;
                    label1.Text = "Сумата от картите на дилъра ти " + dilur.name + " е " + sumDeal + ". \nТвоята сума е " + sum + ". Ти загуби!";
                    textBox1.Text = null; textBox1.Text = null;
                    button8.Visible = true;
                    button6.Visible = false;
                    button5.Visible = true;
                    if (chovek.funds == 0)
                    {
                        button6.Visible = false;
                        button5.Visible = false;
                        label3.Visible = false;
                        textBox1.Visible = false;
                        button7.Visible = true;
                    }
                }
                else
                {

                    label1.Text = "И ти и дилъра ти " + dilur.name + " сте наравно с по " + sum + "!\n Равен резултат!"; textBox1.Text = null;
                    textBox1.Text = null;
                    button8.Visible = true;
                    button6.Visible = false;
                    button5.Visible = true;
                    if (chovek.funds == 0)
                    {
                        button6.Visible = false;
                        button5.Visible = false;
                        label3.Visible = false;
                        textBox1.Visible = false;
                        button7.Visible = true;
                    }
                }
            }
            else if (playBust == false && dealBust == true)
            {
                chovek.funds += 2 * chovek.zalog;
                label1.Text = " Дилъра ти " + dilur.name + " е busted! Твоята сума е " + sum + ".\nТи спечели!"; textBox1.Text = null;
                textBox1.Text = null;
                button8.Visible = true;
                button6.Visible = false;
                button5.Visible = true;
                if (chovek.funds == 0)
                {
                    button6.Visible = false;
                    button5.Visible = false;
                    label3.Visible = false;
                    textBox1.Visible = false;
                    button7.Visible = true;
                }
            }
            else if (dealBust == false && playBust==true)
            {
                chovek.funds -= chovek.zalog;
                label1.Text = "Сумата от картите на дилъра ти " + dilur.name + " е " + sumDeal + ". \nТи си busted! Съжалявам, но загуби!";
                textBox1.Text = null; textBox1.Text = null;
                button8.Visible = true;
                button6.Visible = false;
                button5.Visible = true;
                if (chovek.funds == 0)
                {
                    button6.Visible = false;
                    button5.Visible = false;
                    label3.Visible = false;
                    textBox1.Visible = false;
                    button7.Visible = true;
                }
            }
            else
            {
                label1.Text = "И ти и дилъра ти " + dilur.name + " сте busted! Равен резултат! "; textBox1.Text = null;
                textBox1.Text = null;
                button8.Visible = true;
                button6.Visible = false;
                button5.Visible = true;
                if (chovek.funds == 0)
                {
                    button6.Visible = false;
                    button5.Visible = false;
                    label3.Visible = false;
                    textBox1.Visible = false;
                    button7.Visible = true;
                }
            }

            label7.Text = Convert.ToString(chovek.funds);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (kp == false)
            {
                Random r = new Random();
                int a = r.Next(13);
                switch (a)
                {
                    case 0: { 
                            pictureBox3.Visible = true; 
                            groupBox1.Visible = true;
                            button1.Visible = false;
                            button2.Visible = false;
                            button3.Visible = false;
                            button4.Visible = false;
                            button5.Visible = false;
                            button6.Visible = false;
                            button8.Visible = false;
                            label3.Visible = false;
                            textBox1.Visible = false;
                            label1.Visible = false;
                            label4.Visible = false;
                        } break;
                    case 1: { pictureBox7.Visible = true; sum += 2; } break;
                    case 2: { pictureBox11.Visible = true; sum += 3; } break;
                    case 3: { pictureBox15.Visible = true; sum += 4; } break;
                    case 4: { pictureBox19.Visible = true; sum += 5; } break;
                    case 5: { pictureBox23.Visible = true; sum += 6; } break;
                    case 6: { pictureBox27.Visible = true; sum += 7; } break;
                    case 7: { pictureBox31.Visible = true; sum += 8; } break;
                    case 8: { pictureBox35.Visible = true; sum += 9; } break;
                    case 9: { pictureBox39.Visible = true; sum += 10; } break;
                    case 10: { pictureBox43.Visible = true; sum += 10; } break;
                    case 11: { pictureBox47.Visible = true; sum += 10; } break;
                    case 12: { pictureBox51.Visible = true; sum += 10; } break;
                }
                kp = true;
            }
            else label1.Text = "Вече си изтеглил купа!";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) sum += 1;
            else sum += 11;
            groupBox1.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button8.Visible = true;
            label3.Visible = true;
            textBox1.Visible = true;
            label1.Visible = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label8.Text= Convert.ToString(chovek.name);
            label7.Text = Convert.ToString(chovek.funds);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Form5 frm1 = new Form5();
            frm1.flynn1 = candice1;
            this.Hide();
            frm1.Show();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {

            Form5 frm1 = new Form5();
            frm1.flynn1 = candice1;
            this.Hide();
            frm1.Show();
        }

        int Num2;

        private void button5_Click(object sender, EventArgs e)
        {
            
            bool isNum2 = int.TryParse(textBox1.Text, out Num2);
            if (isNum2 && Num2<=chovek.funds)
            {
                label1.Visible = false;
                button6.Visible = true;
                button5.Visible = true;
                label1.Visible = true;
                button8.Visible=false;
                label4.Visible=false;
                button5.Visible = false;
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                sp = false;
                kr = false; kp = false; pk = false;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                sum = 0;
                chovek.zalog = Num2;

            }
            else if(isNum2){ label4.Text = "Недостатъчно средства!"; label4.Visible = true; }
            else { label4.Text = "Моля въведи валидна сума!"; label4.Visible = true; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (sp == false)
            {
                Random r = new Random();
                int a = r.Next(13);
                switch (a)
                {
                    case 0: { pictureBox1.Visible = true;
                            groupBox1.Visible = true;
                            button1.Visible = false;
                            button2.Visible = false;
                            button3.Visible = false;
                            button4.Visible = false;
                            button5.Visible = false;
                            button6.Visible = false;
                            button8.Visible = false;
                            label3.Visible = false;
                            textBox1.Visible = false;
                            label1.Visible = false;
                            label4.Visible = false;

                        } break;
                    case 1: { pictureBox5.Visible = true; sum += 2; } break;
                    case 2: { pictureBox9.Visible = true; sum += 3; } break;
                    case 3: { pictureBox13.Visible = true; sum += 4; } break;
                    case 4: { pictureBox17.Visible = true; sum += 5; } break;
                    case 5: { pictureBox21.Visible = true; sum += 6; } break;
                    case 6: { pictureBox25.Visible = true; sum += 7; } break;
                    case 7: { pictureBox29.Visible = true; sum += 8; } break;
                    case 8: { pictureBox33.Visible = true; sum += 9; } break;
                    case 9: { pictureBox37.Visible = true; sum += 10; } break;
                    case 10: { pictureBox41.Visible = true; sum += 10; } break;
                    case 11: { pictureBox45.Visible = true; sum += 10; } break;
                    case 12: { pictureBox49.Visible = true; sum += 10; } break;
                }
                sp = true;
            }
            else label1.Text = "Вече си изтеглил спатия!";
        }
    }
}

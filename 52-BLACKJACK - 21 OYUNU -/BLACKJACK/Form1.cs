using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLACKJACK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int sayac = 0;
        int sayac2 = 0;
        int birincipuan = 0;
        int ikincipuan = 0;
        public void metot()
        {
            sayac = 0;
            sayac2 = 0;
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label10.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            button3.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            pb11.Visible = false;
            pb12.Visible = false;
            pb13.Visible = false;
            pb14.Visible = false;
            pb15.Visible = false;
            pb16.Visible = false;
            pb17.Visible = false;
            pb18.Visible = false;
            pb19.Visible = false;
            pbson1.Visible = false;
            pb21.Visible = false;
            pb22.Visible = false;
            pb23.Visible = false;
            pb24.Visible = false;
            pb25.Visible = false;
            pb26.Visible = false;
            pb27.Visible = false;
            pb28.Visible = false;
            pb29.Visible = false;
            pbson2.Visible = false;
            pb31.Visible = false;
            pb32.Visible = false;
            pb33.Visible = false;
            pb34.Visible = false;
            pb35.Visible = false;
            pb36.Visible = false;
            pb37.Visible = false;
            pb38.Visible = false;
            pb39.Visible = false;
            pbson3.Visible = false;
            pb41.Visible = false;
            pb42.Visible = false;
            pb43.Visible = false;
            pb44.Visible = false;
            pb45.Visible = false;
            pb46.Visible = false;
            pb47.Visible = false;
            pb48.Visible = false;
            pb49.Visible = false;
            pbson4.Visible = false;
            pb51.Visible = false;
            pb52.Visible = false;
            pb53.Visible = false;
            pb54.Visible = false;
            pb55.Visible = false;
            pb56.Visible = false;
            pb57.Visible = false;
            pb58.Visible = false;
            pb59.Visible = false;
            pbson5.Visible = false;
            pb61.Visible = false;
            pb62.Visible = false;
            pb63.Visible = false;
            pb64.Visible = false;
            pb65.Visible = false;
            pb66.Visible = false;
            pb67.Visible = false;
            pb68.Visible = false;
            pb69.Visible = false;
            pbson6.Visible = false;
            pb71.Visible = false;
            pb72.Visible = false;
            pb73.Visible = false;
            pb74.Visible = false;
            pb75.Visible = false;
            pb76.Visible = false;
            pb77.Visible = false;
            pb78.Visible = false;
            pb79.Visible = false;
            pbson7.Visible = false;
            pb81.Visible = false;
            pb82.Visible = false;
            pb83.Visible = false;
            pb84.Visible = false;
            pb85.Visible = false;
            pb86.Visible = false;
            pb87.Visible = false;
            pb88.Visible = false;
            pb89.Visible = false;
            pbson8.Visible = false;
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
            sayac++;
            if (sayac == 1)
            {
                int a1, a2, toplam;
                a1 = rastgele.Next(1, 11);
                a2 = rastgele.Next(1, 11);
                label1.Text = a1.ToString();
                label2.Text = a2.ToString();
                toplam = a1 + a2;
                label10.Text = toplam.ToString();
            }
            if (sayac == 2)
            {
                int a3, toplam;
                a3 = rastgele.Next(1, 11);
                label3.Text = a3.ToString();
                toplam = Convert.ToInt32(label1.Text) + Convert.ToInt32(label2.Text) + a3;
                label10.Text = toplam.ToString();
                if (toplam >= 21)
                {
                    button1.Enabled = false;
                }
                if (toplam == 21)
                {
                    label13.Text = "BLACKJACK";
                }
            }
            if (sayac == 3)
            {
                int a4, toplam;
                a4 = rastgele.Next(1, 11);
                label4.Text = a4.ToString();
                toplam = Convert.ToInt32(label1.Text) + Convert.ToInt32(label2.Text) + Convert.ToInt32(label3.Text) + a4;
                label10.Text = toplam.ToString();
                button1.Enabled = false;
                if (toplam == 21)
                {
                    label13.Text = "BLACKJACK";
                }
            }
            if (label1.Text == "1")
            {
                pb11.Visible = true;
            }
            if (label1.Text == "2")
            {
                pb12.Visible = true;
            }
            if (label1.Text == "3")
            {
                pb13.Visible = true;
            }
            if (label1.Text == "4")
            {
                pb14.Visible = true;
            }
            if (label1.Text == "5")
            {
                pb15.Visible = true;
            }
            if (label1.Text == "6")
            {
                pb16.Visible = true;
            }
            if (label1.Text == "7")
            {
                pb17.Visible = true;
            }
            if (label1.Text == "8")
            {
                pb18.Visible = true;
            }
            if (label1.Text == "9")
            {
                pb19.Visible = true;
            }
            if (label1.Text == "10")
            {
                pbson1.Visible = true;
            }
            if (label2.Text == "1")
            {
                pb21.Visible = true;
            }
            if (label2.Text == "2")
            {
                pb22.Visible = true;
            }
            if (label2.Text == "3")
            {
                pb23.Visible = true;
            }
            if (label2.Text == "4")
            {
                pb24.Visible = true;
            }
            if (label2.Text == "5")
            {
                pb25.Visible = true;
            }
            if (label2.Text == "6")
            {
                pb26.Visible = true;
            }
            if (label2.Text == "7")
            {
                pb27.Visible = true;
            }
            if (label2.Text == "8")
            {
                pb28.Visible = true;
            }
            if (label2.Text == "9")
            {
                pb29.Visible = true;
            }
            if (label2.Text == "10")
            {
                pbson2.Visible = true;
            }
            if (label3.Text == "1")
            {
                pb31.Visible = true;
            }
            if (label3.Text == "2")
            {
                pb32.Visible = true;
            }
            if (label3.Text == "3")
            {
                pb33.Visible = true;
            }
            if (label3.Text == "4")
            {
                pb34.Visible = true;
            }
            if (label3.Text == "5")
            {
                pb35.Visible = true;
            }
            if (label3.Text == "6")
            {
                pb36.Visible = true;
            }
            if (label3.Text == "7")
            {
                pb37.Visible = true;
            }
            if (label3.Text == "8")
            {
                pb38.Visible = true;
            }
            if (label3.Text == "9")
            {
                pb39.Visible = true;
            }
            if (label3.Text == "10")
            {
                pbson3.Visible = true;
            }
            if (label4.Text == "1")
            {
                pb41.Visible = true;
            }
            if (label4.Text == "2")
            {
                pb42.Visible = true;
            }
            if (label4.Text == "3")
            {
                pb43.Visible = true;
            }
            if (label4.Text == "4")
            {
                pb44.Visible = true;
            }
            if (label4.Text == "5")
            {
                pb45.Visible = true;
            }
            if (label4.Text == "6")
            {
                pb46.Visible = true;
            }
            if (label4.Text == "7")
            {
                pb47.Visible = true;
            }
            if (label4.Text == "8")
            {
                pb48.Visible = true;
            }
            if (label4.Text == "9")
            {
                pb49.Visible = true;
            }
            if (label4.Text == "10")
            {
                pbson4.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayac2++;
            if (sayac2 == 1)
            {
                int b1, b2, toplam;
                b1 = rastgele.Next(1, 11);
                b2 = rastgele.Next(1, 11);
                label5.Text = b1.ToString();
                label6.Text = b2.ToString();
                toplam = b1 + b2;
                label12.Text = toplam.ToString();
            }
            if (sayac2 == 2)
            {
                int b3, toplam;
                b3 = rastgele.Next(1, 11);
                label7.Text = b3.ToString();
                toplam = Convert.ToInt32(label5.Text) + Convert.ToInt32(label6.Text) + b3;
                label12.Text = toplam.ToString();
                if (toplam >= 21)
                {
                    button2.Enabled = false;
                }
                if (toplam == 21)
                {
                    label14.Text = "BLACKJACK";
                }
            }
            if (sayac2 == 3)
            {
                int b4, toplam;
                b4 = rastgele.Next(1, 11);
                label8.Text = b4.ToString();
                toplam = Convert.ToInt32(label5.Text) + Convert.ToInt32(label6.Text) + Convert.ToInt32(label7.Text) + b4;
                label12.Text = toplam.ToString();
                button2.Enabled = false;
                if (toplam == 21)
                {
                    label14.Text = "BLACKJACK";
                }
            }
            if (label5.Text == "1")
            {
                pb51.Visible = true;
            }
            if (label5.Text == "2")
            {
                pb52.Visible = true;
            }
            if (label5.Text == "3")
            {
                pb53.Visible = true;
            }
            if (label5.Text == "4")
            {
                pb54.Visible = true;
            }
            if (label5.Text == "5")
            {
                pb55.Visible = true;
            }
            if (label5.Text == "6")
            {
                pb56.Visible = true;
            }
            if (label5.Text == "7")
            {
                pb57.Visible = true;
            }
            if (label5.Text == "8")
            {
                pb58.Visible = true;
            }
            if (label5.Text == "9")
            {
                pb59.Visible = true;
            }
            if (label5.Text == "10")
            {
                pbson5.Visible = true;
            }
            if (label6.Text == "1")
            {
                pb61.Visible = true;
            }
            if (label6.Text == "2")
            {
                pb62.Visible = true;
            }
            if (label6.Text == "3")
            {
                pb63.Visible = true;
            }
            if (label6.Text == "4")
            {
                pb64.Visible = true;
            }
            if (label6.Text == "5")
            {
                pb65.Visible = true;
            }
            if (label6.Text == "6")
            {
                pb66.Visible = true;
            }
            if (label6.Text == "7")
            {
                pb67.Visible = true;
            }
            if (label6.Text == "8")
            {
                pb68.Visible = true;
            }
            if (label6.Text == "9")
            {
                pb69.Visible = true;
            }
            if (label6.Text == "10")
            {
                pbson6.Visible = true;
            }
            if (label7.Text == "1")
            {
                pb71.Visible = true;
            }
            if (label7.Text == "2")
            {
                pb72.Visible = true;
            }
            if (label7.Text == "3")
            {
                pb73.Visible = true;
            }
            if (label7.Text == "4")
            {
                pb74.Visible = true;
            }
            if (label7.Text == "5")
            {
                pb75.Visible = true;
            }
            if (label7.Text == "6")
            {
                pb76.Visible = true;
            }
            if (label7.Text == "7")
            {
                pb77.Visible = true;
            }
            if (label7.Text == "8")
            {
                pb78.Visible = true;
            }
            if (label7.Text == "9")
            {
                pb79.Visible = true;
            }
            if (label7.Text == "10")
            {
                pbson7.Visible = true;
            }
            if (label8.Text == "1")
            {
                pb81.Visible = true;
            }
            if (label8.Text == "2")
            {
                pb82.Visible = true;
            }
            if (label8.Text == "3")
            {
                pb83.Visible = true;
            }
            if (label8.Text == "4")
            {
                pb84.Visible = true;
            }
            if (label8.Text == "5")
            {
                pb85.Visible = true;
            }
            if (label8.Text == "6")
            {
                pb86.Visible = true;
            }
            if (label8.Text == "7")
            {
                pb87.Visible = true;
            }
            if (label8.Text == "8")
            {
                pb88.Visible = true;
            }
            if (label8.Text == "9")
            {
                pb89.Visible = true;
            }
            if (label8.Text == "10")
            {
                pbson8.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            int birincitoplam, ikincitoplam;
            birincitoplam = Convert.ToInt32(label10.Text);
            ikincitoplam = Convert.ToInt32(label12.Text);
            if (birincitoplam > ikincitoplam && birincitoplam <= 21)
            {
                birincipuan = birincipuan + 10;
                label17.Text = birincipuan.ToString();
            }
            if (ikincitoplam > birincitoplam && ikincitoplam <= 21)
            {
                ikincipuan = ikincipuan + 10;
                label18.Text = ikincipuan.ToString();
            }
            if (birincitoplam == ikincitoplam && birincitoplam <= 21 && ikincitoplam <= 21)
            {
                birincipuan = birincipuan + 5;
                label17.Text = birincipuan.ToString();
                ikincipuan = ikincipuan + 5;
                label18.Text = ikincipuan.ToString();
            }
            if (birincitoplam > 21 && ikincitoplam > 21)
            {
                birincipuan = birincipuan + 0;
                label17.Text = birincipuan.ToString();
                ikincipuan = ikincipuan + 0;
                label18.Text = ikincipuan.ToString();
            }
            if (birincitoplam < ikincitoplam && ikincitoplam > 21 && birincitoplam <= 21)
            {
                birincipuan = birincipuan + 10;
                label17.Text = birincipuan.ToString();
            }
            if (ikincitoplam < birincitoplam && birincitoplam > 21 && ikincitoplam <= 21)
            {
                ikincipuan = ikincipuan + 10;
                label18.Text = ikincipuan.ToString();
            }          
            if (birincipuan >= 50)
            {
                label19.Text = ">>> 1.OYUNCU KAZANDI <<<";
                button4.Enabled = true;
                button3.Enabled = false;
                pbvic1.Visible = true;
                pbdef2.Visible = true;
                label22.Visible = false;
            }
            if (ikincipuan >= 50)
            {
                label19.Text = ">>> 2.OYUNCU KAZANDI <<<";
                button4.Enabled = true;
                button3.Enabled = false;
                pbdef1.Visible = true;
                pbvic2.Visible = true;
                label22.Visible = false;
            }
            metot();
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            metot();
            birincipuan = 0;
            ikincipuan = 0;
            label17.Text = "0";
            label18.Text = "0";
            label19.Text = "";
            button4.Enabled = false;
            pbdef1.Visible = false;
            pbvic2.Visible = false;
            pbdef2.Visible = false;
            pbvic1.Visible = false;
            label22.Visible = true;
        }
    }
}

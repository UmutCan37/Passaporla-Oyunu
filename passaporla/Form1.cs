using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passaporla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        int soruno=0,dogru=0,yanlis=0;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            { 
                switch (soruno) {
                    case 1:
                        if (textBox1.Text == "akdeniz")
                        {
                            button1.BackColor = Color.Green;
                            dogru++;
                            label2.Text=dogru.ToString();
                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            yanlis++;
                            label4.Text=yanlis.ToString();
                        }
                        break;
                    case 2:
                        if (textBox1.Text == "bursa")
                        {
                            button2.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 3:
                        if (textBox1.Text == "cuma")
                        {
                            button3.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 4:
                        if (textBox1.Text == "diyarbakır")
                        {
                            button4.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 5:
                        if (textBox1.Text == "eski")
                        {
                            button5.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                }
                    
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Sonraki";
            soruno++;
            this.Text=soruno.ToString();

            if (soruno == 1) {
                richTextBox1.Text = "Ülkemizin güney kısmındaki kıyı bölgesi?";
                button1.BackColor=Color.Yellow;


            }
            if (soruno == 2)
            {
                richTextBox1.Text = " Yeşilliği ünlü marmara ilimiz";
                button2.BackColor = Color.Yellow;


            }

            if (soruno == 3)
            {
                richTextBox1.Text = "Müslümanların kutsal günü";
                button3.BackColor = Color.Yellow;


            }

            if (soruno == 4)
            {
                richTextBox1.Text = "karpuzu ile ünlü ilimiz";
                button4.BackColor = Color.Yellow;



            }

            if (soruno == 5)
            {
                richTextBox1.Text = "yeni kelimesinin zıt anlamlısı";
                button5.BackColor = Color.Yellow;
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "padişahın emirlerinin yazılı olduğu kağıt?";
                button6.BackColor = Color.Yellow;


            }
            if (soruno == 7)
            {
                richTextBox1.Text = "dünyanın ısı kaynağı?";
                button7.BackColor = Color.Yellow;


            }
            if (soruno == 8)
            {
                richTextBox1.Text = "öğrencilerin kötü karne getirince bakıştığı nesne?";
                button8.BackColor = Color.Yellow;


            }
            if (soruno == 8)
            {
                richTextBox1.Text = "?";
                button8.BackColor = Color.Yellow;


            }
            if (soruno == 9)
            {
                richTextBox1.Text = "gülüyle ünlü ilimiz?";
                button9.BackColor = Color.Yellow;


            }
            if (soruno == 10)
            {
                richTextBox1.Text = "mersinin diğer ismi?";
                button24.BackColor = Color.Yellow;


            }
            if (soruno == 11)
            {
                richTextBox1.Text = "askeri bir topluluk?";
                button10.BackColor = Color.Yellow;


            }
            if (soruno == 12)
            {
                richTextBox1.Text = "malatyanın meşhur meyvesi?";
                button11.BackColor = Color.Yellow;


            }
            if (soruno == 13)
            {
                richTextBox1.Text = "her yıl bahar aylarında düzenlenen çiçek festivali?";
                button12.BackColor = Color.Yellow;


            }
            if (soruno == 14)
            {
                richTextBox1.Text = "yılın 3.ayı?";
                button13.BackColor = Color.Yellow;


            }
            if (soruno == 15)
            {
                richTextBox1.Text = "üflemeli bir müzik aleti?";
                button14.BackColor = Color.Yellow;


            }
            if (soruno == 16)
            {
                richTextBox1.Text = "halk şairi?";
                button15.BackColor = Color.Yellow;


            }
            if (soruno == 17)
            {
                richTextBox1.Text = "pirinç havuç gibi sbezleer ile yapılan yemek?";
                button19.BackColor = Color.Yellow;


            }
            if (soruno == 18)
            {
                richTextBox1.Text = "11 ayın sultanı?";
                button18.BackColor = Color.Yellow;


            }
            if (soruno == 19)
            {
                richTextBox1.Text = "ingilizce de yılan?";
                button17.BackColor = Color.Yellow;


            }
            if (soruno == 20)
            {
                richTextBox1.Text = "türkiyenin megastarı?";
                button16.BackColor = Color.Yellow;


            }
            if (soruno == 21)
            {
                richTextBox1.Text = "ümit kelimesinin eş anlamlısı?";
                button20.BackColor = Color.Yellow;


            }
            if (soruno == 22)
            {
                richTextBox1.Text = "kahvaltısı ile ünlü ilimiz?";
                button21.BackColor = Color.Yellow;


            }
            if (soruno == 23)
            {
                richTextBox1.Text = "şimsek kelimesinin eş anlamlısı?";
                button22.BackColor = Color.Yellow;


            }
            if (soruno == 24)
            {
                richTextBox1.Text = "ege bölgesinin en çok ağacı bulunan yağı da yapılan bir kahvaltı besini?";
                button23.BackColor = Color.Yellow;


            }
        }
    }
}

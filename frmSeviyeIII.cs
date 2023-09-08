using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TusBas
{
    public partial class frmSeviyeIII : Form
    {
        public frmSeviyeIII()
        {
            InitializeComponent();
        }

        public static int sure = 0;
        public static int skor = 0;
        public static int levelAtlama = 0;

        private void btnBasla_Click(object sender, EventArgs e)
        {
            if (sure > 0 && levelAtlama > 0)
            {
                Timer1.Interval = 1000;
                Timer1.Enabled = true;
                Timer1.Start();

                skor = 0;
                lblSkor.Text = "Skor:0";

                Random random = new Random();
                // 65 ile 90 arasında rastgele bir sayı üret
                int asciiValue = random.Next(65, 91);
                int asciiValue2 = random.Next(65, 91);
                int asciiValue3 = random.Next(65, 91);
                // Üretilen ASCII değerini karaktere dönüştür
                char randomChar = Convert.ToChar(asciiValue);
                char randomChar2 = Convert.ToChar(asciiValue2);
                char randomChar3 = Convert.ToChar(asciiValue3);
                lblHarf.Text = randomChar.ToString() + randomChar2.ToString() + randomChar3.ToString();
            }
            else
                MessageBox.Show("Lütfen Önce Ayarları Seçiniz!");
        }

        private void frmSeviyeIII_Load(object sender, EventArgs e)
        {
            btnSonrakiSeviye.Enabled = false;
        }

        private void btnSonrakiSeviye_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tebrikler, Oyunu Başarıyla Bitirdiniz.");

            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            sure = Convert.ToInt32(cmbBxSure.Text);
            levelAtlama = Convert.ToInt32(cmbBxSkor.Text);
            MessageBox.Show("Ayarlar Onaylandı.");

            lblAyarlar.Text = "Süre: " + sure + "sn | " + levelAtlama + " Skor Yap";

            cmbBxSure.Text = "";
            cmbBxSkor.Text = "";
            txtBx.Text = "";
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            sure -= 1;
            lblSure.Text = sure.ToString();
            if (sure <= 0)
            {
                Timer1.Stop();
                if (skor >= levelAtlama)
                {
                    btnSonrakiSeviye.Enabled = true;
                    MessageBox.Show("Tebrikler, Bu Leveli Geçebilirsiniz.");
                }
                else
                {
                    MessageBox.Show("Kaybettiniz!");
                    lblHarf.Text = "";
                    lblAyarlar.Text = "---- | ----";
                    lblSure.Text = "0";
                    lblSkor.Text = "Skor: 0";
                }
                lblOnceki.Text = "Önceki Skor: " + skor;
            }
            lblSure.ForeColor = Color.Black;
        }

        private void txtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (lblHarf.Text == txtBx.Text)
                {
                    Random random = new Random();
                    // 65 ile 90 arasında rastgele bir sayı üret
                    int asciiValue = random.Next(65, 91);
                    int asciiValue2 = random.Next(65, 91);
                    int asciiValue3 = random.Next(65, 91);
                    // Üretilen ASCII değerini karaktere dönüştür
                    char randomChar = Convert.ToChar(asciiValue);
                    char randomChar2 = Convert.ToChar(asciiValue2);
                    char randomChar3 = Convert.ToChar(asciiValue3);
                    if (randomChar.ToString() != lblHarf.Text)
                        lblHarf.Text = randomChar.ToString() + randomChar2.ToString() + randomChar3.ToString();
                    else
                    {
                        Random random2 = new Random();
                        // 65 ile 90 arasında rastgele bir sayı üret
                        int asciiValue4 = random2.Next(65, 91);
                        int asciiValue5 = random2.Next(65, 91);
                        int asciiValue6 = random2.Next(65, 91);
                        // Üretilen ASCII değerini karaktere dönüştür
                        char randomChar4 = Convert.ToChar(asciiValue4);
                        char randomChar5 = Convert.ToChar(asciiValue5);
                        char randomChar6 = Convert.ToChar(asciiValue6);
                        lblHarf.Text = randomChar4.ToString() + randomChar5.ToString() + randomChar6.ToString();
                    }
                    skor++;
                    txtBx.Text = "";
                }
                else
                {
                    lblSure.ForeColor = Color.Red;
                    sure -= 3;
                    skor--;
                }
                lblSkor.Text = "Skor: " + skor.ToString();
                e.Handled = true;
            }
        }
    }
}

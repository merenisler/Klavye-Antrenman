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
    public partial class frmSeviyeII : Form
    {
        public frmSeviyeII()
        {
            InitializeComponent();
        }

        public static int sure = 0;
        public static int skor = 0;
        public static int levelAtlama = 0;

        private void frmSeviyeII_Load(object sender, EventArgs e)
        {
            btnSonrakiSeviye.Enabled = false;
        }

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
                // Üretilen ASCII değerini karaktere dönüştür
                char randomChar = Convert.ToChar(asciiValue);
                char randomChar2 = Convert.ToChar(asciiValue2);
                lblHarf.Text = randomChar.ToString() + randomChar2.ToString();
            }
            else
                MessageBox.Show("Lütfen Önce Ayarları Seçiniz!");
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
                    // Üretilen ASCII değerini karaktere dönüştür
                    char randomChar = Convert.ToChar(asciiValue);
                    char randomChar2 = Convert.ToChar(asciiValue2);
                    if (randomChar.ToString() != lblHarf.Text)
                        lblHarf.Text = randomChar.ToString() + randomChar2.ToString();
                    else
                    {
                        Random random2 = new Random();
                        // 65 ile 90 arasında rastgele bir sayı üret
                        int asciiValue3 = random2.Next(65, 91);
                        int asciiValue4 = random2.Next(65, 91);
                        // Üretilen ASCII değerini karaktere dönüştür
                        char randomChar3 = Convert.ToChar(asciiValue3);
                        char randomChar4 = Convert.ToChar(asciiValue4);
                        lblHarf.Text = randomChar3.ToString() + randomChar4.ToString();
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

        private void btnSonrakiSeviye_Click(object sender, EventArgs e)
        {
            frmSeviyeIII frmSeviyeIII = new frmSeviyeIII();
            frmSeviyeIII.Show();
            this.Hide();
        }
    }
}

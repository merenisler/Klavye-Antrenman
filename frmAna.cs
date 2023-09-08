namespace TusBas
{
    public partial class Form1 : Form
    {
        public Form1()
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
                // 65 ile 90 arasýnda rastgele bir sayý üret
                int asciiValue = random.Next(65, 91);
                // Üretilen ASCII deðerini karaktere dönüþtür
                char randomChar = Convert.ToChar(asciiValue);
                lblHarf.Text = randomChar.ToString();
            }
            else
                MessageBox.Show("Lütfen Önce Ayarlarý Seçiniz!");
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
                    MessageBox.Show("Tebrikler, Bu Leveli Geçebilirsiniz.");
                    btnSonrakiSeviye.Enabled = true;
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
                    // 65 ile 90 arasýnda rastgele bir sayý üret
                    int asciiValue = random.Next(65, 91);
                    // Üretilen ASCII deðerini karaktere dönüþtür
                    char randomChar = Convert.ToChar(asciiValue);
                    if (randomChar.ToString() != lblHarf.Text)
                        lblHarf.Text = randomChar.ToString();
                    else
                    {
                        Random random2 = new Random();
                        // 65 ile 90 arasýnda rastgele bir sayý üret
                        int asciiValue2 = random2.Next(65, 91);
                        // Üretilen ASCII deðerini karaktere dönüþtür
                        char randomChar2 = Convert.ToChar(asciiValue2);
                        lblHarf.Text = randomChar2.ToString();
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

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSonrakiSeviye.Enabled = false;
        }


        private void btnSonrakiSeviye_Click(object sender, EventArgs e)
        {
            frmSeviyeII frmSeviyeII = new frmSeviyeII();
            frmSeviyeII.Show();
            this.Hide();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            sure = Convert.ToInt32(cmbBxSure.Text);
            levelAtlama = Convert.ToInt32(cmbBxSkor.Text);
            MessageBox.Show("Ayarlar Onaylandý.");

            lblAyarlar.Text = "Süre: " + sure + "sn | " + levelAtlama + " Skor Yap";

            cmbBxSure.Text = "";
            cmbBxSkor.Text = "";
            txtBx.Text = "";
        }
    }
}
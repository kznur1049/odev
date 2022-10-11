namespace geçti_kaldı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sbyte vize, final;
                double ortalama, vizeyuzde, finalyuzde, yuzdetoplamİ;
                vize = Convert.ToSByte(textBox1.Text);
                final = sbyte.Parse(textBox2.Text);
                vizeyuzde = Convert.ToDouble(textBox3.Text);
                finalyuzde = Convert.ToDouble(textBox4.Text);
                yuzdetoplamİ = vizeyuzde + finalyuzde;
                if (vize < 0 || vize > 100)
                {
                    MessageBox.Show("vize notu hatalıdır 0-100 arasında olmalıdır.");
                    label7.Visible = true;
                }
                else if (final < 0 || final > 100)
                {
                    MessageBox.Show("Final notu hatalıdır 0-100 arasında olmalıdır.");
                    label8.Visible = true;

                }
                else if (yuzdetoplamİ != 100)
                {
                    MessageBox.Show("Yüzdeler toplamı 100 olmalıdır.");
                }
                else if (finalyuzde < 50 || vizeyuzde > 50)
                {
                    MessageBox.Show("Vize ve Fina yüzdelerine dikkat et");
                    label11.Visible = true;
                    label12.Visible = true;

                }
                else
                {
                    vizeyuzde = Convert.ToDouble(textBox3.Text);
                    if (final < 0 || final > 100)
                    {
                        MessageBox.Show("Final notu hatalıdır 0-100 arasında olmalıdır.");
                        label8.Visible = true;

                    }

                    finalyuzde = Convert.ToDouble(textBox4.Text);
                    vizeyuzde = vizeyuzde / 100;
                    finalyuzde = finalyuzde / 100;
                    ortalama = vize * vizeyuzde + final * finalyuzde;
                    label9.Text = ortalama.ToString();
                    if (ortalama > 49.5 && final > 49.5)
                    {
                        label4.Text = "GEÇTİNİZ..";
                        label4.ForeColor = Color.Green;
                    }
                    else
                    {
                        label4.Text = "KALDINIZ..";
                        label4.ForeColor = Color.Red;
                    }
                    label5.Visible = true;
                    label4.Visible = true;
                    label6.Visible = true;
                    label9.Visible = true;
                    label7.Visible = false;
                    label8.Visible = false;
                    label11.Visible = false;
                    label12.Visible = false;

                }
            }
            catch
            {
                MessageBox.Show("Bir hata yaptın.");
            }
            finally
            {
                textBox1.Text = "0";
                textBox2.Text = "0";
                textBox3.Text= "0";
                textBox4.Text="0";
            }
            }
            

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Visible = false;
            label6.Visible = false;
            label5.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
        }

        private void label9_Click(object sender, EventArgs e)
        {


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
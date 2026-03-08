using System.Reflection.Emit;

namespace TP_MODUL3_103022430002
{
    public partial class Form1 : Form
    {
        int angkaPertama = 0; // Untuk menyimpan angka sebelum tombol + ditekan
        bool isInputBaru = true; // Penanda untuk mulai mengetik angka baru

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isInputBaru)
            {
                label1.Text = "1";
                isInputBaru = false;
            }
            else
            {
                label1.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isInputBaru)
            {
                label1.Text = "2";
                isInputBaru = false;
            }
            else
            {
                label1.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isInputBaru)
            {
                label1.Text = "3";
                isInputBaru = false;
            }
            else
            {
                label1.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (isInputBaru)
            {
                label1.Text = "4";
                isInputBaru = false;
            }
            else
            {
                label1.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (isInputBaru)
            {
                label1.Text = "5";
                isInputBaru = false;
            }
            else
            {
                label1.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (isInputBaru)
            {
                label1.Text = "6";
                isInputBaru = false;
            }
            else
            {
                label1.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (isInputBaru)
            {
                label1.Text = "7";
                isInputBaru = false;
            }
            else
            {
                label1.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (isInputBaru)
            {
                label1.Text = "8";
                isInputBaru = false;
            }
            else
            {
                label1.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (isInputBaru)
            {
                label1.Text = "9";
                isInputBaru = false;
            }
            else
            {
                label1.Text += "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            angkaPertama = int.Parse(label1.Text);
            isInputBaru = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (isInputBaru)
            {
                label1.Text = "0";
                isInputBaru = false;
            }
            else
            {
                label1.Text += "0";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int angkaKedua = int.Parse(label1.Text);
            label1.Text = (angkaPertama + angkaKedua).ToString();
            isInputBaru = true;
        }
    }
}
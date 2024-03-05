using System.Runtime.InteropServices;

namespace szamologep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string szamolas = "semmi";
        float elso_fel = 0;
        float masodik_fel = 0;
        bool szamolas_volt = false;
        bool kiszamoltuk = false;
        bool tort_e = false;

        private void egy_Click(object sender, EventArgs e)
        {
            if (szamolas_volt | kiszamoltuk) { textBox1.Text = 1.ToString(); }
            else { textBox1.Text += 1.ToString(); }
            szamolas_volt = false;
            kiszamoltuk = false;

        }

        private void ketto_Click(object sender, EventArgs e)
        {
            if (szamolas_volt | kiszamoltuk) { textBox1.Text = 2.ToString(); }
            else { textBox1.Text += 2.ToString(); }
            szamolas_volt = false;
            kiszamoltuk = false;
        }

        private void harom_Click(object sender, EventArgs e)
        {
            if (szamolas_volt | kiszamoltuk) { textBox1.Text = 3.ToString(); }
            else { textBox1.Text += 3.ToString(); }
            szamolas_volt = false;
            kiszamoltuk = false;
        }

        private void negy_Click(object sender, EventArgs e)
        {
            if (szamolas_volt | kiszamoltuk) { textBox1.Text = 4.ToString(); }
            else { textBox1.Text += 4.ToString(); }
            szamolas_volt = false;
            kiszamoltuk = false;
        }

        private void ot_Click(object sender, EventArgs e)
        {
            if (szamolas_volt | kiszamoltuk) { textBox1.Text = 5.ToString(); }
            else { textBox1.Text += 5.ToString(); }
            szamolas_volt = false;
            kiszamoltuk = false;
        }

        private void hat_Click(object sender, EventArgs e)
        {
            if (szamolas_volt | kiszamoltuk) { textBox1.Text = 6.ToString(); }
            else { textBox1.Text += 6.ToString(); }
            szamolas_volt = false;
            kiszamoltuk = false;
        }

        private void het_Click(object sender, EventArgs e)
        {
            if (szamolas_volt | kiszamoltuk) { textBox1.Text = 7.ToString(); }
            else { textBox1.Text += 7.ToString(); }
            szamolas_volt = false;
            kiszamoltuk = false;
        }

        private void nyolc_Click(object sender, EventArgs e)
        {
            if (szamolas_volt | kiszamoltuk) { textBox1.Text = 8.ToString(); }
            else { textBox1.Text += 8.ToString(); }
            szamolas_volt = false;
            kiszamoltuk = false;
        }

        private void kilenc_Click(object sender, EventArgs e)
        {
            if (szamolas_volt | kiszamoltuk) { textBox1.Text = 9.ToString(); }
            else { textBox1.Text += 9.ToString(); }
            szamolas_volt = false;
            kiszamoltuk = false;
        }

        private void nulla_Click(object sender, EventArgs e)
        {
            if (szamolas_volt | kiszamoltuk) { textBox1.Text = 0.ToString(); }
            else { textBox1.Text += 0.ToString(); }
            szamolas_volt = false;
            kiszamoltuk = false;
        }



        private void egyenloseg_Click(object sender, EventArgs e)
        {
            if (szamolas == "osszeadas")
            {
                masodik_fel = float.Parse(textBox1.Text);
                textBox1.Text = (elso_fel + masodik_fel).ToString();
            }
            if (szamolas == "kivonas")
            {
                masodik_fel = float.Parse(textBox1.Text);
                textBox1.Text = (elso_fel - masodik_fel).ToString();
            }
            if (szamolas == "szorzas")
            {
                masodik_fel = float.Parse(textBox1.Text);
                textBox1.Text = (elso_fel * masodik_fel).ToString();
            }
            if (szamolas == "osztas")
            {
                masodik_fel = float.Parse(textBox1.Text);
                textBox1.Text = (elso_fel / masodik_fel).ToString();
            }


            tort_e = false;
            kiszamoltuk = true;
        }

        private void osszeadas_Click(object sender, EventArgs e)
        {
            elso_fel = float.Parse(textBox1.Text);
            szamolas = "osszeadas";
            szamolas_volt = true;
            tort_e = false;
        }

        private void kivonas_Click(object sender, EventArgs e)
        {
            elso_fel = float.Parse(textBox1.Text);
            szamolas = "kivonas";
            szamolas_volt = true;
            tort_e = false;
        }

        private void szorzas_Click(object sender, EventArgs e)
        {
            elso_fel = float.Parse(textBox1.Text);
            szamolas = "szorzas";
            szamolas_volt = true;
            tort_e = false;
        }

        private void osztas_Click(object sender, EventArgs e)
        {
            elso_fel = float.Parse(textBox1.Text);
            szamolas = "osztas";
            szamolas_volt = true;
            tort_e = false;
        }

        private void elojel_Click(object sender, EventArgs e)
        {
            textBox1.Text = (0 - float.Parse(textBox1.Text)).ToString();
        }

        private void tort_Click(object sender, EventArgs e)
        {
            if (tort_e == false)
            {
                textBox1.Text += ",";
                tort_e = true;
            }


        }

        private void delete_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            //commit
        }
    }
}

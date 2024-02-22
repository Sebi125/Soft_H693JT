using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Sor> sorok = new List<Sor>();

            for (int i = 0; i < 10; i++)
            {
                Sor újSor = new Sor();
                újSor.Sorszám = i;
                újSor.Érték = Fibonacci(i);

                sorok.Add(újSor);
            }
            dataGridView1.DataSource = sorok;


            List<Button> buttons = new List<Button>();
            for (int sor = 0; sor < 10; sor++)
            {
                Button button = new Button();
                button.Top = sor * 40;
                button.Width = 40;
                button.Height = 40;
                button.Text = Fibonacci(sor).ToString();

                Controls.Add(button);

            }
        }
        int Fibonacci(int n) 
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}

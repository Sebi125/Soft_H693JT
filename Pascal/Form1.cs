namespace Pascal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int n = 40;
            for (int sor = 0; sor < 10; sor++)
            {
                for (int oszlop = 0; oszlop < sor+1; oszlop++)
                {
                    Button button = new Button();
                    Controls.Add(button);
                    button.Top = sor * n;
                    button.Left = oszlop * n - sor * n / 2 + Width/2;
                    button.Width = n;
                    button.Height = n;
                    int x = Faktori�lis(sor) / (Faktori�lis(oszlop) * Faktori�lis(sor - oszlop));
                    button.Text = x.ToString();
                    // csak irok ide hogy megnezzem a commitot:)
                }
            }
        }

        int Faktori�lis(int n)
        {
            if (n == 0) return 1;
            return n * Faktori�lis(n - 1);
        }

    }
}
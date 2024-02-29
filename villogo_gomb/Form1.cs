namespace villogo_gomb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            for (int oszlop = 0; oszlop < 10; oszlop++)
            {
                for (int sor = 0; sor < 10; sor++)
                {
                    Villogogomb villogogomb = new Villogogomb();
                    villogogomb.Left = oszlop * 40;
                    villogogomb.Top = sor * 40;
                    villogogomb.Width = 40;
                    villogogomb.Height = 40;

                    Controls.Add(villogogomb);
                }
            }
        }
    }
}
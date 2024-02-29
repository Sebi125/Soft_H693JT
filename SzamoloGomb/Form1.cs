namespace SzamoloGomb
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
                    SzamoloGomb szamologomb = new SzamoloGomb();
                    szamologomb.Left = oszlop * 40;
                    szamologomb.Top = sor * 40;
                    

                    Controls.Add(szamologomb);
                }
            }
        }
    }
}
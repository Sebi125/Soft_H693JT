namespace KigyosJatek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int fej_x = 100;
        int fej_y = 100;

        int irány_x = 1;
        int irány_y = 0;

        int lépésszám = 0;

        List<KígyóElem> kígyó = new List<KígyóElem>();


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lépésszám++;

            //Fejnövesztés
            fej_x += irány_x * KígyóElem.Méret;
            fej_y += irány_y * KígyóElem.Méret;
            KígyóElem ke = new KígyóElem();
            kígyó.Add(ke); //Amikor új fejet neveztünk a kígyónak, azt beletesszük a `kígyó` listába is ..
            Controls.Add(ke); //.. és az ûrlap vezérlõinek a listájába is

            foreach (object item in Controls)
            {
                if (item is KígyóElem)
                {
                    KígyóElem k = (KígyóElem)item;

                    if (k.Top == fej_y && k.Left == fej_x)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }
            }


            int hossz = KígyóElem.Hossz;

            //Farokvágás
            if (kígyó.Count > hossz)
            {
                KígyóElem levágandó = kígyó[0];
                Controls.Remove(levágandó);
                kígyó.RemoveAt(0);
            }

            ke.Top = fej_y;
            ke.Left = fej_x;

            if(lépésszám % 2 == 0) ke.BackColor = Color.Yellow;

            Random rnd = new Random();
            int spawn = rnd.Next(0, 10);

            Méreg m = new Méreg();
            if (spawn == 0)
            {
               
                m.Top = 10*rnd.Next(1, 10);
                m.Left = 10*rnd.Next(1, 10);
                Controls.Add(m);
            }
            
            foreach (object item in Controls)
            {
                if (item is Méreg)
                {
                    Méreg mé = (Méreg)item;

                    if (fej_x == mé.Top & fej_y == mé.Left)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                irány_y = -1;
                irány_x = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                irány_y = 1;
                irány_x = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                irány_y = 0;
                irány_x = -1;
            }

            if (e.KeyCode == Keys.Right)
            {
                irány_y = 0;
                irány_x = 1;
            }
        }
    }
}
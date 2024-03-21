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

        int ir�ny_x = 1;
        int ir�ny_y = 0;

        int l�p�ssz�m = 0;

        List<K�gy�Elem> k�gy� = new List<K�gy�Elem>();


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            l�p�ssz�m++;

            //Fejn�veszt�s
            fej_x += ir�ny_x * K�gy�Elem.M�ret;
            fej_y += ir�ny_y * K�gy�Elem.M�ret;
            K�gy�Elem ke = new K�gy�Elem();
            k�gy�.Add(ke); //Amikor �j fejet nevezt�nk a k�gy�nak, azt beletessz�k a `k�gy�` list�ba is ..
            Controls.Add(ke); //.. �s az �rlap vez�rl�inek a list�j�ba is

            foreach (object item in Controls)
            {
                if (item is K�gy�Elem)
                {
                    K�gy�Elem k = (K�gy�Elem)item;

                    if (k.Top == fej_y && k.Left == fej_x)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }
            }


            int hossz = K�gy�Elem.Hossz;

            //Farokv�g�s
            if (k�gy�.Count > hossz)
            {
                K�gy�Elem lev�gand� = k�gy�[0];
                Controls.Remove(lev�gand�);
                k�gy�.RemoveAt(0);
            }

            ke.Top = fej_y;
            ke.Left = fej_x;

            if(l�p�ssz�m % 2 == 0) ke.BackColor = Color.Yellow;

            Random rnd = new Random();
            int spawn = rnd.Next(0, 10);

            M�reg m = new M�reg();
            if (spawn == 0)
            {
               
                m.Top = 10*rnd.Next(1, 10);
                m.Left = 10*rnd.Next(1, 10);
                Controls.Add(m);
            }
            
            foreach (object item in Controls)
            {
                if (item is M�reg)
                {
                    M�reg m� = (M�reg)item;

                    if (fej_x == m�.Top & fej_y == m�.Left)
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
                ir�ny_y = -1;
                ir�ny_x = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                ir�ny_y = 1;
                ir�ny_x = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                ir�ny_y = 0;
                ir�ny_x = -1;
            }

            if (e.KeyCode == Keys.Right)
            {
                ir�ny_y = 0;
                ir�ny_x = 1;
            }
        }
    }
}
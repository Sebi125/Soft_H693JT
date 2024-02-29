namespace randomGombok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 101; i++)
            {
                Button button = new Button();
                button.Left = rnd.Next(1, ClientRectangle.Width);
                button.Top = rnd.Next(1, ClientRectangle.Height);
                button.Width = rnd.Next(1, 10);
                button.Height = rnd.Next(1, 10);
                button.BackColor = Color.FromArgb(rnd.Next(1, 256), rnd.Next(1, 256), rnd.Next(1, 256));

                Controls.Add(button);
            }
        }
    }
}
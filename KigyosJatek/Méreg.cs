using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KigyosJatek
{
    internal class Méreg: PictureBox
    {
        public Méreg() 
        {
            Width = KígyóElem.Méret;
            Height = KígyóElem.Méret;
            BackColor = Color.DarkGreen;
        }
    }
}

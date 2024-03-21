using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KigyosJatek
{
    internal class KígyóElem: PictureBox
    {
        public static int Méret = 20;
        public static int Hossz = 5;

        public KígyóElem()
        {
            Width = KígyóElem.Méret;
            Height = KígyóElem.Méret;
            BackColor = Color.Fuchsia;
        }
    }
}

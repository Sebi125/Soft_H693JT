﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KigyosJatek
{
    internal class Kaja: PictureBox
    {
        public Kaja()
        {
            Width = KígyóElem.Méret;
            Height = KígyóElem.Méret;
            BackColor = Color.Red;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ScreenSaver
{
    public class ScrParameters
    {
        public string entite { get; set; } = "entity name";
        public string systeme { get; set; } = "System Name";
        public string classification { get; set; } = "Restricted Access";
        public int CouleurClassif { get; set; } = Color.DarkRed.ToArgb();
        public string mentions { get; set; } = "place here legal mentions about accessing this system";
        public string imgPath { get; set; } = "";

    }
}

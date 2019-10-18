using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Toller
{
    public class Desk
    {

        public const double MINWIDTH = 24;
        public const double MAXWIDTH = 96;
        public const double MINDEPTH = 12;
        public const double MAXDEPTH = 48;
        public const int MAXDRAWERS = 7;

        public double width { get; set; }
        public  double depth { get; set; }
        public int drawers { get; set; }
        public string customerName { get; set; }
        public string quoteDate { get; set; }


        public DesktopMaterial DeskMaterial { get; set; }


    }
}

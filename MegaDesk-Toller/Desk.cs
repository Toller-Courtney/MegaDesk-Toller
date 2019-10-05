using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Toller
{
    class Desk
    {
        public const double MINWIDTH = 24;
        public const double MAXWIDTH = 96;
        public const double MINDEPTH = 12;
        public const double MAXDEPTH = 48;
        public const int MAXDRAWERS = 7;
        
        public static double width { get; set; }
        public static double depth { get; set; }
        public static int drawers { get; set; }


       public static DesktopMaterial DeskMaterial { get; set; }

        /*Enums for my desktop material*/
        public enum DesktopMaterial:int
        {
            oak = 200,
            laminate = 100,
            pine = 50,
            rosewood = 300,
            veneer = 125
        }
        
        

    }
}

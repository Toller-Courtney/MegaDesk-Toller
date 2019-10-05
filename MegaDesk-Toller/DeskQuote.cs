using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MegaDesk_Toller.Desk;

namespace MegaDesk_Toller
{
    class DeskQuote : Desk
    {
        public const int BASECOST = 200;
        private const int DRAWERCOST = 50;
        private const int SMALLDESK = 1000;
        private const int LARGEDESK = 2000;
        private const int THREEDAYRUSH = 3;
        private const int FIVEDAYRUSH = 5;
        private const int SEVENDAYRUSH = 7;

        
        public int RushDays { get; set; }
        public string customerName { get; set; }
        public string quoteDate { get; set; }
        public double quoteTotal { get; set; }

        public DeskQuote(double width, double depth, int drawers, int materialList, int rushDays)
        {
            //var desktopMaterial = Desk.DesktopMaterial;
            Desk.width = width;
            Desk.depth = depth;
            Desk.drawers = drawers;
            //Desk.DesktopMaterial = materialList;
            RushDays = rushDays;

        }

     
        public double calcSurfaceArea()
        {
           double surfaceArea = width + depth;
            return surfaceArea;
        }
        /*This method calculations the shipping cost based on the surface area
         of the desk and that days seleced for rush order*/
        public double calcShippingRate()
        {
            int shippingRate = 0;
            if(calcSurfaceArea()<SMALLDESK && RushDays == THREEDAYRUSH)
            {
                shippingRate = 60;
            }
            //calculate3 day shipping
            else if ((calcSurfaceArea() > SMALLDESK && calcSurfaceArea() < LARGEDESK) && RushDays == THREEDAYRUSH)
            {
                shippingRate = 70;
            }
            else if (calcSurfaceArea() > LARGEDESK && RushDays == THREEDAYRUSH)
            {
                shippingRate = 80;
                //calculate 5 day shipping
            }else if(calcSurfaceArea()<SMALLDESK && RushDays == FIVEDAYRUSH)
            {
                shippingRate = 40;
            }else if((calcSurfaceArea()>SMALLDESK &&calcSurfaceArea()< LARGEDESK) && RushDays == FIVEDAYRUSH)
            {
                shippingRate = 50;
            }else if (calcSurfaceArea() > LARGEDESK && RushDays == FIVEDAYRUSH)
            {
                shippingRate = 60;
                //calculate 7 day shipping
            }else if(calcSurfaceArea()<SMALLDESK && RushDays == SEVENDAYRUSH)
            {
                shippingRate = 30;
            }else if ((calcSurfaceArea() > SMALLDESK &&calcSurfaceArea()< LARGEDESK) && RushDays == SEVENDAYRUSH)
            {
                shippingRate = 35;
            }else if (calcSurfaceArea() > LARGEDESK && RushDays == SEVENDAYRUSH)
            {
                shippingRate = 40;
            }
            return shippingRate;

        }
        
        public double calcSurfaceAreaCost()
        {
            if (calcSurfaceArea() > SMALLDESK)
            {
                return calcSurfaceArea() * 1;
            }
            else if (calcSurfaceArea() > SMALLDESK && calcSurfaceArea() < LARGEDESK)
            {
                return calcSurfaceArea() * 2;
            }
            else
                return calcSurfaceArea() * 3;

        } 
        public int calcDrawerCost()
        {
            return drawers * DRAWERCOST;
        }
        
        public int materialList()
        {
            foreach (int i in Enum.GetValues(typeof(DesktopMaterial)))
                return i;


        }
        public double calcQuoteTotal()
        {
            double quoteTotal = BASECOST + calcDrawerCost() + calcSurfaceAreaCost() + materialList() + calcShippingRate();
        }

    }
 
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MegaDesk_Toller.Desk;

namespace MegaDesk_Toller
{
    public class DeskQuote : Desk
    {
        public const int BASECOST = 200;
        private const int DRAWERCOST = 50;
        private const int SMALLDESK = 1000;
        private const int LARGEDESK = 2000;
        public const int THREEDAYRUSH = 3;
        public const int FIVEDAYRUSH = 5;
        public const int SEVENDAYRUSH = 7;



        public int RushDays { get; set; }
        public double quoteTotal { get; set; }




        public DeskQuote(string customerName, double width, double depth, int drawers, DesktopMaterial materialList, int rushDays, string quoteDate)
        {
            this.customerName = customerName;
            this.width = width;
            this.depth = depth;
            this.drawers = drawers;
            RushDays = rushDays;
            DeskMaterial = materialList;
            this.quoteDate = quoteDate;

        }


        public double calcSurfaceArea()
        {
            double surfaceArea = width * depth;
            return surfaceArea;
        }
        /*This method calculations the shipping cost based on the surface area
         of the desk and the days seleced for rush order from the txt file.
         using a 3x3 dimension array*/
      
       public int getRushOrder()
        {
            try
            {
                
                string rushDayFilePath = @"rushOrderPrices.txt";
                string[] prices = File.ReadAllLines(rushDayFilePath);
                int[,] rushOrderPrice = new int[3, 3];
                int shippingRate = 0;

                for (int i=0; i<1; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {


                        if ((calcSurfaceArea() < SMALLDESK) && RushDays == THREEDAYRUSH)
                        {
                            shippingRate = rushOrderPrice[0, 0];
                        }
                        else if ((calcSurfaceArea() > SMALLDESK && calcSurfaceArea() < LARGEDESK) && RushDays == THREEDAYRUSH)
                        {
                            shippingRate = rushOrderPrice[0, 1];
                        }
                        else if ((calcSurfaceArea() < LARGEDESK) && RushDays == THREEDAYRUSH)
                        {
                            shippingRate = rushOrderPrice[0, 2];
                        } else if (calcSurfaceArea() < SMALLDESK && RushDays == FIVEDAYRUSH)
                        {
                            shippingRate = rushOrderPrice[1, 0];
                        }
                        else if ((calcSurfaceArea() > SMALLDESK && calcSurfaceArea() < LARGEDESK) && RushDays == FIVEDAYRUSH)
                        {
                            shippingRate = rushOrderPrice[1, 1];
                        }
                        else if (calcSurfaceArea() > LARGEDESK && RushDays == FIVEDAYRUSH)
                        {
                            shippingRate = rushOrderPrice[1, 2];
                        }
                        else if (calcSurfaceArea() < SMALLDESK && RushDays == SEVENDAYRUSH)
                        {
                            shippingRate = rushOrderPrice[2, 0];
                        }
                        else if ((calcSurfaceArea() > SMALLDESK && calcSurfaceArea() < LARGEDESK) && RushDays == SEVENDAYRUSH)
                        {
                            shippingRate = rushOrderPrice[2, 1];
                        }
                        else if (calcSurfaceArea() > LARGEDESK && RushDays == SEVENDAYRUSH)
                        {
                            shippingRate = rushOrderPrice[2, 2];
                        }


                    }
                   
                }
                return shippingRate;
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        /* this is calculating the surface area of the desk*/
        public double calcSurfaceAreaCost()
        {
            if (calcSurfaceArea() > SMALLDESK)
            {
                return calcSurfaceArea() + (calcSurfaceArea() - SMALLDESK);
            }
            return calcSurfaceArea();
        }
        public int calcDrawerCost()
        {
            return drawers * DRAWERCOST;
        }

        /*This is setting the price with the desktop material name to display*/
        private int getMaterialCost()
        {
            try
            {
                switch (DeskMaterial)
                {
                    case DesktopMaterial.Oak: return (int)DesktopMaterial.Oak;
                    case DesktopMaterial.Laminate: return (int)DesktopMaterial.Laminate;
                    case DesktopMaterial.Pine: return (int)DesktopMaterial.Pine;
                    case DesktopMaterial.Rosewood: return (int)DesktopMaterial.Rosewood;
                    case DesktopMaterial.Veneer: return (int)DesktopMaterial.Veneer;
                    default:
                        throw new Exception("Material not found.");

                }
            }
            catch (Exception ex)
            {
                return 50;

            }
        }
      /* This calculates the quote total*/
        public double calcQuoteTotal()
        {
            quoteTotal = BASECOST + calcDrawerCost() + calcSurfaceAreaCost() + getMaterialCost() + getRushOrder();
            return quoteTotal;
        }
        public string GetDate()
        {
            return quoteDate;
        }

    }
   

}

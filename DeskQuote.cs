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
        //public string quoteDate { get; set; }
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
         of the desk and that days seleced for rush order*/
        public double calcShippingRate(int days, int surfaceArea)
        {
            int shippingRate = 0;

            switch (days)
            {
                case 3:
                    if (calcSurfaceArea() < SMALLDESK)
                    {
                        shippingRate = getRushOrder()[0, 0];
                    }
                    else if (calcSurfaceArea() > SMALLDESK && calcSurfaceArea() < LARGEDESK)
                    {
                        shippingRate = getRushOrder()[0, 1];
                    }
                    else
                    {
                        shippingRate = getRushOrder()[0, 2];
                    }
                    break;

                case 5:
                    if (calcSurfaceArea() < SMALLDESK)
                    {
                        shippingRate = getRushOrder()[1, 0];
                    }
                    else if (calcSurfaceArea() > SMALLDESK && calcSurfaceArea() < LARGEDESK)
                    {
                        shippingRate = getRushOrder()[1, 1];
                    }
                    else
                    {
                        shippingRate = getRushOrder()[1, 2];
                    }
                    break;
                case 7:
                    if (calcSurfaceArea() < SMALLDESK)
                    {
                        shippingRate = getRushOrder()[2, 0];
                    }
                    else if (calcSurfaceArea() > SMALLDESK && calcSurfaceArea() < LARGEDESK)
                    {
                        shippingRate = getRushOrder()[2, 1];
                    }
                    else
                    {
                        shippingRate = getRushOrder()[2, 2];
                    }
                    break;
                default:
                    shippingRate = 0;
                    break;
            
        }
            return shippingRate;
    
            //calculate3 day shipping
           /* if (calcSurfaceArea() < SMALLDESK && RushDays == THREEDAYRUSH)
            {
                shippingRate = 0;
            }

            else if ((calcSurfaceArea() > SMALLDESK && calcSurfaceArea() < LARGEDESK) && RushDays == THREEDAYRUSH)
            {
                shippingRate = 70;
            }
            else if (calcSurfaceArea() > LARGEDESK && RushDays == THREEDAYRUSH)
            {
                shippingRate = 80;
                //calculate 5 day shipping
            }
            else if (calcSurfaceArea() < SMALLDESK && RushDays == FIVEDAYRUSH)
            {
                shippingRate = 40;
            }
            else if ((calcSurfaceArea() > SMALLDESK && calcSurfaceArea() < LARGEDESK) && RushDays == FIVEDAYRUSH)
            {
                shippingRate = 50;
            }
            else if (calcSurfaceArea() > LARGEDESK && RushDays == FIVEDAYRUSH)
            {
                shippingRate = 60;
                //calculate 7 day shipping
            }
            else if (calcSurfaceArea() < SMALLDESK && RushDays == SEVENDAYRUSH)
            {
                shippingRate = 30;
            }
            else if ((calcSurfaceArea() > SMALLDESK && calcSurfaceArea() < LARGEDESK) && RushDays == SEVENDAYRUSH)
            {
                shippingRate = 35;
            }
            else if (calcSurfaceArea() > LARGEDESK && RushDays == SEVENDAYRUSH)
            {
                shippingRate = 40;
            }
            return shippingRate;*/

        }
        
        // instead of using the above calShippingRate() I have to use the "rushOrderPrices.txt" file to read in the appropriate price
        // I have to us a 3x3 dimension array in try catch block with the readAllLines to get single dimension array 
        //use nested loops to populate two dimensional arry with 3 rows 3 columns.

       public int[,] getRushOrder()
        {
            try
            {
                string rushDayFilePath = @"rushOrderPrices.txt";
                string[] prices = File.ReadAllLines(rushDayFilePath);
                // var grid = new List<List<string>>();
                int[,] rushOrderPrice = new int[3, 3];

                for (int i=0; i<3; i++)
                {
                    //var subList = new List<string>();
                    for (int j=0; j<3; j++)
                    {
                        rushOrderPrice[i, j] = Int32.Parse(prices[(i * 3) + j]);
                        //subList.Add(prices[i + j + 1]);
                    }
                    //grid.Add(subList);
                }
                return rushOrderPrice;
            }
            catch (Exception)
            {

                throw;
            }
            
        }
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

        private int getMaterialCost()
        {
            try
            {
                switch (DeskMaterial)
                {
                    case DesktopMaterial.oak: return (int)DesktopMaterial.oak;
                    case DesktopMaterial.laminate: return (int)DesktopMaterial.laminate;
                    case DesktopMaterial.pine: return (int)DesktopMaterial.pine;
                    case DesktopMaterial.rosewood: return (int)DesktopMaterial.rosewood;
                    case DesktopMaterial.veneer: return (int)DesktopMaterial.veneer;
                    default:
                        throw new Exception("Material not found.");

                }
            }
            catch (Exception ex)
            {
                return 50;

            }
        }
      
        public double calcQuoteTotal()
        {
            quoteTotal= BASECOST + calcDrawerCost() + calcSurfaceAreaCost() + getMaterialCost() + calcShippingRate();
            return quoteTotal;
        }
        public string GetDate()
        {
            return quoteDate;
        }

    }
   

}

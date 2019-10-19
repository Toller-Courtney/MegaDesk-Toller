using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Toller
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
        }

        private void AllQuotesReturnToMain_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }

        private void ViewAllQuotesExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //This is reading from the json file and displaying the the infomration that I have specified to the screen in a grid view.
        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {
            try
            {
                var orderFile = @"quote.json";

                using (StreamReader reader = new StreamReader(orderFile))
                {
                    string newQuotes = reader.ReadToEnd();
                    List<DeskQuote> deskOrders = JsonConvert.DeserializeObject<List<DeskQuote>>(newQuotes);

                    viewAllQuotesGrid.DataSource = deskOrders.Select(desk => new
                    {
                       
                        Date = desk.quoteDate,
                        Customer = desk.customerName,
                        Width = desk.width,
                        Depth = desk.depth,
                        Drawers = desk.drawers,
                        Material = desk.DeskMaterial,
                        RushOrder = desk.RushDays,
                        Total = desk.calcQuoteTotal()

                    })

                    .ToList();
                }
            }

            catch (Exception)
            {

                throw;
            }
           
           

         
        }
    }
}

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
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
            materialSearchBox.DataSource = Enum.GetValues(typeof(DesktopMaterial));
        }

        private void SearchQuotesReturnToMain_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }

    

        private void materialSearchBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if desktop material matches selection, display from json file.


            
        }

        private void SearchQuotes_Load(object sender, EventArgs e)
        {
            //load the quotes with the correct material selected by user
            //Pull the quotes from the quote.json file that match the users selection.
            //example if oak is selected, search through file and pull only oak to display on screen
            try
            {
                var orderFile = @"quote.json";

                using (StreamReader reader = new StreamReader(orderFile))
                {
                    string newQuotes = reader.ReadToEnd();
                    List<DeskQuote> deskOrders = JsonConvert.DeserializeObject<List<DeskQuote>>(newQuotes);
                    SearchGridView.DataSource = deskOrders.Select(desk => new
                    {
                        Date = desk.quoteDate,
                        Customer = desk.customerName,
                        Width = desk.width,
                        Depth = desk.depth,
                        Drawers = desk.drawers,
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

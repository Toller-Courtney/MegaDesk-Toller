using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Toller
{
    public partial class DisplayQuote : Form
    {
        DeskQuote Quote;
        public DisplayQuote()
        {
            InitializeComponent();
            displayQuoteDateLabel.Text = DateTime.Now.ToString("dd MMM yyy");
        }
       public DisplayQuote(DeskQuote quote):this()
            {
            Quote = quote;
            }


        private void DisplayQuoteReturnToMain_Click(object sender, EventArgs e)
        {
           
           MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();

        }

      
        private void DisplayQuoteExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            userInputDisplayLabel.Text =Quote.customerName;
            userInputWidthLabel.Text = Quote.width.ToString();
            depthInputLabel.Text = Quote.depth.ToString();
            drawerInputLabel.Text = Quote.drawers.ToString();
            materialInputLabel.Text = Quote.DeskMaterial.ToString();
            rushDayInputLabel.Text = Quote.RushDays.ToString();
            displayQuoteDate.Text = Quote.GetDate();
            totalOutputLabel.Text = Quote.calcQuoteTotal().ToString();

        }
    }
}

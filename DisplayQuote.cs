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
            //Figure out why this isn't working and doesn't return to main. I think it is because tag is already being used from
            //addQuote to display this form and it is getting confused.All my other return to main menus work except this one. 
           MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();

        }

        private void Quotedate_Tick(object sender, EventArgs e)
        {
           // DateTime date = DateTime.Now;
           // displayQuoteDateLabel.Text = date.ToString("dd MMM yyy");
        }

        private void DisplayQuoteExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DisplayQuoteDateLabel_Click(object sender, EventArgs e)
        {

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

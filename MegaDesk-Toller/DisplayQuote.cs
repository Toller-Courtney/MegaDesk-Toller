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
        public DisplayQuote()
        {
            InitializeComponent();
            displayQuoteDateLabel.Text = DateTime.Now.ToString("dd MMM yyy");
        }

        private void DisplayQuoteReturnToMain_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }

        private void Quotedate_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            displayQuoteDateLabel.Text= date.ToString("dd MMM yyy");
        }

        private void DisplayQuoteExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DisplayQuoteDateLabel_Click(object sender, EventArgs e)
        {

        }

        
    }
}

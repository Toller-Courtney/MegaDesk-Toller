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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void AddNewQuoteButton_Click(object sender, EventArgs e)
        {
            AddQuote viewAddQuote = new AddQuote();
            viewAddQuote.Tag = this;
            viewAddQuote.Show(this);
            Hide();
        }

        private void ViewAllQuotesButton_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewQuotes = new ViewAllQuotes();
            viewQuotes.Tag = this;
            viewQuotes.Show(this);
            Hide();
        }

        private void SearchQuotesButton_Click(object sender, EventArgs e)
        {
             SearchQuotes searchAllQuotes = new SearchQuotes();
            searchAllQuotes.Tag = this;
            searchAllQuotes.Show(this);
            Hide();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
} 

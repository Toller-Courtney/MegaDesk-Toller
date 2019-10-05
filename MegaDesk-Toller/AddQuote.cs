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
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            
            InitializeComponent();
            DesktopMaterial.DataSource = Enum.GetValues(typeof(Desk.DesktopMaterial));
            

        }

        private void AddQuoteReturnToMainButton_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }

        private void AddNewQuoteExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DeskMaterialDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

           



        }

        private void SubmitQuoteButton_Click(object sender, EventArgs e)
        {
            /*  DisplayQuote viewDisplayQuote = new DisplayQuote();
              viewDisplayQuote.Tag = this;
              viewDisplayQuote.Show(this);
              Hide();*/

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                //MessageBox.Show(customerName.Text, "Name Field is Required");
                //MessageBox.Show(width.Text, "Width Size is out of range");
               // MessageBox.Show(depth.Text, "Depth size is out of range");
            }
            
        }

        private void Width_Validating(object sender, CancelEventArgs e)
        {
            if ((Width< Desk.MINWIDTH && Width > Desk.MAXWIDTH))
            {
                e.Cancel = true;
                width.Focus();
                widthError.SetError(width, "Width must be between 24 and 96 inches");
            }
            else e.Cancel = false;
            widthError.SetError(width, "");
        }


        private void Depth_KeyPress(object sender, KeyPressEventArgs e)


        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void CustomerName_Validating(object sender, CancelEventArgs e)
        {
           if(string.IsNullOrWhiteSpace(customerName.Text))
            {
                e.Cancel = true;
                customerName.Focus();
                nameError.SetError(customerName, "Name is a required field");

            }
            else
            {
                e.Cancel = false;
                nameError.SetError(customerName, "");
            }
        }

        private void Depth_Validating(object sender, CancelEventArgs e)
        {
           //double temp = double.Parse(depth.Text);

            
            if ((Desk.depth< Desk.MINDEPTH && Desk.depth> Desk.MAXDEPTH))
            {
                e.Cancel = true;
                depth.Focus();
                depthError.SetError(depth, "Depth must be between 12 and 48 inches");
            }
            else
                e.Cancel = false;
                depthError.SetError(depth, "");
        }

        private void Width_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }
    }
}

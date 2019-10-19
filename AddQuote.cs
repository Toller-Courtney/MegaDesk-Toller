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
    public partial class AddQuote : Form

    {
        private double ToDouble(string str) { double value; if (double.TryParse(str, out value)) { return value; } return 0; }
        private int ToInt(string str) { int value; if (Int32.TryParse(str, out value)) { return value; } return 0; }
       
        public AddQuote()
        {

            InitializeComponent();
            DesktopMaterialBox.DataSource = Enum.GetValues(typeof(DesktopMaterial));
            quoteDateLabel.Text = DateTime.Now.ToString("dd MMM yyyy");
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

      

        private void SubmitQuoteButton_Click(object sender, EventArgs e)
        {
           

            var item = DesktopMaterialBox.SelectedItem.ToString();
            var material = DesktopMaterial.veneer;
            if (item == DesktopMaterial.laminate.ToString())
            {
                material = DesktopMaterial.laminate;
            }
            else if (item == DesktopMaterial.oak.ToString())
            {
                material = DesktopMaterial.oak;
            }
            else if (item == DesktopMaterial.pine.ToString())
            {
                material = DesktopMaterial.pine;
            }
            else if (item == DesktopMaterial.rosewood.ToString())
            {
                material = DesktopMaterial.rosewood;
            }
            var days = 14;
            if (rushDays.SelectedIndex == DeskQuote.THREEDAYRUSH)
            {
                days = 3;
            }
            else if (rushDays.SelectedIndex == DeskQuote.FIVEDAYRUSH)
            {
                days = 5;
            }
            else if (rushDays.SelectedIndex == DeskQuote.SEVENDAYRUSH)
            {
                days = 7;
            }
            var quote = new DeskQuote(customerName.Text, ToDouble(width.Text), ToDouble(depth.Text), ToInt(drawers.Text), material, days, quoteDateLabel.Text);

            //This is Saving to a JSON file
            try
            {
                // name where the file is located
                var quoteJSONFile = @"quote.json";
                //creating a new DeskQuotes list called deskOrders to store my information in
                List<DeskQuote> deskOrders = new List<DeskQuote>();
                //if my file exists then add the information to my list that already exists
                if(File.Exists(quoteJSONFile))
                {
                    using (StreamReader reader = new StreamReader(quoteJSONFile))
                    {
                        string newQuotes = reader.ReadToEnd();
                        if(newQuotes.Length >0)
                        {
                           deskOrders= JsonConvert.DeserializeObject<List<DeskQuote>>(newQuotes);
                        }
                        deskOrders.Add(quote);
                    }
                    //convert to JSON formate
                    var serializeQuotes = JsonConvert.SerializeObject(deskOrders);
                    //save to JSON file.
                    File.WriteAllText(quoteJSONFile, serializeQuotes);

                }
                //if not, create a new list to add too.
                else
                {
                    //create a list object of orders
                    deskOrders = new List<DeskQuote> { quote };
                    //convert to JSON formate
                    var serializeQuotes = JsonConvert.SerializeObject(deskOrders);
                    //save to JSON file.
                    File.WriteAllText(quoteJSONFile, serializeQuotes);
                }
                
            }
            
            catch (Exception)
            {

                throw;
            }
            DisplayQuote viewDisplayQuote = new DisplayQuote(quote);
            viewDisplayQuote.Tag = Tag;
            viewDisplayQuote.Show(this);
            Hide();


        }

        private void Width_Validating(object sender, CancelEventArgs e)
        {

            double deskWidth = 0;
            if (string.IsNullOrWhiteSpace(width.Text))
            {
                e.Cancel = true;
                width.Focus();
                nameError.SetError(width, "Width is a required field");

            }
            if (!double.TryParse(width.Text, out deskWidth))
            {
                e.Cancel = false;
                widthError.SetError(width, "");
                return;
            }

            if ((deskWidth < Desk.MINWIDTH || deskWidth > Desk.MAXWIDTH))
            {
                e.Cancel = true;
                width.Focus();
                widthError.SetError(width, $"Width must be between {Desk.MINWIDTH} and {Desk.MAXWIDTH} inches");
            }
            else
            {
                e.Cancel = false;
                widthError.SetError(width, "");
            }

        }


        private void Depth_KeyPress(object sender, KeyPressEventArgs e)


        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar) != '.')
            {
                e.Handled = true;

            }
        }

        private void CustomerName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(customerName.Text))
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

            double deskDepth = 0;
            if (string.IsNullOrWhiteSpace(depth.Text))
            {
                e.Cancel = true;
                depth.Focus();
                nameError.SetError(depth, "Depth is a required field");

            }
            if (!double.TryParse(depth.Text, out deskDepth))
            {
                e.Cancel = false;
                depthError.SetError(depth, "");
                return;
            }

            if ((deskDepth < Desk.MINDEPTH || deskDepth > Desk.MAXDEPTH))
            {
                e.Cancel = true;
                depth.Focus();
                depthError.SetError(depth, $"Depth must be between {Desk.MINDEPTH} and {Desk.MAXDEPTH} inches");
            }
            else
            {
                e.Cancel = false;
                depthError.SetError(depth, "");
            }
        }

        private void Width_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar) != '.')
            {
                e.Handled = true;

            }
        }

        private void Drawers_KeyPress(object sender, KeyPressEventArgs e)
        {
            int drawers = 0;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
           
        }

        private void Drawers_Validating(object sender, CancelEventArgs e)
        {
            int deskDrawers = 0;
            if (!int.TryParse(drawers.Text, out deskDrawers))
            {
                e.Cancel = false;
                drawerError.SetError(drawers, "");
                return;
            }
            if (string.IsNullOrWhiteSpace(drawers.Text))
            {
                e.Cancel = true;
                drawers.Focus();
                nameError.SetError(drawers, "Depth is a required field");

            }
            if ((deskDrawers < 0 || deskDrawers > Desk.MAXDRAWERS))
            {
                e.Cancel = true;
                drawers.Focus();
                drawerError.SetError(drawers, $"Max Drawers is {Desk.MAXDRAWERS}");
            }
            else
            {
                e.Cancel = false;
                drawerError.SetError(drawers, "");
            }
        }
    }
}

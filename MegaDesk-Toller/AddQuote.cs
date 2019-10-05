﻿using System;
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

            DesktopMaterial.DataSource = Enum.GetValues(typeof(Desk.DesktopMaterial));



        }

        private void SubmitQuoteButton_Click(object sender, EventArgs e)
        {

        }
    }
}

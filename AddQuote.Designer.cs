namespace MegaDesk_Toller
{
    partial class AddQuote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuote));
            this.addQuoteReturnToMainButton = new System.Windows.Forms.Button();
            this.AddNewQuoteExitButton = new System.Windows.Forms.Button();
            this.addQuoteWelcomeLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.depthLabel = new System.Windows.Forms.Label();
            this.widthRestricionLabel = new System.Windows.Forms.Label();
            this.depthRestrictionLabel = new System.Windows.Forms.Label();
            this.drawerNumberLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.desktopMaterialLabel = new System.Windows.Forms.Label();
            this.width = new System.Windows.Forms.TextBox();
            this.depth = new System.Windows.Forms.TextBox();
            this.drawers = new System.Windows.Forms.TextBox();
            this.DesktopMaterialBox = new System.Windows.Forms.ComboBox();
            this.RushOrderLabel = new System.Windows.Forms.Label();
            this.rushDays = new System.Windows.Forms.ComboBox();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.TextBox();
            this.submitQuoteButton = new System.Windows.Forms.Button();
            this.nameError = new System.Windows.Forms.ErrorProvider(this.components);
            this.widthError = new System.Windows.Forms.ErrorProvider(this.components);
            this.depthError = new System.Windows.Forms.ErrorProvider(this.components);
            this.drawerError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nameError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawerError)).BeginInit();
            this.SuspendLayout();
            // 
            // addQuoteReturnToMainButton
            // 
            this.addQuoteReturnToMainButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.addQuoteReturnToMainButton.Location = new System.Drawing.Point(544, 393);
            this.addQuoteReturnToMainButton.Name = "addQuoteReturnToMainButton";
            this.addQuoteReturnToMainButton.Size = new System.Drawing.Size(78, 45);
            this.addQuoteReturnToMainButton.TabIndex = 0;
            this.addQuoteReturnToMainButton.Text = "Return to Main Menu";
            this.addQuoteReturnToMainButton.UseVisualStyleBackColor = true;
            this.addQuoteReturnToMainButton.Click += new System.EventHandler(this.AddQuoteReturnToMainButton_Click);
            // 
            // AddNewQuoteExitButton
            // 
            this.AddNewQuoteExitButton.Location = new System.Drawing.Point(628, 393);
            this.AddNewQuoteExitButton.Name = "AddNewQuoteExitButton";
            this.AddNewQuoteExitButton.Size = new System.Drawing.Size(87, 45);
            this.AddNewQuoteExitButton.TabIndex = 1;
            this.AddNewQuoteExitButton.Text = "Exit MegaDesk";
            this.AddNewQuoteExitButton.UseVisualStyleBackColor = true;
            this.AddNewQuoteExitButton.Click += new System.EventHandler(this.AddNewQuoteExitButton_Click);
            // 
            // addQuoteWelcomeLabel
            // 
            this.addQuoteWelcomeLabel.AutoSize = true;
            this.addQuoteWelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuoteWelcomeLabel.Location = new System.Drawing.Point(183, 9);
            this.addQuoteWelcomeLabel.Name = "addQuoteWelcomeLabel";
            this.addQuoteWelcomeLabel.Size = new System.Drawing.Size(330, 24);
            this.addQuoteWelcomeLabel.TabIndex = 2;
            this.addQuoteWelcomeLabel.Text = "Create Your Custom Desk Quote Here";
            this.addQuoteWelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.Location = new System.Drawing.Point(117, 125);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(118, 20);
            this.widthLabel.TabIndex = 3;
            this.widthLabel.Text = "Width in Inches";
            this.widthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthLabel.Location = new System.Drawing.Point(114, 175);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(125, 20);
            this.depthLabel.TabIndex = 4;
            this.depthLabel.Text = " Depth in Inches";
            this.depthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // widthRestricionLabel
            // 
            this.widthRestricionLabel.AutoSize = true;
            this.widthRestricionLabel.ForeColor = System.Drawing.Color.Blue;
            this.widthRestricionLabel.Location = new System.Drawing.Point(134, 145);
            this.widthRestricionLabel.Name = "widthRestricionLabel";
            this.widthRestricionLabel.Size = new System.Drawing.Size(111, 13);
            this.widthRestricionLabel.TabIndex = 5;
            this.widthRestricionLabel.Text = "Min: 24\" and Max 96\"";
            this.widthRestricionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // depthRestrictionLabel
            // 
            this.depthRestrictionLabel.AutoSize = true;
            this.depthRestrictionLabel.ForeColor = System.Drawing.Color.Blue;
            this.depthRestrictionLabel.Location = new System.Drawing.Point(134, 195);
            this.depthRestrictionLabel.Name = "depthRestrictionLabel";
            this.depthRestrictionLabel.Size = new System.Drawing.Size(111, 13);
            this.depthRestrictionLabel.TabIndex = 6;
            this.depthRestrictionLabel.Text = "Min: 12\" and Max 48\"";
            this.depthRestrictionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // drawerNumberLabel
            // 
            this.drawerNumberLabel.AutoSize = true;
            this.drawerNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawerNumberLabel.Location = new System.Drawing.Point(114, 225);
            this.drawerNumberLabel.Name = "drawerNumberLabel";
            this.drawerNumberLabel.Size = new System.Drawing.Size(146, 20);
            this.drawerNumberLabel.TabIndex = 7;
            this.drawerNumberLabel.Text = "Number of Drawers";
            this.drawerNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(134, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Max: 7 drawers";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // desktopMaterialLabel
            // 
            this.desktopMaterialLabel.AutoSize = true;
            this.desktopMaterialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desktopMaterialLabel.Location = new System.Drawing.Point(114, 279);
            this.desktopMaterialLabel.Name = "desktopMaterialLabel";
            this.desktopMaterialLabel.Size = new System.Drawing.Size(129, 20);
            this.desktopMaterialLabel.TabIndex = 9;
            this.desktopMaterialLabel.Text = "Desktop Material";
            this.desktopMaterialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(291, 125);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(100, 20);
            this.width.TabIndex = 10;
            this.width.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Width_KeyPress);
            this.width.Validating += new System.ComponentModel.CancelEventHandler(this.Width_Validating);
            // 
            // depth
            // 
            this.depth.Location = new System.Drawing.Point(291, 175);
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(100, 20);
            this.depth.TabIndex = 11;
            this.depth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Depth_KeyPress);
            this.depth.Validating += new System.ComponentModel.CancelEventHandler(this.Depth_Validating);
            // 
            // drawers
            // 
            this.drawers.Location = new System.Drawing.Point(291, 227);
            this.drawers.Name = "drawers";
            this.drawers.Size = new System.Drawing.Size(100, 20);
            this.drawers.TabIndex = 12;
            this.drawers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Drawers_KeyPress);
            this.drawers.Validating += new System.ComponentModel.CancelEventHandler(this.Drawers_Validating);
            // 
            // DesktopMaterialBox
            // 
            this.DesktopMaterialBox.FormattingEnabled = true;
            this.DesktopMaterialBox.Location = new System.Drawing.Point(291, 278);
            this.DesktopMaterialBox.Name = "DesktopMaterialBox";
            this.DesktopMaterialBox.Size = new System.Drawing.Size(100, 21);
            this.DesktopMaterialBox.TabIndex = 13;
            // 
            // RushOrderLabel
            // 
            this.RushOrderLabel.AutoSize = true;
            this.RushOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushOrderLabel.Location = new System.Drawing.Point(114, 330);
            this.RushOrderLabel.Name = "RushOrderLabel";
            this.RushOrderLabel.Size = new System.Drawing.Size(91, 20);
            this.RushOrderLabel.TabIndex = 14;
            this.RushOrderLabel.Text = "Rush Order";
            this.RushOrderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rushDays
            // 
            this.rushDays.FormattingEnabled = true;
            this.rushDays.Items.AddRange(new object[] {
            "14 days-Normal",
            "3 Days",
            "5 Days",
            "7 Days"});
            this.rushDays.Location = new System.Drawing.Point(291, 329);
            this.rushDays.Name = "rushDays";
            this.rushDays.Size = new System.Drawing.Size(100, 21);
            this.rushDays.TabIndex = 15;
            this.rushDays.SelectedIndexChanged += new System.EventHandler(this.DeskMaterialDropDown_SelectedIndexChanged);
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.Location = new System.Drawing.Point(116, 78);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(89, 20);
            this.customerNameLabel.TabIndex = 17;
            this.customerNameLabel.Text = "Your Name";
            this.customerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customerName
            // 
            this.customerName.Location = new System.Drawing.Point(291, 78);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(100, 20);
            this.customerName.TabIndex = 18;
            this.customerName.Validating += new System.ComponentModel.CancelEventHandler(this.CustomerName_Validating);
            // 
            // submitQuoteButton
            // 
            this.submitQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitQuoteButton.Location = new System.Drawing.Point(228, 380);
            this.submitQuoteButton.Name = "submitQuoteButton";
            this.submitQuoteButton.Size = new System.Drawing.Size(113, 29);
            this.submitQuoteButton.TabIndex = 19;
            this.submitQuoteButton.Text = "Submit Quote";
            this.submitQuoteButton.UseVisualStyleBackColor = true;
            this.submitQuoteButton.Click += new System.EventHandler(this.SubmitQuoteButton_Click);
            // 
            // nameError
            // 
            this.nameError.ContainerControl = this;
            // 
            // widthError
            // 
            this.widthError.ContainerControl = this;
            // 
            // depthError
            // 
            this.depthError.ContainerControl = this;
            // 
            // drawerError
            // 
            this.drawerError.ContainerControl = this;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.addQuoteReturnToMainButton;
            this.ClientSize = new System.Drawing.Size(727, 450);
            this.Controls.Add(this.submitQuoteButton);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.rushDays);
            this.Controls.Add(this.RushOrderLabel);
            this.Controls.Add(this.DesktopMaterialBox);
            this.Controls.Add(this.drawers);
            this.Controls.Add(this.depth);
            this.Controls.Add(this.width);
            this.Controls.Add(this.desktopMaterialLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drawerNumberLabel);
            this.Controls.Add(this.depthRestrictionLabel);
            this.Controls.Add(this.widthRestricionLabel);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.addQuoteWelcomeLabel);
            this.Controls.Add(this.AddNewQuoteExitButton);
            this.Controls.Add(this.addQuoteReturnToMainButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddQuote";
            this.Text = "Add a New Quote";
            ((System.ComponentModel.ISupportInitialize)(this.nameError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawerError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addQuoteReturnToMainButton;
        private System.Windows.Forms.Button AddNewQuoteExitButton;
        private System.Windows.Forms.Label addQuoteWelcomeLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.Label widthRestricionLabel;
        private System.Windows.Forms.Label depthRestrictionLabel;
        private System.Windows.Forms.Label drawerNumberLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label desktopMaterialLabel;
        private System.Windows.Forms.TextBox width;
        private System.Windows.Forms.TextBox depth;
        private System.Windows.Forms.TextBox drawers;
        private System.Windows.Forms.ComboBox DesktopMaterialBox;
        private System.Windows.Forms.Label RushOrderLabel;
        private System.Windows.Forms.ComboBox rushDays;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.Button submitQuoteButton;
        private System.Windows.Forms.ErrorProvider nameError;
        private System.Windows.Forms.ErrorProvider widthError;
        private System.Windows.Forms.ErrorProvider depthError;
        private System.Windows.Forms.ErrorProvider drawerError;
    }
}
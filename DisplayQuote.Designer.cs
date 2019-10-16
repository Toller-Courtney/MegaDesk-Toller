namespace MegaDesk_Toller
{
    partial class DisplayQuote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayQuote));
            this.displayQuoteWelcomeLabel = new System.Windows.Forms.Label();
            this.displayQuoteReturnToMain = new System.Windows.Forms.Button();
            this.displayQuoteExit = new System.Windows.Forms.Button();
            this.displayQuoteDate = new System.Windows.Forms.Label();
            this.quotedate = new System.Windows.Forms.Timer(this.components);
            this.displayQuoteDateLabel = new System.Windows.Forms.Label();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.userInputDisplayLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.depthLabel = new System.Windows.Forms.Label();
            this.drawerNumerLabel = new System.Windows.Forms.Label();
            this.selectedMaterialLabel = new System.Windows.Forms.Label();
            this.rushDaysLabel = new System.Windows.Forms.Label();
            this.quoteDateLabel = new System.Windows.Forms.Label();
            this.userInputWidthLabel = new System.Windows.Forms.Label();
            this.depthInputLabel = new System.Windows.Forms.Label();
            this.drawerInputLabel = new System.Windows.Forms.Label();
            this.materialInputLabel = new System.Windows.Forms.Label();
            this.rushDayInputLabel = new System.Windows.Forms.Label();
            this.quoteTotalLabe = new System.Windows.Forms.Label();
            this.totalOutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // displayQuoteWelcomeLabel
            // 
            this.displayQuoteWelcomeLabel.AutoSize = true;
            this.displayQuoteWelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayQuoteWelcomeLabel.Location = new System.Drawing.Point(195, 32);
            this.displayQuoteWelcomeLabel.Name = "displayQuoteWelcomeLabel";
            this.displayQuoteWelcomeLabel.Size = new System.Drawing.Size(261, 24);
            this.displayQuoteWelcomeLabel.TabIndex = 0;
            this.displayQuoteWelcomeLabel.Text = "Your Custom Quote Summary";
            this.displayQuoteWelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayQuoteReturnToMain
            // 
            this.displayQuoteReturnToMain.Location = new System.Drawing.Point(455, 390);
            this.displayQuoteReturnToMain.Name = "displayQuoteReturnToMain";
            this.displayQuoteReturnToMain.Size = new System.Drawing.Size(90, 48);
            this.displayQuoteReturnToMain.TabIndex = 1;
            this.displayQuoteReturnToMain.Text = "Return to Main Menu";
            this.displayQuoteReturnToMain.UseVisualStyleBackColor = true;
            this.displayQuoteReturnToMain.Click += new System.EventHandler(this.DisplayQuoteReturnToMain_Click);
            // 
            // displayQuoteExit
            // 
            this.displayQuoteExit.Location = new System.Drawing.Point(551, 390);
            this.displayQuoteExit.Name = "displayQuoteExit";
            this.displayQuoteExit.Size = new System.Drawing.Size(95, 48);
            this.displayQuoteExit.TabIndex = 2;
            this.displayQuoteExit.Text = "Exit MegaDesk";
            this.displayQuoteExit.UseVisualStyleBackColor = true;
            this.displayQuoteExit.Click += new System.EventHandler(this.DisplayQuoteExit_Click);
            // 
            // displayQuoteDate
            // 
            this.displayQuoteDate.AutoSize = true;
            this.displayQuoteDate.Location = new System.Drawing.Point(28, 40);
            this.displayQuoteDate.Name = "displayQuoteDate";
            this.displayQuoteDate.Size = new System.Drawing.Size(0, 13);
            this.displayQuoteDate.TabIndex = 3;
            // 
            // quotedate
            // 
            this.quotedate.Tick += new System.EventHandler(this.Quotedate_Tick);
            // 
            // displayQuoteDateLabel
            // 
            this.displayQuoteDateLabel.AutoSize = true;
            this.displayQuoteDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayQuoteDateLabel.Location = new System.Drawing.Point(212, 349);
            this.displayQuoteDateLabel.Name = "displayQuoteDateLabel";
            this.displayQuoteDateLabel.Size = new System.Drawing.Size(46, 24);
            this.displayQuoteDateLabel.TabIndex = 4;
            this.displayQuoteDateLabel.Text = "date";
            this.displayQuoteDateLabel.Click += new System.EventHandler(this.DisplayQuoteDateLabel_Click);
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.Location = new System.Drawing.Point(93, 81);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(66, 24);
            this.customerNameLabel.TabIndex = 5;
            this.customerNameLabel.Text = "Name:";
            this.customerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userInputDisplayLabel
            // 
            this.userInputDisplayLabel.AutoSize = true;
            this.userInputDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInputDisplayLabel.Location = new System.Drawing.Point(212, 81);
            this.userInputDisplayLabel.Name = "userInputDisplayLabel";
            this.userInputDisplayLabel.Size = new System.Drawing.Size(185, 24);
            this.userInputDisplayLabel.TabIndex = 6;
            this.userInputDisplayLabel.Text = "customer name here";
            this.userInputDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.Location = new System.Drawing.Point(93, 123);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(110, 24);
            this.widthLabel.TabIndex = 7;
            this.widthLabel.Text = "Desk Width:";
            this.widthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthLabel.Location = new System.Drawing.Point(93, 172);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(107, 24);
            this.depthLabel.TabIndex = 8;
            this.depthLabel.Text = "DeskDepth:";
            this.depthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // drawerNumerLabel
            // 
            this.drawerNumerLabel.AutoSize = true;
            this.drawerNumerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawerNumerLabel.Location = new System.Drawing.Point(93, 220);
            this.drawerNumerLabel.Name = "drawerNumerLabel";
            this.drawerNumerLabel.Size = new System.Drawing.Size(84, 24);
            this.drawerNumerLabel.TabIndex = 9;
            this.drawerNumerLabel.Text = "Drawers:";
            this.drawerNumerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectedMaterialLabel
            // 
            this.selectedMaterialLabel.AutoSize = true;
            this.selectedMaterialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedMaterialLabel.Location = new System.Drawing.Point(93, 262);
            this.selectedMaterialLabel.Name = "selectedMaterialLabel";
            this.selectedMaterialLabel.Size = new System.Drawing.Size(80, 24);
            this.selectedMaterialLabel.TabIndex = 10;
            this.selectedMaterialLabel.Text = "Material:";
            this.selectedMaterialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rushDaysLabel
            // 
            this.rushDaysLabel.AutoSize = true;
            this.rushDaysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rushDaysLabel.Location = new System.Drawing.Point(93, 307);
            this.rushDaysLabel.Name = "rushDaysLabel";
            this.rushDaysLabel.Size = new System.Drawing.Size(105, 24);
            this.rushDaysLabel.TabIndex = 11;
            this.rushDaysLabel.Text = "Rush Days:";
            this.rushDaysLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quoteDateLabel
            // 
            this.quoteDateLabel.AutoSize = true;
            this.quoteDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteDateLabel.Location = new System.Drawing.Point(93, 349);
            this.quoteDateLabel.Name = "quoteDateLabel";
            this.quoteDateLabel.Size = new System.Drawing.Size(110, 24);
            this.quoteDateLabel.TabIndex = 12;
            this.quoteDateLabel.Text = "Quote Date:";
            this.quoteDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userInputWidthLabel
            // 
            this.userInputWidthLabel.AutoSize = true;
            this.userInputWidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInputWidthLabel.Location = new System.Drawing.Point(212, 123);
            this.userInputWidthLabel.Name = "userInputWidthLabel";
            this.userInputWidthLabel.Size = new System.Drawing.Size(102, 24);
            this.userInputWidthLabel.TabIndex = 13;
            this.userInputWidthLabel.Text = "Width here";
            this.userInputWidthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // depthInputLabel
            // 
            this.depthInputLabel.AutoSize = true;
            this.depthInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthInputLabel.Location = new System.Drawing.Point(212, 172);
            this.depthInputLabel.Name = "depthInputLabel";
            this.depthInputLabel.Size = new System.Drawing.Size(107, 24);
            this.depthInputLabel.TabIndex = 14;
            this.depthInputLabel.Text = "Depth Here";
            this.depthInputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // drawerInputLabel
            // 
            this.drawerInputLabel.AutoSize = true;
            this.drawerInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawerInputLabel.Location = new System.Drawing.Point(212, 220);
            this.drawerInputLabel.Name = "drawerInputLabel";
            this.drawerInputLabel.Size = new System.Drawing.Size(183, 24);
            this.drawerInputLabel.TabIndex = 15;
            this.drawerInputLabel.Text = "drawer number here";
            this.drawerInputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialInputLabel
            // 
            this.materialInputLabel.AutoSize = true;
            this.materialInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialInputLabel.Location = new System.Drawing.Point(212, 262);
            this.materialInputLabel.Name = "materialInputLabel";
            this.materialInputLabel.Size = new System.Drawing.Size(199, 24);
            this.materialInputLabel.TabIndex = 16;
            this.materialInputLabel.Text = "Material selection here";
            this.materialInputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rushDayInputLabel
            // 
            this.rushDayInputLabel.AutoSize = true;
            this.rushDayInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rushDayInputLabel.Location = new System.Drawing.Point(212, 307);
            this.rushDayInputLabel.Name = "rushDayInputLabel";
            this.rushDayInputLabel.Size = new System.Drawing.Size(221, 24);
            this.rushDayInputLabel.TabIndex = 17;
            this.rushDayInputLabel.Text = "Rush Day Selection Here";
            this.rushDayInputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quoteTotalLabe
            // 
            this.quoteTotalLabe.AutoSize = true;
            this.quoteTotalLabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteTotalLabe.Location = new System.Drawing.Point(93, 390);
            this.quoteTotalLabe.Name = "quoteTotalLabe";
            this.quoteTotalLabe.Size = new System.Drawing.Size(128, 24);
            this.quoteTotalLabe.TabIndex = 18;
            this.quoteTotalLabe.Text = "Quote Total: $";
            // 
            // totalOutputLabel
            // 
            this.totalOutputLabel.AutoSize = true;
            this.totalOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOutputLabel.Location = new System.Drawing.Point(227, 390);
            this.totalOutputLabel.Name = "totalOutputLabel";
            this.totalOutputLabel.Size = new System.Drawing.Size(144, 24);
            this.totalOutputLabel.TabIndex = 19;
            this.totalOutputLabel.Text = "Quote total here";
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 450);
            this.Controls.Add(this.totalOutputLabel);
            this.Controls.Add(this.quoteTotalLabe);
            this.Controls.Add(this.rushDayInputLabel);
            this.Controls.Add(this.materialInputLabel);
            this.Controls.Add(this.drawerInputLabel);
            this.Controls.Add(this.depthInputLabel);
            this.Controls.Add(this.userInputWidthLabel);
            this.Controls.Add(this.quoteDateLabel);
            this.Controls.Add(this.rushDaysLabel);
            this.Controls.Add(this.selectedMaterialLabel);
            this.Controls.Add(this.drawerNumerLabel);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.userInputDisplayLabel);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.displayQuoteDateLabel);
            this.Controls.Add(this.displayQuoteDate);
            this.Controls.Add(this.displayQuoteExit);
            this.Controls.Add(this.displayQuoteReturnToMain);
            this.Controls.Add(this.displayQuoteWelcomeLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DisplayQuote";
            this.Text = "DisplayQuote";
            this.Load += new System.EventHandler(this.DisplayQuote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label displayQuoteWelcomeLabel;
        private System.Windows.Forms.Button displayQuoteReturnToMain;
        private System.Windows.Forms.Button displayQuoteExit;
        private System.Windows.Forms.Label displayQuoteDate;
        private System.Windows.Forms.Timer quotedate;
        private System.Windows.Forms.Label displayQuoteDateLabel;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Label userInputDisplayLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.Label drawerNumerLabel;
        private System.Windows.Forms.Label selectedMaterialLabel;
        private System.Windows.Forms.Label rushDaysLabel;
        private System.Windows.Forms.Label quoteDateLabel;
        private System.Windows.Forms.Label userInputWidthLabel;
        private System.Windows.Forms.Label depthInputLabel;
        private System.Windows.Forms.Label drawerInputLabel;
        private System.Windows.Forms.Label materialInputLabel;
        private System.Windows.Forms.Label rushDayInputLabel;
        private System.Windows.Forms.Label quoteTotalLabe;
        private System.Windows.Forms.Label totalOutputLabel;
    }
}
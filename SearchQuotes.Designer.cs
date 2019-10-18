namespace MegaDesk_Toller
{
    partial class SearchQuotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchQuotes));
            this.SearchQuotesReturnToMain = new System.Windows.Forms.Button();
            this.SearchQuotesExitButton = new System.Windows.Forms.Button();
            this.materialSearchBox = new System.Windows.Forms.ComboBox();
            this.SearchMaterialLabel = new System.Windows.Forms.Label();
            this.SearchGridView = new System.Windows.Forms.DataGridView();
            this.SearchQuotesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SearchGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchQuotesReturnToMain
            // 
            this.SearchQuotesReturnToMain.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SearchQuotesReturnToMain.Location = new System.Drawing.Point(711, 278);
            this.SearchQuotesReturnToMain.Name = "SearchQuotesReturnToMain";
            this.SearchQuotesReturnToMain.Size = new System.Drawing.Size(77, 48);
            this.SearchQuotesReturnToMain.TabIndex = 0;
            this.SearchQuotesReturnToMain.Text = "Return to Main Menu";
            this.SearchQuotesReturnToMain.UseVisualStyleBackColor = true;
            this.SearchQuotesReturnToMain.Click += new System.EventHandler(this.SearchQuotesReturnToMain_Click);
            // 
            // SearchQuotesExitButton
            // 
            this.SearchQuotesExitButton.Location = new System.Drawing.Point(711, 332);
            this.SearchQuotesExitButton.Name = "SearchQuotesExitButton";
            this.SearchQuotesExitButton.Size = new System.Drawing.Size(77, 48);
            this.SearchQuotesExitButton.TabIndex = 1;
            this.SearchQuotesExitButton.Text = "Exit MegaDesk";
            this.SearchQuotesExitButton.UseVisualStyleBackColor = true;
            this.SearchQuotesExitButton.Click += new System.EventHandler(this.SearchQuotesExitButton_Click);
            // 
            // materialSearchBox
            // 
            this.materialSearchBox.FormattingEnabled = true;
            this.materialSearchBox.Location = new System.Drawing.Point(405, 54);
            this.materialSearchBox.Name = "materialSearchBox";
            this.materialSearchBox.Size = new System.Drawing.Size(121, 21);
            this.materialSearchBox.TabIndex = 2;
            this.materialSearchBox.SelectedIndexChanged += new System.EventHandler(this.materialSearchBox_SelectedIndexChanged);
            // 
            // SearchMaterialLabel
            // 
            this.SearchMaterialLabel.AutoSize = true;
            this.SearchMaterialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchMaterialLabel.Location = new System.Drawing.Point(296, 55);
            this.SearchMaterialLabel.Name = "SearchMaterialLabel";
            this.SearchMaterialLabel.Size = new System.Drawing.Size(103, 20);
            this.SearchMaterialLabel.TabIndex = 3;
            this.SearchMaterialLabel.Text = "Material Type";
            // 
            // SearchGridView
            // 
            this.SearchGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchGridView.Location = new System.Drawing.Point(12, 92);
            this.SearchGridView.Name = "SearchGridView";
            this.SearchGridView.Size = new System.Drawing.Size(776, 150);
            this.SearchGridView.TabIndex = 4;
            // 
            // SearchQuotesLabel
            // 
            this.SearchQuotesLabel.AutoSize = true;
            this.SearchQuotesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchQuotesLabel.Location = new System.Drawing.Point(268, 9);
            this.SearchQuotesLabel.Name = "SearchQuotesLabel";
            this.SearchQuotesLabel.Size = new System.Drawing.Size(258, 24);
            this.SearchQuotesLabel.TabIndex = 5;
            this.SearchQuotesLabel.Text = "Search All Quotes By Material";
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.SearchQuotesReturnToMain;
            this.ClientSize = new System.Drawing.Size(800, 387);
            this.Controls.Add(this.SearchQuotesLabel);
            this.Controls.Add(this.SearchGridView);
            this.Controls.Add(this.SearchMaterialLabel);
            this.Controls.Add(this.materialSearchBox);
            this.Controls.Add(this.SearchQuotesExitButton);
            this.Controls.Add(this.SearchQuotesReturnToMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchQuotes";
            this.Text = "Search Quotes";
            ((System.ComponentModel.ISupportInitialize)(this.SearchGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchQuotesReturnToMain;
        private System.Windows.Forms.Button SearchQuotesExitButton;
        private System.Windows.Forms.ComboBox materialSearchBox;
        private System.Windows.Forms.Label SearchMaterialLabel;
        private System.Windows.Forms.DataGridView SearchGridView;
        private System.Windows.Forms.Label SearchQuotesLabel;
    }
}
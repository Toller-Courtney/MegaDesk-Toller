namespace MegaDesk_Toller
{
    partial class ViewAllQuotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAllQuotes));
            this.AllQuotesReturnToMain = new System.Windows.Forms.Button();
            this.ViewAllQuotesExitButton = new System.Windows.Forms.Button();
            this.viewAllQuotesGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.viewAllQuotesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AllQuotesReturnToMain
            // 
            this.AllQuotesReturnToMain.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AllQuotesReturnToMain.Location = new System.Drawing.Point(12, 398);
            this.AllQuotesReturnToMain.Name = "AllQuotesReturnToMain";
            this.AllQuotesReturnToMain.Size = new System.Drawing.Size(77, 40);
            this.AllQuotesReturnToMain.TabIndex = 0;
            this.AllQuotesReturnToMain.Text = "Return To Main Menu";
            this.AllQuotesReturnToMain.UseVisualStyleBackColor = true;
            this.AllQuotesReturnToMain.Click += new System.EventHandler(this.AllQuotesReturnToMain_Click);
            // 
            // ViewAllQuotesExitButton
            // 
            this.ViewAllQuotesExitButton.Location = new System.Drawing.Point(127, 398);
            this.ViewAllQuotesExitButton.Name = "ViewAllQuotesExitButton";
            this.ViewAllQuotesExitButton.Size = new System.Drawing.Size(90, 40);
            this.ViewAllQuotesExitButton.TabIndex = 1;
            this.ViewAllQuotesExitButton.Text = "Exit MegaDesk";
            this.ViewAllQuotesExitButton.UseVisualStyleBackColor = true;
            this.ViewAllQuotesExitButton.Click += new System.EventHandler(this.ViewAllQuotesExitButton_Click);
            // 
            // viewAllQuotesGrid
            // 
            this.viewAllQuotesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewAllQuotesGrid.Location = new System.Drawing.Point(12, 53);
            this.viewAllQuotesGrid.Name = "viewAllQuotesGrid";
            this.viewAllQuotesGrid.Size = new System.Drawing.Size(821, 150);
            this.viewAllQuotesGrid.TabIndex = 2;
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.AllQuotesReturnToMain;
            this.ClientSize = new System.Drawing.Size(845, 450);
            this.Controls.Add(this.viewAllQuotesGrid);
            this.Controls.Add(this.ViewAllQuotesExitButton);
            this.Controls.Add(this.AllQuotesReturnToMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewAllQuotes";
            this.Text = "View All Quotes";
            this.Load += new System.EventHandler(this.ViewAllQuotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewAllQuotesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AllQuotesReturnToMain;
        private System.Windows.Forms.Button ViewAllQuotesExitButton;
        private System.Windows.Forms.DataGridView viewAllQuotesGrid;
    }
}
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
            this.SearchQuotesReturnToMain = new System.Windows.Forms.Button();
            this.SearchQuotesExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchQuotesReturnToMain
            // 
            this.SearchQuotesReturnToMain.Location = new System.Drawing.Point(12, 390);
            this.SearchQuotesReturnToMain.Name = "SearchQuotesReturnToMain";
            this.SearchQuotesReturnToMain.Size = new System.Drawing.Size(77, 48);
            this.SearchQuotesReturnToMain.TabIndex = 0;
            this.SearchQuotesReturnToMain.Text = "Return to Main Menu";
            this.SearchQuotesReturnToMain.UseVisualStyleBackColor = true;
            this.SearchQuotesReturnToMain.Click += new System.EventHandler(this.SearchQuotesReturnToMain_Click);
            // 
            // SearchQuotesExitButton
            // 
            this.SearchQuotesExitButton.Location = new System.Drawing.Point(116, 390);
            this.SearchQuotesExitButton.Name = "SearchQuotesExitButton";
            this.SearchQuotesExitButton.Size = new System.Drawing.Size(89, 48);
            this.SearchQuotesExitButton.TabIndex = 1;
            this.SearchQuotesExitButton.Text = "Exit MegaDesk";
            this.SearchQuotesExitButton.UseVisualStyleBackColor = true;
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.SearchQuotesReturnToMain;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchQuotesExitButton);
            this.Controls.Add(this.SearchQuotesReturnToMain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchQuotes";
            this.Text = "Search Quotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SearchQuotesReturnToMain;
        private System.Windows.Forms.Button SearchQuotesExitButton;
    }
}
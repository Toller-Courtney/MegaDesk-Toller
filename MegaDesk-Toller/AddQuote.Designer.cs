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
            this.addQuoteReturnToMainButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addQuoteReturnToMainButton
            // 
            this.addQuoteReturnToMainButton.Location = new System.Drawing.Point(12, 393);
            this.addQuoteReturnToMainButton.Name = "addQuoteReturnToMainButton";
            this.addQuoteReturnToMainButton.Size = new System.Drawing.Size(78, 45);
            this.addQuoteReturnToMainButton.TabIndex = 0;
            this.addQuoteReturnToMainButton.Text = "Return to Main Menu";
            this.addQuoteReturnToMainButton.UseVisualStyleBackColor = true;
            this.addQuoteReturnToMainButton.Click += new System.EventHandler(this.AddQuoteReturnToMainButton_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addQuoteReturnToMainButton);
            this.Name = "AddQuote";
            this.Text = "Add a New Quote";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addQuoteReturnToMainButton;
    }
}
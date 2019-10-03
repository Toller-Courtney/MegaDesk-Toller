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
            this.AllQuotesReturnToMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AllQuotesReturnToMain
            // 
            this.AllQuotesReturnToMain.Location = new System.Drawing.Point(12, 398);
            this.AllQuotesReturnToMain.Name = "AllQuotesReturnToMain";
            this.AllQuotesReturnToMain.Size = new System.Drawing.Size(77, 40);
            this.AllQuotesReturnToMain.TabIndex = 0;
            this.AllQuotesReturnToMain.Text = "Return To Main Menu";
            this.AllQuotesReturnToMain.UseVisualStyleBackColor = true;
            this.AllQuotesReturnToMain.Click += new System.EventHandler(this.AllQuotesReturnToMain_Click);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AllQuotesReturnToMain);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AllQuotesReturnToMain;
    }
}
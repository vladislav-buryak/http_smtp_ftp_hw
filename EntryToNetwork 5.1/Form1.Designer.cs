namespace EntryToNetwork_5._1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUri = new TextBox();
            btnFetch = new Button();
            txtResult = new TextBox();
            SuspendLayout();
            // 
            // txtUri
            // 
            txtUri.Location = new Point(12, 12);
            txtUri.Name = "txtUri";
            txtUri.Size = new Size(500, 23);
            txtUri.TabIndex = 0;
            // 
            // btnFetch
            // 
            btnFetch.Location = new Point(518, 12);
            btnFetch.Name = "btnFetch";
            btnFetch.Size = new Size(100, 23);
            btnFetch.TabIndex = 1;
            btnFetch.Text = "Надіслати";
            btnFetch.UseVisualStyleBackColor = true;
            btnFetch.Click += btnFetch_Click_1;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(12, 50);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ScrollBars = ScrollBars.Both;
            txtResult.Size = new Size(606, 350);
            txtResult.TabIndex = 2;
            txtResult.WordWrap = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 420);
            Controls.Add(txtResult);
            Controls.Add(btnFetch);
            Controls.Add(txtUri);
            Name = "Form1";
            Text = "HTML Fetcher";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUri;
        private System.Windows.Forms.Button btnFetch;
        private System.Windows.Forms.TextBox txtResult;
    }
}

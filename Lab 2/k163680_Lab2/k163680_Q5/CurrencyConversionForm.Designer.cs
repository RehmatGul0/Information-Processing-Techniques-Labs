namespace k163680_Q5
{
    partial class CurrencyConversionForm
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
            this.SourceCurrencyLabel = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.Label();
            this.DestinationCurrencyLabel = new System.Windows.Forms.Label();
            this.SourceCurrencyBox = new System.Windows.Forms.ComboBox();
            this.DestinationCurrencyBox = new System.Windows.Forms.ComboBox();
            this.AmountBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ResultBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // SourceCurrencyLabel
            // 
            this.SourceCurrencyLabel.AutoSize = true;
            this.SourceCurrencyLabel.Location = new System.Drawing.Point(13, 28);
            this.SourceCurrencyLabel.Name = "SourceCurrencyLabel";
            this.SourceCurrencyLabel.Size = new System.Drawing.Size(86, 13);
            this.SourceCurrencyLabel.TabIndex = 0;
            this.SourceCurrencyLabel.Text = "Source Currency";
            this.SourceCurrencyLabel.Click += new System.EventHandler(this.SourceCurrencyLabel_Click);
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Location = new System.Drawing.Point(13, 96);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(43, 13);
            this.Amount.TabIndex = 1;
            this.Amount.Text = "Amount";
            this.Amount.Click += new System.EventHandler(this.Amount_Click);
            // 
            // DestinationCurrencyLabel
            // 
            this.DestinationCurrencyLabel.AutoSize = true;
            this.DestinationCurrencyLabel.Location = new System.Drawing.Point(13, 162);
            this.DestinationCurrencyLabel.Name = "DestinationCurrencyLabel";
            this.DestinationCurrencyLabel.Size = new System.Drawing.Size(105, 13);
            this.DestinationCurrencyLabel.TabIndex = 2;
            this.DestinationCurrencyLabel.Text = "Destination Currency";
            this.DestinationCurrencyLabel.Click += new System.EventHandler(this.DestinationCurrencyLabel_Click);
            // 
            // SourceCurrencyBox
            // 
            this.SourceCurrencyBox.FormattingEnabled = true;
            this.SourceCurrencyBox.Location = new System.Drawing.Point(16, 45);
            this.SourceCurrencyBox.Name = "SourceCurrencyBox";
            this.SourceCurrencyBox.Size = new System.Drawing.Size(417, 21);
            this.SourceCurrencyBox.TabIndex = 3;
            this.SourceCurrencyBox.SelectedIndexChanged += new System.EventHandler(this.SourceCurrencyBox_SelectedIndexChanged);
            // 
            // DestinationCurrencyBox
            // 
            this.DestinationCurrencyBox.FormattingEnabled = true;
            this.DestinationCurrencyBox.Location = new System.Drawing.Point(16, 178);
            this.DestinationCurrencyBox.Name = "DestinationCurrencyBox";
            this.DestinationCurrencyBox.Size = new System.Drawing.Size(417, 21);
            this.DestinationCurrencyBox.TabIndex = 4;
            this.DestinationCurrencyBox.SelectedIndexChanged += new System.EventHandler(this.DestinationCurrencyBox_SelectedIndexChanged);
            // 
            // AmountBox
            // 
            this.AmountBox.Location = new System.Drawing.Point(16, 113);
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(417, 20);
            this.AmountBox.TabIndex = 5;
            this.AmountBox.TextChanged += new System.EventHandler(this.AmountBox_TextChanged);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(267, 220);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(166, 23);
            this.CalculateButton.TabIndex = 6;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ResultBox
            // 
            this.ResultBox.Location = new System.Drawing.Point(16, 249);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(417, 80);
            this.ResultBox.TabIndex = 7;
            this.ResultBox.Text = "";
            this.ResultBox.TextChanged += new System.EventHandler(this.ResultBox_TextChanged);
            // 
            // CurrencyConversionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(445, 356);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.AmountBox);
            this.Controls.Add(this.DestinationCurrencyBox);
            this.Controls.Add(this.SourceCurrencyBox);
            this.Controls.Add(this.DestinationCurrencyLabel);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.SourceCurrencyLabel);
            this.MaximizeBox = false;
            this.Name = "CurrencyConversionForm";
            this.Text = "Currency Conversion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SourceCurrencyLabel;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.Label DestinationCurrencyLabel;
        private System.Windows.Forms.ComboBox SourceCurrencyBox;
        private System.Windows.Forms.ComboBox DestinationCurrencyBox;
        private System.Windows.Forms.TextBox AmountBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.RichTextBox ResultBox;
    }
}


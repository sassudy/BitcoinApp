namespace BitcoinApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.currencyCombo = new System.Windows.Forms.ComboBox();
            this.BTNgetrates = new System.Windows.Forms.Button();
            this.AmounOfCoinbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.resultTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // currencyCombo
            // 
            this.currencyCombo.FormattingEnabled = true;
            this.currencyCombo.Items.AddRange(new object[] {
            "EUR",
            "USD"});
            this.currencyCombo.Location = new System.Drawing.Point(65, 74);
            this.currencyCombo.Name = "currencyCombo";
            this.currencyCombo.Size = new System.Drawing.Size(121, 21);
            this.currencyCombo.TabIndex = 0;
            this.currencyCombo.Text = "Select Currency";
            this.currencyCombo.SelectedIndexChanged += new System.EventHandler(this.currencyCombo_SelectedIndexChanged);
            // 
            // BTNgetrates
            // 
            this.BTNgetrates.Location = new System.Drawing.Point(237, 74);
            this.BTNgetrates.Name = "BTNgetrates";
            this.BTNgetrates.Size = new System.Drawing.Size(75, 23);
            this.BTNgetrates.TabIndex = 1;
            this.BTNgetrates.Text = "Get rates";
            this.BTNgetrates.UseVisualStyleBackColor = true;
            // 
            // AmounOfCoinbox
            // 
            this.AmounOfCoinbox.Location = new System.Drawing.Point(65, 149);
            this.AmounOfCoinbox.Name = "AmounOfCoinbox";
            this.AmounOfCoinbox.Size = new System.Drawing.Size(121, 20);
            this.AmounOfCoinbox.TabIndex = 2;
            this.AmounOfCoinbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Amount of Bitcoins";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(70, 195);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(37, 13);
            this.ResultLabel.TabIndex = 4;
            this.ResultLabel.Text = "Result";
            this.ResultLabel.Visible = false;
            this.ResultLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // resultTextbox
            // 
            this.resultTextbox.Location = new System.Drawing.Point(65, 211);
            this.resultTextbox.Name = "resultTextbox";
            this.resultTextbox.Size = new System.Drawing.Size(121, 20);
            this.resultTextbox.TabIndex = 5;
            this.resultTextbox.Visible = false;
            this.resultTextbox.TextChanged += new System.EventHandler(this.Result_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(689, 324);
            this.Controls.Add(this.resultTextbox);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AmounOfCoinbox);
            this.Controls.Add(this.BTNgetrates);
            this.Controls.Add(this.currencyCombo);
            this.Name = "Form1";
            this.Text = "Bitcoin Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox currencyCombo;
        private System.Windows.Forms.Button BTNgetrates;
        private System.Windows.Forms.TextBox AmounOfCoinbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.TextBox resultTextbox;
    }
}


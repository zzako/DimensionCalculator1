namespace DimensionCalculator1
{
    /// <summary>
    /// 
    /// </summary>
    partial class CExchange
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblConvertedCurrency = new System.Windows.Forms.Label();
            this.rbRand = new System.Windows.Forms.RadioButton();
            this.rbPound = new System.Windows.Forms.RadioButton();
            this.rbCanadian = new System.Windows.Forms.RadioButton();
            this.rbEuro = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblCurrencyType = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 22);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = " Dollar is ";
            // 
            // lblConvertedCurrency
            // 
            this.lblConvertedCurrency.AutoSize = true;
            this.lblConvertedCurrency.Location = new System.Drawing.Point(389, 44);
            this.lblConvertedCurrency.Name = "lblConvertedCurrency";
            this.lblConvertedCurrency.Size = new System.Drawing.Size(16, 17);
            this.lblConvertedCurrency.TabIndex = 1;
            this.lblConvertedCurrency.Text = "0";
            // 
            // rbRand
            // 
            this.rbRand.AutoSize = true;
            this.rbRand.Location = new System.Drawing.Point(56, 127);
            this.rbRand.Name = "rbRand";
            this.rbRand.Size = new System.Drawing.Size(63, 21);
            this.rbRand.TabIndex = 10;
            this.rbRand.TabStop = true;
            this.rbRand.Text = "Rand";
            this.rbRand.UseVisualStyleBackColor = true;
            this.rbRand.CheckedChanged += new System.EventHandler(this.rbRand_CheckedChanged);
            // 
            // rbPound
            // 
            this.rbPound.AutoSize = true;
            this.rbPound.Location = new System.Drawing.Point(56, 171);
            this.rbPound.Name = "rbPound";
            this.rbPound.Size = new System.Drawing.Size(70, 21);
            this.rbPound.TabIndex = 9;
            this.rbPound.TabStop = true;
            this.rbPound.Text = "Pound";
            this.rbPound.UseVisualStyleBackColor = true;
            this.rbPound.CheckedChanged += new System.EventHandler(this.rbPound_CheckedChanged);
            // 
            // rbCanadian
            // 
            this.rbCanadian.AutoSize = true;
            this.rbCanadian.Location = new System.Drawing.Point(56, 218);
            this.rbCanadian.Name = "rbCanadian";
            this.rbCanadian.Size = new System.Drawing.Size(130, 21);
            this.rbCanadian.TabIndex = 7;
            this.rbCanadian.TabStop = true;
            this.rbCanadian.Text = "Canadian Dollar";
            this.rbCanadian.UseVisualStyleBackColor = true;
            this.rbCanadian.CheckedChanged += new System.EventHandler(this.rbCanadian_CheckedChanged);
            // 
            // rbEuro
            // 
            this.rbEuro.AutoSize = true;
            this.rbEuro.Location = new System.Drawing.Point(56, 271);
            this.rbEuro.Name = "rbEuro";
            this.rbEuro.Size = new System.Drawing.Size(59, 21);
            this.rbEuro.TabIndex = 8;
            this.rbEuro.TabStop = true;
            this.rbEuro.Text = "Euro";
            this.rbEuro.UseVisualStyleBackColor = true;
            this.rbEuro.CheckedChanged += new System.EventHandler(this.rbEuro_CheckedChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(305, 271);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblCurrencyType
            // 
            this.lblCurrencyType.AutoSize = true;
            this.lblCurrencyType.Location = new System.Drawing.Point(422, 39);
            this.lblCurrencyType.Name = "lblCurrencyType";
            this.lblCurrencyType.Size = new System.Drawing.Size(0, 17);
            this.lblCurrencyType.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "class";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exchange
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 362);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCurrencyType);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.rbEuro);
            this.Controls.Add(this.rbCanadian);
            this.Controls.Add(this.rbPound);
            this.Controls.Add(this.rbRand);
            this.Controls.Add(this.lblConvertedCurrency);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Exchange";
            this.Text = "exchange1";
            this.Load += new System.EventHandler(this.Exchange_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblConvertedCurrency;
        private System.Windows.Forms.RadioButton rbRand;
        private System.Windows.Forms.RadioButton rbPound;
        private System.Windows.Forms.RadioButton rbCanadian;
        private System.Windows.Forms.RadioButton rbEuro;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblCurrencyType;
        private System.Windows.Forms.Button button1;
    }
}
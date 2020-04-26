namespace USD2EGYConverter
{
    partial class USD2EGY_Converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USD2EGY_Converter));
            this.lblCurrency1 = new System.Windows.Forms.Label();
            this.lbeCurrency2 = new System.Windows.Forms.Label();
            this.txtBoxCurrency1 = new System.Windows.Forms.TextBox();
            this.txtBoxCurrency2 = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCurrency1
            // 
            resources.ApplyResources(this.lblCurrency1, "lblCurrency1");
            this.lblCurrency1.Name = "lblCurrency1";
            // 
            // lbeCurrency2
            // 
            resources.ApplyResources(this.lbeCurrency2, "lbeCurrency2");
            this.lbeCurrency2.Name = "lbeCurrency2";
            // 
            // txtBoxCurrency1
            // 
            resources.ApplyResources(this.txtBoxCurrency1, "txtBoxCurrency1");
            this.txtBoxCurrency1.Name = "txtBoxCurrency1";
            this.txtBoxCurrency1.TextChanged += new System.EventHandler(this.txtBoxCurrency1_TextChanged);
            // 
            // txtBoxCurrency2
            // 
            resources.ApplyResources(this.txtBoxCurrency2, "txtBoxCurrency2");
            this.txtBoxCurrency2.Name = "txtBoxCurrency2";
            // 
            // btnConvert
            // 
            this.btnConvert.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnConvert, "btnConvert");
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // USD2EGY_Converter
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtBoxCurrency2);
            this.Controls.Add(this.txtBoxCurrency1);
            this.Controls.Add(this.lbeCurrency2);
            this.Controls.Add(this.lblCurrency1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Name = "USD2EGY_Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrency1;
        private System.Windows.Forms.Label lbeCurrency2;
        private System.Windows.Forms.TextBox txtBoxCurrency1;
        private System.Windows.Forms.TextBox txtBoxCurrency2;
        private System.Windows.Forms.Button btnConvert;
    }
}


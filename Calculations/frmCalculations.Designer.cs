namespace Calculations
{
    partial class FrmCalculations
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.lblCalculate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(79, 38);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(102, 23);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Вычислить";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(12, 12);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(169, 20);
            this.txtValue.TabIndex = 9;
            // 
            // lblCalculate
            // 
            this.lblCalculate.AutoSize = true;
            this.lblCalculate.Location = new System.Drawing.Point(12, 43);
            this.lblCalculate.Name = "lblCalculate";
            this.lblCalculate.Size = new System.Drawing.Size(35, 13);
            this.lblCalculate.TabIndex = 10;
            this.lblCalculate.Text = "label1";
            // 
            // FrmCalculations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblCalculate);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.btnCalculate);
            this.Name = "FrmCalculations";
            this.Text = "Form1";
            this.Closed += new System.EventHandler(this.FrmCalculations_Closed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label lblCalculate;
    }
}


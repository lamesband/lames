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
            this.lTxtValue = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            this.rTxtValue = new System.Windows.Forms.TextBox();
            this.operation = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 91);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(92, 23);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Вычислить";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lTxtValue
            // 
            this.lTxtValue.Location = new System.Drawing.Point(12, 12);
            this.lTxtValue.Name = "lTxtValue";
            this.lTxtValue.Size = new System.Drawing.Size(92, 20);
            this.lTxtValue.TabIndex = 9;
            this.lTxtValue.Text = "10";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(12, 123);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(32, 13);
            this.result.TabIndex = 10;
            this.result.Text = "result";
            // 
            // rTxtValue
            // 
            this.rTxtValue.Location = new System.Drawing.Point(12, 65);
            this.rTxtValue.Name = "rTxtValue";
            this.rTxtValue.Size = new System.Drawing.Size(92, 20);
            this.rTxtValue.TabIndex = 11;
            this.rTxtValue.Text = "2";
            // 
            // operation
            // 
            this.operation.Enabled = false;
            this.operation.Location = new System.Drawing.Point(12, 39);
            this.operation.Name = "operation";
            this.operation.Size = new System.Drawing.Size(92, 20);
            this.operation.TabIndex = 12;
            this.operation.Text = "/";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(139, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(168, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(23, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "/";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(197, 39);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(23, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "*";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FrmCalculations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.operation);
            this.Controls.Add(this.rTxtValue);
            this.Controls.Add(this.result);
            this.Controls.Add(this.lTxtValue);
            this.Controls.Add(this.btnCalculate);
            this.Name = "FrmCalculations";
            this.Text = "Form1";
            this.Closed += new System.EventHandler(this.FrmCalculations_Closed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox lTxtValue;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.TextBox rTxtValue;
        private System.Windows.Forms.TextBox operation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}


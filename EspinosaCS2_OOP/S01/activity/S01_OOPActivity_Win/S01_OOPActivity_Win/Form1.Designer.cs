namespace S01_OOPActivity_Win
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
            this.txtAddends1 = new System.Windows.Forms.TextBox();
            this.txtAddends2 = new System.Windows.Forms.TextBox();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAddends1
            // 
            this.txtAddends1.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F);
            this.txtAddends1.Location = new System.Drawing.Point(59, 32);
            this.txtAddends1.Name = "txtAddends1";
            this.txtAddends1.Size = new System.Drawing.Size(76, 75);
            this.txtAddends1.TabIndex = 0;
            this.txtAddends1.TextChanged += new System.EventHandler(this.txtAddends1_TextChanged);
            // 
            // txtAddends2
            // 
            this.txtAddends2.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F);
            this.txtAddends2.Location = new System.Drawing.Point(212, 32);
            this.txtAddends2.Name = "txtAddends2";
            this.txtAddends2.Size = new System.Drawing.Size(79, 75);
            this.txtAddends2.TabIndex = 1;
            // 
            // txtSum
            // 
            this.txtSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F);
            this.txtSum.Location = new System.Drawing.Point(379, 32);
            this.txtSum.Name = "txtSum";
            this.txtSum.ReadOnly = true;
            this.txtSum.Size = new System.Drawing.Size(150, 75);
            this.txtSum.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "+";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(312, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 55);
            this.label2.TabIndex = 4;
            this.label2.Text = "=";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(454, 125);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(603, 288);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.txtAddends2);
            this.Controls.Add(this.txtAddends1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAddends1;
        private System.Windows.Forms.TextBox txtAddends2;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalculate;
    }
}


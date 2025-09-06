namespace A01_Calculator
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btn0 = new Button();
            btnDot = new Button();
            btnPlus = new Button();
            btnEqual = new Button();
            btnMinus = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnDivide = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnErase = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            textDisplay = new TextBox();
            textEquation = new TextBox();
            btnSettings = new Button();
            btnTimes = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            textHistory = new TextBox();
            lblHistory = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(0, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 67);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(0, 23);
            textBox2.TabIndex = 1;
            // 
            // btn0
            // 
            btn0.BackColor = Color.FromArgb(255, 224, 192);
            btn0.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn0.Location = new Point(12, 290);
            btn0.Name = "btn0";
            btn0.Size = new Size(50, 50);
            btn0.TabIndex = 2;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += Load_Key;
            // 
            // btnDot
            // 
            btnDot.BackColor = Color.FromArgb(255, 224, 192);
            btnDot.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDot.Location = new Point(62, 290);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(50, 50);
            btnDot.TabIndex = 3;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            btnDot.Click += Load_Key;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.FromArgb(255, 224, 192);
            btnPlus.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlus.Location = new Point(112, 290);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(50, 50);
            btnPlus.TabIndex = 4;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += Operator;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = Color.FromArgb(255, 224, 192);
            btnEqual.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEqual.Location = new Point(162, 290);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(50, 50);
            btnEqual.TabIndex = 5;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += Total;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.FromArgb(255, 224, 192);
            btnMinus.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinus.Location = new Point(162, 241);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(50, 50);
            btnMinus.TabIndex = 9;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += Operator;
            // 
            // btn3
            // 
            btn3.BackColor = Color.FromArgb(255, 224, 192);
            btn3.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.Location = new Point(112, 241);
            btn3.Name = "btn3";
            btn3.Size = new Size(50, 50);
            btn3.TabIndex = 8;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += Load_Key;
            // 
            // btn2
            // 
            btn2.BackColor = Color.FromArgb(255, 224, 192);
            btn2.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.Location = new Point(62, 241);
            btn2.Name = "btn2";
            btn2.Size = new Size(50, 50);
            btn2.TabIndex = 7;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += Load_Key;
            // 
            // btn1
            // 
            btn1.BackColor = Color.FromArgb(255, 224, 192);
            btn1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.Location = new Point(12, 241);
            btn1.Name = "btn1";
            btn1.Size = new Size(50, 50);
            btn1.TabIndex = 6;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += Load_Key;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.FromArgb(255, 224, 192);
            btnDivide.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDivide.Location = new Point(162, 191);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(50, 50);
            btnDivide.TabIndex = 13;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += Operator;
            // 
            // btn6
            // 
            btn6.BackColor = Color.FromArgb(255, 224, 192);
            btn6.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn6.Location = new Point(112, 191);
            btn6.Name = "btn6";
            btn6.Size = new Size(50, 50);
            btn6.TabIndex = 12;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += Load_Key;
            // 
            // btn5
            // 
            btn5.BackColor = Color.FromArgb(255, 224, 192);
            btn5.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5.Location = new Point(62, 191);
            btn5.Name = "btn5";
            btn5.Size = new Size(50, 50);
            btn5.TabIndex = 11;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += Load_Key;
            // 
            // btn4
            // 
            btn4.BackColor = Color.FromArgb(255, 224, 192);
            btn4.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.Location = new Point(12, 191);
            btn4.Name = "btn4";
            btn4.Size = new Size(50, 50);
            btn4.TabIndex = 10;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += Load_Key;
            // 
            // btnErase
            // 
            btnErase.BackColor = Color.FromArgb(255, 224, 192);
            btnErase.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnErase.Location = new Point(162, 92);
            btnErase.Name = "btnErase";
            btnErase.Size = new Size(50, 50);
            btnErase.TabIndex = 17;
            btnErase.Text = "⌫";
            btnErase.UseVisualStyleBackColor = false;
            btnErase.Click += btnErase_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 224, 192);
            btnDelete.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(112, 92);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(50, 50);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "C";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 224, 192);
            btnClear.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(62, 92);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(50, 50);
            btnClear.TabIndex = 15;
            btnClear.Text = "CE";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // textDisplay
            // 
            textDisplay.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textDisplay.Location = new Point(12, 56);
            textDisplay.Name = "textDisplay";
            textDisplay.Size = new Size(200, 35);
            textDisplay.TabIndex = 18;
            textDisplay.TextChanged += textBox3_TextChanged;
            // 
            // textEquation
            // 
            textEquation.BackColor = Color.FromArgb(255, 224, 192);
            textEquation.Location = new Point(12, 33);
            textEquation.Name = "textEquation";
            textEquation.Size = new Size(200, 23);
            textEquation.TabIndex = 19;
            textEquation.TextChanged += textEquation_TextChanged;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.FromArgb(255, 224, 192);
            btnSettings.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSettings.Location = new Point(182, 5);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(30, 30);
            btnSettings.TabIndex = 20;
            btnSettings.Text = "☰";
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnTimes
            // 
            btnTimes.BackColor = Color.FromArgb(255, 224, 192);
            btnTimes.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimes.Location = new Point(161, 141);
            btnTimes.Name = "btnTimes";
            btnTimes.Size = new Size(50, 50);
            btnTimes.TabIndex = 24;
            btnTimes.Text = "*";
            btnTimes.UseVisualStyleBackColor = false;
            btnTimes.Click += Operator;
            // 
            // btn9
            // 
            btn9.BackColor = Color.FromArgb(255, 224, 192);
            btn9.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn9.Location = new Point(111, 141);
            btn9.Name = "btn9";
            btn9.Size = new Size(50, 50);
            btn9.TabIndex = 23;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += Load_Key;
            // 
            // btn8
            // 
            btn8.BackColor = Color.FromArgb(255, 224, 192);
            btn8.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn8.Location = new Point(61, 141);
            btn8.Name = "btn8";
            btn8.Size = new Size(50, 50);
            btn8.TabIndex = 22;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += Load_Key;
            // 
            // btn7
            // 
            btn7.BackColor = Color.FromArgb(255, 224, 192);
            btn7.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn7.Location = new Point(11, 141);
            btn7.Name = "btn7";
            btn7.Size = new Size(50, 50);
            btn7.TabIndex = 21;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += Load_Key;
            // 
            // textHistory
            // 
            textHistory.Location = new Point(219, 37);
            textHistory.Multiline = true;
            textHistory.Name = "textHistory";
            textHistory.Size = new Size(124, 303);
            textHistory.TabIndex = 25;
            // 
            // lblHistory
            // 
            lblHistory.AutoSize = true;
            lblHistory.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblHistory.Location = new Point(220, 19);
            lblHistory.Name = "lblHistory";
            lblHistory.Size = new Size(57, 15);
            lblHistory.TabIndex = 26;
            lblHistory.Text = "HISTORY";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 352);
            Controls.Add(lblHistory);
            Controls.Add(textHistory);
            Controls.Add(btnTimes);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnSettings);
            Controls.Add(textEquation);
            Controls.Add(textDisplay);
            Controls.Add(btnErase);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnDivide);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnMinus);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnEqual);
            Controls.Add(btnPlus);
            Controls.Add(btnDot);
            Controls.Add(btn0);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "CALCULATOR";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button btn0;
        private Button btnDot;
        private Button btnPlus;
        private Button btnEqual;
        private Button btnMinus;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnDivide;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnErase;
        private Button btnDelete;
        private Button btnClear;
        private TextBox textDisplay;
        private TextBox textEquation;
        private Button btnSettings;
        private Button btnTimes;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private TextBox textHistory;
        private Label lblHistory;
    }
}

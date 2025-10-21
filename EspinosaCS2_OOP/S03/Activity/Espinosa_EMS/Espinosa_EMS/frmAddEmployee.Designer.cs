namespace Espinosa_EMS
{
    partial class frmAddEmployee
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
            this.pnlSubtitle = new System.Windows.Forms.Panel();
            this.lblAddEmployee = new System.Windows.Forms.Label();
            this.gbEmployeeInput = new System.Windows.Forms.GroupBox();
            this.btnInsertUpdate = new System.Windows.Forms.Button();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.tbLocalNumber = new System.Windows.Forms.TextBox();
            this.tbEmailAddress = new System.Windows.Forms.TextBox();
            this.tbRequestorName = new System.Windows.Forms.TextBox();
            this.tbEmployeeNumber = new System.Windows.Forms.TextBox();
            this.lblSection = new System.Windows.Forms.Label();
            this.lblLocalNumber = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.lblRequestorName = new System.Windows.Forms.Label();
            this.lblEmployeeNumber = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlSubtitle.SuspendLayout();
            this.gbEmployeeInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSubtitle
            // 
            this.pnlSubtitle.BackColor = System.Drawing.Color.Bisque;
            this.pnlSubtitle.Controls.Add(this.lblAddEmployee);
            this.pnlSubtitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubtitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSubtitle.Location = new System.Drawing.Point(0, 0);
            this.pnlSubtitle.Name = "pnlSubtitle";
            this.pnlSubtitle.Size = new System.Drawing.Size(588, 55);
            this.pnlSubtitle.TabIndex = 1;
            // 
            // lblAddEmployee
            // 
            this.lblAddEmployee.AutoSize = true;
            this.lblAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEmployee.Location = new System.Drawing.Point(12, 21);
            this.lblAddEmployee.Name = "lblAddEmployee";
            this.lblAddEmployee.Size = new System.Drawing.Size(97, 16);
            this.lblAddEmployee.TabIndex = 2;
            this.lblAddEmployee.Text = "Add Employee";
            // 
            // gbEmployeeInput
            // 
            this.gbEmployeeInput.Controls.Add(this.btnDelete);
            this.gbEmployeeInput.Controls.Add(this.btnInsertUpdate);
            this.gbEmployeeInput.Controls.Add(this.cmbSection);
            this.gbEmployeeInput.Controls.Add(this.tbLocalNumber);
            this.gbEmployeeInput.Controls.Add(this.tbEmailAddress);
            this.gbEmployeeInput.Controls.Add(this.tbRequestorName);
            this.gbEmployeeInput.Controls.Add(this.tbEmployeeNumber);
            this.gbEmployeeInput.Controls.Add(this.lblSection);
            this.gbEmployeeInput.Controls.Add(this.lblLocalNumber);
            this.gbEmployeeInput.Controls.Add(this.lblEmailAddress);
            this.gbEmployeeInput.Controls.Add(this.lblRequestorName);
            this.gbEmployeeInput.Controls.Add(this.lblEmployeeNumber);
            this.gbEmployeeInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbEmployeeInput.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEmployeeInput.Location = new System.Drawing.Point(0, 55);
            this.gbEmployeeInput.Name = "gbEmployeeInput";
            this.gbEmployeeInput.Size = new System.Drawing.Size(588, 204);
            this.gbEmployeeInput.TabIndex = 2;
            this.gbEmployeeInput.TabStop = false;
            this.gbEmployeeInput.Text = "Employee Details Manual Insert and Update:";
            // 
            // btnInsertUpdate
            // 
            this.btnInsertUpdate.BackColor = System.Drawing.Color.Bisque;
            this.btnInsertUpdate.FlatAppearance.BorderSize = 0;
            this.btnInsertUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertUpdate.Location = new System.Drawing.Point(116, 158);
            this.btnInsertUpdate.Name = "btnInsertUpdate";
            this.btnInsertUpdate.Size = new System.Drawing.Size(118, 23);
            this.btnInsertUpdate.TabIndex = 10;
            this.btnInsertUpdate.Text = "INSERT / UPDATE";
            this.btnInsertUpdate.UseVisualStyleBackColor = false;
            this.btnInsertUpdate.Click += new System.EventHandler(this.btnInsertUpdate_Click);
            // 
            // cmbSection
            // 
            this.cmbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSection.FormattingEnabled = true;
            this.cmbSection.Items.AddRange(new object[] {
            "BPS",
            "IT",
            "HR",
            "GA",
            "Printer",
            "Tape"});
            this.cmbSection.Location = new System.Drawing.Point(115, 130);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(277, 21);
            this.cmbSection.TabIndex = 9;
            // 
            // tbLocalNumber
            // 
            this.tbLocalNumber.Location = new System.Drawing.Point(116, 104);
            this.tbLocalNumber.Name = "tbLocalNumber";
            this.tbLocalNumber.Size = new System.Drawing.Size(276, 22);
            this.tbLocalNumber.TabIndex = 8;
            // 
            // tbEmailAddress
            // 
            this.tbEmailAddress.Location = new System.Drawing.Point(115, 78);
            this.tbEmailAddress.Name = "tbEmailAddress";
            this.tbEmailAddress.Size = new System.Drawing.Size(277, 22);
            this.tbEmailAddress.TabIndex = 7;
            // 
            // tbRequestorName
            // 
            this.tbRequestorName.Location = new System.Drawing.Point(116, 52);
            this.tbRequestorName.Name = "tbRequestorName";
            this.tbRequestorName.Size = new System.Drawing.Size(276, 22);
            this.tbRequestorName.TabIndex = 6;
            // 
            // tbEmployeeNumber
            // 
            this.tbEmployeeNumber.Location = new System.Drawing.Point(116, 26);
            this.tbEmployeeNumber.Name = "tbEmployeeNumber";
            this.tbEmployeeNumber.Size = new System.Drawing.Size(276, 22);
            this.tbEmployeeNumber.TabIndex = 5;
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSection.Location = new System.Drawing.Point(63, 132);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(48, 13);
            this.lblSection.TabIndex = 4;
            this.lblSection.Text = "Section:";
            // 
            // lblLocalNumber
            // 
            this.lblLocalNumber.AutoSize = true;
            this.lblLocalNumber.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalNumber.Location = new System.Drawing.Point(33, 106);
            this.lblLocalNumber.Name = "lblLocalNumber";
            this.lblLocalNumber.Size = new System.Drawing.Size(80, 13);
            this.lblLocalNumber.TabIndex = 3;
            this.lblLocalNumber.Text = "Local Number:";
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailAddress.Location = new System.Drawing.Point(33, 80);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(81, 13);
            this.lblEmailAddress.TabIndex = 2;
            this.lblEmailAddress.Text = "Email Address:";
            this.lblEmailAddress.Click += new System.EventHandler(this.lblEmailAddress_Click);
            // 
            // lblRequestorName
            // 
            this.lblRequestorName.AutoSize = true;
            this.lblRequestorName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestorName.Location = new System.Drawing.Point(19, 54);
            this.lblRequestorName.Name = "lblRequestorName";
            this.lblRequestorName.Size = new System.Drawing.Size(95, 13);
            this.lblRequestorName.TabIndex = 1;
            this.lblRequestorName.Text = "Requestor Name:";
            // 
            // lblEmployeeNumber
            // 
            this.lblEmployeeNumber.AutoSize = true;
            this.lblEmployeeNumber.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeNumber.Location = new System.Drawing.Point(13, 28);
            this.lblEmployeeNumber.Name = "lblEmployeeNumber";
            this.lblEmployeeNumber.Size = new System.Drawing.Size(103, 13);
            this.lblEmployeeNumber.TabIndex = 0;
            this.lblEmployeeNumber.Text = "Employee Number:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Bisque;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(240, 157);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(118, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(588, 403);
            this.Controls.Add(this.gbEmployeeInput);
            this.Controls.Add(this.pnlSubtitle);
            this.Name = "frmAddEmployee";
            this.Text = "frmAddEmployee";
            this.Load += new System.EventHandler(this.frmAddEmployee_Load);
            this.pnlSubtitle.ResumeLayout(false);
            this.pnlSubtitle.PerformLayout();
            this.gbEmployeeInput.ResumeLayout(false);
            this.gbEmployeeInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSubtitle;
        private System.Windows.Forms.Label lblAddEmployee;
        private System.Windows.Forms.GroupBox gbEmployeeInput;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.Label lblLocalNumber;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Label lblRequestorName;
        private System.Windows.Forms.Label lblEmployeeNumber;
        private System.Windows.Forms.ComboBox cmbSection;
        private System.Windows.Forms.TextBox tbLocalNumber;
        private System.Windows.Forms.TextBox tbEmailAddress;
        private System.Windows.Forms.TextBox tbRequestorName;
        private System.Windows.Forms.TextBox tbEmployeeNumber;
        private System.Windows.Forms.Button btnInsertUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}
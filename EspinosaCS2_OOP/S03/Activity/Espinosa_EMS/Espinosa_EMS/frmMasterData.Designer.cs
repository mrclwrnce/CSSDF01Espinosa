namespace Espinosa_EMS
{
    partial class frmMasterData
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
            this.pnlSubTitle = new System.Windows.Forms.Panel();
            this.lblMasterData = new System.Windows.Forms.Label();
            this.dgvMasterdata = new System.Windows.Forms.DataGridView();
            this.btnEditData = new System.Windows.Forms.Button();
            this.lblTransactionNo = new System.Windows.Forms.Label();
            this.pnlSubTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasterdata)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSubTitle
            // 
            this.pnlSubTitle.BackColor = System.Drawing.Color.Bisque;
            this.pnlSubTitle.Controls.Add(this.lblMasterData);
            this.pnlSubTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlSubTitle.Name = "pnlSubTitle";
            this.pnlSubTitle.Size = new System.Drawing.Size(588, 55);
            this.pnlSubTitle.TabIndex = 0;
            // 
            // lblMasterData
            // 
            this.lblMasterData.AutoSize = true;
            this.lblMasterData.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasterData.Location = new System.Drawing.Point(12, 22);
            this.lblMasterData.Name = "lblMasterData";
            this.lblMasterData.Size = new System.Drawing.Size(80, 17);
            this.lblMasterData.TabIndex = 0;
            this.lblMasterData.Text = "Master Data";
            // 
            // dgvMasterdata
            // 
            this.dgvMasterdata.BackgroundColor = System.Drawing.Color.Linen;
            this.dgvMasterdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMasterdata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMasterdata.Location = new System.Drawing.Point(0, 55);
            this.dgvMasterdata.Name = "dgvMasterdata";
            this.dgvMasterdata.Size = new System.Drawing.Size(588, 298);
            this.dgvMasterdata.TabIndex = 1;
            this.dgvMasterdata.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMasterdata_CellClick);
            // 
            // btnEditData
            // 
            this.btnEditData.BackColor = System.Drawing.Color.Bisque;
            this.btnEditData.FlatAppearance.BorderSize = 0;
            this.btnEditData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditData.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditData.Location = new System.Drawing.Point(497, 365);
            this.btnEditData.Name = "btnEditData";
            this.btnEditData.Size = new System.Drawing.Size(75, 23);
            this.btnEditData.TabIndex = 2;
            this.btnEditData.Text = "Edit Data";
            this.btnEditData.UseVisualStyleBackColor = false;
            this.btnEditData.Click += new System.EventHandler(this.btnEditData_Click);
            // 
            // lblTransactionNo
            // 
            this.lblTransactionNo.AutoSize = true;
            this.lblTransactionNo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionNo.Location = new System.Drawing.Point(15, 370);
            this.lblTransactionNo.Name = "lblTransactionNo";
            this.lblTransactionNo.Size = new System.Drawing.Size(144, 13);
            this.lblTransactionNo.TabIndex = 3;
            this.lblTransactionNo.Text = "<TRANSACTION NUMBER>";
            // 
            // frmMasterData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 403);
            this.Controls.Add(this.lblTransactionNo);
            this.Controls.Add(this.btnEditData);
            this.Controls.Add(this.dgvMasterdata);
            this.Controls.Add(this.pnlSubTitle);
            this.Name = "frmMasterData";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.Text = "frmMasterData";
            this.Load += new System.EventHandler(this.frmMasterData_Load);
            this.pnlSubTitle.ResumeLayout(false);
            this.pnlSubTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasterdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSubTitle;
        private System.Windows.Forms.DataGridView dgvMasterdata;
        private System.Windows.Forms.Label lblMasterData;
        private System.Windows.Forms.Button btnEditData;
        private System.Windows.Forms.Label lblTransactionNo;
    }
}
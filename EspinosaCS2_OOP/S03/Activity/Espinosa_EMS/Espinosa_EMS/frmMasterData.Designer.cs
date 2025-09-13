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
            this.dgvMasterdata = new System.Windows.Forms.DataGridView();
            this.lblMasterData = new System.Windows.Forms.Label();
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
            // dgvMasterdata
            // 
            this.dgvMasterdata.BackgroundColor = System.Drawing.Color.Linen;
            this.dgvMasterdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMasterdata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMasterdata.Location = new System.Drawing.Point(0, 55);
            this.dgvMasterdata.Name = "dgvMasterdata";
            this.dgvMasterdata.Size = new System.Drawing.Size(588, 348);
            this.dgvMasterdata.TabIndex = 1;
            // 
            // lblMasterData
            // 
            this.lblMasterData.AutoSize = true;
            this.lblMasterData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasterData.Location = new System.Drawing.Point(12, 22);
            this.lblMasterData.Name = "lblMasterData";
            this.lblMasterData.Size = new System.Drawing.Size(80, 16);
            this.lblMasterData.TabIndex = 0;
            this.lblMasterData.Text = "Master Data";
            // 
            // frmMasterData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 403);
            this.Controls.Add(this.dgvMasterdata);
            this.Controls.Add(this.pnlSubTitle);
            this.Name = "frmMasterData";
            this.Text = "frmMasterData";
            this.pnlSubTitle.ResumeLayout(false);
            this.pnlSubTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasterdata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSubTitle;
        private System.Windows.Forms.DataGridView dgvMasterdata;
        private System.Windows.Forms.Label lblMasterData;
    }
}
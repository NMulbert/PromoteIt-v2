namespace Login_SignIn
{
    partial class Activists_MainUI
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
            this.dgvAllActiveCampaigns = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllActiveCampaigns)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllActiveCampaigns
            // 
            this.dgvAllActiveCampaigns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAllActiveCampaigns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllActiveCampaigns.Location = new System.Drawing.Point(12, 65);
            this.dgvAllActiveCampaigns.Name = "dgvAllActiveCampaigns";
            this.dgvAllActiveCampaigns.RowHeadersWidth = 51;
            this.dgvAllActiveCampaigns.RowTemplate.Height = 29;
            this.dgvAllActiveCampaigns.Size = new System.Drawing.Size(895, 188);
            this.dgvAllActiveCampaigns.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(326, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "All Active Campaigns";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Balance";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(12, 295);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(0, 20);
            this.lblBalance.TabIndex = 3;
            // 
            // Activists_MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 462);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAllActiveCampaigns);
            this.Name = "Activists_MainUI";
            this.Text = "Activists_MainUI";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllActiveCampaigns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvAllActiveCampaigns;
        private Label label1;
        private Label label2;
        private Label lblBalance;
    }
}
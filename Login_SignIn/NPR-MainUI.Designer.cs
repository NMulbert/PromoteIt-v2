namespace Login_SignIn
{
    partial class NPR_MainUI
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
            this.dgvCampaigns = new System.Windows.Forms.DataGridView();
            this.txtCampaignName = new System.Windows.Forms.TextBox();
            this.txtCampaignLink = new System.Windows.Forms.TextBox();
            this.txtCampaignHashtag = new System.Windows.Forms.TextBox();
            this.createBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCampaignName = new System.Windows.Forms.Label();
            this.lblCampaignLink = new System.Windows.Forms.Label();
            this.lblCampaignHashTag = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampaigns)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCampaigns
            // 
            this.dgvCampaigns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCampaigns.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvCampaigns.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvCampaigns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCampaigns.Location = new System.Drawing.Point(436, 48);
            this.dgvCampaigns.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCampaigns.Name = "dgvCampaigns";
            this.dgvCampaigns.RowHeadersWidth = 51;
            this.dgvCampaigns.RowTemplate.Height = 29;
            this.dgvCampaigns.Size = new System.Drawing.Size(482, 245);
            this.dgvCampaigns.TabIndex = 0;
            // 
            // txtCampaignName
            // 
            this.txtCampaignName.Location = new System.Drawing.Point(133, 92);
            this.txtCampaignName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCampaignName.Name = "txtCampaignName";
            this.txtCampaignName.Size = new System.Drawing.Size(140, 23);
            this.txtCampaignName.TabIndex = 1;
            // 
            // txtCampaignLink
            // 
            this.txtCampaignLink.Location = new System.Drawing.Point(133, 116);
            this.txtCampaignLink.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCampaignLink.Name = "txtCampaignLink";
            this.txtCampaignLink.Size = new System.Drawing.Size(140, 23);
            this.txtCampaignLink.TabIndex = 2;
            // 
            // txtCampaignHashtag
            // 
            this.txtCampaignHashtag.Location = new System.Drawing.Point(133, 141);
            this.txtCampaignHashtag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCampaignHashtag.Name = "txtCampaignHashtag";
            this.txtCampaignHashtag.Size = new System.Drawing.Size(140, 23);
            this.txtCampaignHashtag.TabIndex = 3;
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(157, 166);
            this.createBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(82, 22);
            this.createBtn.TabIndex = 4;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(115, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Create Campaign";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Campaign Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Campaign Link :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Campaign Hashtag :";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(605, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "All Campaigns";
            // 
            // lblCampaignName
            // 
            this.lblCampaignName.AutoSize = true;
            this.lblCampaignName.Location = new System.Drawing.Point(279, 95);
            this.lblCampaignName.Name = "lblCampaignName";
            this.lblCampaignName.Size = new System.Drawing.Size(0, 15);
            this.lblCampaignName.TabIndex = 10;
            // 
            // lblCampaignLink
            // 
            this.lblCampaignLink.AutoSize = true;
            this.lblCampaignLink.Location = new System.Drawing.Point(279, 124);
            this.lblCampaignLink.Name = "lblCampaignLink";
            this.lblCampaignLink.Size = new System.Drawing.Size(0, 15);
            this.lblCampaignLink.TabIndex = 11;
            // 
            // lblCampaignHashTag
            // 
            this.lblCampaignHashTag.AutoSize = true;
            this.lblCampaignHashTag.Location = new System.Drawing.Point(279, 144);
            this.lblCampaignHashTag.Name = "lblCampaignHashTag";
            this.lblCampaignHashTag.Size = new System.Drawing.Size(0, 15);
            this.lblCampaignHashTag.TabIndex = 12;
            // 
            // NPR_MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 338);
            this.Controls.Add(this.lblCampaignHashTag);
            this.Controls.Add(this.lblCampaignLink);
            this.Controls.Add(this.lblCampaignName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.txtCampaignHashtag);
            this.Controls.Add(this.txtCampaignLink);
            this.Controls.Add(this.txtCampaignName);
            this.Controls.Add(this.dgvCampaigns);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NPR_MainUI";
            this.Text = "NPR_MainUI";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampaigns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvCampaigns;
        private TextBox txtCampaignName;
        private TextBox txtCampaignLink;
        private TextBox txtCampaignHashtag;
        private Button createBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblCampaignName;
        private Label lblCampaignLink;
        private Label lblCampaignHashTag;
    }
}
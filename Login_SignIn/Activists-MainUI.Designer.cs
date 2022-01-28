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
            this.lblInstuctions = new System.Windows.Forms.Label();
            this.lblSelectedItem = new System.Windows.Forms.Label();
            this.lblSelectedItemPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuy = new System.Windows.Forms.Button();
            this.txtAddressBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAddressEmpty = new System.Windows.Forms.Label();
            this.btnUpdateBalance = new System.Windows.Forms.Button();
            this.btnRefreshCampaigns = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllActiveCampaigns)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllActiveCampaigns
            // 
            this.dgvAllActiveCampaigns.AllowUserToAddRows = false;
            this.dgvAllActiveCampaigns.AllowUserToDeleteRows = false;
            this.dgvAllActiveCampaigns.AllowUserToOrderColumns = true;
            this.dgvAllActiveCampaigns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAllActiveCampaigns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllActiveCampaigns.Location = new System.Drawing.Point(10, 49);
            this.dgvAllActiveCampaigns.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAllActiveCampaigns.Name = "dgvAllActiveCampaigns";
            this.dgvAllActiveCampaigns.ReadOnly = true;
            this.dgvAllActiveCampaigns.RowHeadersWidth = 51;
            this.dgvAllActiveCampaigns.RowTemplate.Height = 29;
            this.dgvAllActiveCampaigns.Size = new System.Drawing.Size(783, 141);
            this.dgvAllActiveCampaigns.TabIndex = 0;
            this.dgvAllActiveCampaigns.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllActiveCampaigns_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(285, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "All Active Campaigns";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Balance";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(10, 228);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(0, 15);
            this.lblBalance.TabIndex = 3;
            // 
            // lblInstuctions
            // 
            this.lblInstuctions.AutoSize = true;
            this.lblInstuctions.Location = new System.Drawing.Point(10, 192);
            this.lblInstuctions.Name = "lblInstuctions";
            this.lblInstuctions.Size = new System.Drawing.Size(462, 15);
            this.lblInstuctions.TabIndex = 4;
            this.lblInstuctions.Text = "To buy a product select the id of the campaign from which you want to buy a produ" +
    "ct.";
            // 
            // lblSelectedItem
            // 
            this.lblSelectedItem.AutoSize = true;
            this.lblSelectedItem.Location = new System.Drawing.Point(74, 261);
            this.lblSelectedItem.Name = "lblSelectedItem";
            this.lblSelectedItem.Size = new System.Drawing.Size(0, 15);
            this.lblSelectedItem.TabIndex = 5;
            // 
            // lblSelectedItemPrice
            // 
            this.lblSelectedItemPrice.AutoSize = true;
            this.lblSelectedItemPrice.Location = new System.Drawing.Point(74, 276);
            this.lblSelectedItemPrice.Name = "lblSelectedItemPrice";
            this.lblSelectedItemPrice.Size = new System.Drawing.Size(0, 15);
            this.lblSelectedItemPrice.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(10, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Product :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(10, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Price :";
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(360, 310);
            this.btnBuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(82, 22);
            this.btnBuy.TabIndex = 9;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // txtAddressBox
            // 
            this.txtAddressBox.Location = new System.Drawing.Point(165, 310);
            this.txtAddressBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddressBox.Name = "txtAddressBox";
            this.txtAddressBox.Size = new System.Drawing.Size(190, 23);
            this.txtAddressBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Please enter an address :";
            // 
            // lblAddressEmpty
            // 
            this.lblAddressEmpty.AutoSize = true;
            this.lblAddressEmpty.Location = new System.Drawing.Point(165, 292);
            this.lblAddressEmpty.Name = "lblAddressEmpty";
            this.lblAddressEmpty.Size = new System.Drawing.Size(0, 15);
            this.lblAddressEmpty.TabIndex = 12;
            // 
            // btnUpdateBalance
            // 
            this.btnUpdateBalance.Location = new System.Drawing.Point(99, 238);
            this.btnUpdateBalance.Name = "btnUpdateBalance";
            this.btnUpdateBalance.Size = new System.Drawing.Size(101, 23);
            this.btnUpdateBalance.TabIndex = 13;
            this.btnUpdateBalance.Text = "Update balance";
            this.btnUpdateBalance.UseVisualStyleBackColor = true;
            this.btnUpdateBalance.Click += new System.EventHandler(this.btnUpdateBalance_Click);
            // 
            // btnRefreshCampaigns
            // 
            this.btnRefreshCampaigns.Location = new System.Drawing.Point(647, 195);
            this.btnRefreshCampaigns.Name = "btnRefreshCampaigns";
            this.btnRefreshCampaigns.Size = new System.Drawing.Size(145, 23);
            this.btnRefreshCampaigns.TabIndex = 14;
            this.btnRefreshCampaigns.Text = "Refresh Campaigns";
            this.btnRefreshCampaigns.UseVisualStyleBackColor = true;
            this.btnRefreshCampaigns.Click += new System.EventHandler(this.btnRefreshCampaigns_Click);
            // 
            // Activists_MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 346);
            this.Controls.Add(this.btnRefreshCampaigns);
            this.Controls.Add(this.btnUpdateBalance);
            this.Controls.Add(this.lblAddressEmpty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAddressBox);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSelectedItemPrice);
            this.Controls.Add(this.lblSelectedItem);
            this.Controls.Add(this.lblInstuctions);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAllActiveCampaigns);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private Label lblInstuctions;
        private Label lblSelectedItem;
        private Label lblSelectedItemPrice;
        private Label label3;
        private Label label4;
        private Button btnBuy;
        private TextBox txtAddressBox;
        private Label label5;
        private Label lblAddressEmpty;
        private Button btnUpdateBalance;
        private Button btnRefreshCampaigns;
    }
}
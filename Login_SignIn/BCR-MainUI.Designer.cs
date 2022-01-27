namespace Login_SignIn
{
    partial class BCR_MainUI
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
            this.dgvAvailableCampaigns = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCampaignName = new System.Windows.Forms.TextBox();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblCampaignNameError = new System.Windows.Forms.Label();
            this.lblProductError = new System.Windows.Forms.Label();
            this.lblCountError = new System.Windows.Forms.Label();
            this.lblPriceError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableCampaigns)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAvailableCampaigns
            // 
            this.dgvAvailableCampaigns.AllowUserToAddRows = false;
            this.dgvAvailableCampaigns.AllowUserToDeleteRows = false;
            this.dgvAvailableCampaigns.AllowUserToResizeColumns = false;
            this.dgvAvailableCampaigns.AllowUserToResizeRows = false;
            this.dgvAvailableCampaigns.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvAvailableCampaigns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableCampaigns.Location = new System.Drawing.Point(12, 59);
            this.dgvAvailableCampaigns.MultiSelect = false;
            this.dgvAvailableCampaigns.Name = "dgvAvailableCampaigns";
            this.dgvAvailableCampaigns.ReadOnly = true;
            this.dgvAvailableCampaigns.RowHeadersWidth = 51;
            this.dgvAvailableCampaigns.RowTemplate.Height = 29;
            this.dgvAvailableCampaigns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvAvailableCampaigns.Size = new System.Drawing.Size(634, 229);
            this.dgvAvailableCampaigns.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available Campaigns";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Campaign Name";
            // 
            // txtCampaignName
            // 
            this.txtCampaignName.Location = new System.Drawing.Point(12, 343);
            this.txtCampaignName.Name = "txtCampaignName";
            this.txtCampaignName.Size = new System.Drawing.Size(177, 27);
            this.txtCampaignName.TabIndex = 3;
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(195, 343);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(177, 27);
            this.txtProduct.TabIndex = 4;
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(378, 342);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(177, 27);
            this.txtCount.TabIndex = 5;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(561, 342);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(177, 27);
            this.txtPrice.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Product";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Count";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(561, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Price";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(744, 341);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblCampaignNameError
            // 
            this.lblCampaignNameError.AutoSize = true;
            this.lblCampaignNameError.Location = new System.Drawing.Point(12, 373);
            this.lblCampaignNameError.Name = "lblCampaignNameError";
            this.lblCampaignNameError.Size = new System.Drawing.Size(0, 20);
            this.lblCampaignNameError.TabIndex = 11;
            // 
            // lblProductError
            // 
            this.lblProductError.AutoSize = true;
            this.lblProductError.Location = new System.Drawing.Point(195, 372);
            this.lblProductError.Name = "lblProductError";
            this.lblProductError.Size = new System.Drawing.Size(0, 20);
            this.lblProductError.TabIndex = 12;
            // 
            // lblCountError
            // 
            this.lblCountError.AutoSize = true;
            this.lblCountError.Location = new System.Drawing.Point(378, 372);
            this.lblCountError.Name = "lblCountError";
            this.lblCountError.Size = new System.Drawing.Size(0, 20);
            this.lblCountError.TabIndex = 13;
            // 
            // lblPriceError
            // 
            this.lblPriceError.AutoSize = true;
            this.lblPriceError.Location = new System.Drawing.Point(561, 372);
            this.lblPriceError.Name = "lblPriceError";
            this.lblPriceError.Size = new System.Drawing.Size(0, 20);
            this.lblPriceError.TabIndex = 14;
            // 
            // BCR_MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 518);
            this.Controls.Add(this.lblPriceError);
            this.Controls.Add(this.lblCountError);
            this.Controls.Add(this.lblProductError);
            this.Controls.Add(this.lblCampaignNameError);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.txtCampaignName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAvailableCampaigns);
            this.Name = "BCR_MainUI";
            this.Text = "BCR_MainUI";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableCampaigns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvAvailableCampaigns;
        private Label label1;
        private Label label2;
        private TextBox txtCampaignName;
        private TextBox txtProduct;
        private TextBox txtCount;
        private TextBox txtPrice;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnAdd;
        private Label lblCampaignNameError;
        private Label lblProductError;
        private Label lblCountError;
        private Label lblPriceError;
    }
}
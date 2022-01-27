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
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.lblOrders = new System.Windows.Forms.Label();
            this.btnGetOrders = new System.Windows.Forms.Button();
            this.lblOrderToUpdate = new System.Windows.Forms.Label();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.lblItemSelected = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableCampaigns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
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
            this.dgvAvailableCampaigns.Location = new System.Drawing.Point(10, 44);
            this.dgvAvailableCampaigns.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAvailableCampaigns.MultiSelect = false;
            this.dgvAvailableCampaigns.Name = "dgvAvailableCampaigns";
            this.dgvAvailableCampaigns.ReadOnly = true;
            this.dgvAvailableCampaigns.RowHeadersWidth = 51;
            this.dgvAvailableCampaigns.RowTemplate.Height = 29;
            this.dgvAvailableCampaigns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvAvailableCampaigns.Size = new System.Drawing.Size(555, 172);
            this.dgvAvailableCampaigns.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available Campaigns";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Campaign Name";
            // 
            // txtCampaignName
            // 
            this.txtCampaignName.Location = new System.Drawing.Point(10, 257);
            this.txtCampaignName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCampaignName.Name = "txtCampaignName";
            this.txtCampaignName.Size = new System.Drawing.Size(155, 23);
            this.txtCampaignName.TabIndex = 3;
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(171, 257);
            this.txtProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(155, 23);
            this.txtProduct.TabIndex = 4;
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(331, 256);
            this.txtCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(155, 23);
            this.txtCount.TabIndex = 5;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(491, 256);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(155, 23);
            this.txtPrice.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Product";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Count";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(491, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Price";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(651, 256);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 22);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblCampaignNameError
            // 
            this.lblCampaignNameError.AutoSize = true;
            this.lblCampaignNameError.Location = new System.Drawing.Point(10, 280);
            this.lblCampaignNameError.Name = "lblCampaignNameError";
            this.lblCampaignNameError.Size = new System.Drawing.Size(0, 15);
            this.lblCampaignNameError.TabIndex = 11;
            // 
            // lblProductError
            // 
            this.lblProductError.AutoSize = true;
            this.lblProductError.Location = new System.Drawing.Point(171, 279);
            this.lblProductError.Name = "lblProductError";
            this.lblProductError.Size = new System.Drawing.Size(0, 15);
            this.lblProductError.TabIndex = 12;
            // 
            // lblCountError
            // 
            this.lblCountError.AutoSize = true;
            this.lblCountError.Location = new System.Drawing.Point(331, 279);
            this.lblCountError.Name = "lblCountError";
            this.lblCountError.Size = new System.Drawing.Size(0, 15);
            this.lblCountError.TabIndex = 13;
            // 
            // lblPriceError
            // 
            this.lblPriceError.AutoSize = true;
            this.lblPriceError.Location = new System.Drawing.Point(491, 279);
            this.lblPriceError.Name = "lblPriceError";
            this.lblPriceError.Size = new System.Drawing.Size(0, 15);
            this.lblPriceError.TabIndex = 14;
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(760, 44);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.RowTemplate.Height = 25;
            this.dgvOrders.Size = new System.Drawing.Size(413, 172);
            this.dgvOrders.TabIndex = 15;
            this.dgvOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellClick);
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblOrders.Location = new System.Drawing.Point(760, 18);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(100, 25);
            this.lblOrders.TabIndex = 16;
            this.lblOrders.Text = "My Orders";
            // 
            // btnGetOrders
            // 
            this.btnGetOrders.Location = new System.Drawing.Point(760, 257);
            this.btnGetOrders.Name = "btnGetOrders";
            this.btnGetOrders.Size = new System.Drawing.Size(124, 23);
            this.btnGetOrders.TabIndex = 17;
            this.btnGetOrders.Text = "Get My Orders";
            this.btnGetOrders.UseVisualStyleBackColor = true;
            this.btnGetOrders.Click += new System.EventHandler(this.btnGetOrders_Click);
            // 
            // lblOrderToUpdate
            // 
            this.lblOrderToUpdate.AutoSize = true;
            this.lblOrderToUpdate.Location = new System.Drawing.Point(954, 229);
            this.lblOrderToUpdate.Name = "lblOrderToUpdate";
            this.lblOrderToUpdate.Size = new System.Drawing.Size(93, 15);
            this.lblOrderToUpdate.TabIndex = 18;
            this.lblOrderToUpdate.Text = "Order To Update";
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.Location = new System.Drawing.Point(1044, 257);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(129, 23);
            this.btnUpdateStatus.TabIndex = 19;
            this.btnUpdateStatus.Text = "Update Selected Order Status";
            this.btnUpdateStatus.UseVisualStyleBackColor = true;
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);
            // 
            // lblItemSelected
            // 
            this.lblItemSelected.AutoSize = true;
            this.lblItemSelected.Location = new System.Drawing.Point(760, 229);
            this.lblItemSelected.Name = "lblItemSelected";
            this.lblItemSelected.Size = new System.Drawing.Size(173, 15);
            this.lblItemSelected.TabIndex = 20;
            this.lblItemSelected.Text = "Select id of the order to update:";
           
            // 
            // BCR_MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 388);
            this.Controls.Add(this.lblItemSelected);
            this.Controls.Add(this.btnUpdateStatus);
            this.Controls.Add(this.lblOrderToUpdate);
            this.Controls.Add(this.btnGetOrders);
            this.Controls.Add(this.lblOrders);
            this.Controls.Add(this.dgvOrders);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BCR_MainUI";
            this.Text = "BCR_MainUI";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableCampaigns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
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
        private DataGridView dgvOrders;
        private Label lblOrders;
        private Button btnGetOrders;
        private Label lblOrderToUpdate;
        private Button btnUpdateStatus;
        private Label lblItemSelected;
    }
}
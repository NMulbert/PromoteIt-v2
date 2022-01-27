using Newtonsoft.Json;
using NPRCreateCampaign.Classes;
using OrderApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_SignIn
{
    public partial class BCR_MainUI : Form
    {
        List<Campaign> campaignsWithNoProducts;
        public BCR_MainUI()
        {
            InitializeComponent();
             
            GetCampaignsNoProductAsync();

        }

        private async void GetCampaignsNoProductAsync()
        {
            HttpClient client = new HttpClient();
            var url = "http://localhost:7730/api/GetCampaignsNoProducts";

            string response = await client.GetStringAsync(url);
            campaignsWithNoProducts = JsonConvert.DeserializeObject<List<Campaign>>(response);

            dgvAvailableCampaigns.DataSource = campaignsWithNoProducts;


        }

        private bool CheckCampaignName(string campaignName)
        {
            foreach (var item in campaignsWithNoProducts)
            {
                if (item.campaignName == campaignName)
                {
                    return true;
                }

            }
            
            return false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int flag = 0;

            if (txtCampaignName.Text == "")
            {
                lblCampaignNameError.Text = "Please enter \na campaign name.";
                flag++;
            }
            else if (!CheckCampaignName(txtCampaignName.Text))
            {
                lblCampaignNameError.Text = "Campaign name \ndoes not exist.";
                flag++;
            }
            else
            {
                lblCampaignNameError.Text = "";
            }
            if (txtProduct.Text == "")
            {
                lblProductError.Text = "Please enter a product.";
                flag++;
            }
            else
            {
                lblProductError.Text = "";
            }
            if (txtCount.Text == "")
            {
                lblCountError.Text = "Please enter \nthe number of products.";
                flag++;
            }
            else
            {
                lblCountError.Text = "";
            }
            if (txtPrice.Text == "")
            {
                lblPriceError.Text = "Please enter a price.";
            }
            else
            {
                lblPriceError.Text = "";
            }
            if (flag == 0)
            {
                AddProduct();
                Thread.Sleep(3000);
                GetCampaignsNoProductAsync();

            }
            else
            {
                flag = 0;
            }
        }

        private async void AddProduct()
        {
            HttpClient addProducClient = new HttpClient();
            var addProductUrl = "http://localhost:7730/api/AddProduct";

            var productData = new
            {
                campaignName = txtCampaignName.Text,
                product = txtProduct.Text,
                productCount = int.Parse(txtCount.Text),
                price = int.Parse(txtPrice.Text),
                compName = frmLogin.name,
                dataBaseId = "PromoteIt",
                containerId = "Campaigns"
            };

           HttpResponseMessage response =  await addProducClient.PostAsJsonAsync(addProductUrl, productData);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Product added successfuly.");
            }
            else
            {
                MessageBox.Show("Unable to add product.");
            }
        }

        private async void GetOrdersAsync()
        {
            HttpClient GetOrdersClient = new HttpClient();
            string GetOrdersUrl = $"http://localhost:7732/api/GetOrders?compName={frmLogin.name}";

            string response = await GetOrdersClient.GetStringAsync(GetOrdersUrl);
            List<Order> ordersLIst = JsonConvert.DeserializeObject<List<Order>>(response);
            dgvOrders.DataSource = ordersLIst;

        }

        private void btnGetOrders_Click(object sender, EventArgs e)
        {
            GetOrdersAsync();
        }
        private async void UpdateSelectedRow()
        {
            if(lblOrderToUpdate.Text !=null)
            {
                HttpClient UpdateOrdersClient = new HttpClient();
                string UpdateOrderStatusurl = "http://localhost:7732/api/UpdateStatus";
                var updatecontent = new
                {
                    id = lblOrderToUpdate.Text,
                    containerId = "Orders",
                    dataBaseId = "PromoteIt"
                };
                HttpResponseMessage message = await UpdateOrdersClient.PostAsJsonAsync(UpdateOrderStatusurl, updatecontent);
                if(message.IsSuccessStatusCode)
                {
                    MessageBox.Show("Order Updated");
                }
                else
                {
                    MessageBox.Show("something went wrongs");
                }
            }
        }
        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOrders.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                lblOrderToUpdate.Text = dgvOrders.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            }
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            UpdateSelectedRow();
            GetOrdersAsync();
        }
    }
}

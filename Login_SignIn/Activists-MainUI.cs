using Newtonsoft.Json;
using NPRCreateCampaign.Classes;
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
    public partial class Activists_MainUI : Form
    {
        string campaignNameCell = "";
        string compNameCell = "";
        public Activists_MainUI()
        {
            InitializeComponent();

            GetAllActiveCampaignsAsync();

            GetUserBalanceAsync(frmLogin.name);

        }

        private async Task GetAllActiveCampaignsAsync()
        {
            List<Campaign> allActiveCampaigns = new List<Campaign>();

            HttpClient client = new HttpClient();
            var url = "http://localhost:7730/api/GetProducts";

            string response = await client.GetStringAsync(url);
            allActiveCampaigns = JsonConvert.DeserializeObject<List<Campaign>>(response);

            dgvAllActiveCampaigns.DataSource = allActiveCampaigns;
        }
        private async Task UpdateBalanceOnLoginAsync()
        {
            HttpClient client = new HttpClient();
            var url = "http://localhost:7731/api/UpdateBalanceOnTweet";
            HttpResponseMessage respons = await client.GetAsync(url);
            MessageBox.Show(respons.StatusCode.ToString());


        }

        private async Task GetUserBalanceAsync(string activistName)
        {
            HttpClient client = new HttpClient();
            var url = $"http://localhost:7734/api/GetBalance?name={activistName}";
            string response = await client.GetStringAsync(url);
            lblBalance.Text = response;
        }

        private void dgvAllActiveCampaigns_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvAllActiveCampaigns.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    if (dgvAllActiveCampaigns.Rows[e.RowIndex].Cells[e.ColumnIndex].Value is Guid)
                    {
                        lblSelectedItem.Text = dgvAllActiveCampaigns.Rows[e.RowIndex].Cells[6].Value.ToString();
                        lblSelectedItemPrice.Text = dgvAllActiveCampaigns.Rows[e.RowIndex].Cells[8].Value.ToString();
                        campaignNameCell = dgvAllActiveCampaigns.Rows[e.RowIndex].Cells[1].Value.ToString();
                        compNameCell = dgvAllActiveCampaigns.Rows[e.RowIndex].Cells[5].Value.ToString();
                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Please select an id.");
            }

        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (txtAddressBox.Text == string.Empty)
            {
                lblAddressEmpty.Text = "Address is missing.";
            }
            else
            {
                lblAddressEmpty.Text = "";

                BuyProductAsync();
                Thread.Sleep(4000);
                GetUserBalanceAsync(frmLogin.name);
                GetAllActiveCampaignsAsync();
            }
        }

        private async Task BuyProductAsync()
        {
            HttpClient buyProductClient = new HttpClient();
            var buyProductUrl = "http://localhost:7730/api/BuyProduct";

            var buyData = new
            {
                userName = frmLogin.name,
                address = txtAddressBox.Text,
                campaignName = campaignNameCell,
                compName = compNameCell,
                product = lblSelectedItem.Text,
                price = lblSelectedItemPrice.Text,
                dataBaseId = "PromoteIt",
                containerId = "Campaigns"
            };

            HttpResponseMessage response = await buyProductClient.PostAsJsonAsync(buyProductUrl, buyData);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Product successfuly purchased");
            }
            else
            {
                MessageBox.Show("Transaction failed due to insufficient funds.");
            }

        }
    }
}

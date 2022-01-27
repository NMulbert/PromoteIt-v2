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


    }
}

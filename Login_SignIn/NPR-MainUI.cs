using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using NPRCreateCampaign.Classes;
using Newtonsoft.Json;

namespace Login_SignIn
{
    public partial class NPR_MainUI : Form
    {
        public NPR_MainUI()
        {
            InitializeComponent();
            string orgName = frmLogin.name;

            GetCampaigns();
        }

        private async void GetCampaigns()
        {
            HttpClient client = new HttpClient();
            var url = "http://localhost:7730/api/GetCampaigns";

            string response = await client.GetStringAsync(url);
            List<Campaign> allCampaigns = JsonConvert.DeserializeObject<List<Campaign>>(response);
            dgvCampaigns.DataSource = allCampaigns;
        }

        private async void CreateCampaign()
        {
            HttpClient campClient = new HttpClient();
            var campUrl = "http://localhost:7730/api/CreateCampaign";
            var campData = new
            {
                campaignName = txtCampaignName.Text,
                campaignLink = txtCampaignLink.Text,
                campaignHashTag = txtCampaignHashtag.Text,
                orgName = frmLogin.name,
                containerId = "Campaigns",
                dataBaseId = "PromoteIt"
            };
            await campClient.PostAsJsonAsync(campUrl, campData);

        }
        private void createBtn_Click(object sender, EventArgs e)
        {
            int flag = 0;

            if (txtCampaignName.Text == "")
            {
                lblCampaignName.Text = "Please enter a user name.";
                flag++;
            }
            else
            {
                lblCampaignName.Text = "";
            }
            if (txtCampaignLink.Text == "")
            {
                lblCampaignLink.Text = "Please enter an email.";
                flag++;
            }
            else
            {
                lblCampaignLink.Text = "";
            }
            if (txtCampaignHashtag.Text == "")
            {
                lblCampaignHashTag.Text = "Please enter an address.";
                flag++;
            }
            else
            {
                lblCampaignHashTag.Text = "";
            }
            if (flag == 0)
            {
                CreateCampaign();
                Thread.Sleep(3000);
                GetCampaigns();
            }
            else
            {
                flag = 0;
            }


        }
    }
}

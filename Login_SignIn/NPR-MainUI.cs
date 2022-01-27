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
            var url = "http://localhost:7071/api/GetCampaigns";

            string response = await client.GetStringAsync(url);
            List<Campaign> allCampaigns = JsonConvert.DeserializeObject<List<Campaign>>(response);
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            


        }
    }
}

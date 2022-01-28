using Newtonsoft.Json;
using NPR_registration.Classes;
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
using TwitterAPI.Classes;

namespace Login_SignIn
{
    public partial class Admin_UI : Form
    {
        public Admin_UI()
        {
            InitializeComponent();
            GetAllCampaignsAsync();
            GetAllTweetsAsync();

            
            GetAllUsersAsync("BCR");
            GetAllUsersAsync("NPR");
            GetAllUsersAsync("Activists");
        }

        private async Task GetAllUsersAsync(string containerId)
        {
            try
            {
                switch (containerId)
                {
                    case "Activists":
                        {
                            HttpClient client = new HttpClient();
                            var url = $"http://localhost:7071/api/GetAllUsersAdmin?containerId={containerId}";
                            string response = await client.GetStringAsync(url);

                            List<Activist> allActivists = JsonConvert.DeserializeObject<List<Activist>>(response);
                            dgvAllActivists.DataSource = allActivists;
                        }
                        break;
                    case "NPR":
                        {
                            HttpClient client = new HttpClient();
                            var url = $"http://localhost:7071/api/GetAllUsersAdmin?containerId={containerId}";
                            string response = await client.GetStringAsync(url);


                            List<NPR> allNPR = JsonConvert.DeserializeObject<List<NPR>>(response);
                            dgvAllNPR.DataSource = allNPR;
                        }
                        break;
                    case "BCR":
                        {
                            HttpClient client = new HttpClient();
                            var url = $"http://localhost:7071/api/GetAllUsersAdmin?containerId={containerId}";
                            string response = await client.GetStringAsync(url);


                            List<BCR> allBCR = JsonConvert.DeserializeObject<List<BCR>>(response);
                            dgvAllBCR.DataSource = allBCR;
                        }
                        break;

                    default:
                        MessageBox.Show("Unable to load data.");
                        break;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private async Task GetAllTweetsAsync()
        {
            HttpClient client = new HttpClient();
            var url = "http://localhost:7731/api/GetAllTweets";

            string response = await client.GetStringAsync(url);
            List<Tweet> allTweets = JsonConvert.DeserializeObject<List<Tweet>>(response);
            dgvAllTweets.DataSource = allTweets;
        }

        private async Task GetAllCampaignsAsync()
        {
            HttpClient client = new HttpClient();
            var url = "http://localhost:7730/api/GetCampaigns";

            string response = await client.GetStringAsync(url);
            List<Campaign> allCampaigns = JsonConvert.DeserializeObject<List<Campaign>>(response);
            dgvAllCampaigns.DataSource = allCampaigns;
        }
    }
}

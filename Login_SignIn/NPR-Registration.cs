using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_SignIn
{
    public partial class NPR_Registration : Form
    {
        bool userRegistred = false;
        public NPR_Registration()
        {
            InitializeComponent();
        }

        private async void registerBtn_Click_1(object sender, EventArgs e)
        {
            int flag = 0;

            if (orgNameTxtBox.Text == "")
            {
                orgNameErrorLbl.Text = "Please enter an organization name.";
                flag++;
            }
            else
            {
                orgNameErrorLbl.Text = "";
            }
            if (emailTxtBox.Text == "")
            {
                emailErrorLbl.Text = "Please enter an email.";
                flag++;
            }
            else
            {
                emailErrorLbl.Text = "";
            }
            if (orgWebsiteTxtBox.Text == "")
            {
                orgWebsiteErrorLbl.Text = "Please enter a website address.";
                flag++;
            }
            else
            {
                orgWebsiteErrorLbl.Text = "";
            }
            if (passwordTxtBox.Text == "")
            {
                passwordErrorLbl.Text = "Please enter a password.";
                flag++;
            }
            else
            {
                passwordErrorLbl.Text = "";
            }
            if (flag == 0)
            {
                await CallAzureFunction();
                if (userRegistred)
                {
                    frmLogin.name = orgNameTxtBox.Text;
                    NPR_MainUI NPRMainUI = new NPR_MainUI();
                    NPRMainUI.Show();

                    this.Hide();
                }
            }
            else
            {
                flag = 0;
            }


        }

        public async Task CallAzureFunction()
        {
            HttpClient client = new HttpClient();
            string url = "http://localhost:7071/api/NPRregister";
            var userInput = new
            {
                orgName = orgNameTxtBox.Text,
                email = emailTxtBox.Text,
                website = orgWebsiteTxtBox.Text,
                password = passwordTxtBox.Text,
                dataBaseId = "PromoteIt",
                containerId = "NPR"
            };

            HttpResponseMessage response = await client.PostAsJsonAsync(url, userInput);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show(response.Content.ReadAsStringAsync().Result);
                userRegistred = true;
            }
            else
            {
                MessageBox.Show("NPR already exists");
            }
        }

        
    }
}



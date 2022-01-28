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
    public partial class BCR_registration : Form
    {
        bool userRegistred = false;
        public BCR_registration()
        {
            InitializeComponent();
        }

        private async void registerBtn_Click_1(object sender, EventArgs e)
        {
            int flag = 0;

            if (compNameTxtBox.Text == "")
            {
                compNameErrorLbl.Text = "Please enter an company name.";
                flag++;
            }
            else
            {
                compNameErrorLbl.Text = "";
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
            if (compWebsiteTxtBox.Text == "")
            {
                compWebsiteErrorLbl.Text = "Please enter a website address.";
                flag++;
            }
            else
            {
                compWebsiteErrorLbl.Text = "";
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
                    frmLogin.name = compNameTxtBox.Text;
                    BCR_MainUI BCRMainUI = new BCR_MainUI();
                    BCRMainUI.Show();

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
            string url = "http://localhost:7071/api/BCRregister";

            var userInput = new
            {
                compName = compNameTxtBox.Text,
                email = emailTxtBox.Text,
                website = compWebsiteTxtBox.Text,
                password = passwordTxtBox.Text,
                dataBaseId = "PromoteIt",
                containerId = "BCR"
            };

            HttpResponseMessage response = await client.PostAsJsonAsync(url, userInput);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show(response.Content.ReadAsStringAsync().Result);
                userRegistred = true;
            }
            else
            {
                MessageBox.Show("Buissnes already Exist");
            }
        }

        
    }
}

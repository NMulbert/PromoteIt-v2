using System;
using System.Net.Http.Json;

namespace Winform_BCR_registration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registerBtn_Click(object sender, EventArgs e)
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
                CallAzureFunction();
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

            MessageBox.Show(response.Content.ReadAsStringAsync().Result);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
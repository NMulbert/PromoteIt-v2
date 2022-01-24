using System.Net.Http.Json;

namespace Winform_Activist_registration
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

            if (userNameTxtBox.Text == "")
            {
                userNameErrorLbl.Text = "Please enter a user name.";
                flag++;
            }
            else
            {
                userNameErrorLbl.Text = "";
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
            if (addressTxtBox.Text == "")
            {
                addressErrorLbl.Text = "Please enter an address.";
                flag++;
            }
            else
            {
                addressErrorLbl.Text = "";
            }
            if (phoneNumberTextBox.Text == "")
            {
                phoneNumberErrorLbl.Text = "Please enter a phone number.";
                flag++;
            }
            else
            {
                phoneNumberErrorLbl.Text = "";
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
            string url = "http://localhost:7071/api/ActivistRegister";

            var userInput = new
            {
                userName = userNameTxtBox.Text,
                email = emailTxtBox.Text,
                address = addressTxtBox.Text,
                phoneNumber = phoneNumberTextBox.Text,
                password = passwordTxtBox.Text,
                dataBaseId = "PromoteIt",
                containerId = "Activists"
            };

            HttpResponseMessage response = await client.PostAsJsonAsync(url, userInput);

            MessageBox.Show(response.Content.ReadAsStringAsync().Result);
        }
    }
}
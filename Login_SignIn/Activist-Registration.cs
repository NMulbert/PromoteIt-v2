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
    public partial class Activist_Registration : Form
    {
        bool userRegistred = false;
        public Activist_Registration()
        {
            InitializeComponent();
        }

        private async void registerBtn_Click_1(object sender, EventArgs e)
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
                await CallAzureFunction();
                if(userRegistred)
                {
                    frmLogin.name = userNameTxtBox.Text;
                    Activists_MainUI activistsMainUI = new Activists_MainUI();
                    activistsMainUI.Show();

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

            
            if(response.IsSuccessStatusCode)
            {
                MessageBox.Show(response.Content.ReadAsStringAsync().Result);
                userRegistred = true;
            }
            else
            {
                MessageBox.Show("Activist already exsits");
            }
        }

        
    }
}

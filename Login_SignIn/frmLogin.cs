using System.Net.Http.Json;


namespace Login_SignIn
{
    public partial class frmLogin : Form
    {
        public static string name = "";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string containerName = "";
            if (rdbNPR.Checked && txtUserName.Text != string.Empty)
            {
                containerName = CreateContainer(rdbNPR.TabIndex);
                CallAzureFunction(containerName, txtUserName.Text);

                Name = txtUserName.Text;

                NPR_MainUI nprMainUI = new NPR_MainUI();
                nprMainUI.Show();

                this.Hide();
            }
            else if (rdbBcar.Checked && txtUserName.Text != string.Empty)
            {
                containerName = CreateContainer(rdbBcar.TabIndex);
                CallAzureFunction(containerName, txtUserName.Text);


                this.Hide();
            }
            else if (rdbActivist.Checked && txtUserName.Text != string.Empty)
            {
                containerName = CreateContainer(rdbActivist.TabIndex);
                CallAzureFunction(containerName, txtUserName.Text);


                this.Hide();
            }
            else if (rdbAdmin.Checked && txtUserName.Text != string.Empty)
            {
                containerName = CreateContainer(rdbAdmin.TabIndex);
                CallAzureFunction(containerName, txtUserName.Text);
            }
            else if (txtUserName.Text == string.Empty)
            {
                lblError.Text = "the textbox is empty please enter user name";
            }
            else
            {
                lblError.Text = "";
            }
        }

        private string CreateContainer(int number)
        {
            string container = "";
            switch (number)
            {
                case 1:
                    container = "NPR";
                    break;
                case 2:
                    container = "BCR";
                    break;
                case 3:
                    container = "Activists";
                    break;
                case 4:
                    container = "Admin";
                    break;
            }
            return container;
        }

        public async Task CallAzureFunction(string container, string userName)
        {


            HttpClient client = new HttpClient();
            string url = "http://localhost:7071/api/GetAllUseres";

            var userInput = new
            {
                name = userName,
                dataBaseId = "PromoteIt",
                containerId = container
            };


            HttpResponseMessage response = await client.PostAsJsonAsync(url, userInput);

            //lblError.Text = response.Content.ReadAsStringAsync().Result;
            MessageBox.Show(response.Content.ReadAsStringAsync().Result);
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {

            if(rdbNPR.Checked)
            {
                NPR_Registration signNpr = new NPR_Registration();
                signNpr.Show();

                this.Hide();
            }
            else if(rdbBcar.Checked)
            {
                BCR_registration signBCR = new BCR_registration();
                signBCR.Show();

                this.Hide();
            }
            else if (rdbActivist.Checked)
            {
                Activist_Registration signBCR = new Activist_Registration();
                signBCR.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("if you want to sign in please choose the kind of user abowe");
            }





        }
    }
}
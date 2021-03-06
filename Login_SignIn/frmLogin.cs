using System.Net.Http.Json;


namespace Login_SignIn
{
    public partial class frmLogin : Form
    {
        public static string name = "";
        public frmLogin()
        {
            InitializeComponent();

            //Please start Time trigger function when starting the project
        }



        #region Click Functions
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            bool userInSystem = false;
            string containerName = "";
            if (rdbNPR.Checked && txtUserName.Text != string.Empty)
            {
                containerName = CreateContainer(rdbNPR.TabIndex);
                userInSystem = await CallAzureFunction(containerName, txtUserName.Text);

                name = txtUserName.Text;
                if (userInSystem)
                {
                    NPR_MainUI nprMainUI = new NPR_MainUI();
                    nprMainUI.Show();

                    this.Hide();

                }


            }
            else if (rdbBcar.Checked && txtUserName.Text != string.Empty)
            {
                containerName = CreateContainer(rdbBcar.TabIndex);
                userInSystem = await CallAzureFunction(containerName, txtUserName.Text);


                name = txtUserName.Text;
                if (userInSystem)
                {
                    BCR_MainUI bcrMainUI = new BCR_MainUI();
                    bcrMainUI.Show();

                    this.Hide();

                }
            }
            else if (rdbActivist.Checked && txtUserName.Text != string.Empty)
            {
                containerName = CreateContainer(rdbActivist.TabIndex);
                userInSystem = await CallAzureFunction(containerName, txtUserName.Text);


                name = txtUserName.Text;
                if (userInSystem)
                {
                    Activists_MainUI activistMainUI = new Activists_MainUI();
                    activistMainUI.Show();

                    this.Hide();

                }
            }
            else if (rdbAdmin.Checked && txtUserName.Text != string.Empty)
            {

                name = txtUserName.Text;
                if (txtUserName.Text == "admin")
                {
                    Admin_UI adminUI = new Admin_UI();
                    adminUI.Show();

                    this.Hide();
                }
                else
                {
                    lblError.Text = "Incorrect admin name.";
                }
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
        private void btnSignIn_Click(object sender, EventArgs e)
        {

            if (rdbNPR.Checked)
            {
                NPR_Registration signNpr = new NPR_Registration();
                signNpr.Show();

                this.Hide();
            }
            else if (rdbBcar.Checked)
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
        #endregion
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

        public async Task<bool> CallAzureFunction(string container, string userName)
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
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
                

        }

        
    }
}
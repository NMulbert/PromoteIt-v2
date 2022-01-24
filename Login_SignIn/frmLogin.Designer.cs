namespace Login_SignIn
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.grbUserType = new System.Windows.Forms.GroupBox();
            this.rdbAdmin = new System.Windows.Forms.RadioButton();
            this.rdbActivist = new System.Windows.Forms.RadioButton();
            this.rdbBcar = new System.Windows.Forms.RadioButton();
            this.rdbNPR = new System.Windows.Forms.RadioButton();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblSignMassage = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.grbUserType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(233, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(302, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Welcome  to Promote IT ";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(280, 224);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(65, 15);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "User Name";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(351, 221);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 23);
            this.txtUserName.TabIndex = 3;
            // 
            // grbUserType
            // 
            this.grbUserType.Controls.Add(this.rdbAdmin);
            this.grbUserType.Controls.Add(this.rdbActivist);
            this.grbUserType.Controls.Add(this.rdbBcar);
            this.grbUserType.Controls.Add(this.rdbNPR);
            this.grbUserType.Location = new System.Drawing.Point(280, 77);
            this.grbUserType.Name = "grbUserType";
            this.grbUserType.Size = new System.Drawing.Size(227, 135);
            this.grbUserType.TabIndex = 6;
            this.grbUserType.TabStop = false;
            this.grbUserType.Text = "User Type";
            // 
            // rdbAdmin
            // 
            this.rdbAdmin.AutoSize = true;
            this.rdbAdmin.Location = new System.Drawing.Point(6, 108);
            this.rdbAdmin.Name = "rdbAdmin";
            this.rdbAdmin.Size = new System.Drawing.Size(61, 19);
            this.rdbAdmin.TabIndex = 4;
            this.rdbAdmin.Text = "Admin";
            this.rdbAdmin.UseVisualStyleBackColor = true;
            // 
            // rdbActivist
            // 
            this.rdbActivist.AutoSize = true;
            this.rdbActivist.Location = new System.Drawing.Point(6, 83);
            this.rdbActivist.Name = "rdbActivist";
            this.rdbActivist.Size = new System.Drawing.Size(101, 19);
            this.rdbActivist.TabIndex = 3;
            this.rdbActivist.Text = "Sosical activist";
            this.rdbActivist.UseVisualStyleBackColor = true;
            // 
            // rdbBcar
            // 
            this.rdbBcar.AutoSize = true;
            this.rdbBcar.Location = new System.Drawing.Point(6, 58);
            this.rdbBcar.Name = "rdbBcar";
            this.rdbBcar.Size = new System.Drawing.Size(200, 19);
            this.rdbBcar.TabIndex = 2;
            this.rdbBcar.Text = "Business company representative";
            this.rdbBcar.UseVisualStyleBackColor = true;
            // 
            // rdbNPR
            // 
            this.rdbNPR.AutoSize = true;
            this.rdbNPR.Checked = true;
            this.rdbNPR.Location = new System.Drawing.Point(6, 33);
            this.rdbNPR.Name = "rdbNPR";
            this.rdbNPR.Size = new System.Drawing.Size(157, 19);
            this.rdbNPR.TabIndex = 1;
            this.rdbNPR.TabStop = true;
            this.rdbNPR.Text = "Non profit representetive";
            this.rdbNPR.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(460, 221);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblSignMassage
            // 
            this.lblSignMassage.AutoSize = true;
            this.lblSignMassage.Location = new System.Drawing.Point(280, 256);
            this.lblSignMassage.Name = "lblSignMassage";
            this.lblSignMassage.Size = new System.Drawing.Size(105, 15);
            this.lblSignMassage.TabIndex = 8;
            this.lblSignMassage.Text = "Please Sign in here";
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(460, 256);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(75, 23);
            this.btnSignIn.TabIndex = 9;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(553, 225);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 15);
            this.lblError.TabIndex = 10;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.lblSignMassage);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.grbUserType);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmLogin";
            this.Text = "Login Promoteit";
            this.grbUserType.ResumeLayout(false);
            this.grbUserType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Label lblUserName;
        private TextBox txtUserName;
        private GroupBox grbUserType;
        private RadioButton rdbAdmin;
        private RadioButton rdbActivist;
        private RadioButton rdbBcar;
        private RadioButton rdbNPR;
        private Button btnLogin;
        private Label lblSignMassage;
        private Button btnSignIn;
        private Label lblError;
    }
}
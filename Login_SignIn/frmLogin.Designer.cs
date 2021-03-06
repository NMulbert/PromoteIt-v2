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
            this.lblError = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.lblSignMassage = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.grbUserType = new System.Windows.Forms.GroupBox();
            this.rdbAdmin = new System.Windows.Forms.RadioButton();
            this.rdbActivist = new System.Windows.Forms.RadioButton();
            this.rdbBcar = new System.Windows.Forms.RadioButton();
            this.rdbNPR = new System.Windows.Forms.RadioButton();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grbUserType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(640, 400);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 20);
            this.lblError.TabIndex = 18;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(534, 441);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(86, 31);
            this.btnSignIn.TabIndex = 17;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // lblSignMassage
            // 
            this.lblSignMassage.AutoSize = true;
            this.lblSignMassage.Location = new System.Drawing.Point(328, 441);
            this.lblSignMassage.Name = "lblSignMassage";
            this.lblSignMassage.Size = new System.Drawing.Size(133, 20);
            this.lblSignMassage.TabIndex = 16;
            this.lblSignMassage.Text = "Please Sign in here";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(534, 395);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(86, 31);
            this.btnLogin.TabIndex = 15;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // grbUserType
            // 
            this.grbUserType.Controls.Add(this.rdbAdmin);
            this.grbUserType.Controls.Add(this.rdbActivist);
            this.grbUserType.Controls.Add(this.rdbBcar);
            this.grbUserType.Controls.Add(this.rdbNPR);
            this.grbUserType.Location = new System.Drawing.Point(328, 203);
            this.grbUserType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbUserType.Name = "grbUserType";
            this.grbUserType.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbUserType.Size = new System.Drawing.Size(259, 180);
            this.grbUserType.TabIndex = 14;
            this.grbUserType.TabStop = false;
            this.grbUserType.Text = "User Type";
            // 
            // rdbAdmin
            // 
            this.rdbAdmin.AutoSize = true;
            this.rdbAdmin.Location = new System.Drawing.Point(7, 144);
            this.rdbAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbAdmin.Name = "rdbAdmin";
            this.rdbAdmin.Size = new System.Drawing.Size(74, 24);
            this.rdbAdmin.TabIndex = 4;
            this.rdbAdmin.Text = "Admin";
            this.rdbAdmin.UseVisualStyleBackColor = true;
            // 
            // rdbActivist
            // 
            this.rdbActivist.AutoSize = true;
            this.rdbActivist.Location = new System.Drawing.Point(7, 111);
            this.rdbActivist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbActivist.Name = "rdbActivist";
            this.rdbActivist.Size = new System.Drawing.Size(120, 24);
            this.rdbActivist.TabIndex = 3;
            this.rdbActivist.Text = "Social activist";
            this.rdbActivist.UseVisualStyleBackColor = true;
            // 
            // rdbBcar
            // 
            this.rdbBcar.AutoSize = true;
            this.rdbBcar.Location = new System.Drawing.Point(7, 77);
            this.rdbBcar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbBcar.Name = "rdbBcar";
            this.rdbBcar.Size = new System.Drawing.Size(248, 24);
            this.rdbBcar.TabIndex = 2;
            this.rdbBcar.Text = "Business company representative";
            this.rdbBcar.UseVisualStyleBackColor = true;
            // 
            // rdbNPR
            // 
            this.rdbNPR.AutoSize = true;
            this.rdbNPR.Checked = true;
            this.rdbNPR.Location = new System.Drawing.Point(7, 44);
            this.rdbNPR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbNPR.Name = "rdbNPR";
            this.rdbNPR.Size = new System.Drawing.Size(197, 24);
            this.rdbNPR.TabIndex = 1;
            this.rdbNPR.TabStop = true;
            this.rdbNPR.Text = "Non profit representative";
            this.rdbNPR.UseVisualStyleBackColor = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(409, 395);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(114, 27);
            this.txtUserName.TabIndex = 13;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(328, 399);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(82, 20);
            this.lblUserName.TabIndex = 12;
            this.lblUserName.Text = "User Name";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(274, 129);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(383, 46);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Welcome  to Promote IT ";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.lblSignMassage);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.grbUserType);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLogin";
            this.Text = "Form1";
            this.grbUserType.ResumeLayout(false);
            this.grbUserType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblError;
        private Button btnSignIn;
        private Label lblSignMassage;
        private Button btnLogin;
        private GroupBox grbUserType;
        private RadioButton rdbAdmin;
        private RadioButton rdbActivist;
        private RadioButton rdbBcar;
        private RadioButton rdbNPR;
        private TextBox txtUserName;
        private Label lblUserName;
        private Label lblTitle;
    }
}
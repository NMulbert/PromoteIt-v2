namespace Winform_Activist_registration
{
    partial class Form1
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
            this.phoneNumberErrorLbl = new System.Windows.Forms.Label();
            this.addressErrorLbl = new System.Windows.Forms.Label();
            this.emailErrorLbl = new System.Windows.Forms.Label();
            this.userNameErrorLbl = new System.Windows.Forms.Label();
            this.messageLbl = new System.Windows.Forms.Label();
            this.registerBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.addressTxtBox = new System.Windows.Forms.TextBox();
            this.emailTxtBox = new System.Windows.Forms.TextBox();
            this.userNameTxtBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.passwordErrorLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // phoneNumberErrorLbl
            // 
            this.phoneNumberErrorLbl.AutoSize = true;
            this.phoneNumberErrorLbl.Location = new System.Drawing.Point(476, 264);
            this.phoneNumberErrorLbl.Name = "phoneNumberErrorLbl";
            this.phoneNumberErrorLbl.Size = new System.Drawing.Size(0, 20);
            this.phoneNumberErrorLbl.TabIndex = 43;
            // 
            // addressErrorLbl
            // 
            this.addressErrorLbl.AutoSize = true;
            this.addressErrorLbl.Location = new System.Drawing.Point(476, 231);
            this.addressErrorLbl.Name = "addressErrorLbl";
            this.addressErrorLbl.Size = new System.Drawing.Size(0, 20);
            this.addressErrorLbl.TabIndex = 42;
            // 
            // emailErrorLbl
            // 
            this.emailErrorLbl.AutoSize = true;
            this.emailErrorLbl.Location = new System.Drawing.Point(476, 198);
            this.emailErrorLbl.Name = "emailErrorLbl";
            this.emailErrorLbl.Size = new System.Drawing.Size(0, 20);
            this.emailErrorLbl.TabIndex = 41;
            // 
            // userNameErrorLbl
            // 
            this.userNameErrorLbl.AutoSize = true;
            this.userNameErrorLbl.Location = new System.Drawing.Point(476, 165);
            this.userNameErrorLbl.Name = "userNameErrorLbl";
            this.userNameErrorLbl.Size = new System.Drawing.Size(0, 20);
            this.userNameErrorLbl.TabIndex = 40;
            // 
            // messageLbl
            // 
            this.messageLbl.AutoSize = true;
            this.messageLbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.messageLbl.Location = new System.Drawing.Point(345, 349);
            this.messageLbl.Name = "messageLbl";
            this.messageLbl.Size = new System.Drawing.Size(0, 23);
            this.messageLbl.TabIndex = 39;
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(360, 323);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(94, 29);
            this.registerBtn.TabIndex = 34;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(247, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(305, 35);
            this.label5.TabIndex = 38;
            this.label5.Text = "Social Activist Registration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "User Name";
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Location = new System.Drawing.Point(345, 290);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.PasswordChar = '*';
            this.passwordTxtBox.Size = new System.Drawing.Size(125, 27);
            this.passwordTxtBox.TabIndex = 33;
            // 
            // addressTxtBox
            // 
            this.addressTxtBox.Location = new System.Drawing.Point(345, 224);
            this.addressTxtBox.Name = "addressTxtBox";
            this.addressTxtBox.Size = new System.Drawing.Size(125, 27);
            this.addressTxtBox.TabIndex = 31;
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.Location = new System.Drawing.Point(345, 191);
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.Size = new System.Drawing.Size(125, 27);
            this.emailTxtBox.TabIndex = 30;
            // 
            // userNameTxtBox
            // 
            this.userNameTxtBox.Location = new System.Drawing.Point(345, 158);
            this.userNameTxtBox.Name = "userNameTxtBox";
            this.userNameTxtBox.Size = new System.Drawing.Size(125, 27);
            this.userNameTxtBox.TabIndex = 29;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(345, 257);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(125, 27);
            this.phoneNumberTextBox.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 45;
            this.label6.Text = "Phone Number";
            // 
            // passwordErrorLbl
            // 
            this.passwordErrorLbl.AutoSize = true;
            this.passwordErrorLbl.Location = new System.Drawing.Point(476, 293);
            this.passwordErrorLbl.Name = "passwordErrorLbl";
            this.passwordErrorLbl.Size = new System.Drawing.Size(0, 20);
            this.passwordErrorLbl.TabIndex = 46;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passwordErrorLbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.phoneNumberErrorLbl);
            this.Controls.Add(this.addressErrorLbl);
            this.Controls.Add(this.emailErrorLbl);
            this.Controls.Add(this.userNameErrorLbl);
            this.Controls.Add(this.messageLbl);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.addressTxtBox);
            this.Controls.Add(this.emailTxtBox);
            this.Controls.Add(this.userNameTxtBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label phoneNumberErrorLbl;
        private Label addressErrorLbl;
        private Label emailErrorLbl;
        private Label userNameErrorLbl;
        private Label messageLbl;
        private Button registerBtn;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox passwordTxtBox;
        private TextBox addressTxtBox;
        private TextBox emailTxtBox;
        private TextBox userNameTxtBox;
        private TextBox phoneNumberTextBox;
        private Label label6;
        private Label passwordErrorLbl;
    }
}
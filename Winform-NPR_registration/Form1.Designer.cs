namespace Winform_NPR_registration
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
            this.orgNameTxtBox = new System.Windows.Forms.TextBox();
            this.emailTxtBox = new System.Windows.Forms.TextBox();
            this.orgWebsiteTxtBox = new System.Windows.Forms.TextBox();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.registerBtn = new System.Windows.Forms.Button();
            this.messageLbl = new System.Windows.Forms.Label();
            this.orgNameErrorLbl = new System.Windows.Forms.Label();
            this.emailErrorLbl = new System.Windows.Forms.Label();
            this.orgWebsiteErrorLbl = new System.Windows.Forms.Label();
            this.passwordErrorLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // orgNameTxtBox
            // 
            this.orgNameTxtBox.Location = new System.Drawing.Point(337, 171);
            this.orgNameTxtBox.Name = "orgNameTxtBox";
            this.orgNameTxtBox.Size = new System.Drawing.Size(125, 27);
            this.orgNameTxtBox.TabIndex = 0;
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.Location = new System.Drawing.Point(337, 204);
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.Size = new System.Drawing.Size(125, 27);
            this.emailTxtBox.TabIndex = 1;
            // 
            // orgWebsiteTxtBox
            // 
            this.orgWebsiteTxtBox.Location = new System.Drawing.Point(337, 237);
            this.orgWebsiteTxtBox.Name = "orgWebsiteTxtBox";
            this.orgWebsiteTxtBox.Size = new System.Drawing.Size(125, 27);
            this.orgWebsiteTxtBox.TabIndex = 2;
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Location = new System.Drawing.Point(337, 270);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.PasswordChar = '*';
            this.passwordTxtBox.Size = new System.Drawing.Size(125, 27);
            this.passwordTxtBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Organization Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Organization Website";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(179, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(436, 35);
            this.label5.TabIndex = 8;
            this.label5.Text = "Non - Profit Organization Registration";
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(352, 303);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(94, 29);
            this.registerBtn.TabIndex = 4;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // messageLbl
            // 
            this.messageLbl.AutoSize = true;
            this.messageLbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.messageLbl.Location = new System.Drawing.Point(337, 362);
            this.messageLbl.Name = "messageLbl";
            this.messageLbl.Size = new System.Drawing.Size(0, 23);
            this.messageLbl.TabIndex = 9;
            // 
            // orgNameErrorLbl
            // 
            this.orgNameErrorLbl.AutoSize = true;
            this.orgNameErrorLbl.Location = new System.Drawing.Point(468, 178);
            this.orgNameErrorLbl.Name = "orgNameErrorLbl";
            this.orgNameErrorLbl.Size = new System.Drawing.Size(0, 20);
            this.orgNameErrorLbl.TabIndex = 10;
            // 
            // emailErrorLbl
            // 
            this.emailErrorLbl.AutoSize = true;
            this.emailErrorLbl.Location = new System.Drawing.Point(468, 211);
            this.emailErrorLbl.Name = "emailErrorLbl";
            this.emailErrorLbl.Size = new System.Drawing.Size(0, 20);
            this.emailErrorLbl.TabIndex = 11;
            // 
            // orgWebsiteErrorLbl
            // 
            this.orgWebsiteErrorLbl.AutoSize = true;
            this.orgWebsiteErrorLbl.Location = new System.Drawing.Point(468, 244);
            this.orgWebsiteErrorLbl.Name = "orgWebsiteErrorLbl";
            this.orgWebsiteErrorLbl.Size = new System.Drawing.Size(0, 20);
            this.orgWebsiteErrorLbl.TabIndex = 12;
            // 
            // passwordErrorLbl
            // 
            this.passwordErrorLbl.AutoSize = true;
            this.passwordErrorLbl.Location = new System.Drawing.Point(468, 277);
            this.passwordErrorLbl.Name = "passwordErrorLbl";
            this.passwordErrorLbl.Size = new System.Drawing.Size(0, 20);
            this.passwordErrorLbl.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passwordErrorLbl);
            this.Controls.Add(this.orgWebsiteErrorLbl);
            this.Controls.Add(this.emailErrorLbl);
            this.Controls.Add(this.orgNameErrorLbl);
            this.Controls.Add(this.messageLbl);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.orgWebsiteTxtBox);
            this.Controls.Add(this.emailTxtBox);
            this.Controls.Add(this.orgNameTxtBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox orgNameTxtBox;
        private TextBox emailTxtBox;
        private TextBox orgWebsiteTxtBox;
        private TextBox passwordTxtBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button registerBtn;
        private Label messageLbl;
        private Label orgNameErrorLbl;
        private Label emailErrorLbl;
        private Label orgWebsiteErrorLbl;
        private Label passwordErrorLbl;
    }
}
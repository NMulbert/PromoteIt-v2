namespace Winform_BCR_registration
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
            this.passwordErrorLbl = new System.Windows.Forms.Label();
            this.compWebsiteErrorLbl = new System.Windows.Forms.Label();
            this.emailErrorLbl = new System.Windows.Forms.Label();
            this.compNameErrorLbl = new System.Windows.Forms.Label();
            this.messageLbl = new System.Windows.Forms.Label();
            this.registerBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.compWebsiteTxtBox = new System.Windows.Forms.TextBox();
            this.emailTxtBox = new System.Windows.Forms.TextBox();
            this.compNameTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // passwordErrorLbl
            // 
            this.passwordErrorLbl.AutoSize = true;
            this.passwordErrorLbl.Location = new System.Drawing.Point(471, 269);
            this.passwordErrorLbl.Name = "passwordErrorLbl";
            this.passwordErrorLbl.Size = new System.Drawing.Size(0, 20);
            this.passwordErrorLbl.TabIndex = 28;
            // 
            // compWebsiteErrorLbl
            // 
            this.compWebsiteErrorLbl.AutoSize = true;
            this.compWebsiteErrorLbl.Location = new System.Drawing.Point(471, 236);
            this.compWebsiteErrorLbl.Name = "compWebsiteErrorLbl";
            this.compWebsiteErrorLbl.Size = new System.Drawing.Size(0, 20);
            this.compWebsiteErrorLbl.TabIndex = 27;
            // 
            // emailErrorLbl
            // 
            this.emailErrorLbl.AutoSize = true;
            this.emailErrorLbl.Location = new System.Drawing.Point(471, 203);
            this.emailErrorLbl.Name = "emailErrorLbl";
            this.emailErrorLbl.Size = new System.Drawing.Size(0, 20);
            this.emailErrorLbl.TabIndex = 26;
            // 
            // compNameErrorLbl
            // 
            this.compNameErrorLbl.AutoSize = true;
            this.compNameErrorLbl.Location = new System.Drawing.Point(471, 170);
            this.compNameErrorLbl.Name = "compNameErrorLbl";
            this.compNameErrorLbl.Size = new System.Drawing.Size(0, 20);
            this.compNameErrorLbl.TabIndex = 25;
            // 
            // messageLbl
            // 
            this.messageLbl.AutoSize = true;
            this.messageLbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.messageLbl.Location = new System.Drawing.Point(340, 354);
            this.messageLbl.Name = "messageLbl";
            this.messageLbl.Size = new System.Drawing.Size(0, 23);
            this.messageLbl.TabIndex = 24;
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(355, 295);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(94, 29);
            this.registerBtn.TabIndex = 18;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(130, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(530, 35);
            this.label5.TabIndex = 23;
            this.label5.Text = "Business Company Representative Registration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Company Website";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Company Name";
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Location = new System.Drawing.Point(340, 262);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.PasswordChar = '*';
            this.passwordTxtBox.Size = new System.Drawing.Size(125, 27);
            this.passwordTxtBox.TabIndex = 17;
            // 
            // compWebsiteTxtBox
            // 
            this.compWebsiteTxtBox.Location = new System.Drawing.Point(340, 229);
            this.compWebsiteTxtBox.Name = "compWebsiteTxtBox";
            this.compWebsiteTxtBox.Size = new System.Drawing.Size(125, 27);
            this.compWebsiteTxtBox.TabIndex = 16;
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.Location = new System.Drawing.Point(340, 196);
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.Size = new System.Drawing.Size(125, 27);
            this.emailTxtBox.TabIndex = 15;
            // 
            // compNameTxtBox
            // 
            this.compNameTxtBox.Location = new System.Drawing.Point(340, 163);
            this.compNameTxtBox.Name = "compNameTxtBox";
            this.compNameTxtBox.Size = new System.Drawing.Size(125, 27);
            this.compNameTxtBox.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passwordErrorLbl);
            this.Controls.Add(this.compWebsiteErrorLbl);
            this.Controls.Add(this.emailErrorLbl);
            this.Controls.Add(this.compNameErrorLbl);
            this.Controls.Add(this.messageLbl);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.compWebsiteTxtBox);
            this.Controls.Add(this.emailTxtBox);
            this.Controls.Add(this.compNameTxtBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label passwordErrorLbl;
        private Label compWebsiteErrorLbl;
        private Label emailErrorLbl;
        private Label compNameErrorLbl;
        private Label messageLbl;
        private Button registerBtn;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox passwordTxtBox;
        private TextBox compWebsiteTxtBox;
        private TextBox emailTxtBox;
        private TextBox compNameTxtBox;
    }
}
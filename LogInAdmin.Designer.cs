namespace Wä
{
    partial class LogInAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            lblUserName = new Label();
            lblPassword = new Label();
            lblLogInAdmin = new Label();
            btnLogIn = new Button();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(110, 108);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(262, 23);
            txtUserName.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(110, 233);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(262, 23);
            txtPassword.TabIndex = 1;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(110, 80);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(89, 15);
            lblUserName.TabIndex = 2;
            lblUserName.Text = "Användarnamn";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(110, 204);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(56, 15);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Lösenord";
            // 
            // lblLogInAdmin
            // 
            lblLogInAdmin.AutoSize = true;
            lblLogInAdmin.Location = new Point(110, 31);
            lblLogInAdmin.Name = "lblLogInAdmin";
            lblLogInAdmin.Size = new Size(153, 15);
            lblLogInAdmin.TabIndex = 4;
            lblLogInAdmin.Text = "Logga in som administratör";
            // 
            // btnLogIn
            // 
            btnLogIn.Location = new Point(297, 291);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(75, 23);
            btnLogIn.TabIndex = 5;
            btnLogIn.Text = "Logga in";
            btnLogIn.UseVisualStyleBackColor = true;
            // 
            // LogInAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogIn);
            Controls.Add(lblLogInAdmin);
            Controls.Add(lblPassword);
            Controls.Add(lblUserName);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Name = "LogInAdmin";
            Text = "LogInAdmin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label lblUserName;
        private Label lblPassword;
        private Label lblLogInAdmin;
        private Button btnLogIn;
    }
}
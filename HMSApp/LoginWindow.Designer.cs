namespace HMSApp
{
    partial class LoginWindow
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            HMS = new Label();
            User = new Label();
            Password = new Label();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(382, 153);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(382, 202);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 1;
            // 
            // HMS
            // 
            HMS.AutoSize = true;
            HMS.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            HMS.Location = new Point(210, 78);
            HMS.Name = "HMS";
            HMS.Size = new Size(400, 38);
            HMS.TabIndex = 2;
            HMS.Text = "Hospital Managemen System";
            // 
            // User
            // 
            User.AutoSize = true;
            User.Location = new Point(289, 153);
            User.Name = "User";
            User.Size = new Size(47, 25);
            User.TabIndex = 3;
            User.Text = "User";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(289, 205);
            Password.Name = "Password";
            Password.Size = new Size(87, 25);
            Password.TabIndex = 4;
            Password.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.Highlight;
            btnLogin.Location = new Point(354, 267);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 34);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // LoginWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(Password);
            Controls.Add(User);
            Controls.Add(HMS);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "LoginWindow";
            Text = "LoginWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label HMS;
        private Label User;
        private Label Password;
        private Button btnLogin;
    }
}
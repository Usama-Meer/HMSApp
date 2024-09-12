namespace HMSApp
{
    partial class RoleWindow
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
            roleNameText = new TextBox();
            roleLabel = new Label();
            roleName = new Label();
            btnSubmitRole = new Button();
            roleDescription = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // roleNameText
            // 
            roleNameText.Location = new Point(350, 173);
            roleNameText.Name = "roleNameText";
            roleNameText.Size = new Size(294, 31);
            roleNameText.TabIndex = 1;
            roleNameText.TextChanged += roleNameText_TextChanged;
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            roleLabel.Location = new Point(311, 69);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(122, 32);
            roleLabel.TabIndex = 2;
            roleLabel.Text = "User Role";
            // 
            // roleName
            // 
            roleName.AutoSize = true;
            roleName.Location = new Point(159, 173);
            roleName.Name = "roleName";
            roleName.Size = new Size(98, 25);
            roleName.TabIndex = 4;
            roleName.Text = "Role Name";
            roleName.Click += label2_Click;
            // 
            // btnSubmitRole
            // 
            btnSubmitRole.Location = new Point(311, 301);
            btnSubmitRole.Name = "btnSubmitRole";
            btnSubmitRole.Size = new Size(112, 34);
            btnSubmitRole.TabIndex = 5;
            btnSubmitRole.Text = "Submit";
            btnSubmitRole.UseVisualStyleBackColor = true;
            // 
            // roleDescription
            // 
            roleDescription.AutoSize = true;
            roleDescription.Location = new Point(159, 226);
            roleDescription.Name = "roleDescription";
            roleDescription.Size = new Size(141, 25);
            roleDescription.TabIndex = 6;
            roleDescription.Text = "Role Description";
            roleDescription.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(350, 220);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(294, 31);
            textBox1.TabIndex = 7;
            // 
            // RoleWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(roleDescription);
            Controls.Add(btnSubmitRole);
            Controls.Add(roleName);
            Controls.Add(roleLabel);
            Controls.Add(roleNameText);
            Name = "RoleWindow";
            Text = "RoleWindow";
            Load += RoleWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox roleNameText;
        private Label roleLabel;
        private Label roleName;
        private Button btnSubmitRole;
        private Label roleDescription;
        private TextBox textBox1;
    }
}
namespace HMSApp
{
    partial class RoleWindoww
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
            userRole = new Label();
            roleName = new Label();
            textBoxRoleName = new TextBox();
            roleDescription = new Label();
            textBoxRoleDescryption = new TextBox();
            buttonSave = new Button();
            SuspendLayout();
            // 
            // userRole
            // 
            userRole.AutoSize = true;
            userRole.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            userRole.Location = new Point(309, 69);
            userRole.Name = "userRole";
            userRole.Size = new Size(122, 32);
            userRole.TabIndex = 0;
            userRole.Text = "User Role";
            // 
            // roleName
            // 
            roleName.AutoSize = true;
            roleName.Location = new Point(199, 154);
            roleName.Name = "roleName";
            roleName.Size = new Size(98, 25);
            roleName.TabIndex = 1;
            roleName.Text = "Role Name";
            // 
            // textBoxRoleName
            // 
            textBoxRoleName.Location = new Point(385, 148);
            textBoxRoleName.Name = "textBoxRoleName";
            textBoxRoleName.Size = new Size(211, 31);
            textBoxRoleName.TabIndex = 2;
            // 
            // roleDescription
            // 
            roleDescription.AutoSize = true;
            roleDescription.Location = new Point(199, 218);
            roleDescription.Name = "roleDescription";
            roleDescription.Size = new Size(146, 25);
            roleDescription.TabIndex = 3;
            roleDescription.Text = "Role Descryption";
            // 
            // textBoxRoleDescryption
            // 
            textBoxRoleDescryption.Location = new Point(385, 214);
            textBoxRoleDescryption.Name = "textBoxRoleDescryption";
            textBoxRoleDescryption.Size = new Size(211, 31);
            textBoxRoleDescryption.TabIndex = 4;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(319, 289);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(112, 34);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // RoleWindoww
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSave);
            Controls.Add(textBoxRoleDescryption);
            Controls.Add(roleDescription);
            Controls.Add(textBoxRoleName);
            Controls.Add(roleName);
            Controls.Add(userRole);
            Name = "RoleWindoww";
            Text = "RoleWindoww";
            Load += RoleWindoww_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label userRole;
        private Label roleName;
        private TextBox textBoxRoleName;
        private Label roleDescription;
        private TextBox textBoxRoleDescryption;
        private Button buttonSave;
    }
}
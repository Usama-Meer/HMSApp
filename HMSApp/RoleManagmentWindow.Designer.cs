namespace HMSApp
{
    partial class RoleManagmentWindow
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
            dataGridRoleView = new DataGridView();
            roleId = new DataGridViewTextBoxColumn();
            roleName = new DataGridViewTextBoxColumn();
            roleDescription = new DataGridViewTextBoxColumn();
            buttonCreateRole = new Button();
            buttonUpdateRole = new Button();
            buttonDeleteRole = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridRoleView).BeginInit();
            SuspendLayout();
            // 
            // dataGridRoleView
            // 
            dataGridRoleView.AllowUserToOrderColumns = true;
            dataGridRoleView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridRoleView.Columns.AddRange(new DataGridViewColumn[] { roleId, roleName, roleDescription });
            dataGridRoleView.Location = new Point(117, 104);
            dataGridRoleView.Name = "dataGridRoleView";
            dataGridRoleView.RowHeadersWidth = 62;
            dataGridRoleView.Size = new Size(514, 188);
            dataGridRoleView.TabIndex = 0;
            // 
            // roleId
            // 
            roleId.HeaderText = "Role Id";
            roleId.MinimumWidth = 8;
            roleId.Name = "roleId";
            roleId.Width = 150;
            // 
            // roleName
            // 
            roleName.HeaderText = "Role Name";
            roleName.MinimumWidth = 8;
            roleName.Name = "roleName";
            roleName.Width = 150;
            // 
            // roleDescription
            // 
            roleDescription.HeaderText = "Role Description";
            roleDescription.MinimumWidth = 8;
            roleDescription.Name = "roleDescription";
            roleDescription.Width = 150;
            // 
            // buttonCreateRole
            // 
            buttonCreateRole.Location = new Point(172, 318);
            buttonCreateRole.Name = "buttonCreateRole";
            buttonCreateRole.Size = new Size(120, 34);
            buttonCreateRole.TabIndex = 1;
            buttonCreateRole.Text = "New Role";
            buttonCreateRole.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateRole
            // 
            buttonUpdateRole.Location = new Point(308, 318);
            buttonUpdateRole.Name = "buttonUpdateRole";
            buttonUpdateRole.Size = new Size(120, 34);
            buttonUpdateRole.TabIndex = 2;
            buttonUpdateRole.Text = "Update Role";
            buttonUpdateRole.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteRole
            // 
            buttonDeleteRole.Location = new Point(447, 318);
            buttonDeleteRole.Name = "buttonDeleteRole";
            buttonDeleteRole.Size = new Size(120, 34);
            buttonDeleteRole.TabIndex = 3;
            buttonDeleteRole.Text = "Delete Role";
            buttonDeleteRole.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(262, 40);
            label1.Name = "label1";
            label1.Size = new Size(222, 32);
            label1.TabIndex = 4;
            label1.Text = "Role Management";
            // 
            // RoleManagmentWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(buttonDeleteRole);
            Controls.Add(buttonUpdateRole);
            Controls.Add(buttonCreateRole);
            Controls.Add(dataGridRoleView);
            Name = "RoleManagmentWindow";
            Text = "RoleManagmentWindow";
            ((System.ComponentModel.ISupportInitialize)dataGridRoleView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridRoleView;
        private DataGridViewTextBoxColumn roleId;
        private DataGridViewTextBoxColumn roleName;
        private DataGridViewTextBoxColumn roleDescription;
        private Button buttonCreateRole;
        private Button buttonUpdateRole;
        private Button buttonDeleteRole;
        private Label label1;
    }
}
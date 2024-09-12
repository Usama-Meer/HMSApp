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
            dataGridRoleView.Size = new Size(518, 188);
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
            // RoleManagmentWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridRoleView);
            Name = "RoleManagmentWindow";
            Text = "RoleManagmentWindow";
            ((System.ComponentModel.ISupportInitialize)dataGridRoleView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridRoleView;
        private DataGridViewTextBoxColumn roleId;
        private DataGridViewTextBoxColumn roleName;
        private DataGridViewTextBoxColumn roleDescription;
    }
}
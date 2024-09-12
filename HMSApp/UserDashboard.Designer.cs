namespace HMSApp
{
    partial class AdminDashboard
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
            labelUserDashboard = new Label();
            buttonDoctorManagement = new Button();
            buttonRoleManagement = new Button();
            buttonPatientManagement = new Button();
            buttonReceiptionistManagement = new Button();
            buttonViewAppointments = new Button();
            buttonLogout = new Button();
            buttonUserManagement = new Button();
            SuspendLayout();
            // 
            // labelUserDashboard
            // 
            labelUserDashboard.AutoSize = true;
            labelUserDashboard.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelUserDashboard.Location = new Point(291, 28);
            labelUserDashboard.Name = "labelUserDashboard";
            labelUserDashboard.Size = new Size(221, 32);
            labelUserDashboard.TabIndex = 0;
            labelUserDashboard.Text = "Admin Dashboard";
            // 
            // buttonDoctorManagement
            // 
            buttonDoctorManagement.Location = new Point(265, 125);
            buttonDoctorManagement.Name = "buttonDoctorManagement";
            buttonDoctorManagement.Size = new Size(257, 34);
            buttonDoctorManagement.TabIndex = 1;
            buttonDoctorManagement.Text = "Doctor Management";
            buttonDoctorManagement.UseVisualStyleBackColor = true;
            // 
            // buttonRoleManagement
            // 
            buttonRoleManagement.Location = new Point(265, 171);
            buttonRoleManagement.Name = "buttonRoleManagement";
            buttonRoleManagement.Size = new Size(257, 34);
            buttonRoleManagement.TabIndex = 2;
            buttonRoleManagement.Text = "Role Management";
            buttonRoleManagement.UseVisualStyleBackColor = true;
            // 
            // buttonPatientManagement
            // 
            buttonPatientManagement.Location = new Point(265, 217);
            buttonPatientManagement.Name = "buttonPatientManagement";
            buttonPatientManagement.Size = new Size(257, 34);
            buttonPatientManagement.TabIndex = 3;
            buttonPatientManagement.Text = "Patient Management";
            buttonPatientManagement.UseVisualStyleBackColor = true;
            // 
            // buttonReceiptionistManagement
            // 
            buttonReceiptionistManagement.Location = new Point(265, 262);
            buttonReceiptionistManagement.Name = "buttonReceiptionistManagement";
            buttonReceiptionistManagement.Size = new Size(257, 34);
            buttonReceiptionistManagement.TabIndex = 4;
            buttonReceiptionistManagement.Text = "Receiptionist Management";
            buttonReceiptionistManagement.UseVisualStyleBackColor = true;
            // 
            // buttonViewAppointments
            // 
            buttonViewAppointments.Location = new Point(265, 307);
            buttonViewAppointments.Name = "buttonViewAppointments";
            buttonViewAppointments.Size = new Size(257, 34);
            buttonViewAppointments.TabIndex = 5;
            buttonViewAppointments.Text = "Appointment Management";
            buttonViewAppointments.UseVisualStyleBackColor = true;
            // 
            // buttonLogout
            // 
            buttonLogout.Location = new Point(657, 29);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(112, 34);
            buttonLogout.TabIndex = 6;
            buttonLogout.Text = "Logout";
            buttonLogout.UseVisualStyleBackColor = true;
            // 
            // buttonUserManagement
            // 
            buttonUserManagement.Location = new Point(265, 81);
            buttonUserManagement.Name = "buttonUserManagement";
            buttonUserManagement.Size = new Size(257, 34);
            buttonUserManagement.TabIndex = 7;
            buttonUserManagement.Text = "User Management";
            buttonUserManagement.UseVisualStyleBackColor = true;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonUserManagement);
            Controls.Add(buttonLogout);
            Controls.Add(buttonViewAppointments);
            Controls.Add(buttonReceiptionistManagement);
            Controls.Add(buttonPatientManagement);
            Controls.Add(buttonRoleManagement);
            Controls.Add(buttonDoctorManagement);
            Controls.Add(labelUserDashboard);
            Name = "AdminDashboard";
            Text = "Admin Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUserDashboard;
        private Button buttonDoctorManagement;
        private Button buttonRoleManagement;
        private Button buttonPatientManagement;
        private Button buttonReceiptionistManagement;
        private Button buttonViewAppointments;
        private Button buttonLogout;
        private Button buttonUserManagement;
    }
}
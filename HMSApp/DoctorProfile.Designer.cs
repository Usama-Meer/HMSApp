namespace HMSApp
{
    partial class DoctorProfile
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
            labelDoctorProfile = new Label();
            labelFirstName = new Label();
            labelLastName = new Label();
            labelSpeciality = new Label();
            labelPhone = new Label();
            labelEmail = new Label();
            labelFee = new Label();
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            textBoxSpeciality = new TextBox();
            textBoxPhone = new TextBox();
            textBoxEmail = new TextBox();
            textBoxFee = new TextBox();
            buttonUpdateProfile = new Button();
            buttonDeleteProfile = new Button();
            SuspendLayout();
            // 
            // labelDoctorProfile
            // 
            labelDoctorProfile.AutoSize = true;
            labelDoctorProfile.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelDoctorProfile.Location = new Point(278, 36);
            labelDoctorProfile.Name = "labelDoctorProfile";
            labelDoctorProfile.Size = new Size(176, 32);
            labelDoctorProfile.TabIndex = 0;
            labelDoctorProfile.Text = "Doctor Profile";
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(207, 90);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(97, 25);
            labelFirstName.TabIndex = 1;
            labelFirstName.Text = "First Name";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(207, 132);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(95, 25);
            labelLastName.TabIndex = 2;
            labelLastName.Text = "Last Name";
            // 
            // labelSpeciality
            // 
            labelSpeciality.AutoSize = true;
            labelSpeciality.Location = new Point(207, 174);
            labelSpeciality.Name = "labelSpeciality";
            labelSpeciality.Size = new Size(86, 25);
            labelSpeciality.TabIndex = 3;
            labelSpeciality.Text = "Speciality";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(207, 218);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(95, 25);
            labelPhone.TabIndex = 4;
            labelPhone.Text = "Phone No.";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(207, 258);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(54, 25);
            labelEmail.TabIndex = 5;
            labelEmail.Text = "Email";
            // 
            // labelFee
            // 
            labelFee.AutoSize = true;
            labelFee.Location = new Point(207, 299);
            labelFee.Name = "labelFee";
            labelFee.Size = new Size(39, 25);
            labelFee.TabIndex = 7;
            labelFee.Text = "Fee";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(377, 87);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(150, 31);
            textBoxFirstName.TabIndex = 8;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(377, 129);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(150, 31);
            textBoxLastName.TabIndex = 9;
            // 
            // textBoxSpeciality
            // 
            textBoxSpeciality.Location = new Point(377, 171);
            textBoxSpeciality.Name = "textBoxSpeciality";
            textBoxSpeciality.Size = new Size(150, 31);
            textBoxSpeciality.TabIndex = 10;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(377, 212);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(150, 31);
            textBoxPhone.TabIndex = 11;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(377, 254);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(150, 31);
            textBoxEmail.TabIndex = 12;
            // 
            // textBoxFee
            // 
            textBoxFee.Location = new Point(377, 293);
            textBoxFee.Name = "textBoxFee";
            textBoxFee.Size = new Size(150, 31);
            textBoxFee.TabIndex = 13;
            // 
            // buttonUpdateProfile
            // 
            buttonUpdateProfile.Location = new Point(266, 368);
            buttonUpdateProfile.Name = "buttonUpdateProfile";
            buttonUpdateProfile.Size = new Size(112, 34);
            buttonUpdateProfile.TabIndex = 14;
            buttonUpdateProfile.Text = "Update";
            buttonUpdateProfile.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteProfile
            // 
            buttonDeleteProfile.Location = new Point(424, 368);
            buttonDeleteProfile.Name = "buttonDeleteProfile";
            buttonDeleteProfile.Size = new Size(112, 34);
            buttonDeleteProfile.TabIndex = 15;
            buttonDeleteProfile.Text = "Delete";
            buttonDeleteProfile.UseVisualStyleBackColor = true;
            // 
            // DoctorProfile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDeleteProfile);
            Controls.Add(buttonUpdateProfile);
            Controls.Add(textBoxFee);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxSpeciality);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(labelFee);
            Controls.Add(labelEmail);
            Controls.Add(labelPhone);
            Controls.Add(labelSpeciality);
            Controls.Add(labelLastName);
            Controls.Add(labelFirstName);
            Controls.Add(labelDoctorProfile);
            Name = "DoctorProfile";
            Text = "DoctorProfile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDoctorProfile;
        private Label labelFirstName;
        private Label labelLastName;
        private Label labelSpeciality;
        private Label labelPhone;
        private Label labelEmail;
        private Label labelFee;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private TextBox textBoxSpeciality;
        private TextBox textBoxPhone;
        private TextBox textBoxEmail;
        private TextBox textBoxFee;
        private Button buttonUpdateProfile;
        private Button buttonDeleteProfile;
    }
}
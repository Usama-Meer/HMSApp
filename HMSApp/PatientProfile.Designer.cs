namespace HMSApp
{
    partial class PatientProfile
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
            label1 = new Label();
            labelFirstName = new Label();
            labelLastName = new Label();
            labelAge = new Label();
            label5 = new Label();
            this.labelAddress = new Label();
            this.labelAppointmentDate = new Label();
            textBoxFirstName = new TextBox();
            textBox2 = new TextBox();
            textBoxAge = new TextBox();
            textBoxAddress = new TextBox();
            textBoxLastAppDate = new TextBox();
            comboBoxGender = new ComboBox();
            buttonUpdatePatientProfile = new Button();
            buttonDeletePatientProfile = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(322, 25);
            label1.Name = "label1";
            label1.Size = new Size(177, 32);
            label1.TabIndex = 0;
            label1.Text = "Patient Profile";
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(209, 89);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(97, 25);
            labelFirstName.TabIndex = 1;
            labelFirstName.Text = "First Name";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(209, 131);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(95, 25);
            labelLastName.TabIndex = 2;
            labelLastName.Text = "Last Name";
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Location = new Point(209, 168);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(44, 25);
            labelAge.TabIndex = 3;
            labelAge.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(209, 203);
            label5.Name = "label5";
            label5.Size = new Size(69, 25);
            label5.TabIndex = 4;
            label5.Text = "Gender";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new Point(209, 242);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new Size(77, 25);
            this.labelAddress.TabIndex = 5;
            this.labelAddress.Text = "Address";
            // 
            // labelAppointmentDate
            // 
            this.labelAppointmentDate.AutoSize = true;
            this.labelAppointmentDate.Location = new Point(209, 293);
            this.labelAppointmentDate.Name = "labelAppointmentDate";
            this.labelAppointmentDate.Size = new Size(148, 50);
            this.labelAppointmentDate.TabIndex = 6;
            this.labelAppointmentDate.Text = "Last Apointment \r\nDate";
            this.labelAppointmentDate.Click += this.labelAppointmentDate_Click;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(379, 87);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(182, 31);
            textBoxFirstName.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(379, 128);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(182, 31);
            textBox2.TabIndex = 8;
            // 
            // textBoxAge
            // 
            textBoxAge.Location = new Point(379, 168);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(182, 31);
            textBoxAge.TabIndex = 9;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(380, 251);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(181, 31);
            textBoxAddress.TabIndex = 11;
            // 
            // textBoxLastAppDate
            // 
            textBoxLastAppDate.Location = new Point(379, 293);
            textBoxLastAppDate.Name = "textBoxLastAppDate";
            textBoxLastAppDate.Size = new Size(182, 31);
            textBoxLastAppDate.TabIndex = 12;
            // 
            // comboBoxGender
            // 
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "Male", "Female" });
            comboBoxGender.Location = new Point(379, 205);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(182, 33);
            comboBoxGender.TabIndex = 13;
            // 
            // buttonUpdatePatientProfile
            // 
            buttonUpdatePatientProfile.Location = new Point(247, 364);
            buttonUpdatePatientProfile.Name = "buttonUpdatePatientProfile";
            buttonUpdatePatientProfile.Size = new Size(112, 34);
            buttonUpdatePatientProfile.TabIndex = 14;
            buttonUpdatePatientProfile.Text = "Update";
            buttonUpdatePatientProfile.UseVisualStyleBackColor = true;
            // 
            // buttonDeletePatientProfile
            // 
            buttonDeletePatientProfile.Location = new Point(401, 364);
            buttonDeletePatientProfile.Name = "buttonDeletePatientProfile";
            buttonDeletePatientProfile.Size = new Size(112, 34);
            buttonDeletePatientProfile.TabIndex = 15;
            buttonDeletePatientProfile.Text = "Delete";
            buttonDeletePatientProfile.UseVisualStyleBackColor = true;
            // 
            // PatientProfile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDeletePatientProfile);
            Controls.Add(buttonUpdatePatientProfile);
            Controls.Add(comboBoxGender);
            Controls.Add(textBoxLastAppDate);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxAge);
            Controls.Add(textBox2);
            Controls.Add(textBoxFirstName);
            Controls.Add(this.labelAppointmentDate);
            Controls.Add(this.labelAddress);
            Controls.Add(label5);
            Controls.Add(labelAge);
            Controls.Add(labelLastName);
            Controls.Add(labelFirstName);
            Controls.Add(label1);
            Name = "PatientProfile";
            Text = "PatientProfile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelFirstName;
        private Label labelLastName;
        private Label labelAge;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBoxFirstName;
        private TextBox textBox2;
        private TextBox textBoxAge;
        private TextBox textBox4;
        private TextBox textBoxAddress;
        private TextBox textBoxLastAppDate;
        private ComboBox comboBoxGender;
        private Button buttonUpdatePatientProfile;
        private Button buttonDeletePatientProfile;
    }
}
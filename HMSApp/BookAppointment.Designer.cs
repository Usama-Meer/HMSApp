namespace HMSApp
{
    partial class BookAppointment
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
            btnScheduleApp = new Button();
            comboBox1 = new ComboBox();
            patientName = new Label();
            patientAge = new Label();
            doctorName = new Label();
            label5 = new Label();
            roomNumber = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(257, 32);
            label1.Name = "label1";
            label1.Size = new Size(270, 32);
            label1.TabIndex = 0;
            label1.Text = "Book An Appointment";
            // 
            // btnScheduleApp
            // 
            btnScheduleApp.BackColor = SystemColors.Highlight;
            btnScheduleApp.Location = new Point(308, 335);
            btnScheduleApp.Name = "btnScheduleApp";
            btnScheduleApp.Size = new Size(112, 34);
            btnScheduleApp.TabIndex = 1;
            btnScheduleApp.Text = "Submit";
            btnScheduleApp.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(356, 179);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(300, 33);
            comboBox1.TabIndex = 2;
            // 
            // patientName
            // 
            patientName.AutoSize = true;
            patientName.Location = new Point(190, 98);
            patientName.Name = "patientName";
            patientName.Size = new Size(117, 25);
            patientName.TabIndex = 3;
            patientName.Text = "Patient Name";
            // 
            // patientAge
            // 
            patientAge.AutoSize = true;
            patientAge.Location = new Point(190, 138);
            patientAge.Name = "patientAge";
            patientAge.Size = new Size(44, 25);
            patientAge.TabIndex = 4;
            patientAge.Text = "Age";
            // 
            // doctorName
            // 
            doctorName.AutoSize = true;
            doctorName.Location = new Point(190, 183);
            doctorName.Name = "doctorName";
            doctorName.Size = new Size(124, 25);
            doctorName.TabIndex = 5;
            doctorName.Text = "Doctor  Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(190, 224);
            label5.Name = "label5";
            label5.Size = new Size(160, 25);
            label5.TabIndex = 6;
            label5.Text = "Appointment Date";
            label5.Click += label5_Click;
            // 
            // roomNumber
            // 
            roomNumber.AutoSize = true;
            roomNumber.Location = new Point(190, 266);
            roomNumber.Name = "roomNumber";
            roomNumber.Size = new Size(130, 25);
            roomNumber.TabIndex = 7;
            roomNumber.Text = "Room Number";
            roomNumber.Click += label6_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(356, 92);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 31);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(356, 135);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(300, 31);
            textBox2.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(356, 263);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(300, 31);
            textBox4.TabIndex = 11;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(356, 223);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 12;
            // 
            // BookAppointment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(roomNumber);
            Controls.Add(label5);
            Controls.Add(doctorName);
            Controls.Add(patientAge);
            Controls.Add(patientName);
            Controls.Add(comboBox1);
            Controls.Add(btnScheduleApp);
            Controls.Add(label1);
            Name = "BookAppointment";
            Text = "BookAppointment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnScheduleApp;
        private ComboBox comboBox1;
        private Label patientName;
        private Label patientAge;
        private Label doctorName;
        private Label label5;
        private Label roomNumber;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox4;
        private DateTimePicker dateTimePicker1;
    }
}
namespace CMS
{
    partial class Modify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modify));
            this.lblCMS = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMSelection = new System.Windows.Forms.Label();
            this.btnRtnM1 = new System.Windows.Forms.Button();
            this.btnMTeachers = new System.Windows.Forms.Button();
            this.btnMCourse = new System.Windows.Forms.Button();
            this.comboQualification = new System.Windows.Forms.ComboBox();
            this.textSubject = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboGender = new System.Windows.Forms.ComboBox();
            this.textLname = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.textCity = new System.Windows.Forms.TextBox();
            this.textFname = new System.Windows.Forms.TextBox();
            this.textTID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCMS
            // 
            this.lblCMS.AutoSize = true;
            this.lblCMS.BackColor = System.Drawing.Color.Transparent;
            this.lblCMS.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMS.Location = new System.Drawing.Point(295, 10);
            this.lblCMS.Name = "lblCMS";
            this.lblCMS.Size = new System.Drawing.Size(406, 72);
            this.lblCMS.TabIndex = 3;
            this.lblCMS.Text = "              Welcome to\r\nCourse Management System";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblMSelection);
            this.panel1.Controls.Add(this.btnRtnM1);
            this.panel1.Controls.Add(this.btnMTeachers);
            this.panel1.Controls.Add(this.btnMCourse);
            this.panel1.Location = new System.Drawing.Point(12, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 435);
            this.panel1.TabIndex = 2;
            // 
            // lblMSelection
            // 
            this.lblMSelection.AutoSize = true;
            this.lblMSelection.BackColor = System.Drawing.Color.Transparent;
            this.lblMSelection.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMSelection.ForeColor = System.Drawing.Color.Red;
            this.lblMSelection.Location = new System.Drawing.Point(56, 74);
            this.lblMSelection.Name = "lblMSelection";
            this.lblMSelection.Size = new System.Drawing.Size(147, 22);
            this.lblMSelection.TabIndex = 6;
            this.lblMSelection.Text = "Modify Selection";
            // 
            // btnRtnM1
            // 
            this.btnRtnM1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRtnM1.Location = new System.Drawing.Point(2, 363);
            this.btnRtnM1.Name = "btnRtnM1";
            this.btnRtnM1.Size = new System.Drawing.Size(219, 64);
            this.btnRtnM1.TabIndex = 5;
            this.btnRtnM1.Text = "Return";
            this.btnRtnM1.UseVisualStyleBackColor = true;
            this.btnRtnM1.Click += new System.EventHandler(this.btnRtnM1_Click);
            // 
            // btnMTeachers
            // 
            this.btnMTeachers.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMTeachers.Location = new System.Drawing.Point(2, 293);
            this.btnMTeachers.Name = "btnMTeachers";
            this.btnMTeachers.Size = new System.Drawing.Size(219, 64);
            this.btnMTeachers.TabIndex = 4;
            this.btnMTeachers.Text = "Teacher Records";
            this.btnMTeachers.UseVisualStyleBackColor = true;
            this.btnMTeachers.Click += new System.EventHandler(this.btnMTeachers_Click);
            // 
            // btnMCourse
            // 
            this.btnMCourse.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMCourse.Location = new System.Drawing.Point(2, 223);
            this.btnMCourse.Name = "btnMCourse";
            this.btnMCourse.Size = new System.Drawing.Size(219, 64);
            this.btnMCourse.TabIndex = 3;
            this.btnMCourse.Text = " Course Records";
            this.btnMCourse.UseVisualStyleBackColor = true;
            this.btnMCourse.Click += new System.EventHandler(this.btnMCourse_Click);
            // 
            // comboQualification
            // 
            this.comboQualification.FormattingEnabled = true;
            this.comboQualification.Items.AddRange(new object[] {
            "Bachelor\'s",
            "B\'Ed",
            "M\'Ed",
            "Master\'s",
            "Phd"});
            this.comboQualification.Location = new System.Drawing.Point(420, 363);
            this.comboQualification.Name = "comboQualification";
            this.comboQualification.Size = new System.Drawing.Size(148, 21);
            this.comboQualification.TabIndex = 132;
            // 
            // textSubject
            // 
            this.textSubject.Location = new System.Drawing.Point(731, 312);
            this.textSubject.Multiline = true;
            this.textSubject.Name = "textSubject";
            this.textSubject.Size = new System.Drawing.Size(148, 33);
            this.textSubject.TabIndex = 134;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Cyan;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(604, 312);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 20);
            this.label11.TabIndex = 137;
            this.label11.Text = "Subject";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Cyan;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(305, 363);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 20);
            this.label12.TabIndex = 136;
            this.label12.Text = "Qualification";
            // 
            // comboGender
            // 
            this.comboGender.FormattingEnabled = true;
            this.comboGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Not Specified"});
            this.comboGender.Location = new System.Drawing.Point(731, 262);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(148, 21);
            this.comboGender.TabIndex = 130;
            // 
            // textLname
            // 
            this.textLname.Location = new System.Drawing.Point(731, 152);
            this.textLname.Multiline = true;
            this.textLname.Name = "textLname";
            this.textLname.Size = new System.Drawing.Size(148, 33);
            this.textLname.TabIndex = 123;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(731, 361);
            this.textEmail.Multiline = true;
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(148, 33);
            this.textEmail.TabIndex = 135;
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(420, 257);
            this.textAddress.Multiline = true;
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(148, 33);
            this.textAddress.TabIndex = 125;
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(420, 316);
            this.textPhone.Multiline = true;
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(148, 33);
            this.textPhone.TabIndex = 129;
            // 
            // textCity
            // 
            this.textCity.Location = new System.Drawing.Point(731, 204);
            this.textCity.Multiline = true;
            this.textCity.Name = "textCity";
            this.textCity.Size = new System.Drawing.Size(148, 33);
            this.textCity.TabIndex = 127;
            // 
            // textFname
            // 
            this.textFname.Location = new System.Drawing.Point(420, 205);
            this.textFname.Multiline = true;
            this.textFname.Name = "textFname";
            this.textFname.Size = new System.Drawing.Size(148, 33);
            this.textFname.TabIndex = 121;
            // 
            // textTID
            // 
            this.textTID.Location = new System.Drawing.Point(420, 152);
            this.textTID.Multiline = true;
            this.textTID.Name = "textTID";
            this.textTID.Size = new System.Drawing.Size(148, 33);
            this.textTID.TabIndex = 119;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Cyan;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(604, 361);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 133;
            this.label9.Text = "E-Mail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Cyan;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(604, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 131;
            this.label7.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Cyan;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(305, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 128;
            this.label6.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Cyan;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(604, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 126;
            this.label5.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Cyan;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(305, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 124;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Cyan;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(604, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 122;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Cyan;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(305, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 120;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 118;
            this.label1.Text = "ID";
            // 
            // Modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(895, 498);
            this.Controls.Add(this.comboQualification);
            this.Controls.Add(this.textSubject);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboGender);
            this.Controls.Add(this.textLname);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.textCity);
            this.Controls.Add(this.textFname);
            this.Controls.Add(this.textTID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCMS);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Modify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modify";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCMS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMSelection;
        private System.Windows.Forms.Button btnRtnM1;
        private System.Windows.Forms.Button btnMTeachers;
        private System.Windows.Forms.Button btnMCourse;
        private System.Windows.Forms.ComboBox comboQualification;
        private System.Windows.Forms.TextBox textSubject;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboGender;
        private System.Windows.Forms.TextBox textLname;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.TextBox textCity;
        private System.Windows.Forms.TextBox textFname;
        private System.Windows.Forms.TextBox textTID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
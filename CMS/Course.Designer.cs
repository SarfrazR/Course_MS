namespace CMS
{
    partial class Course
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Course));
            this.btnAddCRec = new System.Windows.Forms.Button();
            this.btnUpdCRec = new System.Windows.Forms.Button();
            this.btnDelCRec = new System.Windows.Forms.Button();
            this.lblCMS = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRet = new System.Windows.Forms.Button();
            this.lblCourse = new System.Windows.Forms.Label();
            this.btnDoneAdd = new System.Windows.Forms.Button();
            this.btnDoneDel = new System.Windows.Forms.Button();
            this.btnDoneUpd = new System.Windows.Forms.Button();
            this.lblAddCName = new System.Windows.Forms.Label();
            this.txtAddC_Name = new System.Windows.Forms.TextBox();
            this.lblAddCHours = new System.Windows.Forms.Label();
            this.lblAddC_ID = new System.Windows.Forms.Label();
            this.txtAddC_ID = new System.Windows.Forms.TextBox();
            this.txtAddC_Hours = new System.Windows.Forms.TextBox();
            this.lblDelC_ID = new System.Windows.Forms.Label();
            this.txtDelC_ID = new System.Windows.Forms.TextBox();
            this.lblUpdC_ID = new System.Windows.Forms.Label();
            this.txtUpdC_ID = new System.Windows.Forms.TextBox();
            this.lblUpdC_Name = new System.Windows.Forms.Label();
            this.txtUpdC_Name = new System.Windows.Forms.TextBox();
            this.lblUpdC_Hours = new System.Windows.Forms.Label();
            this.txtUpdC_hours = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddCRec
            // 
            this.btnAddCRec.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCRec.Location = new System.Drawing.Point(3, 161);
            this.btnAddCRec.Name = "btnAddCRec";
            this.btnAddCRec.Size = new System.Drawing.Size(219, 64);
            this.btnAddCRec.TabIndex = 17;
            this.btnAddCRec.Text = "Add Course";
            this.btnAddCRec.UseVisualStyleBackColor = true;
            this.btnAddCRec.Click += new System.EventHandler(this.btnAddCRec_Click);
            // 
            // btnUpdCRec
            // 
            this.btnUpdCRec.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdCRec.Location = new System.Drawing.Point(4, 301);
            this.btnUpdCRec.Name = "btnUpdCRec";
            this.btnUpdCRec.Size = new System.Drawing.Size(219, 64);
            this.btnUpdCRec.TabIndex = 16;
            this.btnUpdCRec.Text = " Update Course";
            this.btnUpdCRec.UseVisualStyleBackColor = true;
            this.btnUpdCRec.Click += new System.EventHandler(this.btnUpdCRec_Click);
            // 
            // btnDelCRec
            // 
            this.btnDelCRec.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelCRec.Location = new System.Drawing.Point(4, 231);
            this.btnDelCRec.Name = "btnDelCRec";
            this.btnDelCRec.Size = new System.Drawing.Size(219, 64);
            this.btnDelCRec.TabIndex = 15;
            this.btnDelCRec.Text = " DeleteCourse ";
            this.btnDelCRec.UseVisualStyleBackColor = true;
            this.btnDelCRec.Click += new System.EventHandler(this.btnDelTRec_Click);
            // 
            // lblCMS
            // 
            this.lblCMS.AutoSize = true;
            this.lblCMS.BackColor = System.Drawing.Color.Transparent;
            this.lblCMS.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMS.Location = new System.Drawing.Point(287, 8);
            this.lblCMS.Name = "lblCMS";
            this.lblCMS.Size = new System.Drawing.Size(406, 72);
            this.lblCMS.TabIndex = 14;
            this.lblCMS.Text = "              Welcome to\r\nCourse Management System";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnRet);
            this.panel1.Controls.Add(this.btnAddCRec);
            this.panel1.Controls.Add(this.btnUpdCRec);
            this.panel1.Controls.Add(this.lblCourse);
            this.panel1.Controls.Add(this.btnDelCRec);
            this.panel1.Location = new System.Drawing.Point(4, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 435);
            this.panel1.TabIndex = 13;
            // 
            // btnRet
            // 
            this.btnRet.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRet.Location = new System.Drawing.Point(3, 368);
            this.btnRet.Name = "btnRet";
            this.btnRet.Size = new System.Drawing.Size(219, 64);
            this.btnRet.TabIndex = 18;
            this.btnRet.Text = "Return";
            this.btnRet.UseVisualStyleBackColor = true;
            this.btnRet.Click += new System.EventHandler(this.btnRet_Click);
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.BackColor = System.Drawing.Color.Transparent;
            this.lblCourse.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.ForeColor = System.Drawing.Color.Red;
            this.lblCourse.Location = new System.Drawing.Point(73, 74);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(69, 22);
            this.lblCourse.TabIndex = 6;
            this.lblCourse.Text = "Course";
            // 
            // btnDoneAdd
            // 
            this.btnDoneAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoneAdd.Location = new System.Drawing.Point(513, 406);
            this.btnDoneAdd.Name = "btnDoneAdd";
            this.btnDoneAdd.Size = new System.Drawing.Size(213, 55);
            this.btnDoneAdd.TabIndex = 31;
            this.btnDoneAdd.Text = "Done";
            this.btnDoneAdd.UseVisualStyleBackColor = true;
            this.btnDoneAdd.Click += new System.EventHandler(this.btnDoneAdd_Click);
            // 
            // btnDoneDel
            // 
            this.btnDoneDel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoneDel.Location = new System.Drawing.Point(513, 406);
            this.btnDoneDel.Name = "btnDoneDel";
            this.btnDoneDel.Size = new System.Drawing.Size(213, 55);
            this.btnDoneDel.TabIndex = 32;
            this.btnDoneDel.Text = "Done";
            this.btnDoneDel.UseVisualStyleBackColor = true;
            this.btnDoneDel.Click += new System.EventHandler(this.btnDoneDel_Click);
            // 
            // btnDoneUpd
            // 
            this.btnDoneUpd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoneUpd.Location = new System.Drawing.Point(513, 406);
            this.btnDoneUpd.Name = "btnDoneUpd";
            this.btnDoneUpd.Size = new System.Drawing.Size(213, 55);
            this.btnDoneUpd.TabIndex = 33;
            this.btnDoneUpd.Text = "Done";
            this.btnDoneUpd.UseVisualStyleBackColor = true;
            this.btnDoneUpd.Click += new System.EventHandler(this.btnDoneUpd_Click);
            // 
            // lblAddCName
            // 
            this.lblAddCName.AutoSize = true;
            this.lblAddCName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCName.Location = new System.Drawing.Point(306, 181);
            this.lblAddCName.Name = "lblAddCName";
            this.lblAddCName.Size = new System.Drawing.Size(117, 20);
            this.lblAddCName.TabIndex = 15;
            this.lblAddCName.Text = "Course Name";
            // 
            // txtAddC_Name
            // 
            this.txtAddC_Name.Location = new System.Drawing.Point(503, 181);
            this.txtAddC_Name.Name = "txtAddC_Name";
            this.txtAddC_Name.Size = new System.Drawing.Size(276, 20);
            this.txtAddC_Name.TabIndex = 16;
            // 
            // lblAddCHours
            // 
            this.lblAddCHours.AutoSize = true;
            this.lblAddCHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCHours.Location = new System.Drawing.Point(306, 280);
            this.lblAddCHours.Name = "lblAddCHours";
            this.lblAddCHours.Size = new System.Drawing.Size(110, 20);
            this.lblAddCHours.TabIndex = 19;
            this.lblAddCHours.Text = "Credit Hours";
            // 
            // lblAddC_ID
            // 
            this.lblAddC_ID.AutoSize = true;
            this.lblAddC_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddC_ID.Location = new System.Drawing.Point(306, 229);
            this.lblAddC_ID.Name = "lblAddC_ID";
            this.lblAddC_ID.Size = new System.Drawing.Size(90, 20);
            this.lblAddC_ID.TabIndex = 20;
            this.lblAddC_ID.Text = "Course ID";
            // 
            // txtAddC_ID
            // 
            this.txtAddC_ID.Location = new System.Drawing.Point(503, 231);
            this.txtAddC_ID.Name = "txtAddC_ID";
            this.txtAddC_ID.Size = new System.Drawing.Size(276, 20);
            this.txtAddC_ID.TabIndex = 21;
            // 
            // txtAddC_Hours
            // 
            this.txtAddC_Hours.Location = new System.Drawing.Point(503, 282);
            this.txtAddC_Hours.Name = "txtAddC_Hours";
            this.txtAddC_Hours.Size = new System.Drawing.Size(276, 20);
            this.txtAddC_Hours.TabIndex = 22;
            // 
            // lblDelC_ID
            // 
            this.lblDelC_ID.AutoSize = true;
            this.lblDelC_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelC_ID.Location = new System.Drawing.Point(306, 231);
            this.lblDelC_ID.Name = "lblDelC_ID";
            this.lblDelC_ID.Size = new System.Drawing.Size(90, 20);
            this.lblDelC_ID.TabIndex = 23;
            this.lblDelC_ID.Text = "Course ID";
            // 
            // txtDelC_ID
            // 
            this.txtDelC_ID.Location = new System.Drawing.Point(503, 229);
            this.txtDelC_ID.Name = "txtDelC_ID";
            this.txtDelC_ID.Size = new System.Drawing.Size(276, 20);
            this.txtDelC_ID.TabIndex = 24;
            // 
            // lblUpdC_ID
            // 
            this.lblUpdC_ID.AutoSize = true;
            this.lblUpdC_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdC_ID.Location = new System.Drawing.Point(306, 231);
            this.lblUpdC_ID.Name = "lblUpdC_ID";
            this.lblUpdC_ID.Size = new System.Drawing.Size(90, 20);
            this.lblUpdC_ID.TabIndex = 25;
            this.lblUpdC_ID.Text = "Course ID";
            // 
            // txtUpdC_ID
            // 
            this.txtUpdC_ID.Location = new System.Drawing.Point(503, 231);
            this.txtUpdC_ID.Name = "txtUpdC_ID";
            this.txtUpdC_ID.Size = new System.Drawing.Size(276, 20);
            this.txtUpdC_ID.TabIndex = 26;
            // 
            // lblUpdC_Name
            // 
            this.lblUpdC_Name.AutoSize = true;
            this.lblUpdC_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdC_Name.Location = new System.Drawing.Point(306, 181);
            this.lblUpdC_Name.Name = "lblUpdC_Name";
            this.lblUpdC_Name.Size = new System.Drawing.Size(117, 20);
            this.lblUpdC_Name.TabIndex = 27;
            this.lblUpdC_Name.Text = "Course Name";
            // 
            // txtUpdC_Name
            // 
            this.txtUpdC_Name.Location = new System.Drawing.Point(503, 181);
            this.txtUpdC_Name.Name = "txtUpdC_Name";
            this.txtUpdC_Name.Size = new System.Drawing.Size(276, 20);
            this.txtUpdC_Name.TabIndex = 28;
            // 
            // lblUpdC_Hours
            // 
            this.lblUpdC_Hours.AutoSize = true;
            this.lblUpdC_Hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdC_Hours.Location = new System.Drawing.Point(306, 280);
            this.lblUpdC_Hours.Name = "lblUpdC_Hours";
            this.lblUpdC_Hours.Size = new System.Drawing.Size(110, 20);
            this.lblUpdC_Hours.TabIndex = 29;
            this.lblUpdC_Hours.Text = "Credit Hours";
            // 
            // txtUpdC_hours
            // 
            this.txtUpdC_hours.Location = new System.Drawing.Point(503, 280);
            this.txtUpdC_hours.Name = "txtUpdC_hours";
            this.txtUpdC_hours.Size = new System.Drawing.Size(276, 20);
            this.txtUpdC_hours.TabIndex = 30;
            // 
            // Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(879, 487);
            this.Controls.Add(this.btnDoneUpd);
            this.Controls.Add(this.btnDoneDel);
            this.Controls.Add(this.btnDoneAdd);
            this.Controls.Add(this.txtUpdC_hours);
            this.Controls.Add(this.lblUpdC_Hours);
            this.Controls.Add(this.txtUpdC_Name);
            this.Controls.Add(this.lblUpdC_Name);
            this.Controls.Add(this.txtUpdC_ID);
            this.Controls.Add(this.lblUpdC_ID);
            this.Controls.Add(this.txtDelC_ID);
            this.Controls.Add(this.lblDelC_ID);
            this.Controls.Add(this.txtAddC_Hours);
            this.Controls.Add(this.txtAddC_ID);
            this.Controls.Add(this.lblAddC_ID);
            this.Controls.Add(this.lblAddCHours);
            this.Controls.Add(this.txtAddC_Name);
            this.Controls.Add(this.lblAddCName);
            this.Controls.Add(this.lblCMS);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Course";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddCRec;
        private System.Windows.Forms.Button btnUpdCRec;
        private System.Windows.Forms.Button btnDelCRec;
        private System.Windows.Forms.Label lblCMS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Button btnRet;
        private System.Windows.Forms.Button btnDoneAdd;
        private System.Windows.Forms.Button btnDoneDel;
        private System.Windows.Forms.Button btnDoneUpd;
        private System.Windows.Forms.Label lblAddCName;
        private System.Windows.Forms.TextBox txtAddC_Name;
        private System.Windows.Forms.Label lblAddCHours;
        private System.Windows.Forms.Label lblAddC_ID;
        private System.Windows.Forms.TextBox txtAddC_ID;
        private System.Windows.Forms.TextBox txtAddC_Hours;
        private System.Windows.Forms.Label lblDelC_ID;
        private System.Windows.Forms.TextBox txtDelC_ID;
        private System.Windows.Forms.Label lblUpdC_ID;
        private System.Windows.Forms.TextBox txtUpdC_ID;
        private System.Windows.Forms.Label lblUpdC_Name;
        private System.Windows.Forms.TextBox txtUpdC_Name;
        private System.Windows.Forms.Label lblUpdC_Hours;
        private System.Windows.Forms.TextBox txtUpdC_hours;
    }
}
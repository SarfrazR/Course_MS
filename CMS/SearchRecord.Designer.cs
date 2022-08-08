namespace CMS
{
    partial class SearchRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchRecord));
            this.lblCMS = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDSearch = new System.Windows.Forms.Label();
            this.btnRtnM1 = new System.Windows.Forms.Button();
            this.btnSTeachers = new System.Windows.Forms.Button();
            this.btnSCourse = new System.Windows.Forms.Button();
            this.txtCID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblTID = new System.Windows.Forms.Label();
            this.txtTID = new System.Windows.Forms.TextBox();
            this.cmbDCID = new System.Windows.Forms.ComboBox();
            this.cmbDTID = new System.Windows.Forms.ComboBox();
            this.btnDoneCD = new System.Windows.Forms.Button();
            this.btnDoneTD = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCMS
            // 
            this.lblCMS.AutoSize = true;
            this.lblCMS.BackColor = System.Drawing.Color.Transparent;
            this.lblCMS.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMS.Location = new System.Drawing.Point(285, 9);
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
            this.panel1.Controls.Add(this.lblDSearch);
            this.panel1.Controls.Add(this.btnRtnM1);
            this.panel1.Controls.Add(this.btnSTeachers);
            this.panel1.Controls.Add(this.btnSCourse);
            this.panel1.Location = new System.Drawing.Point(12, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 435);
            this.panel1.TabIndex = 2;
            // 
            // lblDSearch
            // 
            this.lblDSearch.AutoSize = true;
            this.lblDSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblDSearch.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSearch.ForeColor = System.Drawing.Color.Red;
            this.lblDSearch.Location = new System.Drawing.Point(56, 74);
            this.lblDSearch.Name = "lblDSearch";
            this.lblDSearch.Size = new System.Drawing.Size(146, 22);
            this.lblDSearch.TabIndex = 6;
            this.lblDSearch.Text = "Search Selection";
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
            // btnSTeachers
            // 
            this.btnSTeachers.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSTeachers.Location = new System.Drawing.Point(2, 293);
            this.btnSTeachers.Name = "btnSTeachers";
            this.btnSTeachers.Size = new System.Drawing.Size(219, 64);
            this.btnSTeachers.TabIndex = 4;
            this.btnSTeachers.Text = " Teacher Records";
            this.btnSTeachers.UseVisualStyleBackColor = true;
            this.btnSTeachers.Click += new System.EventHandler(this.btnSTeachers_Click);
            // 
            // btnSCourse
            // 
            this.btnSCourse.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSCourse.Location = new System.Drawing.Point(2, 223);
            this.btnSCourse.Name = "btnSCourse";
            this.btnSCourse.Size = new System.Drawing.Size(219, 64);
            this.btnSCourse.TabIndex = 3;
            this.btnSCourse.Text = "Course Records";
            this.btnSCourse.UseVisualStyleBackColor = true;
            this.btnSCourse.Click += new System.EventHandler(this.btnSCourse_Click);
            // 
            // txtCID
            // 
            this.txtCID.Location = new System.Drawing.Point(506, 122);
            this.txtCID.Name = "txtCID";
            this.txtCID.Size = new System.Drawing.Size(305, 20);
            this.txtCID.TabIndex = 4;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(322, 123);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(75, 19);
            this.lblID.TabIndex = 5;
            this.lblID.Text = "CourseID";
            // 
            // lblTID
            // 
            this.lblTID.AutoSize = true;
            this.lblTID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTID.Location = new System.Drawing.Point(322, 123);
            this.lblTID.Name = "lblTID";
            this.lblTID.Size = new System.Drawing.Size(85, 19);
            this.lblTID.TabIndex = 6;
            this.lblTID.Text = "Teacher ID";
            // 
            // txtTID
            // 
            this.txtTID.Location = new System.Drawing.Point(506, 122);
            this.txtTID.Name = "txtTID";
            this.txtTID.Size = new System.Drawing.Size(305, 20);
            this.txtTID.TabIndex = 7;
            // 
            // cmbDCID
            // 
            this.cmbDCID.FormattingEnabled = true;
            this.cmbDCID.Location = new System.Drawing.Point(314, 243);
            this.cmbDCID.Name = "cmbDCID";
            this.cmbDCID.Size = new System.Drawing.Size(517, 21);
            this.cmbDCID.TabIndex = 8;
            // 
            // cmbDTID
            // 
            this.cmbDTID.FormattingEnabled = true;
            this.cmbDTID.Location = new System.Drawing.Point(314, 243);
            this.cmbDTID.Name = "cmbDTID";
            this.cmbDTID.Size = new System.Drawing.Size(517, 21);
            this.cmbDTID.TabIndex = 9;
            // 
            // btnDoneCD
            // 
            this.btnDoneCD.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoneCD.Location = new System.Drawing.Point(451, 315);
            this.btnDoneCD.Name = "btnDoneCD";
            this.btnDoneCD.Size = new System.Drawing.Size(219, 64);
            this.btnDoneCD.TabIndex = 7;
            this.btnDoneCD.Text = "Done";
            this.btnDoneCD.UseVisualStyleBackColor = true;
            this.btnDoneCD.Click += new System.EventHandler(this.btnDoneCD_Click);
            // 
            // btnDoneTD
            // 
            this.btnDoneTD.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoneTD.Location = new System.Drawing.Point(451, 315);
            this.btnDoneTD.Name = "btnDoneTD";
            this.btnDoneTD.Size = new System.Drawing.Size(219, 64);
            this.btnDoneTD.TabIndex = 10;
            this.btnDoneTD.Text = "Done";
            this.btnDoneTD.UseVisualStyleBackColor = true;
            this.btnDoneTD.Click += new System.EventHandler(this.btnDoneTD_Click);
            // 
            // SearchRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(895, 510);
            this.Controls.Add(this.btnDoneTD);
            this.Controls.Add(this.btnDoneCD);
            this.Controls.Add(this.cmbDTID);
            this.Controls.Add(this.cmbDCID);
            this.Controls.Add(this.txtTID);
            this.Controls.Add(this.lblTID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtCID);
            this.Controls.Add(this.lblCMS);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchRecord";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCMS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDSearch;
        private System.Windows.Forms.Button btnRtnM1;
        private System.Windows.Forms.Button btnSTeachers;
        private System.Windows.Forms.Button btnSCourse;
        private System.Windows.Forms.TextBox txtCID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblTID;
        private System.Windows.Forms.TextBox txtTID;
        private System.Windows.Forms.ComboBox cmbDCID;
        private System.Windows.Forms.ComboBox cmbDTID;
        private System.Windows.Forms.Button btnDoneCD;
        private System.Windows.Forms.Button btnDoneTD;
    }
}
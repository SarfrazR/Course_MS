namespace CMS
{
    partial class DisplaySelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplaySelection));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDSelection = new System.Windows.Forms.Label();
            this.btnRtnM = new System.Windows.Forms.Button();
            this.btnDTeachers = new System.Windows.Forms.Button();
            this.btnDCourse = new System.Windows.Forms.Button();
            this.lblCMS = new System.Windows.Forms.Label();
            this.cmbACR = new System.Windows.Forms.ComboBox();
            this.cmbATR = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblDSelection);
            this.panel1.Controls.Add(this.btnRtnM);
            this.panel1.Controls.Add(this.btnDTeachers);
            this.panel1.Controls.Add(this.btnDCourse);
            this.panel1.Location = new System.Drawing.Point(2, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 435);
            this.panel1.TabIndex = 0;
            // 
            // lblDSelection
            // 
            this.lblDSelection.AutoSize = true;
            this.lblDSelection.BackColor = System.Drawing.Color.Transparent;
            this.lblDSelection.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSelection.ForeColor = System.Drawing.Color.Red;
            this.lblDSelection.Location = new System.Drawing.Point(56, 74);
            this.lblDSelection.Name = "lblDSelection";
            this.lblDSelection.Size = new System.Drawing.Size(150, 22);
            this.lblDSelection.TabIndex = 6;
            this.lblDSelection.Text = "Display Selection";
            this.lblDSelection.Click += new System.EventHandler(this.lblDSelection_Click);
            // 
            // btnRtnM
            // 
            this.btnRtnM.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRtnM.Location = new System.Drawing.Point(2, 363);
            this.btnRtnM.Name = "btnRtnM";
            this.btnRtnM.Size = new System.Drawing.Size(219, 64);
            this.btnRtnM.TabIndex = 5;
            this.btnRtnM.Text = "Return";
            this.btnRtnM.UseVisualStyleBackColor = true;
            this.btnRtnM.Click += new System.EventHandler(this.btnRtnM_Click);
            // 
            // btnDTeachers
            // 
            this.btnDTeachers.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDTeachers.Location = new System.Drawing.Point(2, 293);
            this.btnDTeachers.Name = "btnDTeachers";
            this.btnDTeachers.Size = new System.Drawing.Size(219, 64);
            this.btnDTeachers.TabIndex = 4;
            this.btnDTeachers.Text = "All Teacher Records";
            this.btnDTeachers.UseVisualStyleBackColor = true;
            this.btnDTeachers.Click += new System.EventHandler(this.btnDTeachers_Click);
            // 
            // btnDCourse
            // 
            this.btnDCourse.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDCourse.Location = new System.Drawing.Point(2, 223);
            this.btnDCourse.Name = "btnDCourse";
            this.btnDCourse.Size = new System.Drawing.Size(219, 64);
            this.btnDCourse.TabIndex = 3;
            this.btnDCourse.Text = "All Course Records";
            this.btnDCourse.UseVisualStyleBackColor = true;
            this.btnDCourse.Click += new System.EventHandler(this.btnDCourse_Click);
            // 
            // lblCMS
            // 
            this.lblCMS.AutoSize = true;
            this.lblCMS.BackColor = System.Drawing.Color.Transparent;
            this.lblCMS.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMS.Location = new System.Drawing.Point(273, 33);
            this.lblCMS.Name = "lblCMS";
            this.lblCMS.Size = new System.Drawing.Size(406, 72);
            this.lblCMS.TabIndex = 1;
            this.lblCMS.Text = "              Welcome to\r\nCourse Management System";
            // 
            // cmbACR
            // 
            this.cmbACR.FormattingEnabled = true;
            this.cmbACR.Location = new System.Drawing.Point(250, 131);
            this.cmbACR.Name = "cmbACR";
            this.cmbACR.Size = new System.Drawing.Size(586, 21);
            this.cmbACR.TabIndex = 2;
            // 
            // cmbATR
            // 
            this.cmbATR.FormattingEnabled = true;
            this.cmbATR.Location = new System.Drawing.Point(250, 131);
            this.cmbATR.Name = "cmbATR";
            this.cmbATR.Size = new System.Drawing.Size(586, 21);
            this.cmbATR.TabIndex = 3;
            this.cmbATR.SelectedIndexChanged += new System.EventHandler(this.cmbATR_SelectedIndexChanged);
            // 
            // DisplaySelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(911, 537);
            this.Controls.Add(this.cmbATR);
            this.Controls.Add(this.cmbACR);
            this.Controls.Add(this.lblCMS);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DisplaySelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisplaySelection";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void cmbATR_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRtnM;
        private System.Windows.Forms.Button btnDTeachers;
        private System.Windows.Forms.Button btnDCourse;
        private System.Windows.Forms.Label lblDSelection;
        private System.Windows.Forms.Label lblCMS;
        private System.Windows.Forms.ComboBox cmbACR;
        private System.Windows.Forms.ComboBox cmbATR;
    }
}
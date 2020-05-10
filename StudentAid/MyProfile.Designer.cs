namespace StudentAid
{
    partial class MyProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyProfile));
            this.MyCourses_Button = new System.Windows.Forms.Button();
            this.SignOut_Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Textbooks_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Internships_ComboBox = new System.Windows.Forms.ComboBox();
            this.ProjectTeam_Button = new System.Windows.Forms.Button();
            this.Contest_Button = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.YourName_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MyCourses_Button
            // 
            this.MyCourses_Button.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.MyCourses_Button.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyCourses_Button.ForeColor = System.Drawing.SystemColors.Highlight;
            this.MyCourses_Button.Location = new System.Drawing.Point(12, 100);
            this.MyCourses_Button.Name = "MyCourses_Button";
            this.MyCourses_Button.Size = new System.Drawing.Size(99, 38);
            this.MyCourses_Button.TabIndex = 0;
            this.MyCourses_Button.Text = " My Courses";
            this.MyCourses_Button.UseVisualStyleBackColor = false;
            this.MyCourses_Button.Click += new System.EventHandler(this.MyCourses_Button_Click);
            // 
            // SignOut_Button
            // 
            this.SignOut_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignOut_Button.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SignOut_Button.Location = new System.Drawing.Point(688, 2);
            this.SignOut_Button.Name = "SignOut_Button";
            this.SignOut_Button.Size = new System.Drawing.Size(75, 23);
            this.SignOut_Button.TabIndex = 26;
            this.SignOut_Button.Text = "Sign Out";
            this.SignOut_Button.UseVisualStyleBackColor = true;
            this.SignOut_Button.Click += new System.EventHandler(this.SignOut_Button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // Textbooks_Button
            // 
            this.Textbooks_Button.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Textbooks_Button.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbooks_Button.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Textbooks_Button.Location = new System.Drawing.Point(290, 100);
            this.Textbooks_Button.Name = "Textbooks_Button";
            this.Textbooks_Button.Size = new System.Drawing.Size(124, 38);
            this.Textbooks_Button.TabIndex = 28;
            this.Textbooks_Button.Text = "My Textbooks";
            this.Textbooks_Button.UseVisualStyleBackColor = false;
            this.Textbooks_Button.Click += new System.EventHandler(this.Textbooks_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(506, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "This form shows all the information realted to you - your courses, textbooks down" +
    "loaded,...etc-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(140, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 19);
            this.label2.TabIndex = 31;
            this.label2.Text = "My Internships";
            // 
            // Internships_ComboBox
            // 
            this.Internships_ComboBox.FormattingEnabled = true;
            this.Internships_ComboBox.Items.AddRange(new object[] {
            "Accepted",
            "Pending"});
            this.Internships_ComboBox.Location = new System.Drawing.Point(140, 179);
            this.Internships_ComboBox.Name = "Internships_ComboBox";
            this.Internships_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.Internships_ComboBox.TabIndex = 32;
            this.Internships_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Internships_ComboBox_SelectedIndexChanged);
            // 
            // ProjectTeam_Button
            // 
            this.ProjectTeam_Button.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ProjectTeam_Button.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectTeam_Button.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ProjectTeam_Button.Location = new System.Drawing.Point(454, 162);
            this.ProjectTeam_Button.Name = "ProjectTeam_Button";
            this.ProjectTeam_Button.Size = new System.Drawing.Size(139, 38);
            this.ProjectTeam_Button.TabIndex = 33;
            this.ProjectTeam_Button.Text = "My Project Teams";
            this.ProjectTeam_Button.UseVisualStyleBackColor = false;
            this.ProjectTeam_Button.Click += new System.EventHandler(this.ProjectTeam_Button_Click);
            // 
            // Contest_Button
            // 
            this.Contest_Button.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Contest_Button.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contest_Button.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Contest_Button.Location = new System.Drawing.Point(600, 100);
            this.Contest_Button.Name = "Contest_Button";
            this.Contest_Button.Size = new System.Drawing.Size(124, 38);
            this.Contest_Button.TabIndex = 34;
            this.Contest_Button.Text = "My Contests";
            this.Contest_Button.UseVisualStyleBackColor = false;
            this.Contest_Button.Click += new System.EventHandler(this.Contest_Button_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Accepted",
            "Pending"});
            this.comboBox1.Location = new System.Drawing.Point(282, 266);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 36;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(278, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 19);
            this.label3.TabIndex = 35;
            this.label3.Text = "My Business ideas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sigmar One", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(394, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Welcome";
            // 
            // YourName_Label
            // 
            this.YourName_Label.AutoSize = true;
            this.YourName_Label.Font = new System.Drawing.Font("Sigmar One", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourName_Label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.YourName_Label.Location = new System.Drawing.Point(473, 9);
            this.YourName_Label.Name = "YourName_Label";
            this.YourName_Label.Size = new System.Drawing.Size(56, 20);
            this.YourName_Label.TabIndex = 37;
            this.YourName_Label.Text = "label3";
            // 
            // MyProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.YourName_Label);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Contest_Button);
            this.Controls.Add(this.ProjectTeam_Button);
            this.Controls.Add(this.Internships_ComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Textbooks_Button);
            this.Controls.Add(this.SignOut_Button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MyCourses_Button);
            this.Name = "MyProfile";
            this.Text = "MyProfile";
            this.Load += new System.EventHandler(this.MyProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MyCourses_Button;
        private System.Windows.Forms.Button SignOut_Button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Textbooks_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Internships_ComboBox;
        private System.Windows.Forms.Button ProjectTeam_Button;
        private System.Windows.Forms.Button Contest_Button;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label YourName_Label;
    }
}
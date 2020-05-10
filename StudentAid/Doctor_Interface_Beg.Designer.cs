namespace StudentAid
{
    partial class Doctor_Interface_Beg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctor_Interface_Beg));
            this.SignOut_Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Courses_Label = new System.Windows.Forms.Label();
            this.Upload_ComboBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.ViewMyCourses_button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.YourName_Label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SignOut_Button
            // 
            this.SignOut_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignOut_Button.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SignOut_Button.Location = new System.Drawing.Point(693, 3);
            this.SignOut_Button.Name = "SignOut_Button";
            this.SignOut_Button.Size = new System.Drawing.Size(75, 23);
            this.SignOut_Button.TabIndex = 16;
            this.SignOut_Button.Text = "Sign Out";
            this.SignOut_Button.UseVisualStyleBackColor = true;
            this.SignOut_Button.Click += new System.EventHandler(this.SignOut_Button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Courses_Label
            // 
            this.Courses_Label.AutoSize = true;
            this.Courses_Label.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Courses_Label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Courses_Label.Location = new System.Drawing.Point(52, 110);
            this.Courses_Label.Name = "Courses_Label";
            this.Courses_Label.Size = new System.Drawing.Size(65, 19);
            this.Courses_Label.TabIndex = 18;
            this.Courses_Label.Text = "Upload";
            // 
            // Upload_ComboBox
            // 
            this.Upload_ComboBox.FormattingEnabled = true;
            this.Upload_ComboBox.Items.AddRange(new object[] {
            "Courses",
            "Textbook",
            "Seminar",
            "Research Paper"});
            this.Upload_ComboBox.Location = new System.Drawing.Point(30, 132);
            this.Upload_ComboBox.Name = "Upload_ComboBox";
            this.Upload_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.Upload_ComboBox.TabIndex = 17;
            this.Upload_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Upload_ComboBox_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Location = new System.Drawing.Point(365, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 49);
            this.button2.TabIndex = 26;
            this.button2.Text = "Community";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ViewMyCourses_button1
            // 
            this.ViewMyCourses_button1.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewMyCourses_button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ViewMyCourses_button1.Location = new System.Drawing.Point(198, 110);
            this.ViewMyCourses_button1.Name = "ViewMyCourses_button1";
            this.ViewMyCourses_button1.Size = new System.Drawing.Size(121, 49);
            this.ViewMyCourses_button1.TabIndex = 27;
            this.ViewMyCourses_button1.Text = "View My Courses";
            this.ViewMyCourses_button1.UseVisualStyleBackColor = true;
            this.ViewMyCourses_button1.Click += new System.EventHandler(this.ViewMyCourses_button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sigmar One", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(377, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 63;
            this.label3.Text = "Welcome";
            // 
            // YourName_Label
            // 
            this.YourName_Label.AutoSize = true;
            this.YourName_Label.Font = new System.Drawing.Font("Sigmar One", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourName_Label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.YourName_Label.Location = new System.Drawing.Point(456, 5);
            this.YourName_Label.Name = "YourName_Label";
            this.YourName_Label.Size = new System.Drawing.Size(56, 20);
            this.YourName_Label.TabIndex = 62;
            this.YourName_Label.Text = "label3";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(533, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 98);
            this.button1.TabIndex = 85;
            this.button1.Text = "View statistics of all courses";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Doctor_Interface_Beg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.YourName_Label);
            this.Controls.Add(this.ViewMyCourses_button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Courses_Label);
            this.Controls.Add(this.Upload_ComboBox);
            this.Controls.Add(this.SignOut_Button);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Doctor_Interface_Beg";
            this.Text = "Doctor_Interface_Beg";
            this.Load += new System.EventHandler(this.Doctor_Interface_Beg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignOut_Button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Courses_Label;
        private System.Windows.Forms.ComboBox Upload_ComboBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ViewMyCourses_button1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label YourName_Label;
        public System.Windows.Forms.Button button1;
    }
}
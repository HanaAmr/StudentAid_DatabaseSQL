namespace StudentAid
{
    partial class Student_Interface_Beg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Interface_Beg));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SignOut_Button = new System.Windows.Forms.Button();
            this.ViewInternships_Button = new System.Windows.Forms.Button();
            this.ViewContests_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Resources_ComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Projects_ComboBox = new System.Windows.Forms.ComboBox();
            this.MyProfile_Button = new System.Windows.Forms.Button();
            this.Courses_Button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.YourName_Label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SignOut_Button
            // 
            this.SignOut_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignOut_Button.Location = new System.Drawing.Point(690, 5);
            this.SignOut_Button.Name = "SignOut_Button";
            this.SignOut_Button.Size = new System.Drawing.Size(75, 23);
            this.SignOut_Button.TabIndex = 13;
            this.SignOut_Button.Text = "Sign Out";
            this.SignOut_Button.UseVisualStyleBackColor = true;
            this.SignOut_Button.Click += new System.EventHandler(this.SignOut_Button_Click);
            // 
            // ViewInternships_Button
            // 
            this.ViewInternships_Button.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewInternships_Button.Location = new System.Drawing.Point(175, 117);
            this.ViewInternships_Button.Name = "ViewInternships_Button";
            this.ViewInternships_Button.Size = new System.Drawing.Size(121, 36);
            this.ViewInternships_Button.TabIndex = 14;
            this.ViewInternships_Button.Text = "View Internships";
            this.ViewInternships_Button.UseVisualStyleBackColor = true;
            this.ViewInternships_Button.Click += new System.EventHandler(this.ViewInternships_Button_Click);
            // 
            // ViewContests_Button
            // 
            this.ViewContests_Button.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewContests_Button.Location = new System.Drawing.Point(520, 117);
            this.ViewContests_Button.Name = "ViewContests_Button";
            this.ViewContests_Button.Size = new System.Drawing.Size(121, 36);
            this.ViewContests_Button.TabIndex = 15;
            this.ViewContests_Button.Text = "View Contests";
            this.ViewContests_Button.UseVisualStyleBackColor = true;
            this.ViewContests_Button.Click += new System.EventHandler(this.ViewContests_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(361, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Resources";
            // 
            // Resources_ComboBox
            // 
            this.Resources_ComboBox.FormattingEnabled = true;
            this.Resources_ComboBox.Items.AddRange(new object[] {
            "Textbooks",
            "Seminars",
            "Research Papers"});
            this.Resources_ComboBox.Location = new System.Drawing.Point(342, 126);
            this.Resources_ComboBox.Name = "Resources_ComboBox";
            this.Resources_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.Resources_ComboBox.TabIndex = 19;
            this.Resources_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Resources_ComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(34, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Projects";
            // 
            // Projects_ComboBox
            // 
            this.Projects_ComboBox.FormattingEnabled = true;
            this.Projects_ComboBox.Items.AddRange(new object[] {
            "Join an existing project",
            "Request a new project"});
            this.Projects_ComboBox.Location = new System.Drawing.Point(12, 204);
            this.Projects_ComboBox.Name = "Projects_ComboBox";
            this.Projects_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.Projects_ComboBox.TabIndex = 20;
            this.Projects_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Projects_ComboBox_SelectedIndexChanged);
            // 
            // MyProfile_Button
            // 
            this.MyProfile_Button.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyProfile_Button.Location = new System.Drawing.Point(142, 24);
            this.MyProfile_Button.Name = "MyProfile_Button";
            this.MyProfile_Button.Size = new System.Drawing.Size(121, 36);
            this.MyProfile_Button.TabIndex = 22;
            this.MyProfile_Button.Text = "My Profile";
            this.MyProfile_Button.UseVisualStyleBackColor = true;
            this.MyProfile_Button.Click += new System.EventHandler(this.MyProfile_Button_Click);
            // 
            // Courses_Button
            // 
            this.Courses_Button.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Courses_Button.Location = new System.Drawing.Point(12, 117);
            this.Courses_Button.Name = "Courses_Button";
            this.Courses_Button.Size = new System.Drawing.Size(121, 36);
            this.Courses_Button.TabIndex = 23;
            this.Courses_Button.Text = "View Courses";
            this.Courses_Button.UseVisualStyleBackColor = true;
            this.Courses_Button.Click += new System.EventHandler(this.Courses_Button_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(175, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 49);
            this.button1.TabIndex = 24;
            this.button1.Text = "Looking for a sponsor?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(333, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 49);
            this.button2.TabIndex = 25;
            this.button2.Text = "Community";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // YourName_Label
            // 
            this.YourName_Label.AutoSize = true;
            this.YourName_Label.Font = new System.Drawing.Font("Sigmar One", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourName_Label.Location = new System.Drawing.Point(469, 15);
            this.YourName_Label.Name = "YourName_Label";
            this.YourName_Label.Size = new System.Drawing.Size(56, 20);
            this.YourName_Label.TabIndex = 26;
            this.YourName_Label.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sigmar One", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(390, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Welcome";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Student_Interface_Beg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.YourName_Label);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Courses_Button);
            this.Controls.Add(this.MyProfile_Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Projects_ComboBox);
            this.Controls.Add(this.Resources_ComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ViewContests_Button);
            this.Controls.Add(this.ViewInternships_Button);
            this.Controls.Add(this.SignOut_Button);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "Student_Interface_Beg";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Student_Interface_Beg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SignOut_Button;
        private System.Windows.Forms.Button ViewInternships_Button;
        private System.Windows.Forms.Button ViewContests_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Resources_ComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Projects_ComboBox;
        private System.Windows.Forms.Button MyProfile_Button;
        private System.Windows.Forms.Button Courses_Button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label YourName_Label;
        public System.Windows.Forms.Label label3;
    }
}
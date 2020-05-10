namespace StudentAid
{
    partial class AvailableCourses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AvailableCourses));
            this.label1 = new System.Windows.Forms.Label();
            this.AvailableCourses_DataGridView = new System.Windows.Forms.DataGridView();
            this.AddToMyProfile_Button = new System.Windows.Forms.Button();
            this.GiveYourFeedback_Button = new System.Windows.Forms.Button();
            this.Feedback_Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SignOut_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.YourName_Label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AvailableCourses_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "The available courses are:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AvailableCourses_DataGridView
            // 
            this.AvailableCourses_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AvailableCourses_DataGridView.Location = new System.Drawing.Point(151, 98);
            this.AvailableCourses_DataGridView.Name = "AvailableCourses_DataGridView";
            this.AvailableCourses_DataGridView.Size = new System.Drawing.Size(404, 169);
            this.AvailableCourses_DataGridView.TabIndex = 2;
            this.AvailableCourses_DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AddToMyProfile_Button
            // 
            this.AddToMyProfile_Button.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToMyProfile_Button.Location = new System.Drawing.Point(271, 273);
            this.AddToMyProfile_Button.Name = "AddToMyProfile_Button";
            this.AddToMyProfile_Button.Size = new System.Drawing.Size(172, 25);
            this.AddToMyProfile_Button.TabIndex = 3;
            this.AddToMyProfile_Button.Text = "Add To My Profile";
            this.AddToMyProfile_Button.UseVisualStyleBackColor = true;
            this.AddToMyProfile_Button.Click += new System.EventHandler(this.AddToMyProfile_Button_Click);
            // 
            // GiveYourFeedback_Button
            // 
            this.GiveYourFeedback_Button.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GiveYourFeedback_Button.Location = new System.Drawing.Point(594, 172);
            this.GiveYourFeedback_Button.Name = "GiveYourFeedback_Button";
            this.GiveYourFeedback_Button.Size = new System.Drawing.Size(177, 25);
            this.GiveYourFeedback_Button.TabIndex = 4;
            this.GiveYourFeedback_Button.Text = "Give Your Feedback";
            this.GiveYourFeedback_Button.UseVisualStyleBackColor = true;
            this.GiveYourFeedback_Button.Click += new System.EventHandler(this.GiveYourFeedback_Button_Click);
            // 
            // Feedback_Button
            // 
            this.Feedback_Button.Location = new System.Drawing.Point(468, 221);
            this.Feedback_Button.Name = "Feedback_Button";
            this.Feedback_Button.Size = new System.Drawing.Size(75, 23);
            this.Feedback_Button.TabIndex = 5;
            this.Feedback_Button.Text = "Feedbacks";
            this.Feedback_Button.UseVisualStyleBackColor = true;
            this.Feedback_Button.Click += new System.EventHandler(this.Feedback_Button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // SignOut_Button
            // 
            this.SignOut_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignOut_Button.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SignOut_Button.Location = new System.Drawing.Point(696, 6);
            this.SignOut_Button.Name = "SignOut_Button";
            this.SignOut_Button.Size = new System.Drawing.Size(75, 23);
            this.SignOut_Button.TabIndex = 17;
            this.SignOut_Button.Text = "Sign Out";
            this.SignOut_Button.UseVisualStyleBackColor = true;
            this.SignOut_Button.Click += new System.EventHandler(this.SignOut_Button_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(617, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 62);
            this.label2.TabIndex = 18;
            this.label2.Text = "Wanna give your feedback on this course?";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(287, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sigmar One", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(395, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "Welcome";
            // 
            // YourName_Label
            // 
            this.YourName_Label.AutoSize = true;
            this.YourName_Label.Font = new System.Drawing.Font("Sigmar One", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourName_Label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.YourName_Label.Location = new System.Drawing.Point(474, 8);
            this.YourName_Label.Name = "YourName_Label";
            this.YourName_Label.Size = new System.Drawing.Size(56, 20);
            this.YourName_Label.TabIndex = 39;
            this.YourName_Label.Text = "label3";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(12, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 98);
            this.button1.TabIndex = 86;
            this.button1.Text = "View feedback on all courses";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AvailableCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.YourName_Label);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SignOut_Button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Feedback_Button);
            this.Controls.Add(this.GiveYourFeedback_Button);
            this.Controls.Add(this.AddToMyProfile_Button);
            this.Controls.Add(this.AvailableCourses_DataGridView);
            this.Controls.Add(this.label1);
            this.Name = "AvailableCourses";
            this.Text = "AvailableCourses";
            this.Load += new System.EventHandler(this.AvailableCourses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AvailableCourses_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView AvailableCourses_DataGridView;
        private System.Windows.Forms.Button AddToMyProfile_Button;
        private System.Windows.Forms.Button GiveYourFeedback_Button;
        private System.Windows.Forms.Button Feedback_Button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SignOut_Button;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label YourName_Label;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Button button1;
    }
}
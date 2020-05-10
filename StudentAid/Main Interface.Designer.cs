namespace StudentAid
{
    partial class MainInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainInterface));
            this.Mission_Label = new System.Windows.Forms.Label();
            this.Vision_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Student_CheckBox = new System.Windows.Forms.CheckBox();
            this.Doctor_CheckBox = new System.Windows.Forms.CheckBox();
            this.Sponsor_CheckBox = new System.Windows.Forms.CheckBox();
            this.Mission_Statement = new System.Windows.Forms.Label();
            this.Vision_Statement = new System.Windows.Forms.Label();
            this.SignUp_Button = new System.Windows.Forms.Button();
            this.Or_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Mission_Label
            // 
            this.Mission_Label.AutoSize = true;
            this.Mission_Label.Font = new System.Drawing.Font("Courgette", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mission_Label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Mission_Label.Location = new System.Drawing.Point(14, 8);
            this.Mission_Label.Name = "Mission_Label";
            this.Mission_Label.Size = new System.Drawing.Size(157, 19);
            this.Mission_Label.TabIndex = 0;
            this.Mission_Label.Text = "Mission Statement :";
            this.Mission_Label.Click += new System.EventHandler(this.Mission_Label_Click);
            // 
            // Vision_Label
            // 
            this.Vision_Label.AutoSize = true;
            this.Vision_Label.Font = new System.Drawing.Font("Courgette", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vision_Label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Vision_Label.Location = new System.Drawing.Point(10, 155);
            this.Vision_Label.Name = "Vision_Label";
            this.Vision_Label.Size = new System.Drawing.Size(139, 19);
            this.Vision_Label.TabIndex = 4;
            this.Vision_Label.Text = "Vision Statement:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(731, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Login as:";
            // 
            // Student_CheckBox
            // 
            this.Student_CheckBox.AutoSize = true;
            this.Student_CheckBox.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_CheckBox.Location = new System.Drawing.Point(718, 64);
            this.Student_CheckBox.Name = "Student_CheckBox";
            this.Student_CheckBox.Size = new System.Drawing.Size(69, 18);
            this.Student_CheckBox.TabIndex = 6;
            this.Student_CheckBox.Text = "Student";
            this.Student_CheckBox.UseVisualStyleBackColor = true;
            this.Student_CheckBox.CheckedChanged += new System.EventHandler(this.Student_CheckBox_CheckedChanged);
            // 
            // Doctor_CheckBox
            // 
            this.Doctor_CheckBox.AutoSize = true;
            this.Doctor_CheckBox.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doctor_CheckBox.Location = new System.Drawing.Point(718, 88);
            this.Doctor_CheckBox.Name = "Doctor_CheckBox";
            this.Doctor_CheckBox.Size = new System.Drawing.Size(64, 18);
            this.Doctor_CheckBox.TabIndex = 7;
            this.Doctor_CheckBox.Text = "Doctor";
            this.Doctor_CheckBox.UseVisualStyleBackColor = true;
            this.Doctor_CheckBox.CheckedChanged += new System.EventHandler(this.Doctor_CheckBox_CheckedChanged);
            // 
            // Sponsor_CheckBox
            // 
            this.Sponsor_CheckBox.AutoSize = true;
            this.Sponsor_CheckBox.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sponsor_CheckBox.Location = new System.Drawing.Point(718, 112);
            this.Sponsor_CheckBox.Name = "Sponsor_CheckBox";
            this.Sponsor_CheckBox.Size = new System.Drawing.Size(72, 18);
            this.Sponsor_CheckBox.TabIndex = 8;
            this.Sponsor_CheckBox.Text = "Sponsor";
            this.Sponsor_CheckBox.UseVisualStyleBackColor = true;
            this.Sponsor_CheckBox.CheckedChanged += new System.EventHandler(this.Sponsor_CheckBox_CheckedChanged);
            // 
            // Mission_Statement
            // 
            this.Mission_Statement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Mission_Statement.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mission_Statement.Location = new System.Drawing.Point(16, 32);
            this.Mission_Statement.Name = "Mission_Statement";
            this.Mission_Statement.Size = new System.Drawing.Size(155, 116);
            this.Mission_Statement.TabIndex = 9;
            this.Mission_Statement.Text = "We strive to utilize effective ways, minimize complex processes and maximize effi" +
    "ciency in order to provide an optimal experience for all students .";
            this.Mission_Statement.Click += new System.EventHandler(this.Mission_Statement_Click);
            // 
            // Vision_Statement
            // 
            this.Vision_Statement.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vision_Statement.Location = new System.Drawing.Point(16, 188);
            this.Vision_Statement.Name = "Vision_Statement";
            this.Vision_Statement.Size = new System.Drawing.Size(167, 156);
            this.Vision_Statement.TabIndex = 10;
            this.Vision_Statement.Text = resources.GetString("Vision_Statement.Text");
            // 
            // SignUp_Button
            // 
            this.SignUp_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SignUp_Button.BackgroundImage")));
            this.SignUp_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SignUp_Button.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUp_Button.ForeColor = System.Drawing.SystemColors.Highlight;
            this.SignUp_Button.Location = new System.Drawing.Point(762, 141);
            this.SignUp_Button.Name = "SignUp_Button";
            this.SignUp_Button.Size = new System.Drawing.Size(80, 33);
            this.SignUp_Button.TabIndex = 11;
            this.SignUp_Button.UseVisualStyleBackColor = true;
            this.SignUp_Button.Click += new System.EventHandler(this.SignUp_Button_Click);
            // 
            // Or_Label
            // 
            this.Or_Label.AutoSize = true;
            this.Or_Label.Font = new System.Drawing.Font("Fugaz One", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Or_Label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Or_Label.Location = new System.Drawing.Point(732, 151);
            this.Or_Label.Name = "Or_Label";
            this.Or_Label.Size = new System.Drawing.Size(22, 17);
            this.Or_Label.TabIndex = 12;
            this.Or_Label.Text = "OR";
            // 
            // MainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1023, 466);
            this.Controls.Add(this.Or_Label);
            this.Controls.Add(this.SignUp_Button);
            this.Controls.Add(this.Vision_Statement);
            this.Controls.Add(this.Mission_Statement);
            this.Controls.Add(this.Sponsor_CheckBox);
            this.Controls.Add(this.Doctor_CheckBox);
            this.Controls.Add(this.Student_CheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Vision_Label);
            this.Controls.Add(this.Mission_Label);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("MS Outlook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.MaximumSize = new System.Drawing.Size(2000, 1000);
            this.Name = "MainInterface";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainInterface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Mission_Label;
        private System.Windows.Forms.Label Vision_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Student_CheckBox;
        private System.Windows.Forms.CheckBox Doctor_CheckBox;
        private System.Windows.Forms.CheckBox Sponsor_CheckBox;
        private System.Windows.Forms.Label Mission_Statement;
        private System.Windows.Forms.Label Vision_Statement;
        private System.Windows.Forms.Button SignUp_Button;
        private System.Windows.Forms.Label Or_Label;
    }
}


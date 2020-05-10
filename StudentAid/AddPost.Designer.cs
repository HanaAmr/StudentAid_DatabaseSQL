namespace StudentAid
{
    partial class AddPost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPost));
            this.SignOut_Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.posts_textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SubmitPost_button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.YourName_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SignOut_Button
            // 
            this.SignOut_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignOut_Button.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SignOut_Button.Location = new System.Drawing.Point(693, 2);
            this.SignOut_Button.Name = "SignOut_Button";
            this.SignOut_Button.Size = new System.Drawing.Size(75, 23);
            this.SignOut_Button.TabIndex = 22;
            this.SignOut_Button.Text = "Sign Out";
            this.SignOut_Button.UseVisualStyleBackColor = true;
            this.SignOut_Button.Click += new System.EventHandler(this.SignOut_Button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // posts_textBox1
            // 
            this.posts_textBox1.Location = new System.Drawing.Point(98, 108);
            this.posts_textBox1.Multiline = true;
            this.posts_textBox1.Name = "posts_textBox1";
            this.posts_textBox1.Size = new System.Drawing.Size(537, 71);
            this.posts_textBox1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Write your question here:";
            // 
            // SubmitPost_button1
            // 
            this.SubmitPost_button1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitPost_button1.Location = new System.Drawing.Point(599, 219);
            this.SubmitPost_button1.Name = "SubmitPost_button1";
            this.SubmitPost_button1.Size = new System.Drawing.Size(75, 23);
            this.SubmitPost_button1.TabIndex = 25;
            this.SubmitPost_button1.Text = "Add";
            this.SubmitPost_button1.UseVisualStyleBackColor = true;
            this.SubmitPost_button1.Click += new System.EventHandler(this.SubmitPost_button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sigmar One", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(349, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Welcome";
            // 
            // YourName_Label
            // 
            this.YourName_Label.AutoSize = true;
            this.YourName_Label.Font = new System.Drawing.Font("Sigmar One", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourName_Label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.YourName_Label.Location = new System.Drawing.Point(428, 4);
            this.YourName_Label.Name = "YourName_Label";
            this.YourName_Label.Size = new System.Drawing.Size(56, 20);
            this.YourName_Label.TabIndex = 30;
            this.YourName_Label.Text = "label3";
            // 
            // AddPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.YourName_Label);
            this.Controls.Add(this.SubmitPost_button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.posts_textBox1);
            this.Controls.Add(this.SignOut_Button);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddPost";
            this.Text = "AddPost";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignOut_Button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox posts_textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SubmitPost_button1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label YourName_Label;
    }
}
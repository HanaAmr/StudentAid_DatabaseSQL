namespace StudentAid
{
    partial class Community_RepliesOnly
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Community_RepliesOnly));
            this.SignOut_Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Replies_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddPost_button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.YourName_Label = new System.Windows.Forms.Label();
            this.Messagelabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Replies_dataGridView1)).BeginInit();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "All Answers";
            // 
            // Replies_dataGridView1
            // 
            this.Replies_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Replies_dataGridView1.Location = new System.Drawing.Point(92, 114);
            this.Replies_dataGridView1.Name = "Replies_dataGridView1";
            this.Replies_dataGridView1.Size = new System.Drawing.Size(577, 226);
            this.Replies_dataGridView1.TabIndex = 26;
            // 
            // AddPost_button1
            // 
            this.AddPost_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPost_button1.Location = new System.Drawing.Point(625, 68);
            this.AddPost_button1.Name = "AddPost_button1";
            this.AddPost_button1.Size = new System.Drawing.Size(109, 23);
            this.AddPost_button1.TabIndex = 27;
            this.AddPost_button1.Text = "Add Reply";
            this.AddPost_button1.UseVisualStyleBackColor = true;
            this.AddPost_button1.Click += new System.EventHandler(this.AddPost_button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sigmar One", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(350, 2);
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
            this.YourName_Label.Location = new System.Drawing.Point(429, 2);
            this.YourName_Label.Name = "YourName_Label";
            this.YourName_Label.Size = new System.Drawing.Size(56, 20);
            this.YourName_Label.TabIndex = 30;
            this.YourName_Label.Text = "label3";
            // 
            // Messagelabel
            // 
            this.Messagelabel.AutoSize = true;
            this.Messagelabel.Font = new System.Drawing.Font("SketchFlow Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Messagelabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Messagelabel.Location = new System.Drawing.Point(103, 128);
            this.Messagelabel.Name = "Messagelabel";
            this.Messagelabel.Size = new System.Drawing.Size(318, 23);
            this.Messagelabel.TabIndex = 44;
            this.Messagelabel.Text = "No Answers on this post yet!";
            this.Messagelabel.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(243, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 45;
            this.textBox1.Visible = false;
            // 
            // Community_RepliesOnly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Messagelabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.YourName_Label);
            this.Controls.Add(this.AddPost_button1);
            this.Controls.Add(this.Replies_dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SignOut_Button);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Community_RepliesOnly";
            this.Text = "Community_RepliesOnly";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Replies_dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignOut_Button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddPost_button1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label YourName_Label;
        public System.Windows.Forms.DataGridView Replies_dataGridView1;
        public System.Windows.Forms.Label Messagelabel;
        public System.Windows.Forms.TextBox textBox1;
    }
}
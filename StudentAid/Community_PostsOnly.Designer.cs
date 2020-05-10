namespace StudentAid
{
    partial class Community_PostsOnly
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Community_PostsOnly));
            this.SignOut_Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Posts_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddPost_button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.YourName_Label = new System.Windows.Forms.Label();
            this.Messagelabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Posts_dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SignOut_Button
            // 
            this.SignOut_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignOut_Button.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SignOut_Button.Location = new System.Drawing.Point(702, 2);
            this.SignOut_Button.Name = "SignOut_Button";
            this.SignOut_Button.Size = new System.Drawing.Size(75, 23);
            this.SignOut_Button.TabIndex = 19;
            this.SignOut_Button.Text = "Sign Out";
            this.SignOut_Button.UseVisualStyleBackColor = true;
            this.SignOut_Button.Click += new System.EventHandler(this.SignOut_Button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Traditional Arabic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(557, 86);
            this.label1.TabIndex = 20;
            this.label1.Text = "This platform in intended to help you get all the answers on your questions , and" +
    "  why not help others as well?";
            // 
            // Posts_dataGridView1
            // 
            this.Posts_dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Posts_dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Posts_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Posts_dataGridView1.Location = new System.Drawing.Point(91, 155);
            this.Posts_dataGridView1.Name = "Posts_dataGridView1";
            this.Posts_dataGridView1.Size = new System.Drawing.Size(641, 228);
            this.Posts_dataGridView1.TabIndex = 21;
            this.Posts_dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AddPost_button1
            // 
            this.AddPost_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPost_button1.Location = new System.Drawing.Point(636, 101);
            this.AddPost_button1.Name = "AddPost_button1";
            this.AddPost_button1.Size = new System.Drawing.Size(109, 23);
            this.AddPost_button1.TabIndex = 22;
            this.AddPost_button1.Text = "Ask Question?";
            this.AddPost_button1.UseVisualStyleBackColor = true;
            this.AddPost_button1.Visible = false;
            this.AddPost_button1.Click += new System.EventHandler(this.AddPost_button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "All Questions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sigmar One", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(385, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Welcome";
            // 
            // YourName_Label
            // 
            this.YourName_Label.AutoSize = true;
            this.YourName_Label.Font = new System.Drawing.Font("Sigmar One", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourName_Label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.YourName_Label.Location = new System.Drawing.Point(464, 9);
            this.YourName_Label.Name = "YourName_Label";
            this.YourName_Label.Size = new System.Drawing.Size(56, 20);
            this.YourName_Label.TabIndex = 28;
            this.YourName_Label.Text = "label3";
            // 
            // Messagelabel
            // 
            this.Messagelabel.AutoSize = true;
            this.Messagelabel.Font = new System.Drawing.Font("SketchFlow Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Messagelabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Messagelabel.Location = new System.Drawing.Point(110, 169);
            this.Messagelabel.Name = "Messagelabel";
            this.Messagelabel.Size = new System.Drawing.Size(191, 23);
            this.Messagelabel.TabIndex = 43;
            this.Messagelabel.Text = "No questions yet!";
            this.Messagelabel.Visible = false;
            // 
            // Community_PostsOnly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Messagelabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.YourName_Label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddPost_button1);
            this.Controls.Add(this.Posts_dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SignOut_Button);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Community_PostsOnly";
            this.Text = "Community_PostsOnly";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Posts_dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignOut_Button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button AddPost_button1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label YourName_Label;
        public System.Windows.Forms.DataGridView Posts_dataGridView1;
        public System.Windows.Forms.Label Messagelabel;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAid
{
    public partial class AddPost : Form
    {
        Controller controllerObj;
        public AddPost()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void SignOut_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Au revoir, see you soon!");
            MainInterface MI = new MainInterface();
            MI.Show();
        }

        private void SubmitPost_button1_Click(object sender, EventArgs e)
        {
            if (posts_textBox1.Text=="")
            {
                MessageBox.Show("Please write your question first");
            }
            else
            {
                object i = controllerObj.GetStudentIDFromName(YourName_Label.Text.ToString());
                int c = int.Parse(controllerObj.GetCountOfPosts().ToString());
                int postNo = c + 1 + 8000;
                
                int r = controllerObj.AddPost(postNo,posts_textBox1.Text.ToString());
                int s = controllerObj.StudentAddPost(i.ToString(),postNo);
                if (r!= 0 && s!=0)
                {
                    MessageBox.Show("Your question is added succesfully, wait for someone to help!");
                   
                    Community_PostsOnly C = new Community_PostsOnly();
                    C.YourName_Label.Text = YourName_Label.Text;
                    C.AddPost_button1.Visible = true;
                    DataTable dt = controllerObj.GetAllQuestions();
                    if (dt != null)
                    {
                        C.Posts_dataGridView1.DataSource = dt;
                        C.Posts_dataGridView1.Refresh();
                        
                        C.Show();
                    }
                    else
                    {
                        C.Messagelabel.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("Something went wrong while adding your question, please try again");
                }
            }
        }
    }
}

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
    public partial class AddReply : Form
    {
        Controller controllerObj;
        public AddReply()
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
            if (replies_textBox1.Text=="")
            {
                MessageBox.Show("Please enter your reply first");
            }
            else
            {
                int c = int.Parse(controllerObj.GetCountReplyPosts_Student().ToString());
                int ReplypostNo = c + 10 /*+ 700000*/;
                Community_RepliesOnly C = new Community_RepliesOnly();
                //string p = C.textBox1.Text.ToString();
                Community_PostsOnly Cp = new Community_PostsOnly();
                
                object i=controllerObj.GetStudentIDFromName(YourName_Label.Text.ToString());
                object f = controllerObj.GetDoctorIDFromName(YourName_Label.Text.ToString());
                object b = controllerObj.GetSponsorIDFromName(YourName_Label.Text.ToString());
                int text = controllerObj.AddPost(ReplypostNo, replies_textBox1.Text.ToString());
                if (i != null)
                {
                    int r = controllerObj.StudentAddReply(i.ToString(), no_textBox1.Text.ToString(), ReplypostNo);
                }
                else if (f !=null)
                {
                    int q = controllerObj.DoctorAddReply(f.ToString(), no_textBox1.Text.ToString(), ReplypostNo);
                }
                else if(b != null)
                {
                    int u = controllerObj.SponsorAddReply(b.ToString(), no_textBox1.Text.ToString(), ReplypostNo) ;
                }
                if (text !=0 )
                {
                    MessageBox.Show("Thank you for your participation, your reply is added succesfully");

                    ///////////////////////////
                    DataTable R = controllerObj.GetAllRepliesOnASpecificPost(no_textBox1.Text.ToString());
                    if (R != null)
                    {
                        C.Replies_dataGridView1.DataSource = R;
                        C.Replies_dataGridView1.Refresh();
                        C.YourName_Label.Text = YourName_Label.Text;
                        C.textBox1.Text = no_textBox1.Text;
                        C.Show();

                    }
                    else
                    {
                        C.Messagelabel.Visible = true;
                    }
                }
                else
                {
                    //MessageBox.Show("Couldn't add your reply succesfully, please try again");
                }
            }
        }
    }
}

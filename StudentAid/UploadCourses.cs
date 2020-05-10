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
    public partial class UploadCourses : Form
    {
        Controller controllerObj;
        public UploadCourses()
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

        private void UploadT_Button_Click(object sender, EventArgs e)
        {
            if (RPName_TextBox.Text=="" || CourseLink_TextBox.Text=="")
            {
                MessageBox.Show("Please write down the required info");
            }
            else
            {
                int c = int.Parse(controllerObj.GetCountOfCourses().ToString());
                int IdeaNo = c + 1 + 57400;
                int dt2 = controllerObj.AddCourses(IdeaNo,RPName_TextBox.Text.ToString(),CourseLink_TextBox.Text.ToString(),int.Parse(CourseLevel_numericUpDown.Value.ToString()));
                if (dt2 !=0)
                {
                    MessageBox.Show("Your New Course is added succesfully, students will join it soon");
                }
                else
                {
                    MessageBox.Show(" Something went wrong while adding your new course, please try again");
                }
            }
        }

        private void UploadCourses_Load(object sender, EventArgs e)
        {

        }
    }
}

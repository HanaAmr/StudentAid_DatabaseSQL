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
    public partial class AvailableCourses : Form
    {
        Controller controllerObj;
        public AvailableCourses()
        {
            InitializeComponent();

            
            controllerObj = new Controller();
            DataTable dt = controllerObj.GetAllCoursesNameAndNumbers();
            comboBox1.DataSource=dt;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Name";
           

        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Feedback_Button_Click(object sender, EventArgs e)
        {
            Feedbacks F = new Feedbacks();
            F.YourName_Label.Text = YourName_Label.Text;
            DataTable dt = controllerObj.GetFeedbacksOfASpecificCourseByName(comboBox1.SelectedValue.ToString());
            if (dt != null)
            {
                F.Feedbacks_DataGridView.DataSource = dt;
                F.Feedbacks_DataGridView.Refresh();
            }
            else
            {
                F.Messagelabel.Visible = true; //No feedbacks yet
            }
            F.Show();
        }

        private void SignOut_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Au revoir, see you soon!");
            MainInterface MI = new MainInterface();
            MI.Show();
        }

        private void GiveYourFeedback_Button_Click(object sender, EventArgs e)
        {
            GiveYourFeedback YF = new GiveYourFeedback();
            YF.YourName_Label.Text = YourName_Label.Text;
            object n = controllerObj.GetCourseNumberFromCourseName(comboBox1.SelectedValue.ToString());
            YF.no.Text = n.ToString();
            YF.Show();
        }

        private void AddToMyProfile_Button_Click(object sender, EventArgs e)
        {
            object dt = controllerObj.GetCourseNumberFromCourseName(comboBox1.SelectedValue.ToString());
            object dt1 = controllerObj.GetStudentIDFromName(YourName_Label.Text.ToString());
            int dt2 = controllerObj.AddCourseToAStudentProfile(dt.ToString(), dt1.ToString());
            if (dt2 ==0)
            {
                MessageBox.Show("This course already exists in your profile , Check your courses ");

            }
            else
            {
                MessageBox.Show("Course added to your profile!, for more info, go check My profile");
            }
            
          
        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetInfoOfACourseByName(comboBox1.SelectedValue.ToString());
            AvailableCourses_DataGridView.DataSource = dt;
            AvailableCourses_DataGridView.Refresh();
        }

        private void AvailableCourses_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FeedbackStatistics F = new FeedbackStatistics();
            F.Show();
        }
    }
}

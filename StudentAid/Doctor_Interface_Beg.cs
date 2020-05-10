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
    public partial class Doctor_Interface_Beg : Form
    {
        Controller controllerObj;
        public Doctor_Interface_Beg()
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

        private void Upload_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Upload_ComboBox.SelectedItem.ToString() == "Courses")
            {
                UploadCourses UC = new UploadCourses();
                UC.YourName_Label.Text = YourName_Label.Text;
                UC.Show();
            }
            else if (Upload_ComboBox.SelectedItem.ToString()== "Textbook")
            {
                UploadTextbooks UT = new UploadTextbooks();
                UT.YourName_Label.Text = YourName_Label.Text;
                UT.Show();
          
            }
            else if (Upload_ComboBox.SelectedItem.ToString() == "Seminar")
            {
                UploadSeminars US = new UploadSeminars();
                US.YourName_Label.Text = YourName_Label.Text;
                US.Show();
            }
            else if (Upload_ComboBox.SelectedItem.ToString() == "Research Paper")
            {
                UploadResearchPapers UR = new UploadResearchPapers();
                UR.YourName_Label.Text = YourName_Label.Text;
                UR.Show();
            }
        }

        private void Doctor_Interface_Beg_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Community_PostsOnly C = new Community_PostsOnly();
           
            C.YourName_Label.Text = YourName_Label.Text;
            DataTable dt = controllerObj.GetAllQuestions();
            if (dt != null)
            {
                C.Posts_dataGridView1.DataSource = dt;
                C.Posts_dataGridView1.Refresh();
            }
            else
            {
                C.Messagelabel.Visible = true;
            }
            C.Show();

        }

        private void ViewMyCourses_button1_Click(object sender, EventArgs e)
        {
            Doctor_sCourses DC = new Doctor_sCourses();
            DC.YourName_Label.Text = YourName_Label.Text;
            DataTable dt = controllerObj.GetCoursesOfASpecificDoctorByName(YourName_Label.Text.ToString());
            if (dt != null)
            {
                DC.dataGridView1.DataSource = dt;
                DC.dataGridView1.Refresh();
               
            }
            else
            {
                DC.Messagelabel.Visible = true;
            }
            DC.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CourseStatistics C = new CourseStatistics();
            C.Show();
        }
    }
}

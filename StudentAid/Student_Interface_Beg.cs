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

    public partial class Student_Interface_Beg : Form
    {
        Controller controllerObj;
        public Student_Interface_Beg()
        {
            InitializeComponent();
            controllerObj = new Controller();


        }

        

        private void YouName_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignOut_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Au revoir, see you soon!");
            MainInterface MI = new MainInterface();
            MI.Show();
        }

        private void ViewInternships_Button_Click(object sender, EventArgs e)
        {
            ViewInterns V = new ViewInterns();
            V.YourName_Label.Text = YourName_Label.Text;            
            V.Show();

           

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Resources_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Resources_ComboBox.SelectedItem.ToString()== "Textbooks")
            {
                ViewTextbooks V = new ViewTextbooks();
                V.YourName_Label.Text = YourName_Label.Text;
                V.Show();

            }
            else if (Resources_ComboBox.SelectedItem.ToString() == "Seminars")
            {
                ViewSeminars V = new ViewSeminars();
                V.YourName_Label.Text = YourName_Label.Text;
                V.Show();

            }
            else if (Resources_ComboBox.SelectedItem.ToString() == "Research Papers")
            {
                ViewRP V = new ViewRP();
                V.YourName_Label.Text = YourName_Label.Text;
                V.Show();

            }
        }

        private void ViewContests_Button_Click(object sender, EventArgs e)
        {
            ViewContests V = new ViewContests();
            V.YourName_Label.Text = YourName_Label.Text;
            V.Show();

        }

        private void Projects_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if( Projects_ComboBox.SelectedItem.ToString()== "Join an existing project")
            {
                ViewProjectTeams V = new ViewProjectTeams();
                V.YourName_Label.Text = YourName_Label.Text;
                V.Show();

            }
            else if (Projects_ComboBox.SelectedItem.ToString() == "Request a new project")
            {
                RequestProject RP = new RequestProject();
                object dt = controllerObj.GetEmailOfStudentByName(YourName_Label.Text.ToString());
                RP.TeamLeaderContact_TextBox.Text = dt.ToString();
                RP.YourName_Label.Text = YourName_Label.Text;
                RP.Show();
            }
        }

        private void Courses_Label_Click(object sender, EventArgs e)
        {

        }

        private void MyProfile_Button_Click(object sender, EventArgs e)
        {
            MyProfile P = new MyProfile();
            P.YourName_Label.Text = YourName_Label.Text;
            P.Show();
        }

        private void Courses_Button_Click(object sender, EventArgs e)
        {
            AvailableCourses C = new AvailableCourses();
            C.YourName_Label.Text = YourName_Label.Text;
            C.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LookingForASponsor L = new LookingForASponsor();
            L.YourName_Label.Text = YourName_Label.Text;
            L.Show(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Community_PostsOnly C = new Community_PostsOnly();
            C.AddPost_button1.Visible = true;
            C.YourName_Label.Text = YourName_Label.Text;
            DataTable dt = controllerObj.GetAllQuestions();
            if (dt!= null)
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Student_Interface_Beg_Load(object sender, EventArgs e)
        {

        }
    }
}

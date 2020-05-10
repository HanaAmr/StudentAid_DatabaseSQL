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
    public partial class MyProfile : Form
    {
        Controller controllerObj;
        public MyProfile()
        {
            InitializeComponent();
            controllerObj = new Controller();
            

        }

        private void MyCourses_Button_Click(object sender, EventArgs e)
        {
            
            MyProfileDetails PD = new MyProfileDetails();
            Student_Login S = new Student_Login();
            PD.textBox1.Text = " Choose which courses to show";
            PD.YourName_Label.Text = YourName_Label.Text;           
            PD.comboBox1.Visible = true;
            PD.Show();
        }

        private void Internships_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Internships_ComboBox.SelectedItem.ToString() == "Accepted")
            {
                
                MyProfileDetails PD = new MyProfileDetails();
                Student_Login S = new Student_Login();
                PD.textBox1.Text = " The internships that are accepted are:";
                PD.YourName_Label.Text = YourName_Label.Text;
                object O = controllerObj.GetStudentUsernameFromName(YourName_Label.Text.ToString());
                DataTable dt = controllerObj.GetAcceptedInternshipsOfAStudentByUsername(O.ToString());
                PD.DataGridView1.DataSource = dt;
                PD.DataGridView1.Refresh();
                PD.Show();
            }
            else if (Internships_ComboBox.SelectedItem.ToString() == "Pending")
            {
                
                MyProfileDetails PD = new MyProfileDetails();
                Student_Login S = new Student_Login();
                PD.textBox1.Text = " The internships that are still pending are:";
                PD.YourName_Label.Text = YourName_Label.Text;
                object O = controllerObj.GetStudentUsernameFromName(YourName_Label.Text.ToString());
                DataTable dt = controllerObj.GetPendingInternshipsOfAStudentByUsername(O.ToString());
                PD.DataGridView1.DataSource = dt;
                PD.DataGridView1.Refresh();
                PD.Show();

            }
        }

        private void Textbooks_Button_Click(object sender, EventArgs e)
        {
            
            MyProfileDetails PD = new MyProfileDetails();
            Student_Login S = new Student_Login();
            PD.textBox1.Text = " The textbooks that you downloaded are:";
            PD.YourName_Label.Text = YourName_Label.Text;
            object O = controllerObj.GetStudentUsernameFromName(YourName_Label.Text.ToString());
            DataTable dt = controllerObj.GetTextbookNameLoadedByASpecificStudentByUsername(O.ToString());
            PD.DataGridView1.DataSource = dt;
            PD.DataGridView1.Refresh();
            PD.Show();
        }

        private void ProjectTeam_Button_Click(object sender, EventArgs e)
        {
            
            MyProfileDetails PD = new MyProfileDetails();
            Student_Login S = new Student_Login();
            PD.textBox1.Text = " The project teams that you joined are:";
            PD.YourName_Label.Text = YourName_Label.Text;
            object O = controllerObj.GetStudentUsernameFromName(YourName_Label.Text.ToString());
            DataTable dt = controllerObj.GetProjectTeamNameJoinedByASpecificStudentByUsername(O.ToString());
            PD.DataGridView1.DataSource = dt;
            PD.DataGridView1.Refresh();
            PD.Show();
        }

        private void Contest_Button_Click(object sender, EventArgs e)
        {
            
            MyProfileDetails PD = new MyProfileDetails();
            Student_Login S = new Student_Login();
            PD.textBox1.Text = " The contests that you joined are:";
            PD.YourName_Label.Text = YourName_Label.Text;
            object O = controllerObj.GetStudentUsernameFromName(YourName_Label.Text.ToString());
            DataTable dt = controllerObj.GetContestsNameJoinedByASpecificStudentByUsername(O.ToString());
            PD.DataGridView1.DataSource = dt;
            PD.DataGridView1.Refresh();
            PD.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Accepted")
            {
                
                MyProfileDetails PD = new MyProfileDetails();
                Student_Login S = new Student_Login();

                PD.textBox1.Text = " The business ideas that are accepted are:";
                PD.YourName_Label.Text = YourName_Label.Text;
               
                object O = controllerObj.GetStudentUsernameFromName(YourName_Label.Text.ToString());
                DataTable dt = controllerObj.GetAcceptedBusinessIdeasOfAstudentByUsername(O.ToString());
                PD.DataGridView1.DataSource = dt;
                PD.DataGridView1.Refresh();
                PD.Show();

            }
            else if (comboBox1.SelectedItem.ToString() == "Pending")
            {
               
                MyProfileDetails PD = new MyProfileDetails();
                Student_Login S = new Student_Login();

                PD.textBox1.Text = " The business ideas that are still pending are:";
                PD.YourName_Label.Text = YourName_Label.Text;
                object O = controllerObj.GetStudentUsernameFromName(YourName_Label.Text.ToString());
                DataTable dt = controllerObj.GetPendingBusinessIdeaOfAStudentByUsername(O.ToString());
                PD.DataGridView1.DataSource = dt;
                PD.DataGridView1.Refresh();

                PD.Show();
            }
        }

        private void SignOut_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Au revoir, see you soon!");
            MainInterface MI = new MainInterface();
            MI.Show();
        }

        private void MyProfile_Load(object sender, EventArgs e)
        {

        }
    }
}

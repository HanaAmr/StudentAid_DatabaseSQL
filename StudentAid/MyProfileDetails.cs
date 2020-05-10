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
    public partial class MyProfileDetails : Form
    {
        Controller controllerObj;
        public MyProfileDetails()
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString()== "Courses not graded yet")
            {
                object O = controllerObj.GetStudentUsernameFromName(YourName_Label.Text.ToString());
                DataTable dt = controllerObj.GetCoursesOfAStudentByUsername(O.ToString());
                DataGridView1.DataSource = dt;
                DataGridView1.Refresh();
            }
            else if (comboBox1.SelectedItem.ToString() == "Courses graded")
            {
                object O = controllerObj.GetStudentUsernameFromName(YourName_Label.Text.ToString());
                DataTable dt = controllerObj.GetCoursesWithGradesOfAStudentByUsername(O.ToString());
                DataGridView1.DataSource = dt;
                DataGridView1.Refresh();

            }
            
        }
       

    }
}

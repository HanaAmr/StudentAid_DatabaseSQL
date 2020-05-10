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
    public partial class ViewInterns : Form
    {
        Controller controllerObj;
        public ViewInterns()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.GetAllInternshipsNamesAndIDs();
            comboBox1.DataSource = dt;
           comboBox1.DisplayMember = "InternshipName";
            comboBox1.ValueMember = "InternshipName";




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SignOut_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Au revoir, see you soon!");
            MainInterface MI = new MainInterface();
            MI.Show();
        }

        private void Request_Button_Click(object sender, EventArgs e)
        {
            object dt1 = controllerObj.GetStudentIDFromName(YourName_Label.Text.ToString());
            object dt = controllerObj.GetInternshipIDByName(comboBox1.SelectedValue.ToString());
            int dt2 = controllerObj.AddInternshipToAStudentProfile(dt1.ToString(),dt.ToString());
            if (dt2 != 0)
            {
                MessageBox.Show("Internship is added to your profile successfully, to check it view your internships! ");
            }
            else
            {
                MessageBox.Show("The internship already exists to your profile,please check it out!");
            }
        }


        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DataTable dt1 = controllerObj.GetAllInfoOfInternshipByName(comboBox1.SelectedValue.ToString());
            DataGridView1.DataSource = dt1;
            DataGridView1.Refresh();

        }
    }
}

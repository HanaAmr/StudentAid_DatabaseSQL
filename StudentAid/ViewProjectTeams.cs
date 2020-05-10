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
    public partial class ViewProjectTeams : Form
    {
        Controller controllerObj;
        public ViewProjectTeams()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.GetAllProjectTeamsNameAndNumbers();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "TeamNumber";

        }

        private void SignOut_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Au revoir, see you soon!");
            MainInterface MI = new MainInterface();
            MI.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt1 = controllerObj.GetInfoOfAProjectTeamByNumber(comboBox1.SelectedValue.ToString());
            DataGridView1.DataSource = dt1;
            DataGridView1.Refresh();
        }

        private void Request_Button_Click(object sender, EventArgs e)
        {
            object dt1 = controllerObj.GetStudentIDFromName(YourName_Label.Text.ToString());
            int dt = controllerObj.AddProjectTeamToAStudentProfile(dt1.ToString(), comboBox1.SelectedValue.ToString());
            if (dt != 0)
            {
                MessageBox.Show("Team is added to your profile successfully, to check it view your Project Teams! ");
            }
            else
            {
                MessageBox.Show("You're already in this team,please check it out!");
            }
        }
    }
}

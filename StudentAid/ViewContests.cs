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
    public partial class ViewContests : Form
    {
        Controller controllerObj;
        public ViewContests()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.GetAllContestsNamesAndNumbers(); 
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ContestNumber";

        }

        private void SignOut_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Au revoir, see you soon!");
            MainInterface MI = new MainInterface();
            MI.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt1 = controllerObj.GetInfoOfAContestByNumber(comboBox1.SelectedValue.ToString());
            DataGridView1.DataSource = dt1;
            DataGridView1.Refresh();
        }

        private void Request_Button_Click(object sender, EventArgs e)
        {
            object dt1 = controllerObj.GetStudentIDFromName(YourName_Label.Text.ToString());
            int dt = controllerObj.AddContestToAStudentProfile(dt1.ToString(), comboBox1.SelectedValue.ToString());
            if (dt != 0)
            {
                MessageBox.Show("Contest is added to your profile successfully, to check it view your contests! ");
            }
            else
            {
                MessageBox.Show("This contest already exists to your profile,please check it out!");
            }
        }
    }
}

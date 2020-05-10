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
    public partial class MainInterface : Form
    {
        public MainInterface()
        {
            InitializeComponent();
        }

        private void mission_TextAlignChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainInterface_Load(object sender, EventArgs e)
        {

        }

        private void Student_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Student_CheckBox.Checked == true)
            {
                Doctor_CheckBox.Checked = false;
                Sponsor_CheckBox.Checked = false;
                Student_Login S = new Student_Login();
                S.Show();
            }
        }

        private void Doctor_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Doctor_CheckBox.Checked == true)
            {
                Student_CheckBox.Checked = false;
                Sponsor_CheckBox.Checked = false;
                Doctor_Login D = new Doctor_Login();
                D.Show();
            }
        }

        private void Sponsor_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Sponsor_CheckBox.Checked ==true)
            {
                Student_CheckBox.Checked = false;
                Doctor_CheckBox.Checked = false;
                Sponsor_Login S = new Sponsor_Login();
                S.Show();
            }
        }

        private void SignUp_Button_Click(object sender, EventArgs e)
        {

            Student_CheckBox.Checked = false;
            Doctor_CheckBox.Checked = false;
            Sponsor_CheckBox.Checked = false;
            SignUp U = new SignUp();
            U.Show();
        }

        private void Mission_Label_Click(object sender, EventArgs e)
        {

        }

        private void Mission_Statement_Click(object sender, EventArgs e)
        {

        }
    }
}

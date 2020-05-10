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
    public partial class RequestProject : Form
    {
        Controller controllerObj;
        public RequestProject()
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

        private void Submit_Button_Click(object sender, EventArgs e)
      {
            if (ProjectName_TextBox.Text == "" || ProjectDescription_TextBox.Text == "" || ProjectReq_TextBox.Text == "")
            {
                MessageBox.Show(" Please fill in all the required info");
            }
            else
            {
                object dt = controllerObj.GetStudentIDFromName(YourName_Label.Text.ToString());
                int c = int.Parse(controllerObj.GetCountOfProjectTeam().ToString());
                int TeamNo = c + 1 + 4000;
                int dt1 = controllerObj.AddProjectTeam(TeamNo,ProjectName_TextBox.Text.ToString(),ProjectDescription_TextBox.Text.ToString(),dt.ToString());
                int dt2 = controllerObj.AddProjectTeamrequirements(TeamNo, ProjectReq_TextBox.Text.ToString());

                if (dt1 !=0 && dt2 !=0)
                {
                    MessageBox.Show("Your New Project Team is added , wait for members to join you soon!");

                }
                else
                {
                    MessageBox.Show("Something went wrong while creating your team, please try again");
                }

                
            }
        }
    }
}

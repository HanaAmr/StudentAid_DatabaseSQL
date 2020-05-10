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
    public partial class LookingForASponsor : Form
    {
        Controller controllerObj;
        public LookingForASponsor()
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

        private void Request_Button_Click(object sender, EventArgs e)
        {
            if (IdeaDescription_TextBox.Text == "")
            {
                MessageBox.Show("Please write down your idea description");
            }
            else
            {
                object dt = controllerObj.GetStudentIDFromName(YourName_Label.Text.ToString());
                int c = int.Parse(controllerObj.GetCountOfBusinessIdea().ToString());
                int IdeaNo = c + 1 + 5000;
                int dt1 = controllerObj.AddBusinessIdeaa(IdeaNo, IdeaDescription_TextBox.Text.ToString(), int.Parse(dt.ToString()));
                if (dt1 != 0)
                {
                    MessageBox.Show("Business Idea is added to your profile as pending! A sponsor will respond soon ");
                }
                else
                {
                    MessageBox.Show("Unable to add your business idea, please try again");
                }
            }
        }
    }
}

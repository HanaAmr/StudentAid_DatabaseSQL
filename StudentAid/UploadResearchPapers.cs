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
    public partial class UploadResearchPapers : Form
    {
        Controller controllerObj;
        public UploadResearchPapers()
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

        private void UploadT_Button_Click(object sender, EventArgs e)
        {
            if (RPName_TextBox.Text == "" || RPPublisher_TextBox.Text == "" || RPPublisher_TextBox.Text == "")
            {
                MessageBox.Show("Please write down the required info");
            }
            else
            {
                int c = int.Parse(controllerObj.GetCountOfRPapers().ToString());
                int RPNo = c + 1 + 56400;
                int dt2 = controllerObj.AddRPapers(RPNo, RPName_TextBox.Text.ToString(), RPLink_TextBox.Text.ToString(), RPPublisher_TextBox.Text.ToString());

                if (dt2 != 0)
                {
                    MessageBox.Show("A New Research Paper is added succesfully");
                }
                else
                {
                    MessageBox.Show(" Something went wrong while adding this Research paper, please try again");
                }
            }
        }
    }
}

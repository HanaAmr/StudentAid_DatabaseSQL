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
    public partial class AddInternship : Form
    {
        Controller controllerObj;
        public AddInternship()
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
            if (InternshipName_TextBox.Text=="" || InternLink_TextBox.Text== "")
            {
                MessageBox.Show("Please write down the required info");
            }
            else
            {
                object dt = controllerObj.GetSponsorIDFromName(YourName_Label.Text.ToString());
                int c = int.Parse(controllerObj.GetCountOfInternships().ToString());
                int InternNo = c + 1 + 7000;
                int dt2 = controllerObj.AddInterships(InternNo,InternshipName_TextBox.Text.ToString(),InternLink_TextBox.Text.ToString(),dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(),dt.ToString());
                if (dt2 != 0)
                {
                    MessageBox.Show("A New Internship is added succesfully");
                }
                else
                {
                    MessageBox.Show(" Something went wrong while adding this internship, please try again");
                }
            }
        }
    }
}

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
    public partial class AddContests : Form
    {
        Controller controllerObj;
        public AddContests()
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
            if (ContestName_TextBox.Text == "" || ContestTheme_textBox1.Text == "" || CourseLink_TextBox.Text=="" || textBox1.Text=="" || textBox2.Text=="")
            {
                MessageBox.Show("Please write down the required info");
            }
            else
            {
                object dt = controllerObj.GetSponsorIDFromName(YourName_Label.Text.ToString());
                int c = int.Parse(controllerObj.GetCountOfContests().ToString());
                int ContestNo = c + 1 + 2000;
                int dt2 = controllerObj.AddContests(ContestNo, ContestName_TextBox.Text.ToString(), CourseLink_TextBox.Text.ToString(), textBox2.Text.ToString(),dateTimePicker1.Value.ToShortTimeString(),textBox1.Text.ToString(),ContestTheme_textBox1.Text.ToString()  ,dt.ToString());
                if (dt2 != 0)
                {
                    MessageBox.Show("A New contest is added succesfully");
                }
                else
                {
                    MessageBox.Show(" Something went wrong while adding this contest, please try again");
                }
            }
        }
    }
}

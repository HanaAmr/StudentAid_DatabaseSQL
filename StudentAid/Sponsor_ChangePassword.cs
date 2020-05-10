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
    public partial class Sponsor_ChangePassword : Form
    {
        Controller controllerObj;
        public Sponsor_ChangePassword()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Please fill in all the required information");
            }
            else if (textBox2.Text.ToString() != textBox3.Text.ToString())
            {
                MessageBox.Show("Password Mismatch , please write down them again");
                textBox2.Text = null;
                textBox3.Text = null;
            }
            else
            {
                int r = controllerObj.SponsorChangePassword(textBox1.Text.ToString(), textBox2.Text.ToString());
                if (r != 0)
                {
                    object c = controllerObj.GetSponsorNameByUsername(textBox1.Text.ToString());
                    MessageBox.Show("Password changed succesfully, Enjoy!");
                    Sponsor_Interface_Beg S = new Sponsor_Interface_Beg();
                    S.YourName_Label.Text = c.ToString();
                    S.Show();
                }
                else
                {
                    MessageBox.Show("Something went wrong while changing your password, please re-enter your info");
                }
            }

        }
    }
}

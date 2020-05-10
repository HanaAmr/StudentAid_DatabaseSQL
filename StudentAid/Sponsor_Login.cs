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
    public partial class Sponsor_Login : Form
    {
        Controller controllerObj;
        public Sponsor_Login()
        {
            InitializeComponent();
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show(" Please write your username and password");
            }
            else
            {
                DataTable dt = controllerObj.CheckSponsorLogIn(textBox1.Text.ToString(), textBox2.Text.ToString());
                if (dt != null)
                {
                    Sponsor_Interface_Beg S = new Sponsor_Interface_Beg();
                    object dt2 = controllerObj.GetSponsorNameByUsername(textBox1.Text.ToString());
                    S.YourName_Label.Text = dt2.ToString();
                    S.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Password or username, please try again");
                }
            }

            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sponsor_ChangePassword S = new Sponsor_ChangePassword();
            S.Show();
        }
    }
}

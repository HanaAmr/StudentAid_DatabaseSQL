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
    public partial class Doctor_Login : Form
    {
        Controller controllerObj;
        public Doctor_Login()
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
                object r = controllerObj.CheckDoctorLogIn(textBox1.Text.ToString(),textBox2.Text.ToString());
                if (r!= null)
                {
                    Doctor_Interface_Beg D = new Doctor_Interface_Beg();
                    object dt2 = controllerObj.GetDoctorNameByUsername(textBox1.Text.ToString());
                    D.YourName_Label.Text = dt2.ToString();
                    D.Show();
                   
                }
                else
                {
                    MessageBox.Show("Incorrect Password or username, please try again");

                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Doctor_ChangePassword D = new Doctor_ChangePassword();
            D.Show();
        }
    }
}

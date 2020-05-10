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
    public partial class Student_Login : Form
    {
        Controller controllerObj;
        public Student_Login()
        {
            InitializeComponent();
        }

        private void Username_Label_Click(object sender, EventArgs e)
        {

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
                DataTable dt = controllerObj.CheckStudentLogIn(textBox1.Text.ToString(), textBox2.Text.ToString());
                if (dt != null)
                {

                    Student_Interface_Beg St = new Student_Interface_Beg();
                    object dt2 = controllerObj.GetStudentNameUsingUsername(textBox1.Text.ToString());
                    St.YourName_Label.Text = dt2.ToString();

                    St.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Password or username, please try again");
                }
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Student_ChangePassword P = new Student_ChangePassword();
            P.Show();
        }
    }
}

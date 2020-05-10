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
    public partial class SignUp : Form
    {
        Controller controllerObj;
        public SignUp()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void Register_Button_Click(object sender, EventArgs e)
        {
            if  (Login_Name_TextBox.Text=="" || Login_Username_Button.Text==""|| Login_Email_Textbox.Text=="" ||Login_Password_Button.Text=="")
            {
                MessageBox.Show("Please fill in all the required info");

            }
            else if (SignUpAs_ComboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all the required info");
            }
            
            else if (SignUpAs_ComboBox1.SelectedItem.ToString() == "Student")
            {
                int c = int.Parse(controllerObj.GetCountOfStudent().ToString());
                int StudNo = c + 1 + 1170000;
                int r = controllerObj.AddStudent(StudNo,Login_Name_TextBox.Text.ToString(),Login_Username_Button.Text.ToString(),Login_Password_Button.Text.ToString(),Login_Email_Textbox.Text.ToString());
                if (r != 0)
                {
                    Student_Interface_Beg S = new Student_Interface_Beg();
                    MessageBox.Show("Your account is added succesfully, enjoy!");
                    S.Show();
                }
                else
                {
                    MessageBox.Show("Something went wrong while adding your account , please try again");
                }
            }
            else if (SignUpAs_ComboBox1.SelectedItem.ToString() == "Doctor")
            {
                
                int c = int.Parse(controllerObj.GetCountOfDoctors().ToString());
                int StudNo = c + 1 + 1170000;
                int r = controllerObj.AddDoctors(StudNo, Login_Name_TextBox.Text.ToString(), Login_Username_Button.Text.ToString(), Login_Password_Button.Text.ToString(), Login_Email_Textbox.Text.ToString());
                if (r != 0)
                {
                   
                    MessageBox.Show("Your account is added succesfully, enjoy!");
                    Doctor_Interface_Beg D = new Doctor_Interface_Beg();
                    D.Show();
                }
                else
                {
                    MessageBox.Show("Something went wrong while adding your account , please try again");
                }

            }
            else if (SignUpAs_ComboBox1.SelectedItem.ToString() == "Sponsor")
            {
                

                int c = int.Parse(controllerObj.GetCountOfSponsors().ToString());
                int StudNo = c + 1 + 97000;
                int r = controllerObj.AddSponsors(StudNo, Login_Name_TextBox.Text.ToString(), Login_Username_Button.Text.ToString(), Login_Password_Button.Text.ToString(), Login_Email_Textbox.Text.ToString());
                if (r != 0)
                {
                    
                    MessageBox.Show("Your account is added succesfully, enjoy!");
                   Sponsor_Interface_Beg S = new Sponsor_Interface_Beg();
                    S.Show();
                }
           

                else
                {
                    MessageBox.Show("Something went wrong while adding your account , please try again");
                }
            }
            

        }

        private void SignUpAs_ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                
        }
    }
}

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
    public partial class GiveYourFeedback : Form
    {
        Controller controllerObj;
        public GiveYourFeedback()
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
            
                AvailableCourses A = new AvailableCourses();
                int c = int.Parse(controllerObj.GetCountOfFeedback().ToString());
                int FeedbackNo = c + 1 + 3000;
                
                int dt1 = controllerObj.AddFeedback(FeedbackNo, no.Text.ToString(),int.Parse(Rate_numericUpDown.Value.ToString()),GiveFeedback_TextBox.Text.ToString());
                if (dt1 != 0)
                {
                    MessageBox.Show("Your feedback is added to this course! thank you for your response ");
                }
                else
                {
                    MessageBox.Show("Unable to add your feedback, please try again");
                }
            
        }
    }
}

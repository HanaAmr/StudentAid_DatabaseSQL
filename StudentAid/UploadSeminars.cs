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
    public partial class UploadSeminars : Form
    {
        Controller controllerObj;

        public UploadSeminars()
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
            if (SeminarName_TextBox.Text == "" || Presenter_TextBox.Text == "" || SeminarLink_TextBox.Text == "")
            {
                MessageBox.Show("Please write down the required info");
            }
            else
            {
                int c = int.Parse(controllerObj.GetCountOfSeminars().ToString());
                int SeminarNo = c + 1 + 4180000;
                int dt2 = controllerObj.AddSeminars(SeminarNo, SeminarName_TextBox.Text.ToString(), SeminarLink_TextBox.Text.ToString(), Presenter_TextBox.Text.ToString());

                if (dt2 != 0)
                {
                    MessageBox.Show("A New Seminar is added succesfully");
                }
                else
                {
                    MessageBox.Show(" Something went wrong while adding this seminar, please try again");
                }
            }
        }
    }
}

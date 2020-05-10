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
    public partial class UploadTextbooks : Form
    {
        Controller controllerObj;

        public UploadTextbooks()
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

        private void UploadTextbooks_Load(object sender, EventArgs e)
        {

        }

        private void UploadT_Button_Click(object sender, EventArgs e)
        {
            if (TextbookName_TextBox.Text == "" || TextBookPublisher_TextBox.Text == "" || TextbookLink_TextBox.Text == "")
            {
                MessageBox.Show("Please write down the required info");
            }
            else
            {
                int c = int.Parse(controllerObj.GetCountOfTextbook().ToString());
                int textbookNo = c + 1 + 6000;
                int dt2 = controllerObj.AddTextbook(textbookNo, TextbookName_TextBox.Text.ToString(), TextbookLink_TextBox.Text.ToString(), TextBookPublisher_TextBox.Text.ToString());
                if (dt2 != 0)
                {
                    MessageBox.Show("A New textbook is added succesfully");
                }
                else
                {
                    MessageBox.Show(" Something went wrong while adding this textbook, please try again");
                }
            }
        }
    }
}

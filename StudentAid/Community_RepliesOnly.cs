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
    public partial class Community_RepliesOnly : Form
    {
        Controller controllerObj;
        public Community_RepliesOnly()
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

        private void AddPost_button1_Click(object sender, EventArgs e)
        {
            AddReply R = new AddReply();
            R.YourName_Label.Text = YourName_Label.Text;
            R.no_textBox1.Text = textBox1.Text;
            
            R.Show();
        }
    }
}

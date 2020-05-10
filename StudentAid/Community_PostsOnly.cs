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
    public partial class Community_PostsOnly : Form
    {
        Controller controllerObj;
        public Community_PostsOnly()
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //textBox1.Text = Posts_dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Community_RepliesOnly RO = new Community_RepliesOnly();
            RO.YourName_Label.Text = YourName_Label.Text;
            DataTable R = controllerObj.GetAllRepliesOnASpecificPost(Posts_dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            RO.textBox1.Text = Posts_dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            if (R != null)
            {
                RO.Replies_dataGridView1.DataSource = R;
                RO.Replies_dataGridView1.Refresh();
                
            }
            else
            {
                RO.Messagelabel.Visible = true;
            }
            RO.Show();
        }

        private void AddPost_button1_Click(object sender, EventArgs e)
        {
            AddPost P = new AddPost();
            
            P.YourName_Label.Text = YourName_Label.Text;
           
            P.Show();
        }
    }
}

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
    public partial class ViewBusinessIdeas : Form
    {
        Controller controllerObj;
        public ViewBusinessIdeas()
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

        private void Accept_Button_Click(object sender, EventArgs e)
        {
            
        }

        private void BusniessIdeas_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string i = BusniessIdeas_dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            object s = controllerObj.GetSponsorIDFromName(YourName_Label.Text.ToString());
            int r = controllerObj.AcceptStudentBusinessIdeas(s.ToString(),i);
            MessageBox.Show("thank you for your support, this will show up on the student's profile");
            DataTable dt = controllerObj.GetAllNonAcceptedBusinessideas();
            if (dt != null)
            {
                BusniessIdeas_dataGridView.DataSource = dt;
                BusniessIdeas_dataGridView.Refresh();
                
            }
            else
            {
                BusniessIdeas_dataGridView.DataSource = null;
                label4.Visible = true;
            }
        }
    }
}

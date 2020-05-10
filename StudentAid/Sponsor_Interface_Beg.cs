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
    public partial class Sponsor_Interface_Beg : Form
    {
        Controller controllerObj;
        public Sponsor_Interface_Beg()
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

        private void ViewInternships_Button_Click(object sender, EventArgs e)
        {
            ViewBusinessIdeas VB = new ViewBusinessIdeas();
            VB.YourName_Label.Text = YourName_Label.Text;
            DataTable dt = controllerObj.GetAllNonAcceptedBusinessideas();
            if (dt != null)
            {
                VB.BusniessIdeas_dataGridView.DataSource = dt;
                VB.BusniessIdeas_dataGridView.Refresh();
            }
            else
            {
                VB.label2.Visible = true;   
            }
            VB.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Community_PostsOnly C = new Community_PostsOnly();
            
            C.YourName_Label.Text = YourName_Label.Text;
            DataTable dt = controllerObj.GetAllQuestions();
            if (dt != null)
            {
                C.Posts_dataGridView1.DataSource = dt;
                C.Posts_dataGridView1.Refresh();
            }
            else
            {
                C.Messagelabel.Visible = true;
            }
            C.Show();
        }

        private void Sponsor_Interface_Beg_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddContests C = new AddContests();
            C.YourName_Label.Text = YourName_Label.Text;
            C.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Add Internship")
            {
                AddInternship I = new AddInternship();
                I.YourName_Label.Text = YourName_Label.Text;
                I.Show();

            }
            else if (comboBox1.SelectedItem.ToString() == "View my internships")
            {
                ViewMyInternships VI = new ViewMyInternships();
                VI.YourName_Label.Text = YourName_Label.Text;
                DataTable dt = controllerObj.GetInternshipsOfASpecificSponsorUsingName(YourName_Label.Text.ToString());
                if (dt != null)
                {
                    VI.dataGridView1.DataSource = dt;
                    VI.dataGridView1.Refresh();
                }
                else
                {
                    VI.Messagelabel.Visible = true;
                }
                VI.Show();
            }
        }
    }
}

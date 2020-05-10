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
    public partial class StudentsInThisIntern : Form
    {
        Controller controllerObj;
        public StudentsInThisIntern()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString()== "Accepted Students")
            {
                DataTable dt = controllerObj.GetAllAcceptedStudentsInASpecificInternship(textBox1.Text);
                if (dt != null)
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = dt;
                    Messagelabel.Visible = false;
                    label2.Visible = false;
                    comboBox2.Visible = false;
                    button1.Visible = false;
                    AcceptStud_button1.Visible = false;
                    dataGridView1.Refresh();
                }
                else
                {
                    dataGridView1.DataSource = null;
                    Messagelabel.Visible = true;
                }

            }
            else if (comboBox1.SelectedItem.ToString() == "Pending Students")
            {
                DataTable dt = controllerObj.GetAllNonAcceptedStudentsInAnIntern(textBox1.Text);
                if (dt != null)
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                    AcceptStud_button1.Visible = true;
                    Messagelabel.Visible = false;
                }
                else
                {
                    dataGridView1.DataSource = null;
                    Messagelabel.Visible = true;
                }

            }
                

        }

        private void AcceptStud_button1_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            comboBox2.Visible = true;
            AcceptStud_button1.Visible = false;
            DataTable dt = controllerObj.GetAllNonAcceptedStudentsInAnIntern(textBox1.Text);
            dataGridView1.DataSource = null;
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "Student_Name";
            comboBox2.ValueMember = "Student_ID";
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object c = controllerObj.GetSponsorIDFromName(YourName_Label.Text.ToString());
            int r = controllerObj.AcceptStudentIntern(c.ToString(),comboBox2.SelectedValue.ToString(),textBox1.Text.ToString());
            DataTable dt = controllerObj.GetAllNonAcceptedStudentsInAnIntern(textBox1.Text);
            if (dt != null)
            {
                dataGridView1.DataSource = null;
                comboBox2.DataSource = dt;
                comboBox2.DisplayMember = "Student_Name";
                comboBox2.ValueMember = "Student_ID";
            }
            else
            {
                dataGridView1.DataSource = null;
                label2.Visible = false;
                comboBox2.Visible = false;
                button1.Visible = false;
                label4.Visible = true;
            }
        }
    }
}

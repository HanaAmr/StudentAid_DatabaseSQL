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
    public partial class StudentsInThisCourse : Form
    {
        Controller controllerObj;
        public StudentsInThisCourse()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                
                    
        }

        private void AddGrade_button1_Click(object sender, EventArgs e)
        {
            
            DataTable dt = controllerObj.GetUngradedStudentsInASpecificCourse(WhatCourse.Text.ToString());
            if (dt != null)
            {
                Ungraded_comboBox1.DataSource = dt;
                Ungraded_comboBox1.DisplayMember = "Student_Name";
                Ungraded_comboBox1.ValueMember = "Student_ID";
                Ungraded_comboBox1.Visible = true;
                Done_button1.Visible = true;
                Choose_label2.Visible = true;
                Add_button1.Visible = true;
                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
            }
            else
            {
                dataGridView1.DataSource = null;
                label2.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DataTable dt1 = controllerObj.GetAllStudentsInaSpecificCourseWithGrades(WhatCourse.Text.ToString());
            if (dt1 != null)
            {
                dataGridView1.DataSource = dt1;
                Ungraded_comboBox1.Visible = false;
                Choose_label2.Visible = false;
                grade_textBox1.Visible = false;
                Add_button1.Visible = false;
                dataGridView1.Refresh();
                label4.Visible = false;
                Done_button1.Visible = false;
            }
            else
            {
                label2.Visible = true;
            }
        }

        private void Ungraded_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            grade_textBox1.Visible = true;
            
            
        }

        private void add_button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Add_button1_Click_1(object sender, EventArgs e)
        {
            if (grade_textBox1.Text == "")
            {
                MessageBox.Show("Please enter grade first");
            }
            else
            {
                object c = controllerObj.GetDoctorIDFromName(YourName_Label.Text.ToString());
                object d = controllerObj.GetCourseNumberFromCourseName(WhatCourse.Text.ToString());
                int r = controllerObj.AddgradeToAStudentInACourse(c.ToString(), Ungraded_comboBox1.SelectedValue.ToString(), d.ToString(), grade_textBox1.Text.ToString());
                grade_textBox1.Text = null;
                DataTable dt = controllerObj.GetUngradedStudentsInASpecificCourse(WhatCourse.Text.ToString());
                if (dt != null)
                {
                    Ungraded_comboBox1.DataSource = dt;
                    Ungraded_comboBox1.DisplayMember = "Student_Name";
                    Ungraded_comboBox1.ValueMember = "Student_ID";
                    Ungraded_comboBox1.Visible = true;
                    Done_button1.Visible = true;
                    Choose_label2.Visible = true;
                    Add_button1.Visible = true;
                    dataGridView1.DataSource = null;
                    dataGridView1.Refresh();
                }
                else
                {
                    dataGridView1.DataSource = null;
                    label4.Visible = true;
                    Ungraded_comboBox1.Visible = false;
                    Choose_label2.Visible = false;
                    grade_textBox1.Visible = false;
                    Add_button1.Visible = false;
                }

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CourseStatistics C = new CourseStatistics();
            C.Show();
        }
    }
}

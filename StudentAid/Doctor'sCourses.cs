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
    public partial class Doctor_sCourses : Form
    {
        Controller controllerObj;
        public Doctor_sCourses()
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
            //textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            object dt = controllerObj.GetCourseNameFromNumber(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            StudentsInThisCourse St = new StudentsInThisCourse();
            St.WhatCourse.Text = dt.ToString();
            St.YourName_Label.Text = YourName_Label.Text;

            DataTable dt1 = controllerObj.GetAllStudentsInaSpecificCourseWithGrades(dt.ToString());
            if (dt1 != null)
            {
                St.dataGridView1.DataSource = dt1;
                St.dataGridView1.Refresh();
                St.AddGrade_button1.Visible = true;
               

            }
            else
            {
                St.Messagelabel.Visible = true;
            }

            St.Show();
           
        }
    }
}

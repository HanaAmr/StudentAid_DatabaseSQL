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
    public partial class ViewMyInternships : Form
    {
        Controller controllerObj;
        public ViewMyInternships()
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
           string I= dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox1.Text = I;
            StudentsInThisIntern S = new StudentsInThisIntern();
            S.YourName_Label.Text = YourName_Label.Text;
            S.textBox1.Text = textBox1.Text;
            S.Show();

        }
    }
}

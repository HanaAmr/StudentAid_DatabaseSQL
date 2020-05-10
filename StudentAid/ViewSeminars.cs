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
    public partial class ViewSeminars : Form
    {
        Controller controllerObj;
        public ViewSeminars()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.GetAllSeminarsNamesAndNumbers();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "SeminarName";
            comboBox1.ValueMember = "SeminarNumber";

        }

        private void SignOut_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Au revoir, see you soon!");
            MainInterface MI = new MainInterface();
            MI.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt1 = controllerObj.GetAllInfoOfSeminarByNumber(comboBox1.SelectedValue.ToString());
            DataGridView1.DataSource = dt1;
            DataGridView1.Refresh();
        }
    }
}

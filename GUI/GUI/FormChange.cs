using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using GUI.BUS;

namespace GUI
{
    public partial class FormChange : Form
    {
        List<Student> students;
        public FormChange()
        {
            students = Student.GetStudents();
            InitializeComponent();
        }

        private void pBoxName_Click(object sender, EventArgs e)
        {
            
            txtBoxName.ReadOnly = !txtBoxName.ReadOnly;
        }

        private void pBoxClass_Click(object sender, EventArgs e)
        {
            txtBoxClass.ReadOnly = !txtBoxClass.ReadOnly;
        }

        private void pBoxAvg_Click(object sender, EventArgs e)
        {
            txtBoxAvg.ReadOnly = !txtBoxAvg.ReadOnly;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SearchSV();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            UpdateSV();
        }
        private void UpdateSV()
        {
            FormChangeBUS.Instance.UpdateSinhVien(txtBoxID, txtBoxName, txtBoxClass, txtBoxAvg);
        }
        private void SearchSV()
        {
            FormChangeBUS.Instance.FindSinhVien(txtBoxSearch, txtBoxID, txtBoxName, txtBoxClass, txtBoxAvg);
        }
    }
}

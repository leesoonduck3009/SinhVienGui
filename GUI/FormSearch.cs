using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormSearch : Form
    {
        List<Student> students;
        public FormSearch()
        {
            //if (students == null)
                students = Student.GetStudents();
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            
            

            foreach (Student student in students)
            {
                if (student.Id.ToString() == txtBoxSearch.Text)
                {
                    this.txtBoxID.Text = student.Id.ToString();
                    this.txtBoxName.Text = student.Name;
                    this.txtBoxClass.Text = student.Class;
                    this.txtBoxAvg.Text = student.Avg.ToString();
                    this.txtBoxSearch.Text = null;
                    return;
                }
            }
            if (txtBoxSearch.Text != null && txtBoxSearch.Text != "")
                MessageBox.Show("Không có sinh viên trong danh sách", "Thông báo");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}

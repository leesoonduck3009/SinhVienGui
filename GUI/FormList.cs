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
    public partial class FormList : Form
    {
        public FormList()
        {
            // this.Name = "Form1";
            InitializeComponent();
            List<Student> students = Student.GetStudents();
            foreach (Student student in students)
            {
                dataGridList.Rows.Add(student.Id.ToString(),student.Name,student.Class,student.Avg.ToString());


            }
            // dataGridList.AutoSize = true;
        }

        private void dataGridList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void FormList_Load(object sender, EventArgs e)
        {

        }
    }
}

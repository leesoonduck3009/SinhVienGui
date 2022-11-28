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
    public partial class FormAdd : Form
    {
        List<Student> students;
        public FormAdd()
        {
            //if (students!= null)
                students = Student.GetStudents();
            InitializeComponent();
        }

        private void bttAdd_Click(object sender, EventArgs e)
        {
            FormAddBUS.Instance.AddStudent(this.txtBoxID, this.txtBoxName, this.txtBoxClass, this.txtBoxAvg);
 
        }
    }
}

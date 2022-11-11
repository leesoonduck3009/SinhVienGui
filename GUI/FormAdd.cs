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
            Student student = new Student();
            if (txtBoxID.Text == "" || txtBoxName.Text == "" || txtBoxAvg.Text == "" || txtBoxClass.Text == "")
                return;
            
                student.Id=int.Parse(txtBoxID.Text);    
                student.Name=txtBoxName.Text;
                student.Class=txtBoxClass.Text;
                student.Avg = float.Parse(txtBoxAvg.Text);
            
            foreach (Student studenttemp in students)
            {
                if (studenttemp.Id == student.Id)
                {
                    MessageBox.Show("Đã có mã số sinh viên này trong danh sách", "Thông báo");
                    return;
                }
            }
            txtBoxID.Text = "";
            txtBoxName.Text = "";
            txtBoxAvg.Text = "";
            txtBoxClass.Text = "";
            students.Add(student);
                File.AppendAllText("data.txt", student.ToString());
            MessageBox.Show("Đã thêm sinh viên thành công", "Thông báo");
        }
    }
}

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

        private void buttonChange_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            if (txtBoxID.Text == "" || txtBoxID.Text==null)
                return;

            student.Id = int.Parse(txtBoxID.Text);
            student.Name = txtBoxName.Text;
            student.Class = txtBoxClass.Text;
            student.Avg = float.Parse(txtBoxAvg.Text);
            bool flag = false;
            for(int i =0;i < students.Count;i++)
            {
                if (students[i] != student && student.Id == students[i].Id)
                {
                    students[i] = student;
                    flag = true;
                }    
            }
            if (flag)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn thông tin cần thay đổi không? ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.OK)
                {
                    File.WriteAllText("data.txt", students[0].ToString());
                    for (int i = 1; i < students.Count; i++)
                    {
                        File.AppendAllText("data.txt", students[i].ToString());

                    }
                }
            }
        }

    }
}

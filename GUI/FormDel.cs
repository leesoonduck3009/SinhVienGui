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
    public partial class FormDel : Form
    {
        List<Student> students = new List<Student>();
        public FormDel()
        {
           
                students = Student.GetStudents();
            InitializeComponent();
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
            if (txtBoxID.Text != null && txtBoxID.Text != "")
            {

                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn xóa sinh viên này ?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.OK)
                {
                    Student temp = new Student();
                    string id = txtBoxID.Text;
                    for(int i=0;i<students.Count;i++)
                    {
                        if (students[i].Id.ToString() == txtBoxID.Text)
                            temp=students[i];
                    }
                    students.Remove(temp);
                }
            }
           
            File.WriteAllText("data.txt", students[0].ToString());
            for (int i=1;i<students.Count;i++)
            {
                File.AppendAllText("data.txt", students[i].ToString());

            }
            txtBoxID.Text = "";
            txtBoxName.Text = "";
            txtBoxAvg.Text = "";
            txtBoxClass.Text = "";
        }

        private void txtBoxAvg_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxClass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

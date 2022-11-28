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

            SearchSV();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteSV();
        }
        
        private void DeleteSV()
        {
            FormDelBUS.Instance.DeleteSinhVien(txtBoxSearch,txtBoxID, txtBoxName, txtBoxClass, txtBoxAvg);
        }
        private void SearchSV()
        {
            FormDelBUS.Instance.FindSinhVien(txtBoxSearch, txtBoxID, txtBoxName, txtBoxClass, txtBoxAvg);
        }
    }
}

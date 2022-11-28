using GUI.DAO;
using GUI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.BUS
{
    internal class FormAddBUS
    {
        private static FormAddBUS instance;
        public static FormAddBUS Instance
        {
            get { if (instance == null) instance = new FormAddBUS(); return instance; }
            private set { instance = value; }
        }
        public void AddStudent(TextBox ID, TextBox Name, TextBox Class, TextBox DTB)
        {
            SinhVienDAO.Instance.AddSinhVien(ID.Text, Name.Text, Class.Text, DTB.Text);
            ID.Text = "";
            Name.Text = "";
            Class.Text = "";
            DTB.Text = "";

        }
    }
}

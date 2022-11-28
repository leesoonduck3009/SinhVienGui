using GUI.DAO;
using GUI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.BUS
{
    internal class FormListBUS
    {
        DataGridView dataGridList;
        private static FormListBUS instance;
        public static FormListBUS Instance
        {
            get { if (instance == null) instance = new FormListBUS(); return instance; }
            private set { instance = value; }
        }
        public void GetList(DataGridView dataGridList)
        {
            dataGridList.Rows.Clear();
            this.dataGridList = dataGridList;
            List<SinhVien> sinhviens = SinhVienDAO.Instance.GetAllSinhVien();
            foreach (SinhVien sinhvien in sinhviens)
            {
                dataGridList.Rows.Add(sinhvien.MaSV.ToString(),sinhvien.TenSV,sinhvien.MaLop,sinhvien.DTB.ToString());
            }
        }
        public void FindName( TextBox Name)
        {

            Name.TextChanged += Name_TextChanged; 
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            
            if (textBox.Text == "")
            {
                GetList(dataGridList);
            }
            else
            {
                List<SinhVien> sinhviens = SinhVienDAO.Instance.FindNameSinhVien(textBox.Text);
                if (sinhviens != null)
                {
                    dataGridList.Rows.Clear();
                    foreach (SinhVien sinhvien in sinhviens)
                    {
                        dataGridList.Rows.Add(sinhvien.MaSV.ToString(), sinhvien.TenSV, sinhvien.MaLop, sinhvien.DTB.ToString());
                    }
                }
            }
        }


    }
}

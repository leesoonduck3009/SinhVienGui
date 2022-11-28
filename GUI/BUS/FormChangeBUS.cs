using GUI.DAO;
using GUI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI.BUS
{
    internal class FormChangeBUS
    {

        private static FormChangeBUS instance;
        public static FormChangeBUS Instance
        {
            get { if (instance == null) instance = new FormChangeBUS(); return instance; }
            private set { instance = value; }
        }
        public void FindSinhVien(TextBox txtIDSearch, TextBox txtID, TextBox txtName, TextBox txtClass, TextBox txtAVG)
        {
            SinhVien sinhVien = SinhVienDAO.Instance.FindIDSinhVien(int.Parse(txtIDSearch.Text));
            if (sinhVien == null)
            {
                MessageBox.Show("Không có sinh viên này", "Thông báo");
                return;
            }
            txtID.Text = txtIDSearch.Text;
            txtName.Text = sinhVien.TenSV;
            txtClass.Text = sinhVien.MaLop;
            txtAVG.Text = sinhVien.DTB.ToString();
            txtIDSearch.Text = "";
        }
        public void UpdateSinhVien(TextBox txtID, TextBox txtName, TextBox txtClass, TextBox txtAVG)
        {
            if (txtID.Text != "")
            {
                try
                {
                    SinhVien sinhVien = new SinhVien();
                    sinhVien.MaSV = int.Parse(txtID.Text);
                    sinhVien.TenSV = txtName.Text;
                    sinhVien.MaLop = txtClass.Text;
                    sinhVien.DTB = double.Parse(txtAVG.Text);
                    SinhVienDAO.Instance.UpdateSinhVien(sinhVien);
                    MessageBox.Show("Cập nhật thông tin thành công", "Thông báo");
                    txtID.Text = "";
                    txtName.Text = "";
                    txtClass.Text = "";
                    txtAVG.Text = "";
                }
                catch(Exception e)
                {
                    MessageBox.Show("Cập nhật thông tin thất bại", "Thông báo");
                }
            }
        }
    }
}

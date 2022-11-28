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
    internal class FormDelBUS
    {
        SinhVien sinhVien;
        private static FormDelBUS instance;
        public static FormDelBUS Instance
        {
            get { if (instance == null) instance = new FormDelBUS(); return instance; }
            private set { instance = value; }
        }
        public void FindSinhVien(TextBox txtIDSearch, TextBox txtID, TextBox txtName, TextBox txtClass, TextBox txtAVG)
        {
            sinhVien= SinhVienDAO.Instance.FindIDSinhVien(int.Parse(txtIDSearch.Text));
            if (sinhVien == null)
            {
                MessageBox.Show("Không có sinh viên này", "Thông báo");
                return;
            }
            txtID.Text = txtIDSearch.Text;
            txtName.Text = sinhVien.TenSV;
            txtClass.Text = sinhVien.MaLop;
            txtAVG.Text = sinhVien.DTB.ToString();

        }
        public void DeleteSinhVien(TextBox txtIDSearch, TextBox txtID, TextBox txtName, TextBox txtClass, TextBox txtAVG)
        {
            if (txtID.Text != "")
            {
                /* try*/
                //{

                    SinhVienDAO.Instance.DeleteSinhVien(sinhVien);
                MessageBox.Show("Xóa sinh viên thành công", "Thông báo");
                    txtID.Text = "";
                    txtName.Text = "";
                    txtClass.Text = "";
                    txtAVG.Text = "";
                    txtIDSearch.Text = "";
                // }
                /*                catch (Exception e)
                                {
                                    MessageBox.Show("Xóa sinh viên thất bại", "Thông báo");
                                }*/
            }
        }
    }
}

using GUI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.DAO;
namespace GUI.BUS
{
    internal class FormSearchBUS
    {
        private static FormSearchBUS instance;
        public static FormSearchBUS Instance
        {
            get { if (instance == null) instance = new FormSearchBUS(); return instance; }
            private set { instance = value; }
        }
        public void TimSinhVien(TextBox txtIDSearch,TextBox txtID,TextBox txtName, TextBox txtClass, TextBox txtAVG)
        {
           

            try
            {
                SinhVien sinhVien = SinhVienDAO.Instance.FindIDSinhVien(int.Parse(txtIDSearch.Text));
                if(sinhVien == null)
                {
                    MessageBox.Show("Không có sinh viên này trong danh sách", "Thông báo");
                }   
                else
                {
                    txtID.Text = txtIDSearch.Text;
                    txtName.Text = sinhVien.TenSV;
                    txtClass.Text = sinhVien.MaLop;
                    txtAVG.Text = sinhVien.DTB.ToString();
                    txtIDSearch.Text = "";
                }    
                    
            }
            catch(Exception e)
            {
                MessageBox.Show("Không có sinh viên này trong danh sách", "Thông báo");
            }

        }
    }
}

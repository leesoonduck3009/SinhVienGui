using GUI.BUS;
using GUI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GUI.DAO
{
    internal class SinhVienDAO
    {
        private static SinhVienDAO instance;
        public static SinhVienDAO Instance
        {
            get { if (instance == null) instance = new SinhVienDAO(); return instance; }
            private set { instance = value; }
        }
        public List<SinhVien>GetAllSinhVien()
        {
            ModuleQLSV db = new ModuleQLSV();
            return db.SinhViens.ToList();
        }
        public void AddSinhVien(string ID, string Name, string Class, string DTB)
        {
            ModuleQLSV db = new ModuleQLSV();
            SinhVien sinhVien = new SinhVien();
            sinhVien.MaSV = int.Parse(ID);
            sinhVien.TenSV = Name;
            sinhVien.MaLop = Class;
            sinhVien.DTB = float.Parse(DTB);
            db.SinhViens.Add(sinhVien);
            db.SaveChanges();
        }
        public List<SinhVien> FindNameSinhVien(string name)
        {
            ModuleQLSV db = new ModuleQLSV();
            return db.SinhViens.Where(p => p.TenSV.Contains(name)).ToList();
        }
    }
}

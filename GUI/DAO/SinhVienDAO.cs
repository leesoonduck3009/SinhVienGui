using GUI.BUS;
using GUI.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
        public void LoadSinhVien()
        {
            ModuleQLSV db = new ModuleQLSV();
             db.SinhViens.ToList();
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
        public SinhVien FindIDSinhVien(int ID)
        {
            ModuleQLSV db = new ModuleQLSV();
            return db.SinhViens.Find(ID);
        }
        public void UpdateSinhVien(SinhVien a)
        {
            ModuleQLSV db = new ModuleQLSV();
            db.SinhViens.AddOrUpdate(a);
            db.SaveChanges();
        }
        public void DeleteSinhVien(SinhVien a)
        {
            ModuleQLSV db = new ModuleQLSV();
            db.SinhViens.Remove(a);
            db.SaveChanges();
        }
    }
}

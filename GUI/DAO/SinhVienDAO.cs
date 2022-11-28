using GUI.BUS;
using GUI.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GUI.DAO
{
    internal class SinhVienDAO
    {
        ModuleQLSV db = new ModuleQLSV();
        private static SinhVienDAO instance;
        public static SinhVienDAO Instance
        {
            get { if (instance == null) instance = new SinhVienDAO(); return instance; }
            private set { instance = value; }
        }
        public void LoadSinhVien()
        {

             db.SinhViens.ToList();
        }
        public List<SinhVien>GetAllSinhVien()
        {

            return db.SinhViens.ToList();
        }
        public void AddSinhVien(string ID, string Name, string Class, string DTB)
        {

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

            return db.SinhViens.Find(ID);
        }
        public void UpdateSinhVien(SinhVien a)
        {

            db.SinhViens.AddOrUpdate(a);
            db.SaveChanges();
        }
        public void DeleteSinhVien(SinhVien a)
        {

            db.SinhViens.Remove(a);
            db.SaveChanges();
        }
    }
}

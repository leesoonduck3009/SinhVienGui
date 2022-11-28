namespace GUI.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SinhVien")]
    public partial class SinhVien
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaSV { get; set; }

        [StringLength(100)]
        public string TenSV { get; set; }

        [StringLength(10)]
        public string MaLop { get; set; }

        public double? DTB { get; set; }

        public virtual Lop Lop { get; set; }
    }
}

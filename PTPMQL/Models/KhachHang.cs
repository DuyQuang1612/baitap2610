

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PTPMQL.Models
{
    [Table("KhachHangs")]
    public class KhachHang
    {   [Key]
        public string KhachHangID { get; set; }
        public string KhachHangName { get; set; }
        public string KhachHangDiaChi { get; set; }
        public string KhachHangSodt { get; set; }

    }
}
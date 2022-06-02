using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcCoreDB.Models
{
    [Table("tblOgrenciler")]
    public class Ogrenci
    {
       
        public int Id { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(25)]
        public string Ad{ get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(25)]
        public string Soyad { get; set; }

        [Column(TypeName = "int")]
        public int Numara { get; set; }

    }
}

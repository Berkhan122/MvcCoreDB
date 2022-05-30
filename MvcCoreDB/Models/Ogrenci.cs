using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcCoreDB.Models
{
    [Table("tblOgrenciler")]
    public class Ogrenci
    {
        [Key]
        public int ogrId { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(25)]
        public string ogrName { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(25)]
        public string ogrSurname { get; set; }

    }
}

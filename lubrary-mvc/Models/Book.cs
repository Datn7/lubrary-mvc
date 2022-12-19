using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lubrary_mvc.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Title { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string Author { get; set; }

        [Column(TypeName = "nvarchar(150)")]
        public string Description { get; set; }
    }
}
 
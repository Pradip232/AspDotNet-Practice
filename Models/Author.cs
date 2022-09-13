using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AspDotNet_Practice.Models
{
    [Table("Authors")]
    public class Author
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AuthorId { get; set; }

        [Required]
        public string AuthorName { get; set; }

        #region Navigation properties to a Master Model - Book
        public int BookId { get; set; }


        [ForeignKey(nameof(Author.BookId))]
        public Book Bo { get; set; }
        #endregion
    }
}

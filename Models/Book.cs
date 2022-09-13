using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AspDotNet_Practice.Models
{
    [Table("Books")]
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookId { get; set; }

        [Required]
        public string BookTitle { get; set; }

        [Required]
        [DefaultValue(1)]
        public int NumberOfCopies { get; set; }

        [Required]
        [DefaultValue(true)]
        public bool IsEnabled { get; set; }

        #region     Navigation properties to a category Model
        //Navigation properties to a Master Model - Category
        [Required]
        public int CategoryId { get; set; }


        [ForeignKey(nameof(Book.CategoryId))]
        public Category co { get; set; }

        #endregion

        #region
        public ICollection<Author> Authors { get; set; }
        #endregion

    }
}

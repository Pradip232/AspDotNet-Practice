using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AspDotNet_Practice.Models
{
    [Table("Categories")]
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "Id cannot be empty.")]
        public int CategoryId { get; set; }


        [Required(ErrorMessage ="Category Name cannot be empty.")]
        //[MaxLength(60)]
        [StringLength(100,ErrorMessage ="{0} must be having less than {1} characteres.")]
        public string CategoryName { get; set; }

/*
        CREATE TABLE [Category] (
            [CategoryID] int not null IDENTITY(1,1),
            [CategoryName] varchar(100),
            CONSTRAIN PRIMARY KEY[PK_Categories]([CategoryID] ASC)
        )
        GO
 */



    }
}

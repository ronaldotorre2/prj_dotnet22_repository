using SGC.Shared.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGC.Domain.Entities
{
    /// <summary>
    /// Entidade representativa de produto
    /// </summary>
    [Table("Product")]
    public class Product : Entity
    {
        [Required]
        [Column("Title")]
        public string Title { get; set; }
        
        [Column("Description")]
        public string Description { get; set; }

        [Column("Image")]
        public string Image { get; private set; }

        [Column("CategoryId", TypeName = "int")]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        public Product()
        {
            Category = new Category();
        }
    }
}
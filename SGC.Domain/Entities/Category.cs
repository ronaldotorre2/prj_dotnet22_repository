using SGC.Shared.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGC.Domain.Entities
{
    /// <summary>
    /// Entidade representativa de categoria
    /// </summary>
    [Table("Category")]
    public class Category : Entity
    {
        [Required]
        [Column("Name")]
        public string Name { get; set; }

        [Column("Description")]
        public string Description { get; set; }
    }
}
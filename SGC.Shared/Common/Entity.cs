using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGC.Shared.Common
{
    public class Entity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id", TypeName = "int")]
        public int Id { get; set; }

        [Column("AddDate", TypeName = "DateTime")]
        public DateTime AddDate { get; set; }

        [Column("AddUser")]
        public string AddUser { get; set; }

        [Column("LastUpdateDate", TypeName = "DateTime")]
        public DateTime? LastUpdateDate { get; set; }

        [Column("LastUpdateUser")]
        public string LastUpdateUser { get; set; }
    }
}
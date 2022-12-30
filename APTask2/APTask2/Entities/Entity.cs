using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APTask2.Entities
{
    public abstract class Entity
    {
        [Required]
        [Column(TypeName = "bigint")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RecordId { get; set; }

        [Required]
        [Timestamp]
        public byte[] RowVersion { get; set; }

        [StringLength(5)]
        public string CreatedBy { get; set; }

        [StringLength(5)]
        public string ModifiedBy { get; set; }
    }
}

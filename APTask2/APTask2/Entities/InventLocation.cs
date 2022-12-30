using APTask2.Helpers;
using System;
using System.ComponentModel.DataAnnotations;

namespace APTask2.Entities
{
    public class InventLocation : Entity
    {
        [Key]
        [StringLength(10)]
        public string InventLocationId { get; set; }

        [StringLength(10)]
        public string InventSiteId { get; set; }

        [StringLength(140)]
        public string Name { get; set; }

        [Required]
        public DateTime CreateDateTime { get; set; }

        [Required]
        public DateTime UpdateDateTime { get; set; }

        public static InventLocation Create(int inventLocationId)
        {
            string inventLocationIdAsString;
            if (inventLocationId < 10)
            {
                inventLocationIdAsString = $"0{inventLocationId}";
            }
            else
            {
                inventLocationIdAsString = inventLocationId.ToString();
            }

            var inventLocation = new InventLocation()
            {
                InventLocationId = inventLocationIdAsString,
                InventSiteId = 10.CreateString(),
                Name = 140.CreateString(),
                CreateDateTime = DateTime.UtcNow,
                UpdateDateTime = DateTime.UtcNow,

                RowVersion = new byte[0],
                CreatedBy = 5.CreateString(),
                ModifiedBy = 5.CreateString()
            };
            return inventLocation;
        }
    }
}

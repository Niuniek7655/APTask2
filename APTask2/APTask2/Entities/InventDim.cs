using APTask2.Helpers;
using System.ComponentModel.DataAnnotations;

namespace APTask2.Entities
{
    public class InventDim : Entity
    {
        [Key]
        [StringLength(20)]
        public string InventDimId { get; set; }

        [StringLength(10)]
        public string InventSiteId { get; set; }

        [StringLength(10)]
        public string InventLocationId { get; set; }

        [StringLength(10)]
        public string WMSLocationId { get; set; }

        [StringLength(20)]
        public string InventBatchId { get; set; }

        [StringLength(18)]
        public string WMSPalletId { get; set; }

        [StringLength(10)]
        public string InventColorId { get; set; }

        [StringLength(20)]
        public string InventSerialId { get; set; }

        [StringLength(10)]
        public string InventSizeId { get; set; }

        public static InventDim Create(string inventLocationId)
        {
            InventDim inventDim = new InventDim()
            {
                InventDimId = 20.CreateString(),
                InventSiteId = 10.CreateString(),
                InventLocationId = inventLocationId,
                WMSLocationId = 10.CreateString(),
                InventBatchId = 20.CreateString(),
                WMSPalletId = 18.CreateString(),
                InventColorId = 10.CreateString(),
                InventSerialId = 20.CreateString(),
                InventSizeId = 10.CreateString(),

                RowVersion = new byte[0],
                CreatedBy = 5.CreateString(),
                ModifiedBy = 5.CreateString()
            };

            return inventDim;
        }
    }
}

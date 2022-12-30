using APTask2.Entities;

namespace APTask2.DTO
{
    public class InventDimDTO
    {
        public string InventDimId { get; set; }

        public string InventSiteId { get; set; }

        public string InventLocationId { get; set; }

        public string WMSLocationId { get; set; }

        public string InventBatchId { get; set; }

        public string WMSPalletId { get; set; }

        public string InventColorId { get; set; }

        public string InventSerialId { get; set; }

        public string InventSizeId { get; set; }

        public int RecordId { get; set; }

        public string CreatedBy { get; set; }

        public string ModifiedBy { get; set; }

        public InventDimDTO(InventDim inventDim)
        {
            InventDimId = inventDim.InventDimId;
            InventSiteId = inventDim.InventSiteId;
            InventLocationId = inventDim.InventLocationId;
            WMSLocationId = inventDim.WMSLocationId;
            InventBatchId = inventDim.InventBatchId;
            WMSPalletId = inventDim.WMSPalletId;
            InventColorId = inventDim.InventColorId;
            InventSerialId = inventDim.InventSerialId;
            InventSizeId = inventDim.InventSizeId;
            RecordId = inventDim.RecordId;
            CreatedBy = inventDim.CreatedBy;
            ModifiedBy = inventDim.ModifiedBy;
        }
    }
}

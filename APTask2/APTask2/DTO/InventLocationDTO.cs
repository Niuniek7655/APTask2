using APTask2.Entities;
using System;

namespace APTask2.DTO
{
    public class InventLocationDTO
    {
        public string InventLocationId { get; set; }

        public string InventSiteId { get; set; }

        public string Name { get; set; }

        public DateTime CreateDateTime { get; set; }

        public DateTime UpdateDateTime { get; set; }

        public int RecordId { get; set; }

        public string CreatedBy { get; set; }

        public string ModifiedBy { get; set; }

        public InventLocationDTO(InventLocation inventLocation)
        {
            InventLocationId = inventLocation.InventLocationId;
            InventSiteId = inventLocation.InventSiteId;
            Name = inventLocation.Name;
            CreateDateTime = inventLocation.CreateDateTime;
            UpdateDateTime = inventLocation.UpdateDateTime;
            RecordId = inventLocation.RecordId;
            CreatedBy = inventLocation.CreatedBy;
            ModifiedBy = inventLocation.ModifiedBy;
        }

        public InventLocation ConverToInventLocation()
        {
            return new InventLocation()
            {
                InventLocationId = InventLocationId,
                InventSiteId = InventSiteId,
                Name = Name,
                CreateDateTime = CreateDateTime,
                UpdateDateTime = UpdateDateTime,
                RecordId = RecordId,
                CreatedBy = CreatedBy,
                ModifiedBy = ModifiedBy,
                RowVersion = new byte[0],
            };
        }
    }
}

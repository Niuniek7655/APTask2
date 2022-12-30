using APTask2.DAL;
using APTask2.DTO;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace APTask2
{
    public partial class AddOrUpdateInventLocation : Form
    {
        private readonly APTaskDbContext _context;
        private readonly InventLocationDTO _inventLocationDTO;
        private string previousInventLocationId = string.Empty;
        public AddOrUpdateInventLocation(APTaskDbContext context, InventLocationDTO inventLocationDTO)
        {
            _context = context;
            _inventLocationDTO = inventLocationDTO;

            InitializeComponent();

            previousInventLocationId = _inventLocationDTO.InventLocationId;
            textBoxDirectInventLocationId.Text = _inventLocationDTO.InventLocationId;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            var inventLocationId = textBoxDirectInventLocationId.Text;
            if(string.IsNullOrWhiteSpace(inventLocationId) || inventLocationId.Count() > 10)
            {
                MessageBox.Show($"Invalid inventLocationId value: {inventLocationId}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var fromWMSLocationId = textBoxFromWMSLocationId.Text;
            if (string.IsNullOrWhiteSpace(fromWMSLocationId) || fromWMSLocationId.Count() > 10)
            {
                MessageBox.Show($"Invalid fromWMSLocationId value: {fromWMSLocationId}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var toWMSLocationId = textBoxToWMSLocationId.Text;
            if (string.IsNullOrWhiteSpace(toWMSLocationId) || toWMSLocationId.Count() > 10)
            {
                MessageBox.Show($"Invalid toWMSLocationId value: {toWMSLocationId}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isExistInventLocations = _context.InventLocations.Any(x => x.InventLocationId.Equals(textBoxDirectInventLocationId.Text));
            var inventLocation = _inventLocationDTO.ConverToInventLocation();
            if (!isExistInventLocations)
            {
                inventLocation.InventLocationId = inventLocationId;
                inventLocation.CreateDateTime = DateTime.UtcNow;
                _context.InventLocations.Add(inventLocation);
            }
            else
            {
                inventLocation.UpdateDateTime = DateTime.UtcNow;
            }

            var inventDimsToUpdate = _context
                .InventDims
                .Where(x => x.InventLocationId == previousInventLocationId)
                .Where(y => string.Compare(y.WMSLocationId, fromWMSLocationId) >= 0 &&
                            string.Compare(y.WMSLocationId, toWMSLocationId) <= 0);

            foreach(var inventDim in inventDimsToUpdate)
            {
                inventDim.InventLocationId = inventLocationId;
            }

            _context.SaveChanges();

            DialogResult = DialogResult.OK;
        }
    }
}

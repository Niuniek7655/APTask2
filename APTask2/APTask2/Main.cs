using APTask2.DAL;
using APTask2.DTO;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace APTask2
{
    public partial class Main : Form
    {
        private readonly APTaskDbContext _context;
        private bool _isLoad = false;

        public Main(APTaskDbContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            var inventLocations = _context
                .InventLocations
                .ToList()
                .Select(x => new InventLocationDTO(x))
                .ToList();
            dataGridViewInventLocation.DataSource = inventLocations;

            var inventDims = _context
                .InventDims
                .ToList()
                .Select(x => new InventDimDTO(x))
                .ToList();
            dataGridViewInventDim.DataSource = inventDims;

            _isLoad = true;
        }

        private void dataGridViewInventLocation_SelectionChanged(object sender, EventArgs e)
        {
            if(!_isLoad)
            {
                return;
            }

            var isRowSelected = IsRowSelected();
            if(!isRowSelected)
            {
                return;
            }

            var row = dataGridViewInventLocation.SelectedRows[0];
            var item = row.DataBoundItem as InventLocationDTO;

            var newInventDims = _context
                .InventDims
                .Where(x => x.InventLocationId == item.InventLocationId)
                .ToList()
                .Select(y => new InventDimDTO(y))
                .ToList();

            dataGridViewInventDim.DataSource = newInventDims;

            labelNumberOfInventDimForInventLocationId.Visible = true;
            labelNumberOfInventDimForInventLocationId.Text = $"Number of InventDim for InventLocationId : {newInventDims.Count}";

            var numberOfUniqueWMSLocationIdInInventDimForInventLocationId = newInventDims
                .GroupBy(x => x.WMSLocationId)
                .Select(y => y.FirstOrDefault())
                .Count();
            labelNumberOfUniqueWMSLocationIdInInventDimForInventLocationId.Visible = true;
            labelNumberOfUniqueWMSLocationIdInInventDimForInventLocationId.Text = $"Number of unique WMSLocationId in InventDim for InventLocationId: {numberOfUniqueWMSLocationIdInInventDimForInventLocationId}";
        }

        private void buttonAddOrUpdate_Click(object sender, EventArgs e)
        {
            var isRowSelected = IsRowSelected();
            if (!isRowSelected)
            {
                return;
            }

            var row = dataGridViewInventLocation.SelectedRows[0];
            var item = row.DataBoundItem as InventLocationDTO;

            var addOrUpdateInventLocation = new AddOrUpdateInventLocation(_context, item);
            var result = addOrUpdateInventLocation.ShowDialog();
            if (result == DialogResult.OK)
            {
                MessageBox.Show($"Operation complete", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool IsRowSelected()
        {
            var rowsCount = dataGridViewInventLocation.SelectedRows.Count;
            if (rowsCount == 0 || rowsCount > 1)
            {
                return false;
            }

            var row = dataGridViewInventLocation.SelectedRows[0];
            if (row == null ||
                row.DataBoundItem == null ||
                !(row.DataBoundItem is InventLocationDTO))
            {
                return false;
            }

            return true;
        }
    }
}

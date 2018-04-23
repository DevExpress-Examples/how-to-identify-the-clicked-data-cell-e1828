using System.Windows;
using System.Windows.Controls;

namespace AgDataGrid_CellClick {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
            grid.DataSource = ProductList.GetData();
        }

        private void grid_CellClick(object sender, DevExpress.AgDataGrid.CellClickEventArgs e) {
            string message = string.Format("RowHandle: {0}; Row Visible Index: {1}; Column: {2}; Value: {3}",
                new object[]{e.Cell.RowHandle, grid.GetRowVisibleIndex(e.Cell.RowHandle),
                    e.Cell.Column.FieldName, e.Cell.Value.CellValue});
            MessageBox.Show(message, "Cell Info", MessageBoxButton.OK);
        }
    }
}

Imports Microsoft.VisualBasic
Imports System.Windows
Imports System.Windows.Controls

Namespace AgDataGrid_CellClick
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			grid.DataSource = ProductList.GetData()
		End Sub

		Private Sub grid_CellClick(ByVal sender As Object, _
                               ByVal e As DevExpress.AgDataGrid.CellClickEventArgs)
			Dim message As String = String.Format( _
"RowHandle: {0}; Row Visible Index: {1}; Column: {2}; Value: {3}", _
New Object(){e.Cell.RowHandle, grid.GetRowVisibleIndex(e.Cell.RowHandle), _
                       e.Cell.Column.FieldName, e.Cell.Value.CellValue})
	      MessageBox.Show(message, "Cell Info", MessageBoxButton.OK)
		End Sub
	End Class
End Namespace

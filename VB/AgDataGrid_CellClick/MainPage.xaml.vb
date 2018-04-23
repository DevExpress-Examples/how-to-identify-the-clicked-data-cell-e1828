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

		Private Sub grid_CellClick(ByVal sender As Object, ByVal e As DevExpress.AgDataGrid.CellClickEventArgs)
			Dim message As String = String.Format("RowHandle: {0}; Row Visible Index: {1}; Column: {2}; Value: {3}", New Object(){e.Cell.RowHandle, grid.GetRowVisibleIndex(e.Cell.RowHandle), e.Cell.Column.FieldName, e.Cell.Value})
			MessageBox.Show(message, "Cell Info", MessageBoxButton.OK)
		End Sub
	End Class
End Namespace

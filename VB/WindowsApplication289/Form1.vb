Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Demos

Namespace WindowsApplication289
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()

			gridControl1.DataSource = ProductInfoCreator.CreateData()

		End Sub

		Private Sub gridView1_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles gridView1.CustomUnboundColumnData
			Dim view As GridView = CType(sender, GridView)

			If e.Column.FieldName = "PlainNotes" AndAlso e.IsGetData Then
				Dim value As Object = (CType(sender, GridView)).GetListSourceRowCellValue(e.ListSourceRowIndex, gridColumn3)
				e.Value = repositoryItemRichTextEdit1.ConvertEditValueToPlainText(value)
			End If
		End Sub
	End Class
End Namespace
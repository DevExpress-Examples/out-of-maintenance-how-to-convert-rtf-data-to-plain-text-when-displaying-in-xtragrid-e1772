Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraGrid.Demos

Namespace WindowsApplication289
	Partial Public Class Form1
		Inherits Form
		Private richServer As RichEditDocumentServer

		Public Sub New()
			InitializeComponent()

			gridControl1.DataSource = ProductInfoCreator.CreateData()

			richServer = New RichEditDocumentServer()

		End Sub

		Private Sub gridView1_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles gridView1.CustomUnboundColumnData
			Dim view As GridView = CType(sender, GridView)

			'// The code commented below is also correct, but the use of the RichEditDocumentServer provides you with additional advantages
			'if (e.Column.FieldName == "PlainNotes" && e.IsGetData) {
			'    object value = ((GridView)sender).GetListSourceRowCellValue(e.ListSourceRowIndex, gridColumn3);
			'    e.Value = repositoryItemRichTextEdit1.ConvertEditValueToPlainText(value);
			'}

			If e.Column.FieldName = "PlainNotes" AndAlso e.IsGetData Then
				Dim value As Object = (CType(sender, GridView)).GetListSourceRowCellValue(e.ListSourceRowIndex, gridColumn3)
				richServer.RtfText = value.ToString()
				e.Value = richServer.Text
			End If

		End Sub
	End Class
End Namespace
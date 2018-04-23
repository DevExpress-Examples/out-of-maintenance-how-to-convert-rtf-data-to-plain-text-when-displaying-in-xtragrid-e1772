Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Demos
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections
Imports DevExpress.XtraRichEdit.Model
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraEditors.Controls.Rtf

Namespace WindowsApplication289
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()

			gridControl1.DataSource = ProductInfoCreator.CreateData()

		End Sub

		Private Sub gridView1_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles gridView1.CustomUnboundColumnData
			Dim view As GridView = CType(sender, GridView)
			If e.Column.FieldName = "PlainNotes" Then
				If e.IsGetData Then
					Dim rtf As String = (CType((CType(view.DataSource, IList))(e.ListSourceRowIndex), ProductInfo)).Notes
					Dim model As New DocumentModel()
					Dim converter As New StringEditValueToDocumentModelConverter(DocumentFormat.Rtf, Encoding.Default)
					Dim converter2 As New DocumentModelToStringConverter(DocumentFormat.PlainText, Encoding.Default)
					converter.ConvertToDocumentModel(model, rtf)
					Dim text As String = TryCast(converter2.ConvertToEditValue(model), String)
					e.Value = text
					model.Dispose()
				End If
			End If
		End Sub
	End Class
End Namespace
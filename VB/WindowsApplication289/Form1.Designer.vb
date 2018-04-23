Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication289
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
			Me.gridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemRichTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemRichTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemRichTextEdit1, Me.repositoryItemMemoEdit1})
			Me.gridControl1.Size = New System.Drawing.Size(972, 266)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.gridColumn1, Me.gridColumn2, Me.gridColumn3})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsView.RowAutoHeight = True
'			Me.gridView1.CustomUnboundColumnData += New DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(Me.gridView1_CustomUnboundColumnData);
			' 
			' gridColumn1
			' 
			Me.gridColumn1.Caption = "Name"
			Me.gridColumn1.FieldName = "Name"
			Me.gridColumn1.Name = "gridColumn1"
			Me.gridColumn1.Visible = True
			Me.gridColumn1.VisibleIndex = 0
			Me.gridColumn1.Width = 162
			' 
			' gridColumn2
			' 
			Me.gridColumn2.Caption = "PlainNotes"
			Me.gridColumn2.ColumnEdit = Me.repositoryItemMemoEdit1
			Me.gridColumn2.FieldName = "PlainNotes"
			Me.gridColumn2.Name = "gridColumn2"
			Me.gridColumn2.OptionsColumn.AllowEdit = False
			Me.gridColumn2.UnboundType = DevExpress.Data.UnboundColumnType.String
			Me.gridColumn2.Visible = True
			Me.gridColumn2.VisibleIndex = 1
			Me.gridColumn2.Width = 394
			' 
			' repositoryItemMemoEdit1
			' 
			Me.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1"
			' 
			' gridColumn3
			' 
			Me.gridColumn3.Caption = "Notes"
			Me.gridColumn3.ColumnEdit = Me.repositoryItemRichTextEdit1
			Me.gridColumn3.FieldName = "Notes"
			Me.gridColumn3.Name = "gridColumn3"
			Me.gridColumn3.OptionsColumn.AllowEdit = False
			Me.gridColumn3.Visible = True
			Me.gridColumn3.VisibleIndex = 2
			Me.gridColumn3.Width = 395
			' 
			' repositoryItemRichTextEdit1
			' 
			Me.repositoryItemRichTextEdit1.DocumentFormat = DevExpress.XtraRichEdit.DocumentFormat.Rtf
			Me.repositoryItemRichTextEdit1.Name = "repositoryItemRichTextEdit1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(972, 266)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemRichTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
		Private repositoryItemRichTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit
	End Class
End Namespace


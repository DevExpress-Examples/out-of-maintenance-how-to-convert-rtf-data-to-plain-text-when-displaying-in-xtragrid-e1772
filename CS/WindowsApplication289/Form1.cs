using System;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraRichEdit;
using DevExpress.XtraGrid.Demos;

namespace WindowsApplication289
{
    public partial class Form1 : Form
    {
        RichEditDocumentServer richServer;

        public Form1()
        {
            InitializeComponent();

            gridControl1.DataSource = ProductInfoCreator.CreateData();

            richServer = new RichEditDocumentServer();

        }

        private void gridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            GridView view = (GridView)sender;

            //// The code commented below is also correct, but the use of the RichEditDocumentServer provides you with additional advantages
            //if (e.Column.FieldName == "PlainNotes" && e.IsGetData) {
            //    object value = ((GridView)sender).GetListSourceRowCellValue(e.ListSourceRowIndex, gridColumn3);
            //    e.Value = repositoryItemRichTextEdit1.ConvertEditValueToPlainText(value);
            //}

            if (e.Column.FieldName == "PlainNotes" && e.IsGetData) {
                object value = ((GridView)sender).GetListSourceRowCellValue(e.ListSourceRowIndex, gridColumn3);
                richServer.RtfText = value.ToString();
                e.Value = richServer.Text;
            }

        }
    }
}
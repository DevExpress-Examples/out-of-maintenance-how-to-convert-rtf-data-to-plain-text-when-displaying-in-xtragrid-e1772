using System;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Demos;

namespace WindowsApplication289
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            gridControl1.DataSource = ProductInfoCreator.CreateData();

        }

        private void gridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            GridView view = (GridView)sender;

            if (e.Column.FieldName == "PlainNotes" && e.IsGetData) {
                object value = ((GridView)sender).GetListSourceRowCellValue(e.ListSourceRowIndex, gridColumn3);
                e.Value = repositoryItemRichTextEdit1.ConvertEditValueToPlainText(value);
            }
        }
    }
}
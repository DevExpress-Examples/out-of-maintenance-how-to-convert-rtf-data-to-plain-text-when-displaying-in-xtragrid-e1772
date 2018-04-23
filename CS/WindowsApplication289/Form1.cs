using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Demos;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections;
using DevExpress.XtraRichEdit.Model;
using DevExpress.XtraRichEdit;
using DevExpress.XtraEditors.Controls.Rtf;

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
            if (e.Column.FieldName == "PlainNotes")
            {
                if (e.IsGetData)
                {
                    string rtf = ((ProductInfo)((IList)view.DataSource)[e.ListSourceRowIndex]).Notes;
                    DocumentModel model = new DocumentModel();
                    StringEditValueToDocumentModelConverter converter = new StringEditValueToDocumentModelConverter(DocumentFormat.Rtf, Encoding.Default);
                    DocumentModelToStringConverter converter2 = new DocumentModelToStringConverter(DocumentFormat.PlainText, Encoding.Default);
                    converter.ConvertToDocumentModel(model, rtf);
                    string text = converter2.ConvertToEditValue(model) as string;
                    e.Value = text;
                    model.Dispose();
                }
            }
        }
    }
}
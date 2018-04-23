# How to convert RTF data to plain text when displaying in XtraGrid


<p>This example demonstrates how to convert RTF data to plain text on the fly, and display it in the XtraGrid control.</p>


<h3>Description</h3>

<p>The approach used before version 10.2.6 is not recommended since it involves objects intended for internal use. These objects can be renamed or dropped without warning in future releases.<br />
For version 10.2.6 and higher you are advised to use the <strong>DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit.ConvertEditValueToPlainText</strong> method which encapsulates the code suggested for earlier versions.</p><br />


<br/>



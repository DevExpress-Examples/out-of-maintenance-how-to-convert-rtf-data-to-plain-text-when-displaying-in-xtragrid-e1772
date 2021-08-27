<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128609505/10.2.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1772)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsApplication289/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication289/Form1.vb))
<!-- default file list end -->
# How to convert RTF data to plain text when displaying in XtraGrid


<p>This example demonstrates how to convert RTF data to plain text on the fly, and display it in the XtraGrid control.</p>


<h3>Description</h3>

<p>The approach used before version 10.2.6 is not recommended since it involves objects intended for internal use. These objects can be renamed or dropped without warning in future releases.<br />
For version 10.2.6 and higher you are advised to use the <strong>DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit.ConvertEditValueToPlainText</strong> method which encapsulates the code suggested for earlier versions.</p><br />


<br/>



using Newtonsoft.Json;
using Syncfusion.EJ2.DocumentEditor;
using System;
using System.IO;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Test.Component
{
	public partial class DocumentEditor : Wisej.Web.Ext.Syncfusion2.Test.Component.TestBase
	{
		public DocumentEditor()
		{
			InitializeComponent();
		}

		private void documentEditor1_WebRequest(object sender, WebRequestEventArgs e)
		{
			switch (e.Request.QueryString["action"])
			{
				case "load":
					break;

				default:
					break;

			}
		}

		private void DocumentEditor_Load(object sender, EventArgs e)
		{
			var docBytes = File.ReadAllBytes(Application.MapPath("Data/DocumentEditor/W2W.docx"));
			
			using (var ms = new MemoryStream(docBytes))
			{
				var document = WordDocument.Load(ms, FormatType.Docx);
				string sfdt = JsonConvert.SerializeObject(document);
				this.documentEditor1.Call("openFile", sfdt);
			}
		}
	}
}

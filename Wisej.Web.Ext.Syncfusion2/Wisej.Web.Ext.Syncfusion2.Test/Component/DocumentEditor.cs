using Newtonsoft.Json;
using Syncfusion.EJ2.DocumentEditor;
using System;
using System.IO;

namespace Wisej.Web.Ext.Syncfusion2.Test.Component
{
    public partial class DocumentEditor : TestBase
	{
		public DocumentEditor()
		{
			InitializeComponent();

			this.documentEditor1.Instance.created += new WidgetEventHandler(documentEditor1_WidgetEvent);
		}

		private void DocumentEditor_Load(object sender, EventArgs e)
		{
			var bytes = File.ReadAllBytes(Application.MapPath("Data/DocumentEditor/WisejCP1.docx"));

			using (var ms = new MemoryStream(bytes))
			{
				var document = WordDocument.Load(ms, FormatType.Docx);
				string sfdt = JsonConvert.SerializeObject(document);
				this.documentEditor1.Call("openFile", sfdt);
			}
		}

		private void documentEditor1_WebRequest(object sender, WebRequestEventArgs e)
		{
			switch (e.Request.QueryString["action"])
			{
				case "serviceImport":
					var files = e.Request.Files;
					// can only load one document at a time.
					if (files.Count > 0)
                    {
						var file = files[0];
						var index = file.FileName.LastIndexOf('.');
						var type = file.FileName.Substring(index).ToLower();

						e.Response.Write(ProcessDocument(file.InputStream, type));
					}
					break;

				default:
					break;
			}
		}

		private void documentEditor1_WidgetEvent(object sender, WidgetEventArgs e)
        {
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

        private void button1_Click(object sender, EventArgs e)
        {
			var path = Application.MapPath("Data/DocumentEditor/WisejCP2.docx");

			var docBytes = File.ReadAllBytes(path);
			using (var stream = new MemoryStream(docBytes))
            {
				var sfdt = ProcessDocument(stream, Path.GetExtension(path));
				this.documentEditor1.Call("openFile", sfdt);
			}
		}

		/// <summary>
		/// Generates the SFDT string for the given document.
		/// </summary>
		/// <param name="bytes"></param>
		/// <param name="format"></param>
		/// <returns></returns>
		private string ProcessDocument(Stream stream, string format)
        {
			var type = (FormatType)Enum.Parse(typeof(FormatType), format.Replace(".", ""), true);
			var document = WordDocument.Load(stream, type);
			var sfdt = JsonConvert.SerializeObject(document);
			document.Dispose();
			return sfdt;
		}
	}
}

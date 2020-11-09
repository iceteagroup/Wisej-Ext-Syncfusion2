using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Test.Component
{
	public partial class PDFViewer : Wisej.Web.Ext.Syncfusion2.Test.Component.TestBase
	{
		public PDFViewer()
		{
			InitializeComponent();
		}

		private void PDFViewer_Load(object sender, EventArgs e)
		{
			this.pdfViewer1.Instance.load("WisejDataSheet", null);
		}

		private void pdfViewer1_WebRequest(object sender, WebRequestEventArgs e)
		{
			switch(e.Request.QueryString["action"])
			{
				case "load":
					e.Response.AddHeader("Content-Disposition", $"inline; filename=Wisej.pdf");
					e.Response.TransmitFile(Application.MapPath("Data/Wisej.pdf"));
					break;

				default:
					break;

			}
		}
	}
}

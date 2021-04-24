using Syncfusion.EJ2.Spreadsheet;
using System;
using System.IO;
using System.Web;
using Wisej.Core;

namespace Wisej.Web.Ext.Syncfusion2.Test.Component
{
    public partial class Spreadsheet : TestBase
	{
		public Spreadsheet()
		{
			InitializeComponent();
		}

		private void Spreadsheet_Load(object sender, EventArgs e)
		{
			this.spreadsheet1.Options.allowOpen = true;
			this.spreadsheet1.Options.openUrl = ((Widget)this.spreadsheet1).GetPostbackURL() + "&action=load";

			var filePath = Application.MapPath("Data/Spreadsheet/Sample.xls");
			this.spreadsheet1.Instance.openFromJson(new
			{
				file = ProcessFile(filePath)
			});
		}

		private void button1_Click(object sender, EventArgs e)
		{
			// update the first sheet.
			this.spreadsheet1.Eval(@"
				this.widget.sheets[0].showHeaders = false;
				this.widget.refresh();
			");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var filePath = Application.MapPath("Data/Spreadsheet/Sample2.xlsx");
			this.spreadsheet1.Instance.openFromJson(new
			{
				file = ProcessFile(filePath)
			});
		}

		private void spreadsheet1_WebRequest(object sender, WebRequestEventArgs e)
		{
			switch (e.Request.Params["action"])
			{
				case "load":
						e.Response.Write(ProcessFile(e.Request.Files[0]));
					break;

				case "fetch":
					var filePath = e.Request.Params["path"];
					e.Response.WriteFile(Application.MapPath(filePath));
					break;

				default:
					break;
			}
		}

        /// <summary>
        /// Processes the given file (path) and returns the JSON configuration.
        /// </summary>
        /// <param name="filePath">The path of the excel file.</param>
        /// <returns>The JSON configuration of the file.</returns>
        private string ProcessFile(string filePath)
		{
			// create a postback url.
			var postback = $"{Application.StartupUrl}{((Widget)this.spreadsheet1).GetPostbackURL()}&action=fetch&path={filePath}";

			var open = new OpenRequest();
			open.File = new[] { postback };
			return Workbook.Open(open);
		}

		/// <summary>
		/// Processes the given file and returns the JSON configuration.
		/// </summary>
		/// <param name="file">The uploaded file.</param>
		/// <returns>The JSON configuration of the file.</returns>
		private string ProcessFile(HttpPostedFile file)
		{
			var open = new OpenRequest();
			open.File = new[] { new HttpPostedFileWrapper(file) };
			return Workbook.Open(open);
		}
    }
}

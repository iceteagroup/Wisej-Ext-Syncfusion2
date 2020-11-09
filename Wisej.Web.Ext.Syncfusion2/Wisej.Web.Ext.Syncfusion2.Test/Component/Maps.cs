using System;
using System.IO;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Test.Component
{
	public partial class Maps : Wisej.Web.Ext.Syncfusion2.Test.Component.TestBase
	{
		public Maps()
		{
			InitializeComponent();
		}

		private void Maps_Load(object sender, EventArgs e)
		{
			var worldText = File.ReadAllText(Application.MapPath("Data/Maps/WorldMap_Countries.json"));
			this.maps1.Options.layers = new[] {
				new { shapeData = JSON.Parse(worldText) }
			};

			this.maps1.Update();
		}
	}
}

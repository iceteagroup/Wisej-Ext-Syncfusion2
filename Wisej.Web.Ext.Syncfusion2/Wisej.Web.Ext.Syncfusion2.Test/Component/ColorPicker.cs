using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Test.Component
{
	public partial class ColorPicker : Wisej.Web.Ext.Syncfusion2.Test.Component.TestBase
	{
		public ColorPicker()
		{
			InitializeComponent();

			this.colorPicker1.Instance.change += new WidgetEventHandler(colorPicker1_WidgetEvent);
		}

		private async void colorPicker1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			var color = await this.colorPicker1.Instance.getValueAsync();
			AlertBox.Show($"Color: {color}");
		}
	}
}

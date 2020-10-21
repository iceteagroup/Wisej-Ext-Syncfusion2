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

		private void colorPicker1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}

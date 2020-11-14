using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Test.Component
{
	public partial class DateTimePicker : Wisej.Web.Ext.Syncfusion2.Test.Component.TestBase
	{
		public DateTimePicker()
		{
			InitializeComponent();

			this.dateTimePicker1.Instance.change += new WidgetEventHandler(dateTimePicker1_WidgetEvent);
			this.dateTimePicker1.Instance.navigated += new WidgetEventHandler(dateTimePicker1_WidgetEvent);
		}

		private void dateTimePicker1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}

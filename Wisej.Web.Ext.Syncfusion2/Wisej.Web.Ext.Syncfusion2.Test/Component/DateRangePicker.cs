using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Test.Component
{
	public partial class DateRangePicker : Wisej.Web.Ext.Syncfusion2.Test.Component.TestBase
	{
		public DateRangePicker()
		{
			InitializeComponent();

			this.dateRangePicker1.Instance.change += new WidgetEventHandler(dateRangePicker1_WidgetEvent);
			this.dateRangePicker1.Instance.select += new WidgetEventHandler(dateRangePicker1_WidgetEvent);
			this.dateRangePicker1.Instance.navigated += new WidgetEventHandler(dateRangePicker1_WidgetEvent);
		}

		private void dateRangePicker1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}

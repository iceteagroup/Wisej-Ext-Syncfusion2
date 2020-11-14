using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Test.Component
{
	public partial class DatePicker : Wisej.Web.Ext.Syncfusion2.Test.Component.TestBase
	{
		public DatePicker()
		{
			InitializeComponent();

			this.datePicker1.Instance.change += new WidgetEventHandler(datePicker1_WidgetEvent);
			this.datePicker1.Instance.navigated += new WidgetEventHandler(datePicker1_WidgetEvent);
		}

		private void datePicker1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}

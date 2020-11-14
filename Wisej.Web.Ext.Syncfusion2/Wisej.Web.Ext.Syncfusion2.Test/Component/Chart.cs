using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Test.Component
{
	public partial class Chart : TestBase
	{
		public Chart()
		{
			InitializeComponent();

			this.chart1.Instance.pointClick += new WidgetEventHandler(chart1_WidgetEvent);
			this.chart1.Instance.legendClick += new WidgetEventHandler(chart1_WidgetEvent);
		}

		private void chart1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}

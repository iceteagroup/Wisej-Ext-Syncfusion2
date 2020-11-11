using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Test.Component
{
	public partial class AccumulationChart : Wisej.Web.Ext.Syncfusion2.Test.Component.TestBase
	{
		public AccumulationChart()
		{
			InitializeComponent();

			this.accumulationChart1.Instance.chartMouseClick += new WidgetEventHandler(accumulationChart1_WidgetEvent);
		}

		private void accumulationChart1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}

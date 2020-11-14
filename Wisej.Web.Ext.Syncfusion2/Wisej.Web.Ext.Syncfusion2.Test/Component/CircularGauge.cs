using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Test.Component
{
	public partial class CircularGauge : Wisej.Web.Ext.Syncfusion2.Test.Component.TestBase
	{
		public CircularGauge()
		{
			InitializeComponent();

			this.circularGauge1.Instance.dragStart += new WidgetEventHandler(circularGauge1_WidgetEvent);
			this.circularGauge1.Instance.dragEnd += new WidgetEventHandler(circularGauge1_WidgetEvent);
		}

		private void circularGauge1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}

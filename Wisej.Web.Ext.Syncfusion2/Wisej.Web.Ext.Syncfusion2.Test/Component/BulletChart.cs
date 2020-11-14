using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Test.Component
{
	public partial class BulletChart : Wisej.Web.Ext.Syncfusion2.Test.Component.TestBase
	{
		public BulletChart()
		{
			InitializeComponent();

			this.bulletChart1.Instance.bulletChartMouseClick += new WidgetEventHandler(bulletChart1_WidgetEvent);
		}

		private void bulletChart1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}

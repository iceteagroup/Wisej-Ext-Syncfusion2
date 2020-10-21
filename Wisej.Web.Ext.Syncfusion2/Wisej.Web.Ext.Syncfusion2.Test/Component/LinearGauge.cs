using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Test.Component
{
	public partial class LinearGauge : Wisej.Web.Ext.Syncfusion2.Test.Component.TestBase
	{
		public LinearGauge()
		{
			InitializeComponent();

			this.linearGauge1.Instance.valueChange += new WidgetEventHandler(linearGauge1_WidgetEvent);
		}

		private void linearGauge1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.linearGauge1.Instance.setPointerValue(0, 0, this.numericUpDown1.Value);
		}
	}
}

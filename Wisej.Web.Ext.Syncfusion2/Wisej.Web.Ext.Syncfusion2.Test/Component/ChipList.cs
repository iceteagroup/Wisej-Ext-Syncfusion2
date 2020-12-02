using System;

namespace Wisej.Web.Ext.Syncfusion2.Test.Component
{
	public partial class ChipList : Wisej.Web.Ext.Syncfusion2.Test.Component.TestBase
	{
		private Camera.Camera camera1 = new Camera.Camera();
		public ChipList()
		{
			InitializeComponent();

			this.chipList1.Instance.click += new WidgetEventHandler(chipList1_WidgetEvent);
			this.chipList1.Instance.delete += new WidgetEventHandler(chipList1_WidgetEvent);
		}

		private void ChipList_Load(object sender, EventArgs e)
		{
			this.chipList1.Options.chips = new object[] 
			{ 
				new 
				{ 
					text = "Apple",
					cssClass = "e-primary"
				}, 
				new 
				{ 
					text = "Microsoft",
					cssClass = "e-info"
				},
				new 
				{ 
					text = "Google",
					cssClass = "e-success"
				},
				new 
				{ 
					text = "Tesla",
					cssClass = "e-warning"
				},
				new 
				{ 
					text = "Intel",
					cssClass = "e-danger"
				} 
			};
		}

		private void chipList1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}

using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Test.Component
{
	public partial class ChipList : Wisej.Web.Ext.Syncfusion2.Test.Component.TestBase
	{
		public ChipList()
		{
			InitializeComponent();
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
	}
}

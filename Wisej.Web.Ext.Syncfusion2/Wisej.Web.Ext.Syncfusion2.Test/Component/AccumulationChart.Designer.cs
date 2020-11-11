namespace Wisej.Web.Ext.Syncfusion2.Test.Component
{
	partial class AccumulationChart
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Wisej Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccumulationChart));
			this.accumulationChart1 = new Wisej.Web.Ext.Syncfusion2.AccumulationChart();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/accumulation-chart/es5-gettin" +
    "g-started/";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/accumulation-chart/overvi" +
    "ew/";
			// 
			// panel
			// 
			this.panel.Controls.Add(this.accumulationChart1);
			// 
			// accumulationChart1
			// 
			this.accumulationChart1.Dock = Wisej.Web.DockStyle.Fill;
			this.accumulationChart1.Location = new System.Drawing.Point(8, 8);
			this.accumulationChart1.Name = "accumulationChart1";
			this.accumulationChart1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("accumulationChart1.Options"))));
			this.accumulationChart1.Size = new System.Drawing.Size(437, 297);
			this.accumulationChart1.TabIndex = 0;
			this.accumulationChart1.Text = "accumulationChart1";
			// 
			// AccumulationChart
			// 
			this.Name = "AccumulationChart";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion2.AccumulationChart accumulationChart1;
	}
}

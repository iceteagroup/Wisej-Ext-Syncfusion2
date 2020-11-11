namespace Wisej.Web.Ext.Syncfusion2.Test.Component
{
	partial class StockChart
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockChart));
			this.stockChart1 = new Wisej.Web.Ext.Syncfusion2.StockChart();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/stock-chart/es5-getting-start" +
    "ed/";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/stock-chart/";
			// 
			// panel
			// 
			this.panel.Controls.Add(this.stockChart1);
			// 
			// stockChart1
			// 
			this.stockChart1.Dock = Wisej.Web.DockStyle.Fill;
			this.stockChart1.Location = new System.Drawing.Point(8, 8);
			this.stockChart1.Name = "stockChart1";
			this.stockChart1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("stockChart1.Options"))));
			this.stockChart1.Size = new System.Drawing.Size(437, 297);
			this.stockChart1.TabIndex = 0;
			this.stockChart1.Text = "stockChart1";
			// 
			// StockChart
			// 
			this.Name = "StockChart";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion2.StockChart stockChart1;
	}
}

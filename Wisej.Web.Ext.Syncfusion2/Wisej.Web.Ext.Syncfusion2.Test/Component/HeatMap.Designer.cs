namespace Wisej.Web.Ext.Syncfusion2.Test.Component
{
	partial class HeatMap
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeatMap));
			this.heatMap1 = new Wisej.Web.Ext.Syncfusion2.HeatMap();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/heatmap-chart/getting-started" +
    "/";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/heatmap/";
			// 
			// panel
			// 
			this.panel.Controls.Add(this.heatMap1);
			// 
			// heatMap1
			// 
			this.heatMap1.Dock = Wisej.Web.DockStyle.Fill;
			this.heatMap1.Location = new System.Drawing.Point(8, 8);
			this.heatMap1.Name = "heatMap1";
			this.heatMap1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("heatMap1.Options"))));
			this.heatMap1.Size = new System.Drawing.Size(437, 297);
			this.heatMap1.TabIndex = 0;
			this.heatMap1.Text = "heatMap1";
			// 
			// HeatMap
			// 
			this.Name = "HeatMap";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion2.HeatMap heatMap1;
	}
}

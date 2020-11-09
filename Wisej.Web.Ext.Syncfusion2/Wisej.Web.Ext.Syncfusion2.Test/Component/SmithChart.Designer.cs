namespace Wisej.Web.Ext.Syncfusion2.Test.Component
{
	partial class SmithChart
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SmithChart));
			this.smithChart1 = new Wisej.Web.Ext.Syncfusion2.SmithChart();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.smithChart1);
			// 
			// smithChart1
			// 
			this.smithChart1.Dock = Wisej.Web.DockStyle.Fill;
			this.smithChart1.Location = new System.Drawing.Point(8, 8);
			this.smithChart1.Name = "smithChart1";
			this.smithChart1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("smithChart1.Options"))));
			this.smithChart1.Size = new System.Drawing.Size(437, 297);
			this.smithChart1.TabIndex = 0;
			this.smithChart1.Text = "smithChart1";
			// 
			// SmithChart
			// 
			this.Name = "SmithChart";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion2.SmithChart smithChart1;
	}
}

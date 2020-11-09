namespace Wisej.Web.Ext.Syncfusion2.Test.Component
{
	partial class BulletChart
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BulletChart));
			this.bulletChart1 = new Wisej.Web.Ext.Syncfusion2.BulletChart();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.bulletChart1);
			// 
			// bulletChart1
			// 
			this.bulletChart1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.bulletChart1.Location = new System.Drawing.Point(104, 90);
			this.bulletChart1.Name = "bulletChart1";
			this.bulletChart1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("bulletChart1.Options"))));
			this.bulletChart1.Size = new System.Drawing.Size(244, 132);
			this.bulletChart1.TabIndex = 0;
			this.bulletChart1.Text = "bulletChart1";
			// 
			// BulletChart
			// 
			this.Name = "BulletChart";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion2.BulletChart bulletChart1;
	}
}

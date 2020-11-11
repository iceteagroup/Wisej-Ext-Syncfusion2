namespace Wisej.Web.Ext.Syncfusion2.Test.Component
{
	partial class Grid
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grid));
			this.grid1 = new Wisej.Web.Ext.Syncfusion2.Grid();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/grid/getting-started/";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/grid/";
			// 
			// panel
			// 
			this.panel.Controls.Add(this.grid1);
			// 
			// grid1
			// 
			this.grid1.Dock = Wisej.Web.DockStyle.Fill;
			this.grid1.Location = new System.Drawing.Point(8, 8);
			this.grid1.Name = "grid1";
			this.grid1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("grid1.Options"))));
			this.grid1.Size = new System.Drawing.Size(437, 297);
			this.grid1.TabIndex = 0;
			this.grid1.Text = "grid1";
			// 
			// Grid
			// 
			this.Name = "Grid";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion2.Grid grid1;
	}
}

namespace Wisej.Web.Ext.Syncfusion2.Test.Component
{
	partial class TreeGrid
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreeGrid));
			this.treeGrid1 = new Wisej.Web.Ext.Syncfusion2.TreeGrid();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/treegrid/getting-started/";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/treegrid/";
			// 
			// panel
			// 
			this.panel.Controls.Add(this.treeGrid1);
			// 
			// treeGrid1
			// 
			this.treeGrid1.Dock = Wisej.Web.DockStyle.Fill;
			this.treeGrid1.Location = new System.Drawing.Point(8, 8);
			this.treeGrid1.Name = "treeGrid1";
			this.treeGrid1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("treeGrid1.Options"))));
			this.treeGrid1.Size = new System.Drawing.Size(437, 297);
			this.treeGrid1.TabIndex = 0;
			this.treeGrid1.Text = "treeGrid1";
			// 
			// TreeGrid
			// 
			this.Name = "TreeGrid";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion2.TreeGrid treeGrid1;
	}
}

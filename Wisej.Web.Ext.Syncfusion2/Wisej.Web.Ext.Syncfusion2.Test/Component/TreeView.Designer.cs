namespace Wisej.Web.Ext.Syncfusion2.Test.Component
{
	partial class TreeView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreeView));
			this.treeView1 = new Wisej.Web.Ext.Syncfusion2.TreeView();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/treeview/es5-getting-started/" +
    "";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/treeview/";
			// 
			// panel
			// 
			this.panel.Controls.Add(this.treeView1);
			// 
			// treeView1
			// 
			this.treeView1.Dock = Wisej.Web.DockStyle.Fill;
			this.treeView1.Location = new System.Drawing.Point(8, 8);
			this.treeView1.Name = "treeView1";
			this.treeView1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("treeView1.Options"))));
			this.treeView1.Size = new System.Drawing.Size(437, 297);
			this.treeView1.TabIndex = 0;
			this.treeView1.Text = "treeView1";
			// 
			// TreeView
			// 
			this.Name = "TreeView";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion2.TreeView treeView1;
	}
}

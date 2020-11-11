namespace Wisej.Web.Ext.Syncfusion2.Test.Component
{
	partial class Kanban
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kanban));
			this.kanban1 = new Wisej.Web.Ext.Syncfusion2.Kanban();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/kanban/getting-started/";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/kanban/";
			// 
			// panel
			// 
			this.panel.Controls.Add(this.kanban1);
			// 
			// kanban1
			// 
			this.kanban1.Dock = Wisej.Web.DockStyle.Fill;
			this.kanban1.Location = new System.Drawing.Point(8, 8);
			this.kanban1.Name = "kanban1";
			this.kanban1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("kanban1.Options"))));
			this.kanban1.Size = new System.Drawing.Size(437, 297);
			this.kanban1.TabIndex = 0;
			this.kanban1.Text = "kanban1";
			// 
			// Kanban
			// 
			this.Name = "Kanban";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion2.Kanban kanban1;
	}
}

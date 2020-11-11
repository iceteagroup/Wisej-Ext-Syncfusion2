namespace Wisej.Web.Ext.Syncfusion2.Test.Component
{
	partial class RichTextEditor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RichTextEditor));
			this.richTextEditor1 = new Wisej.Web.Ext.Syncfusion2.RichTextEditor();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/rich-text-editor/es5-getting-" +
    "started/";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/rich-text-editor/";
			// 
			// panel
			// 
			this.panel.Controls.Add(this.richTextEditor1);
			// 
			// richTextEditor1
			// 
			this.richTextEditor1.Dock = Wisej.Web.DockStyle.Fill;
			this.richTextEditor1.Location = new System.Drawing.Point(8, 8);
			this.richTextEditor1.Name = "richTextEditor1";
			this.richTextEditor1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("richTextEditor1.Options"))));
			this.richTextEditor1.Size = new System.Drawing.Size(437, 297);
			this.richTextEditor1.TabIndex = 0;
			this.richTextEditor1.Text = "richTextEditor1";
			// 
			// RichTextEditor
			// 
			this.Name = "RichTextEditor";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion2.RichTextEditor richTextEditor1;
	}
}

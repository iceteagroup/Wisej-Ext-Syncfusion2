namespace Wisej.Web.Ext.Syncfusion2.Test.Component
{
	partial class DocumentEditor
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
			this.documentEditor1 = new Wisej.Web.Ext.Syncfusion2.DocumentEditor();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.documentEditor1);
			// 
			// documentEditor1
			// 
			this.documentEditor1.Dock = Wisej.Web.DockStyle.Fill;
			this.documentEditor1.Location = new System.Drawing.Point(8, 8);
			this.documentEditor1.Name = "documentEditor1";
			this.documentEditor1.Size = new System.Drawing.Size(437, 297);
			this.documentEditor1.TabIndex = 0;
			this.documentEditor1.Text = "documentEditor1";
			this.documentEditor1.WebRequest += new Wisej.Web.WebRequestHandler(this.documentEditor1_WebRequest);
			// 
			// DocumentEditor
			// 
			this.Name = "DocumentEditor";
			this.Load += new System.EventHandler(this.DocumentEditor_Load);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion2.DocumentEditor documentEditor1;
	}
}

namespace Wisej.Web.Ext.Syncfusion2.Test.Component
{
	partial class FileManager
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
			this.fileManager1 = new Wisej.Web.Ext.Syncfusion2.FileManager();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/file-manager/es5-getting-star" +
    "ted/";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/file-manager/";
			// 
			// panel
			// 
			this.panel.Controls.Add(this.fileManager1);
			// 
			// fileManager1
			// 
			this.fileManager1.Dock = Wisej.Web.DockStyle.Fill;
			this.fileManager1.Location = new System.Drawing.Point(8, 8);
			this.fileManager1.Name = "fileManager1";
			this.fileManager1.Size = new System.Drawing.Size(437, 297);
			this.fileManager1.TabIndex = 0;
			this.fileManager1.Text = "fileManager1";
			// 
			// FileManager
			// 
			this.Name = "FileManager";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion2.FileManager fileManager1;
	}
}

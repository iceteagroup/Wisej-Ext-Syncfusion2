namespace Wisej.Web.Ext.Syncfusion2.Test.Component
{
	partial class Uploader
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
			this.uploader1 = new Wisej.Web.Ext.Syncfusion2.Uploader();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/uploader/es5-getting-started/" +
    "";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/uploader/";
			// 
			// panel
			// 
			this.panel.Controls.Add(this.uploader1);
			// 
			// uploader1
			// 
			this.uploader1.Anchor = Wisej.Web.AnchorStyles.None;
			this.uploader1.Location = new System.Drawing.Point(39, 106);
			this.uploader1.Name = "uploader1";
			this.uploader1.Size = new System.Drawing.Size(374, 100);
			this.uploader1.TabIndex = 0;
			this.uploader1.Text = "uploader1";
			// 
			// Uploader
			// 
			this.Name = "Uploader";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion2.Uploader uploader1;
	}
}

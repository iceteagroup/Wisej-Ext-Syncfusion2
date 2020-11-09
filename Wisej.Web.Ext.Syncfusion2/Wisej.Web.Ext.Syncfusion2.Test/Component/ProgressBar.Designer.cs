namespace Wisej.Web.Ext.Syncfusion2.Test.Component
{
	partial class ProgressBar
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
			this.progressBar1 = new Wisej.Web.Ext.Syncfusion2.ProgressBar();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.progressBar1);
			// 
			// progressBar1
			// 
			this.progressBar1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.progressBar1.Location = new System.Drawing.Point(58, 106);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"value\":70,\"animation\":{\"enable\":true,\"duration\":2000,\"delay\":0}}")));
			this.progressBar1.Size = new System.Drawing.Size(337, 100);
			this.progressBar1.TabIndex = 0;
			this.progressBar1.Text = "progressBar1";
			// 
			// ProgressBar
			// 
			this.Name = "ProgressBar";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion2.ProgressBar progressBar1;
	}
}

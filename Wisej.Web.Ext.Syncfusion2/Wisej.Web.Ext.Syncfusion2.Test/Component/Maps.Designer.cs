namespace Wisej.Web.Ext.Syncfusion2.Test.Component
{
	partial class Maps
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
			this.maps1 = new Wisej.Web.Ext.Syncfusion2.Maps();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.maps1);
			// 
			// maps1
			// 
			this.maps1.Dock = Wisej.Web.DockStyle.Fill;
			this.maps1.Location = new System.Drawing.Point(8, 8);
			this.maps1.Name = "maps1";
			this.maps1.Size = new System.Drawing.Size(437, 297);
			this.maps1.TabIndex = 0;
			this.maps1.Text = "maps1";
			// 
			// Maps
			// 
			this.Name = "Maps";
			this.Load += new System.EventHandler(this.Maps_Load);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion2.Maps maps1;
	}
}

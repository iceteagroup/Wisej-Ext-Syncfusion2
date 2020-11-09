namespace Wisej.Web.Ext.Syncfusion2.Test.Component
{
	partial class Toolbar
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
			this.toolbar1 = new Wisej.Web.Ext.Syncfusion2.Toolbar();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.toolbar1);
			// 
			// toolbar1
			// 
			this.toolbar1.Dock = Wisej.Web.DockStyle.Top;
			this.toolbar1.Location = new System.Drawing.Point(8, 8);
			this.toolbar1.Name = "toolbar1";
			this.toolbar1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"items\":[{\"text\":\"Cut\"},{\"text\":\"Copy\"},{\"text\":\"Paste\"},{\"type\":\"Separator\"},{\"" +
        "text\":\"Bold\"},{\"text\":\"Italic\"},{\"text\":\"Underline\"}]}")));
			this.toolbar1.Size = new System.Drawing.Size(437, 52);
			this.toolbar1.TabIndex = 0;
			this.toolbar1.Text = "toolbar1";
			// 
			// Toolbar
			// 
			this.Name = "Toolbar";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion2.Toolbar toolbar1;
	}
}

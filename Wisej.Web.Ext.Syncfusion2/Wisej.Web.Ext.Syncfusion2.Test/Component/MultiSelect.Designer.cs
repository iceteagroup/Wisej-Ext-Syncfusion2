namespace Wisej.Web.Ext.Syncfusion2.Test.Component
{
	partial class MultiSelect
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
			this.multiSelect1 = new Wisej.Web.Ext.Syncfusion2.MultiSelect();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/multi-select/es5-getting-star" +
    "ted/";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/multi-select/";
			// 
			// panel
			// 
			this.panel.Controls.Add(this.multiSelect1);
			// 
			// multiSelect1
			// 
			this.multiSelect1.Anchor = Wisej.Web.AnchorStyles.None;
			this.multiSelect1.Location = new System.Drawing.Point(76, 139);
			this.multiSelect1.Name = "multiSelect1";
			this.multiSelect1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"dataSource\":[\"Badminton\",\"Cricket\",\"Football\",\"Golf\",\"Tennis\"]}")));
			this.multiSelect1.Size = new System.Drawing.Size(300, 35);
			this.multiSelect1.TabIndex = 0;
			this.multiSelect1.Text = "multiSelect1";
			// 
			// MultiSelect
			// 
			this.Name = "MultiSelect";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion2.MultiSelect multiSelect1;
	}
}

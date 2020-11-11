namespace Wisej.Web.Ext.Syncfusion2.Test.Component
{
	partial class Slider
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
			this.slider1 = new Wisej.Web.Ext.Syncfusion2.Slider();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/range-slider/getting-started/" +
    "";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/slider/";
			// 
			// panel
			// 
			this.panel.Controls.Add(this.slider1);
			// 
			// slider1
			// 
			this.slider1.Anchor = Wisej.Web.AnchorStyles.None;
			this.slider1.Location = new System.Drawing.Point(71, 106);
			this.slider1.Name = "slider1";
			this.slider1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"type\":\"Range\",\"value\":[30,70]}")));
			this.slider1.Size = new System.Drawing.Size(311, 100);
			this.slider1.TabIndex = 0;
			this.slider1.Text = "slider1";
			// 
			// Slider
			// 
			this.Name = "Slider";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion2.Slider slider1;
	}
}

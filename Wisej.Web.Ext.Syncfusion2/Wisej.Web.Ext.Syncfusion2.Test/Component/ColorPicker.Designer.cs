namespace Wisej.Web.Ext.Syncfusion2.Test.Component
{
	partial class ColorPicker
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
			this.colorPicker1 = new Wisej.Web.Ext.Syncfusion2.ColorPicker();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/color-picker/es5-getting-star" +
    "ted/";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/color-picker/";
			// 
			// panel
			// 
			this.panel.Controls.Add(this.colorPicker1);
			// 
			// colorPicker1
			// 
			this.colorPicker1.Anchor = Wisej.Web.AnchorStyles.None;
			this.colorPicker1.Location = new System.Drawing.Point(201, 139);
			this.colorPicker1.Name = "colorPicker1";
			this.colorPicker1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"width\":\"300px\"}")));
			this.colorPicker1.Size = new System.Drawing.Size(51, 35);
			this.colorPicker1.TabIndex = 0;
			this.colorPicker1.Text = "colorPicker1";
			// 
			// ColorPicker
			// 
			this.Name = "ColorPicker";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion2.ColorPicker colorPicker1;
	}
}

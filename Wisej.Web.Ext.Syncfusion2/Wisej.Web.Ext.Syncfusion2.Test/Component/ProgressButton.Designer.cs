namespace Wisej.Web.Ext.Syncfusion2.Test.Component
{
	partial class ProgressButton
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
			this.progressButton1 = new Wisej.Web.Ext.Syncfusion2.ProgressButton();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.progressButton1);
			// 
			// progressButton1
			// 
			this.progressButton1.Anchor = Wisej.Web.AnchorStyles.None;
			this.progressButton1.Location = new System.Drawing.Point(145, 106);
			this.progressButton1.Name = "progressButton1";
			this.progressButton1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"content\":\"Spin Left\",\"enableProgress\":true}")));
			this.progressButton1.Size = new System.Drawing.Size(144, 46);
			this.progressButton1.TabIndex = 0;
			this.progressButton1.Text = "progressButton1";
			// 
			// ProgressButton
			// 
			this.Name = "ProgressButton";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion2.ProgressButton progressButton1;
	}
}

namespace Wisej.Web.Ext.Syncfusion2.Test.Component
{
	partial class Calendar
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
			this.calendar1 = new Wisej.Web.Ext.Syncfusion2.Calendar();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/calendar/es5-getting-started/" +
    "";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/calendar/overview/";
			// 
			// panel
			// 
			this.panel.Controls.Add(this.calendar1);
			// 
			// calendar1
			// 
			this.calendar1.Anchor = Wisej.Web.AnchorStyles.None;
			this.calendar1.Location = new System.Drawing.Point(95, 18);
			this.calendar1.Name = "calendar1";
			this.calendar1.Size = new System.Drawing.Size(263, 277);
			this.calendar1.TabIndex = 0;
			this.calendar1.Text = "calendar1";
			// 
			// Calendar
			// 
			this.Name = "Calendar";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion2.Calendar calendar1;
	}
}

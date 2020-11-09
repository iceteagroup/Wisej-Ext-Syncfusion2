namespace Wisej.Web.Ext.Syncfusion2.Test.Component
{
	partial class Gantt
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gantt));
			this.gantt1 = new Wisej.Web.Ext.Syncfusion2.Gantt();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.gantt1);
			// 
			// gantt1
			// 
			this.gantt1.Dock = Wisej.Web.DockStyle.Fill;
			this.gantt1.Location = new System.Drawing.Point(8, 8);
			this.gantt1.Name = "gantt1";
			this.gantt1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("gantt1.Options"))));
			this.gantt1.Size = new System.Drawing.Size(437, 297);
			this.gantt1.TabIndex = 0;
			this.gantt1.Text = "gantt1";
			// 
			// Gantt
			// 
			this.Name = "Gantt";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion2.Gantt gantt1;
	}
}

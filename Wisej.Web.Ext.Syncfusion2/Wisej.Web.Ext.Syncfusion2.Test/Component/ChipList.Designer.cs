namespace Wisej.Web.Ext.Syncfusion2.Test.Component
{
	partial class ChipList
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
			this.chipList1 = new Wisej.Web.Ext.Syncfusion2.ChipList();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/chips/getting-started/";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/chips/chipList/";
			// 
			// panel
			// 
			this.panel.Controls.Add(this.chipList1);
			// 
			// chipList1
			// 
			this.chipList1.Anchor = Wisej.Web.AnchorStyles.None;
			this.chipList1.Location = new System.Drawing.Point(41, 137);
			this.chipList1.Name = "chipList1";
			this.chipList1.Size = new System.Drawing.Size(371, 39);
			this.chipList1.TabIndex = 0;
			this.chipList1.Text = "chipList1";
			// 
			// ChipList
			// 
			this.Name = "ChipList";
			this.Load += new System.EventHandler(this.ChipList_Load);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion2.ChipList chipList1;
	}
}

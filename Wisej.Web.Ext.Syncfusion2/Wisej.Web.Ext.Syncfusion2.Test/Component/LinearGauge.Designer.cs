namespace Wisej.Web.Ext.Syncfusion2.Test.Component
{
	partial class LinearGauge
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
			this.linearGauge1 = new Wisej.Web.Ext.Syncfusion2.LinearGauge();
			this.numericUpDown1 = new Wisej.Web.NumericUpDown();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.numericUpDown1);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.numericUpDown1, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.linearGauge1);
			// 
			// linearGauge1
			// 
			this.linearGauge1.Dock = Wisej.Web.DockStyle.Fill;
			this.linearGauge1.Location = new System.Drawing.Point(8, 8);
			this.linearGauge1.Name = "linearGauge1";
			this.linearGauge1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"width\":\"100%\",\"height\":\"100%\"}")));
			this.linearGauge1.Size = new System.Drawing.Size(437, 297);
			this.linearGauge1.TabIndex = 0;
			this.linearGauge1.Text = "linearGauge1";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.AutoSize = false;
			this.numericUpDown1.Label.Size = 50;
			this.numericUpDown1.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.numericUpDown1.LabelText = "Value";
			this.numericUpDown1.Location = new System.Drawing.Point(28, 34);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(195, 60);
			this.numericUpDown1.TabIndex = 1;
			// 
			// LinearGauge
			// 
			this.Name = "LinearGauge";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion2.LinearGauge linearGauge1;
		private NumericUpDown numericUpDown1;
	}
}

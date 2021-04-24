namespace Wisej.Web.Ext.Syncfusion2.Test.Component
{
	partial class Spreadsheet
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
            this.spreadsheet1 = new Wisej.Web.Ext.Syncfusion2.Spreadsheet();
            this.button1 = new Wisej.Web.Button();
            this.button2 = new Wisej.Web.Button();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/spreadsheet/getting-started/";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/spreadsheet";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.button1, 0);
            this.groupBox1.Controls.SetChildIndex(this.button2, 0);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.spreadsheet1);
            // 
            // spreadsheet1
            // 
            this.spreadsheet1.Dock = Wisej.Web.DockStyle.Fill;
            this.spreadsheet1.Location = new System.Drawing.Point(8, 8);
            this.spreadsheet1.Name = "spreadsheet1";
            this.spreadsheet1.Size = new System.Drawing.Size(437, 297);
            this.spreadsheet1.TabIndex = 0;
            this.spreadsheet1.Text = "spreadsheet1";
            this.spreadsheet1.WebRequest += new Wisej.Web.WebRequestHandler(this.spreadsheet1_WebRequest);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Hide Headers";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 27);
            this.button2.TabIndex = 2;
            this.button2.Text = "Sample Data";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Spreadsheet
            // 
            this.Name = "Spreadsheet";
            this.Load += new System.EventHandler(this.Spreadsheet_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion2.Spreadsheet spreadsheet1;
        private Button button1;
        private Button button2;
    }
}

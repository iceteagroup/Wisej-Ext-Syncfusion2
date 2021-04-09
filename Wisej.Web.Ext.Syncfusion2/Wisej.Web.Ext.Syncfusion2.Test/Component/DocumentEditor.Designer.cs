namespace Wisej.Web.Ext.Syncfusion2.Test.Component
{
	partial class DocumentEditor
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
            this.documentEditor1 = new Wisej.Web.Ext.Syncfusion2.DocumentEditor();
            this.button1 = new Wisej.Web.Button();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/document-editor/getting-start" +
    "ed/";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/document-editor-container" +
    "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.button1, 0);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.documentEditor1);
            // 
            // documentEditor1
            // 
            this.documentEditor1.Dock = Wisej.Web.DockStyle.Fill;
            this.documentEditor1.Location = new System.Drawing.Point(8, 8);
            this.documentEditor1.Name = "documentEditor1";
            this.documentEditor1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"enableEditor\":false}")));
            this.documentEditor1.Size = new System.Drawing.Size(437, 297);
            this.documentEditor1.TabIndex = 0;
            this.documentEditor1.Text = "documentEditor1";
            this.documentEditor1.WebRequest += new Wisej.Web.WebRequestHandler(this.documentEditor1_WebRequest);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Easy Migrations Article";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DocumentEditor
            // 
            this.Name = "DocumentEditor";
            this.Load += new System.EventHandler(this.DocumentEditor_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion2.DocumentEditor documentEditor1;
        private Button button1;
    }
}

///////////////////////////////////////////////////////////////////////////////
//
// (C) 2020 ICE TEA GROUP LLC - ALL RIGHTS RESERVED
//
// 
//
// ALL INFORMATION CONTAINED HEREIN IS, AND REMAINS
// THE PROPERTY OF ICE TEA GROUP LLC AND ITS SUPPLIERS, IF ANY.
// THE INTELLECTUAL PROPERTY AND TECHNICAL CONCEPTS CONTAINED
// HEREIN ARE PROPRIETARY TO ICE TEA GROUP LLC AND ITS SUPPLIERS
// AND MAY BE COVERED BY U.S. AND FOREIGN PATENTS, PATENT IN PROCESS, AND
// ARE PROTECTED BY TRADE SECRET OR COPYRIGHT LAW.
//
// DISSEMINATION OF THIS INFORMATION OR REPRODUCTION OF THIS MATERIAL
// IS STRICTLY FORBIDDEN UNLESS PRIOR WRITTEN PERMISSION IS OBTAINED
// FROM ICE TEA GROUP LLC.
//
///////////////////////////////////////////////////////////////////////////////


namespace Wisej.Web.Ext.Syncfusion2
{
	/// <summary>
	/// The Document Editor component is used to create, edit, view, and print Word documents in web applications. 
	/// All the user interactions and editing operations that run purely in the client-side provides much faster 
	/// editing experience to the users.
	/// </summary>
	public class DocumentEditor : ej2Base
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="DocumentEditor"/> class.
		/// </summary>
		public DocumentEditor() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="DocumentEditor"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public DocumentEditor(object options) : base("ej.documenteditor.DocumentEditorContainer", options)
		{
			this.WiredEvents = new[] {
				"beforePaneSwitch",
				"commentDelete",
				"commentChange",
				"contentControl",
				"customContextMenuSelect",
				"documentChange",
				"selectionChange",
				"serviceFailure",
				"toolbarClick",
				"trackChange"
			};
		}
	}
}

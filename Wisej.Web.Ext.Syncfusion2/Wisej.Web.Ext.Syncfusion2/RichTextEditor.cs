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
	/// The rich text editor component is WYSIWYG ("what you see is what you get") editor that provides the best
	/// user experience to create and update the content. Users can format their content using standard toolbar commands.
	/// </summary>
	public class RichTextEditor : ej2Base
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="RichTextEditor"/> class.
		/// </summary>
		public RichTextEditor() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="RichTextEditor"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public RichTextEditor(object options) : base("ej.richtexteditor.RichTextEditor", options)
		{
			this.WiredEvents = new[] {
				"afterImageDelete",
				"blur",
				"change",
				"focus",
				"imageSelected",
				"imageUploadFailed",
				"imageUploadSuccess",
				"imageUploading",
				"quickToolbarClose",
				"quickToolbarOpen",
				"toolbarClick"
			};
		}
	}
}

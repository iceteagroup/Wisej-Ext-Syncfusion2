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
	/// The PDF Viewer component enables you to view and print the PDF files.
	/// </summary>
	public class PDFViewer : ej2Base
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="PDFViewer"/> class.
		/// </summary>
		public PDFViewer() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="PDFViewer"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public PDFViewer(object options) : base("ej.pdfviewer.PdfViewer", options)
		{
			this.WiredEvents = new[] {
				"addSignature",
				"annotationAdd",
				"annotationDoubleClick",
				"annotationMouseLeave",
				"annotationMouseover",
				"annotationMove",
				"annotationPropertiesChange",
				"annotationRemove",
				"annotationResize",
				"annotationSelect",
				"bookmarkClick",
				"documentLoad",
				"documentLoadFailed",
				"documentUnload",
				"downloadEnd",
				"downloadStart",
				"exportSuccess",
				"hyperlinkClick",
				"hyperlinkMouseOver",
				"importFailed",
				"importStart",
				"importSuccess",
				"moveSignature",
				"pageChange",
				"pageClick",
				"pageMouseover",
				"printEnd",
				"printStart",
				"removeSignature",
				"resizeSignature",
				"signaturePropertiesChanged",
				"signatureSelect",
				"textSearchComplete",
				"textSearchHighlight",
				"textSearchStart",
				"textSelectionStart",
				"textSelectionEnd",
				"thumbnailClick",
				"zoomChange"
			};
		}
	}
}

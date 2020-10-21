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
	/// The Grid is used to display and manipulate tabular data with configuration options to control
	/// the way the data is presented and manipulated.
	/// </summary>
	public class Grid : ej2Base
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="Grid"/> class.
		/// </summary>
		public Grid() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="Grid"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public Grid(object options) : base("ej.grids.Grid", options)
		{
			this.WiredEvents = new[] {
				"actionBegin",
				"actionComplete",
				"actionFailure",
				"batchAdd",
				"batchCancel",
				"batchDelete",
				"beforeAutoFill",
				"beforeBatchAdd",
				"beforeBatchDelete",
				"beforeBatchSave",
				"beforeCopy",
				"beforeDataBound",
				"beforeExcelExport",
				"beforeOpenColumnChooser",
				"beforePaste",
				"beforePdfExport",
				"beforePrint",
				"beginEdit",
				"cellDeselected",
				"cellDeselecting",
				"cellEdit",
				"cellSave",
				"cellSaved",
				"cellSelected",
				"cellSelecting",
				"checkBoxChange",
				"columnDataStateChange",
				"columnDrag",
				"columnDragStart",
				"columnDrop",
				"columnMenuClick",
				"columnMenuOpen",
				"commandClick",
				"contextMenuOpen",
				"dataBound",
				"dataSourceChanged",
				"dataStateChange",
				"detailDataBound",
				"excelExportComplete",
				"exportDetailDataBound",
				"keyPressed",
				"pdfExportComplete",
				"printComplete",
				"recordClick",
				"recordDoubleClick",
				"resizeStart",
				"resizeStop",
				"resizing",
				"rowDeselected",
				"rowDeselecting",
				"rowDrag",
				"rowDragStart",
				"rowDragStartHelper",
				"rowDrop",
				"rowSelected",
				"rowSelecting",
				"toolbarClick"
			};
		}
	}
}

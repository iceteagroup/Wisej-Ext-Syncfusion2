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
	/// The Spreadsheet component is used to organize and analyze data in tabular format.
	/// It has a built-in calculation library that supports most commonly used formulas.
	/// </summary>
	public class Spreadsheet : ej2Base
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="Spreadsheet"/> class.
		/// </summary>
		public Spreadsheet() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="Spreadsheet"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public Spreadsheet(object options) : base("ej.spreadsheet.Spreadsheet", options)
		{
			this.WiredEvents = new[] {
				"actionBegin",
				"actionComplete",
				"afterHyperlinkClick",
				"afterHyperlinkCreate",
				"beforeCellFormat",
				"beforeCellRender",
				"beforeCellSave",
				"beforeDataBound",
				"beforeHyperlinkClick",
				"beforeHyperlinkCreate",
				"beforeOpen",
				"beforeSave",
				"beforeSelect",
				"beforeSort",
				"cellEdit",
				"cellEditing",
				"cellSave",
				"contextMenuBeforeClose",
				"contextMenuBeforeOpen",
				"contextMenuItemSelect",
				"dataBound",
				"dialogBeforeOpen",
				"fileMenuBeforeClose",
				"fileMenuBeforeOpen",
				"fileMenuItemSelect",
				"openComplete",
				"openFailure",
				"saveComplete",
				"select",
				"sortComplete"
			};
		}
	}
}

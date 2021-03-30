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
	/// The Gantt provides support for automatic and manual task scheduling modes. It is used to 
	/// indicate whether the start date and end date of all the tasks will be automatically validated or not.
	/// </summary>
	public class Gantt : ej2Base
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="Gantt"/> class.
		/// </summary>
		public Gantt() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="Gantt"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public Gantt(object options) : base("ej.gantt.Gantt", options)
		{
			this.WiredEvents = new[] {
				"beforeExcelExport",
				"beforePdfExport",
				"cellDeselected",
				"cellDeselecting",
				"cellEdit",
				"cellSelected",
				"cellSelecting",
				"collapsed",
				"collapsing",
				"columnDrag",
				"columnDrop",
				"columnMenuClick",
				"contextMenuClick",
				"expanded",
				"rowDrag",
				"rowDrop",
				"rowSelected",
				"splitterResized",
				"toolbarClick"
			};
		}
	}
}

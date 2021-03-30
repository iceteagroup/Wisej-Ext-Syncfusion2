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
	/// The TreeGrid component is a feature-rich control used to visualize 
	/// self-referential hierarchical data effectively in a tabular format.
	/// </summary>
	public class TreeGrid : ej2Base
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="TreeGrid"/> class.
		/// </summary>
		public TreeGrid() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="TreeGrid"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public TreeGrid(object options) : base("ej.treegrid.TreeGrid", options)
		{
			this.WiredEvents = new[] {
				"cellEdit",
				"cellSave",
				"cellSelected",
				"checkboxChange",
				"columnDrag",
				"columnDrop",
				"columnMenuOpen",
				"columnMenuClick",
				"contextMenuClick",
				"contextMenuOpen",
				"rowDrag",
				"rowDrop",
				"rowSelected",
				"toolbarClick"
			};
		}
	}
}

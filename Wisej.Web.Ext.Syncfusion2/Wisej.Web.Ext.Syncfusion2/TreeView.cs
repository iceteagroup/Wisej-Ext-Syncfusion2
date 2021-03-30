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
	/// The TreeView component is used to represent hierarchical data in a tree like 
	/// structure with advanced functions to edit, drag and drop, select with CheckBox and more.
	/// </summary>
	public class TreeView : ej2Base
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="TreeView"/> class.
		/// </summary>
		public TreeView() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="TreeView"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public TreeView(object options) : base("ej.navigations.TreeView", options)
		{
			this.WiredEvents = new[] {
				"keyPress",
				"nodeChecked",
				"nodeClicked",
				"nodeCollapsed",
				"nodeDragging",
				"nodeDropped",
				"nodeEdited",
				"nodeExpanded",
				"nodeSelected"
			};
		}
	}
}

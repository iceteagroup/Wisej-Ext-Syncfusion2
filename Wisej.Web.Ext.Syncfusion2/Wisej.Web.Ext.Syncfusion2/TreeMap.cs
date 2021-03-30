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
	/// The tree map control provides a simple and effective way to visualize flat or hierarchical data 
	/// as clustered rectangles with a specific, weighted attribute determining the size of each rectangle.
	/// </summary>
	public class TreeMap : ej2Base
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="TreeMap"/> class.
		/// </summary>
		public TreeMap() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="TreeMap"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public TreeMap(object options) : base("ej.treemap.TreeMap", options)
		{
			this.WiredEvents = new[] {
				"click",
				"doubleClick",
				"itemClick",
				"itemHighlight",
				"itemMove",
				"itemSelected",
				"mouseMove",
				"rightClick"
			};
		}
	}
}

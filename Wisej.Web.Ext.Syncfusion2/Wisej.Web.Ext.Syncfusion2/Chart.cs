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
	/// The Chart control is used to visualize the data with user interactivity and provides 
	/// customizing options to configure the data visually.
	/// </summary>
	public class Chart : ej2Base
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="Chart"/> class.
		/// </summary>
		public Chart() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="Chart"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public Chart(object options) : base("ej.charts.Chart", options)
		{
			this.WiredEvents = new[] {
				"afterExport",
				"axisLabelClick",
				"chartMouseClick",
				"chartMouseDown",
				"chartMouseLeave",
				"chartMouseMove",
				"chartMouseUp",
				"drag",
				"dragComplete",
				"dragEnd",
				"dragStart",
				"legendClick",
				"multiLevelLabelClick",
				"pointClick",
				"pointDoubleClick",
				"pointMove",
				"resized",
				"scrollChanged",
				"scrollEnd",
				"scrollStart",
				"selectionComplete",
				"zoomComplete"
			};
		}
	}
}

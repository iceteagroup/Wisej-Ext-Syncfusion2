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
	/// The pivot table is an easily configurable, presentation-quality business control used for 
	/// visualizing relational data sources in cross-tabular format. It is displayed with drill-up 
	/// and drill-down capabilities and allows users to easily aggregate data.
	/// </summary>
	public class PivotView : ej2Base
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="PivotView"/> class.
		/// </summary>
		public PivotView() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="PivotView"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public PivotView(object options) : base("ej.pivotview.PivotView", options)
		{
			this.WiredEvents = new[] {
				"beforeExport",
				"beginDrillThrough",
				"calculatedFieldCreate",
				"cellClick",
				"cellSelected",
				"cellSelecting",
				"chartSeriesCreated",
				"dataBound",
				"drill",
				"drillThrough",
				"editCompleted",
				"fieldDragStart",
				"fieldListRefreshed",
				"fieldRemove",
				"hyperlinkCellClick",
				"memberEditorOpen",
				"memberFiltering",
				"onFieldDropped",
				"toolbarClick"
			};
		}
	}
}

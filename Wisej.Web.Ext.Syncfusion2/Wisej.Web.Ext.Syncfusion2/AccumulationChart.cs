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
	/// In EJ2, accumulation chart is implemented as a separate control to avoid the axis related logics. 
	/// The dependencies for accumulation chart is same as chart control.
	/// </summary>
	public class AccumulationChart : ej2Base
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="AccumulationChart"/> class.
		/// </summary>
		public AccumulationChart() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="AccumulationChart"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public AccumulationChart(object options) : base("ej.charts.AccumulationChart", options)
		{
			this.WiredEvents = new[] {
				""
			};
		}
	}
}

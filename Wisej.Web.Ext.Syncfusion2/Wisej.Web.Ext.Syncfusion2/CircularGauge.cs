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
	/// The circular gauge control is ideal to visualize numeric values over a circular scale. 
	/// All the circular gauge elements are rendered using Scalable Vector Graphics(SVG).
	/// </summary>
	public class CircularGauge : ej2Base
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="CircularGauge"/> class.
		/// </summary>
		public CircularGauge() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="CircularGauge"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public CircularGauge(object options) : base("ej.circulargauge.CircularGauge", options)
		{
			this.WiredEvents = new[] {
				"beforePrint",
				"dragMove",
				"dragStart",
				"dragEnd",
				"gaugeMouseDown",
				"gaugeMouseLeave",
				"gaugeMouseMove",
				"gaugeMouseUp",
				"radiusCalculate",
			};
		}
	}
}

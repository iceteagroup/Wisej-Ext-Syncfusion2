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
	/// Very small chart control drawn without axes or coordinates. 
	/// The sparklines are easy to interpret and convey more information 
	/// to users by visualizing data in a small amount of space.
	/// </summary>
	public class Sparkline : ej2Base
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="Sparkline"/> class.
		/// </summary>
		public Sparkline() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="Sparkline"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public Sparkline(object options) : base("ej.charts.Sparkline", options)
		{
			this.WiredEvents = new[] {
				"pointRegionMouseClick",
				"pointRegionMouseMove",
				"sparklineMouseClick",
				"sparklineMouseMove"
			};
		}
	}
}

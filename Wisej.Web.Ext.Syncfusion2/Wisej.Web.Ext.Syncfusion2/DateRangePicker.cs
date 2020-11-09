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
	/// TODO: Fill out summary.
	/// </summary>
	public class DateRangePicker : ej2Base
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="DateRangePicker"/> class.
		/// </summary>
		public DateRangePicker() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="DateRangePicker"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public DateRangePicker(object options) : base("ej.calendars.DateRangePicker", "<input width='100%' height='100%'>", options)
		{
			this.WiredEvents = new[] {
				""
			};
		}
	}
}

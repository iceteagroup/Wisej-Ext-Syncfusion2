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
	/// Represents the DatePicker component that allows user to select or enter a date value.
	/// </summary>
	public class DatePicker : ej2Base
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="DatePicker"/> class.
		/// </summary>
		public DatePicker() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="DatePicker"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public DatePicker(object options) : base("ej.calendars.DatePicker", "<input type='text'>", options)
		{
			this.WiredEvents = new[] {
				"blur",
				"change",
				"cleared",
				"close",
				"focus",
				"navigated",
				"open"
			};
		}
	}
}

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
	/// The schedule component is an event calendar that facilitates almost all the basic Outlook and 
	/// Google Calendar features, allowing the user to plan and manage appointments and time efficiently.
	/// </summary>
	public class Schedule : ej2Base
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="Schedule"/> class.
		/// </summary>
		public Schedule() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="Schedule"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public Schedule(object options) : base("ej.schedule.Schedule", options)
		{
			this.WiredEvents = new[] {
				"cellClick",
				"cellDoubleClick",
				"drag",
				"dragStart",
				"dragStop",
				"eventClick",
				"hover",
				"moreEventsClick",
				"navigating",
				"popupClose",
				"popupOpen",
				"select"
			};
		}
	}
}

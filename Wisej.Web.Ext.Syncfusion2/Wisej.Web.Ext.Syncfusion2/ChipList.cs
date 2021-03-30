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
	/// Chip is a small block of essential information that triggers an event on click action. 
	/// It contains the text, an image, or both, mostly used in contacts, mails or filter tags.
	/// </summary>
	public class ChipList : ej2Base
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="ChipList"/> class.
		/// </summary>
		public ChipList() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="ChipList"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public ChipList(object options) : base("ej.buttons.ChipList", options)
		{
			this.WiredEvents = new[] {
				"click",
				"delete"
			};
		}
	}
}

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
	/// The HTML5/JavaScript In-Place Editor control is most useful for editing a value dynamically within its context (in-place).
	/// It has built-in support to handle all the form controls, including TextBox, Dropdown List, DatePicker, and Rich Text Editor. 
	/// It features inline and pop-up modes, and customizable user interface (UI) and events.
	/// </summary>
	public class InPlaceEditor : ej2Base
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="InPlaceEditor"/> class.
		/// </summary>
		public InPlaceEditor() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="InPlaceEditor"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public InPlaceEditor(object options) : base("ej.inplaceeditor.InPlaceEditor", options)
		{
			this.WiredEvents = new[] {
				"change",
				"cancelClick",
				"submitClick",
			};
		}
	}
}

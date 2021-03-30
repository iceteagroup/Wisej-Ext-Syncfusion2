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
	/// SplitButton has primary and secondary button. Primary button is used to select default action 
	/// and secondary button is used to toggle contextual overlays for displaying list of action items.
	/// </summary>
	public class SplitButton : ej2Base
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="SplitButton"/> class.
		/// </summary>
		public SplitButton() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="SplitButton"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public SplitButton(object options) : base("ej.splitbuttons.SplitButton", "<button>", options)
		{
			this.WiredEvents = new[] {
				"click",
				"close",
				"open",
				"select"
			};
		}
	}
}

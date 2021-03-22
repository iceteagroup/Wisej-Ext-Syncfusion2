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
	/// The Palette shows a set of nodes and connectors. 
	/// It allows you to drag and drop the nodes and connectors into the Diagram.
	/// </summary>
	public class SymbolPalette : ej2Base
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="SymbolPalette"/> class.
		/// </summary>
		public SymbolPalette() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="Slider"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public SymbolPalette(object options) : base("ej.diagrams.SymbolPalette", options)
		{
		}
	}
}

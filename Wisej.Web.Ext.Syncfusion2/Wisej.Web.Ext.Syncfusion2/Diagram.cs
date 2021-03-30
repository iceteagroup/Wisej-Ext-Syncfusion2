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
	/// The diagram component visually represents information. It is also used to create diagrams 
	/// like flow charts, organizational charts, mind maps, and BPMN either through code or a visual interface.
	/// </summary>
	public class Diagram : ej2Base
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="Diagram"/> class.
		/// </summary>
		public Diagram() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="Diagram"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public Diagram(object options) : base("ej.diagrams.Diagram", options)
		{
			this.WiredEvents = new[] {
				"click",
				"collectionChange",
				"connectionChange",
				"contextMenuClick",
				"contextMenuOpen",
				"dataLoaded",
				"doubleClick",
				"dragEnter",
				"dragLeave",
				"dragOver",
				"drop",
				"expandStateChange",
				"historyChange",
				"mouseEnter",
				"mouseLeave",
				"mouseOver",
				"positionChange",
				"propertyChange",
				"rotateChange",
				"scrollChange",
				"segmentCollectionChange",
				"selectionChange",
				"sizeChange",
				"sourcePointChange",
				"targetPointChange",
				"textEdit"
			};
		}
	}
}

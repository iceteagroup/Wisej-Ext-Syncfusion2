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
	/// The Maps component is used to visualize the geographical data and represent the statistical data of 
	/// a particular geographical area on earth with user interactivity, and provides various customizing options.
	/// </summary>
	public class Maps : ej2Base
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="Maps"/> class.
		/// </summary>
		public Maps() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="Maps"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public Maps(object options) : base("ej.maps.Maps", options)
		{
			this.WiredEvents = new[] {
				"bubbleClick",
				"bubbleMouseMove",
				"click",
				"doubleClick",
				"itemHighlight",
				"itemSelection",
				"markerClick",
				"markerClusterClick",
				"markerClusterMouseMove",
				"markerMouseMove",
				"pan",
				"rightClick",
				"shapeHighlight",
				"shapeSelected",
				"zoom"
			};
		}
	}
}

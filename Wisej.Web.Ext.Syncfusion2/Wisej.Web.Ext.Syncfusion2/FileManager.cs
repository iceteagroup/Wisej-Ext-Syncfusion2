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
	/// The File Manager component is used to explore a file system through a web application, 
	/// similar to the windows explorer for windows. It supports the basic file operations such as create, rename, delete.
	/// </summary>
	public class FileManager : ej2Base
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="FileManager"/> class.
		/// </summary>
		public FileManager() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="FileManager"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public FileManager(object options) : base("ej.filemanager.FileManager", options)
		{
			this.WiredEvents = new[] {
				"beforeDownload",
				"beforeImageLoad",
				"beforePopupClose",
				"beforePopupOpen",
				"beforeSend",
				"failure",
				"fileDragStart",
				"fileDragStop",
				"fileDragging",
				"fileDropped",
				"fileLoad",
				"fileOpen",
				"fileSelect",
				"fileSelection",
				"menuClick",
				"menuOpen",
				"popupClose",
				"popupOpen",
				"success",
				"toolbarClick"
			};
		}
	}
}

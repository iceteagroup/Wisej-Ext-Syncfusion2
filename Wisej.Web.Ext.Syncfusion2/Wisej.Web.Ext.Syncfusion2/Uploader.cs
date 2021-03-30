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
	/// The uploader component allows to upload images, documents, and other files from local to server.
	/// </summary>
	public class Uploader : ej2Base
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="Uploader"/> class.
		/// </summary>
		public Uploader() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="Uploader"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public Uploader(object options) : base("ej.inputs.Uploader", "<input width='100%' height='100%'>", options)
		{
			this.WiredEvents = new[] {
				"change",
				"chunkFailure",
				"chunkSuccess",
				"chunkUploading",
				"clearing",
				"failure",
				"pausing",
				"progress",
				"resuming",
				"selected",
				"success",
				"uploading"
			};
		}
	}
}

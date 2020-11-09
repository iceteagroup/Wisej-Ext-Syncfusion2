//# sourceURL=wisej.web.ext.Syncfusion2Widget.DocumentEditor.js

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

/**
 * Process the options map before it is used to
 * create or update the widget.
 */
this.filterOptions = function (options) {

	options.width = "100%";
	options.height = "100%";

	if (!options.serviceUrl) {
		var serviceUrl = this.getServiceUrl();
		options.serviceUrl = serviceUrl;
		options.serverActionSettings = {
			load: "?action=load"
		}
	}
};

this.openFile = function (sfdt) {

	if (!this.widget) {
		var me = this;
		this.addListenerOnce("Initialized", function () {

			me.openFile(sfdt);
		})
		return;
	}

	if (this.widget.documentEditor == null)
		this.widget.documentEditor = new ej.documenteditor.DocumentEditor();

	this.widget.documentEditor.open(sfdt);
}

this.initWidget = function () {

	this.fireEvent("Initialized");
}
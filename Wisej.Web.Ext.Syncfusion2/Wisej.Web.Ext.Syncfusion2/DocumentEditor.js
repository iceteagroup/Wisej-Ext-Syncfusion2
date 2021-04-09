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

// Returns a data map that can be converted to JSON.
this.filterEventData = function (args) {

	switch (args.name) {
		case "":
			break;

		default:
			break;
    }
}

/**
 * Process the options map before it is used to
 * create or update the widget.
 */
this.filterOptions = function (options) {

	// fill the widget.
	options.width = "100%";
	options.height = "100%";

	debugger;
	options.serviceUrl = this.getServiceUrl() + "?action=service";

	// detect widget creation.
	var me = this;
	options.created = function () {
		me.fireEvent("Initialized");
	};
};

/**
 * Processes opening documents.
 * @param {any} sfdt the document string.
 */
this.openFile = function (sfdt) {

	var me = this;
	if (!this.widget) {
		this.addListenerOnce("Initialized", function () {

			me.openFile(sfdt);
		});
		return;
	}

	if (this.widget.documentEditor == null)
		this.widget.documenteditor = new ej.documenteditor.DocumentEditor();
    
	setTimeout(function () {
		me.widget.documentEditor.open(sfdt);
	}, 1000);
}
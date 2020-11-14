//# sourceURL=wisej.web.ext.Syncfusion2Widget.DatePicker.js

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
 * Resizes the hosted widget to always fit our container.
 */
this.resizeWidget = function () {

	var widget = this.widget;
	if (widget) {

		var bounds = this.getBounds();
		widget.width = bounds.width - 2;
	}
}

// Returns a data map that can be converted to JSON.
this.filterEventData = function (args) {

	var data = {};
	switch (args.name) {

		case "change":
			data = {
				isInteracted: args.isInteracted,
				value: args.value,
				values: args.values
			};
			break;

		case "navigated":
			data = {
				date: args.date,
				view: args.view
			};
			break;

		default:
			break;
	}
	return data;
}
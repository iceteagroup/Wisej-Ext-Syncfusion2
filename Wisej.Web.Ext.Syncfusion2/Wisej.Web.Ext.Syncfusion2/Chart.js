//# sourceURL=wisej.web.ext.Syncfusion2Widget.Chart.js

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

	var data = {};
	switch (args.name) {

		case "axisLabelClick":
			data = {
				index: args.index,
				labelID: args.labelID,
				text: args.text,
				value: args.value
			};
			break;

		case "legendClick":
			data = {
				legendShape: args.legendShape,
				legendText: args.legendText
			};
			break;

		case "multiLevelLabelClick":
			data = {
				text: args.text
			};
			break;

		case "pointMove":
		case "pointClick":
		case "pointDoubleClick":
			data = {
				pageX: args.pageX,
				pageY: args.pageY,
				pointIndex: args.pointIndex,
				seriesIndex: args.seriesIndex
			};
			break;

		case "selectionComplete":
			data = {
				selectedDataValues: args.selectedDataValues
			};
			break;

		default:
			break;
	}

	return data;
}
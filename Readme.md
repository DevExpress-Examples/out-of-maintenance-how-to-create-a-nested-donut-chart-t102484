<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128567851/14.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T102484)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# How to create a Nested Donut chart


The following example demonstrates how to create a<strong> Nested Donut </strong>chart. <br />To do this, it is necessary to assign the <a href="https://documentation.devexpress.com/#Silverlight/DevExpressXpfChartsChartControl_Diagramtopic">ChartControl.Diagram </a> property to <a href="https://documentation.devexpress.com/#Silverlight/clsDevExpressXpfChartsSimpleDiagram2Dtopic">SimpleDiagram2D</a>, and then add two <strong>NestedDonutSeries2D</strong> objects with points to the diagram's <a href="https://documentation.devexpress.com/#Silverlight/DevExpressXpfChartsDiagram_Seriestopic">Diagram.Series </a> collection.<br />Also, this example shows how to change the color of each series point according to its values using the <a href="https://documentation.devexpress.com/#Silverlight/DevExpressXpfChartsChartControl_CustomDrawSeriesPointtopic">ChartControl.CustomDrawSeriesPoint </a> event. As a result, segments of an outer donut representing kinds of products are colored with a specific Product group color (an inner donut).

<br/>



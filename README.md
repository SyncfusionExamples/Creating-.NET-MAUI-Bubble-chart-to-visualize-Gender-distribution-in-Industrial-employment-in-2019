# Creating-.NET-MAUI-Bubble-chart-to-visualize-Gender-distribution-in-Industrial-employment-in-2019
This Blog explains the Gender Distribution in Industrial Employment in 2019 using [Syncfusion .NET MAUI Bubble Chart](https://www.syncfusion.com/maui-controls/maui-cartesian-charts/chart-types/maui-bubble-chart).
A Bubble chart is a type of scatter plot that displays three dimensions of data, with the position of each bubble determined by the first two dimensions (x and y axes) and the size of the bubble representing the third dimension. This visualization is useful for comparing and analyzing relationships between data points in three variables simultaneously.

To render a bubble chart, create an instance of [BubbleSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.BubbleSeries.html?tabs=tabid-1%2Ctabid-28), and add it to the [Series](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_Series) collection property of [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html?tabs=tabid-1).
### Customizing the chart appearence
In this example, we have enhanced the appearence of our Bubble chart by customizing various elements, such as appearence of the axis elements, tooltip and title.
### Adding the Customized Title
A Title can improve the readability of the plotted data with a description in the chart.
### Axis Customization
We can customize axis elements, including the axis title, axis label style, line style and tick syle.
### Tooltip Customization
Using a tooltip, we can display the data in the data points. By including the Tooltiptemplate, we can display additional information about the datapoint.
## Selection Behavior 
The .NET MAUI SfCartesianChart supports selection that allows you to select a series by using [SeriesSelectionBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SeriesSelectionBehavior.html). It provides the ability to customize the selected and unselected series brush with the help of [Type](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSelectionBehavior.html#Syncfusion_Maui_Charts_ChartSelectionBehavior_Type) property and [SelectionChanging](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSelectionBehavior.html#Syncfusion_Maui_Charts_ChartSelectionBehavior_SelectionChanging) event.

### Output
![ScreenCapture-5-31-2024-101806-A](https://github.com/SyncfusionExamples/Creating-.NET-MAUI-Bubble-chart-to-visualize-Gender-distribution-in-Industrial-employment-in-2019/assets/126753532/840ab012-e645-4309-9bc1-d3f398fe84bc)

## Troubleshooting
### Path too long exception
If you are facing a path too long exception when building this example project, close Visual Studio and rename the repository to a shorter name and build the project.

For the step by step procedure, refer to the [Gender Distribution in Industrial Employment Blog](https://www.syncfusion.com/blogs/post/dotnetmaui-bubble-chart-gender-parity).

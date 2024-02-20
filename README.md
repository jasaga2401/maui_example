In Maui using C# application to show how to display a simple bar chart using Syncfusion charts (eg you will need a license key) and outputting the chart using XAML.

You need to include the registration Licensing key for Syncfusion in the file 'App.xaml.cs'

You need to add a class person where you can setup the Name and Height properties. 

You need to add a class DataViewModel where you can add static data that is stored in a list 'Data' linked to the class person to store the data. 

You can then bind the data within XAML (local:DataViewModel)

Here is the URL of a video you can follow to help guide you through the various steps to create a chart. 
https://help.syncfusion.com/maui/cartesian-charts/getting-started

The use of a class to setup fields and the MVVM (Model-view-viewmodel) is a popular structure for arranging and output data.  


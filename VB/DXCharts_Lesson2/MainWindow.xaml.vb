Imports Microsoft.VisualBasic
Imports System.Windows

Namespace DXCharts_Lesson2

	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()

			carSeries.DataSource = New CarsDBDataSetTableAdapters.CarsTableAdapter().GetData()
		End Sub
	End Class
End Namespace

Imports Microsoft.VisualBasic
Imports System.Windows

Namespace WpfApplication2

	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()

			carSeries.DataSource = New CarsDBDataSetTableAdapters.CarsTableAdapter().GetData()
		End Sub
	End Class
End Namespace

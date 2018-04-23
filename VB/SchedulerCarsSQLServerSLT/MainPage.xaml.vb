Imports Microsoft.VisualBasic
Imports System
Imports System.Windows
Imports System.Windows.Controls

Namespace SchedulerCarsSQLServerSLT
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub SchedulerStorage_AppointmentCollectionModified(ByVal sender As Object, ByVal e As EventArgs)
			If ddsAppointments.HasChanges Then
				ddsAppointments.SubmitChanges()
			End If
		End Sub

		Private Sub DomainDataSource_LoadedData(ByVal sender As Object, ByVal e As LoadedDataEventArgs)
			If e.HasError Then
				MessageBox.Show("Connection could not be established." & Environment.NewLine & e.Error.Message, "Connection Error", MessageBoxButton.OK)
				e.MarkErrorAsHandled()
			End If

			If sender Is ddsAppointments AndAlso firstLoad Then
				firstLoad = False
				If schedulerControl1.Storage.AppointmentStorage.Count > 0 Then
					schedulerControl1.Start = schedulerControl1.Storage.AppointmentStorage(0).Start
				End If
			End If
		End Sub

		Private Sub DomainDataSource_SubmittedChanges(ByVal sender As Object, ByVal e As SubmittedChangesEventArgs)
			If e.HasError Then
				MessageBox.Show(e.Error.ToString(), "Submit Changes Error", MessageBoxButton.OK)
				e.MarkErrorAsHandled()
			End If
		End Sub

		Private firstLoad As Boolean = True
	End Class
End Namespace

Imports Microsoft.VisualBasic
	Imports System
	Imports System.Collections.Generic
	Imports System.ComponentModel
	Imports System.ComponentModel.DataAnnotations
	Imports System.Data
	Imports System.Linq
	Imports System.ServiceModel.DomainServices.EntityFramework
	Imports System.ServiceModel.DomainServices.Hosting
	Imports System.ServiceModel.DomainServices.Server
Namespace SchedulerCarsSQLServerSLT.Web


	' Implements application logic using the CarsXtraSchedulingEntities context.
	' TODO: Add your application logic to these methods or in additional methods.
	' TODO: Wire up authentication (Windows/ASP.NET Forms) and uncomment the following to disable anonymous access
	' Also consider adding roles to restrict access as appropriate.
	' [RequiresAuthentication]
	<EnableClientAccess()> _
	Public Class SchedulingDomainService
		Inherits LinqToEntitiesDomainService(Of CarsXtraSchedulingEntities)

		' TODO:
		' Consider constraining the results of your query method.  If you need additional input you can
		' add parameters to this method or create additional query methods with different names.
		' To support paging you will need to add ordering to the 'CarScheduling' query.
		Public Function GetCarScheduling() As IQueryable(Of CarScheduling)
			Return Me.ObjectContext.CarScheduling
		End Function

		Public Function GetCars() As IQueryable(Of Cars)
			Return Me.ObjectContext.Cars
		End Function

		Public Sub InsertCarScheduling(ByVal carScheduling As CarScheduling)
			If (carScheduling.EntityState <> EntityState.Detached) Then
				Me.ObjectContext.ObjectStateManager.ChangeObjectState(carScheduling, EntityState.Added)
			Else
				Me.ObjectContext.CarScheduling.AddObject(carScheduling)
			End If
		End Sub

		Public Sub UpdateCarScheduling(ByVal currentCarScheduling As CarScheduling)
			Me.ObjectContext.CarScheduling.AttachAsModified(currentCarScheduling, Me.ChangeSet.GetOriginal(currentCarScheduling))
		End Sub

		Public Sub DeleteCarScheduling(ByVal carScheduling As CarScheduling)
			If (carScheduling.EntityState <> EntityState.Detached) Then
				Me.ObjectContext.ObjectStateManager.ChangeObjectState(carScheduling, EntityState.Deleted)
			Else
				Me.ObjectContext.CarScheduling.Attach(carScheduling)
				Me.ObjectContext.CarScheduling.DeleteObject(carScheduling)
			End If
		End Sub
	End Class
End Namespace



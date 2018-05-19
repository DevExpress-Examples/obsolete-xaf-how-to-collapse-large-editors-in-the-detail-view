Imports Microsoft.VisualBasic
Imports System

Imports DevExpress.ExpressApp.Updating
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.Persistent.BaseImpl

Namespace WebSolution.Module
	Public Class Updater
		Inherits ModuleUpdater
		Public Sub New(ByVal session As Session, ByVal currentDBVersion As Version)
			MyBase.New(session, currentDBVersion)
		End Sub
		Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
			MyBase.UpdateDatabaseAfterUpdateSchema()

			Dim p As Person = Session.FindObject(Of Person)(CriteriaOperator.Parse("FirstName = ?", "Click here to open the detail view"))
			If p Is Nothing Then
				p = New Person(Session)
				p.FirstName = "Click here to open the detail view"
				p.Save()
			End If
		End Sub
	End Class
End Namespace

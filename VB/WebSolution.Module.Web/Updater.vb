' Developer Express Code Central Example:
' How to collapse large editors in the detail view
' 
' Sometimes when your detail view contains a lot of editors, it is necessary to
' effectively use the space on the page. For example, usually editors in which
' collection properties are shown take a lot of space. You can reduce the space if
' you provide the capability to collapse large editors.
' In this example, I show
' how to put a large editor into the ASPxNavBar
' (ms-help://DevExpress.AspNet/clsDevExpressWebASPxNavBarASPxNavBartopic.htm)
' control that can expand/collapse its groups.
' 
' See Also:
' Access Editor
' Settings (ms-help://DevExpress.Xaf/CustomDocument2729.htm)
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E1499


Imports Microsoft.VisualBasic
Imports System

Imports DevExpress.ExpressApp.Updating
Imports DevExpress.ExpressApp
Imports DevExpress.Xpo

Namespace WebSolution.Module.Web
	Public Class Updater
		Inherits ModuleUpdater
		Public Sub New(ByVal objectSpace As ObjectSpace, ByVal currentDBVersion As Version)
			MyBase.New(objectSpace, currentDBVersion)
		End Sub
		Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
			MyBase.UpdateDatabaseAfterUpdateSchema()
		End Sub
	End Class
End Namespace

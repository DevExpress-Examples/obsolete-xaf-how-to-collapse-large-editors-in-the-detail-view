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
Namespace WebSolution.Module.Web
	Partial Public Class WebSolutionAspNetModule
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			' 
			' WebSolutionAspNetModule
			' 
			Me.RequiredModuleTypes.Add(GetType(WebSolution.Module.WebSolutionModule))
			Me.RequiredModuleTypes.Add(GetType(DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule))

		End Sub

		#End Region
	End Class
End Namespace

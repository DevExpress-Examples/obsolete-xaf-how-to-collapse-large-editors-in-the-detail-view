Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Editors
Imports System.Web.UI
Imports DevExpress.Web.ASPxNavBar

Namespace WebSolution.Module.Web
	Public Class CollapseLargeEditorDetailViewController
		Inherits ViewController
		Public Sub New()
			TargetViewType = ViewType.DetailView
		End Sub
		Protected Overrides Sub OnViewControlsCreated()
			MyBase.OnViewControlsCreated()
			Dim dv As DetailView = CType(View, DetailView)
			For Each item As DetailViewItem In dv.Items
				Dim control As Control = CType(item.Control, Control)
				Dim parent As Control = control.Parent
				If parent IsNot Nothing Then
					If TypeOf item Is ListPropertyEditor AndAlso dv.ViewEditMode = ViewEditMode.View Then
						Dim navbar As New ASPxNavBar()
						Dim index As Integer = parent.Controls.IndexOf(control)
						parent.Controls.RemoveAt(index)
						parent.Controls.AddAt(index, navbar)
						Dim group As New NavBarGroup(String.Empty)
						group.ExpandButtonPosition = ExpandButtonPosition.Left
						group.ContentTemplate = New NavBarGroupContentTemplate(control)
						navbar.Groups.Add(group)
					End If
				End If
			Next item
		End Sub
	End Class
	Public Class NavBarGroupContentTemplate
		Implements ITemplate
		Public Sub New(ByVal templateControl As Control)
			MyBase.New()
			templateControlCore = templateControl
		End Sub
		Private templateControlCore As Control = Nothing
		Public ReadOnly Property TemplateControl() As Control
			Get
				Return templateControlCore
			End Get
		End Property
		Public Sub InstantiateIn(ByVal container As Control) Implements ITemplate.InstantiateIn
			If TemplateControl IsNot Nothing Then
				container.Controls.Add(TemplateControl)
			End If
		End Sub
	End Class
End Namespace
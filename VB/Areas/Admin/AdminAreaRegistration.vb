Imports Microsoft.VisualBasic
Imports System.Web.Mvc

Namespace AreaSample.Areas.Admin
	Public Class AdminAreaRegistration
		Inherits AreaRegistration
		Public Overrides ReadOnly Property AreaName() As String
			Get
				Return "Admin"
			End Get
		End Property

		Public Overrides Sub RegisterArea(ByVal context As AreaRegistrationContext)
			context.MapRoute("Admin_default", "Admin/{controller}/{action}/{id}", New With {Key .action = "Index", Key .id = UrlParameter.Optional})
		End Sub
	End Class
End Namespace

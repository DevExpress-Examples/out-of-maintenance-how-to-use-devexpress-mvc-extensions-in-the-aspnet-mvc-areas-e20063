Imports Microsoft.VisualBasic
Imports System.Web.Mvc

Namespace AreaSample.Areas.User
	Public Class UserAreaRegistration
		Inherits AreaRegistration
		Public Overrides ReadOnly Property AreaName() As String
			Get
				Return "User"
			End Get
		End Property

		Public Overrides Sub RegisterArea(ByVal context As AreaRegistrationContext)
			context.MapRoute("User_default", "User/{controller}/{action}/{id}", New With {Key .action = "Index", Key .id = UrlParameter.Optional})
		End Sub
	End Class
End Namespace

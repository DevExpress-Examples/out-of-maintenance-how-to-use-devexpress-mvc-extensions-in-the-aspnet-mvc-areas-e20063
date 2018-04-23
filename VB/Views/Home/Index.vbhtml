@Html.DevExpress().Button( _
    Sub(b)
            b.Name = "btnGoToAdminArea"
            b.Text = "Go To Admin Area"
            b.RouteValues = New With {.Area = "Admin", .Controller = "Home", .Action = "Index"}
    End Sub).GetHtml()
<br />
@Html.DevExpress().Button( _
    Sub(b)
            b.Name = "btnGoToUserArea"
            b.Text = "Go To User Area"
            b.RouteValues = New With {.Area = "User", .Controller = "Home", .Action = "Index"}
    End Sub).GetHtml()
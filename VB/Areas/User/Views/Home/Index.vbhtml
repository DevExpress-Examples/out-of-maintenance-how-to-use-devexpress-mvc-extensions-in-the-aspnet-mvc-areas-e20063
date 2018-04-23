<script type="text/javascript">
    function OnClick(s, e) {
        alert("Hello From the User Area");
    }
</script>
@Html.DevExpress().Button( _
    Sub(b)
            b.Name = "btn"
            b.Text = "Say Hello"
            b.ClientSideEvents.Click = "OnClick"
    End Sub).GetHtml()
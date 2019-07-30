<!-- default file list -->
*Files to look at*:

* [Index.cshtml](./CS/Areas/Admin/Views/Home/Index.cshtml)
* [Web.config](./CS/Areas/Admin/Views/Web.config) (VB: [Web.config](./VB/Areas/Admin/Views/Web.config))
* [Index.cshtml](./CS/Areas/User/Views/Home/Index.cshtml)
* [Web.config](./CS/Areas/User/Views/Web.config) (VB: [Web.config](./VB/Areas/User/Views/Web.config))
* [Index.cshtml](./CS/Views/Home/Index.cshtml)
<!-- default file list end -->
# How to use DevExpress MVC Extensions in the ASP.NET MVC Areas
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e20063/)**
<!-- run online end -->


<p>When using Areas with DevExpress MVC Extensions, please make sure:</p><p>1. That the DevExpress references are added to the web.config files located inside of the Areas folders. (Please download and see this attached example.)</p><p>2. Specify the "Area =" attribute in the RouteValues of the MVC extension declaration of the CSHTML or VBHTML file. (see below).</p><p>This example illustrates this solution in action. It is an illustration of the <a href="https://www.devexpress.com/Support/Center/p/KA18612">KA18612: Why may the "System.Web.WebPages.Html.HtmlHelper' does not contain a definition for 'DevExpress' ..." error occur</a> KB Article. Refer to the Article for an explanation.<br />
All the Areas use the same base Layout View with the DevExpress scripts and styles registration hosted in the ~/Views/Shared/_Layout.cshtml.</p>

<br/>



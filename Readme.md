# How to use DevExpress MVC Extensions in the ASP.NET MVC Areas


<p>When using Areas with DevExpress MVC Extensions, please make sure:</p><p>1. That the DevExpress references are added to the web.config files located inside of the Areas folders. (Please download and see this attached example.)</p><p>2. Specify the "Area =" attribute in the RouteValues of the MVC extension declaration of the CSHTML or VBHTML file. (see below).</p><p>This example illustrates this solution in action. It is an illustration of the <a href="https://www.devexpress.com/Support/Center/p/KA18612">KA18612: Why may the "System.Web.WebPages.Html.HtmlHelper' does not contain a definition for 'DevExpress' ..." error occur</a> KB Article. Refer to the Article for an explanation.<br />
All the Areas use the same base Layout View with the DevExpress scripts and styles registration hosted in the ~/Views/Shared/_Layout.cshtml.</p>

<br/>



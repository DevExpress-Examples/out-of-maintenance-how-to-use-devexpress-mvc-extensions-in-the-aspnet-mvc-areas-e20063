<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128567021/14.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E20063)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
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



#pragma checksum "C:\Users\dogan\OneDrive\Masaüstü\BilgeAdam Boost (Doğan)\BasicAdminApp\BasicAdminApp\Views\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27034cef4ac309de262416a22382ea51110f071f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Index), @"mvc.1.0.view", @"/Views/Order/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27034cef4ac309de262416a22382ea51110f071f", @"/Views/Order/Index.cshtml")]
    public class Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BasicAdminApp.Models.OrderVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\dogan\OneDrive\Masaüstü\BilgeAdam Boost (Doğan)\BasicAdminApp\BasicAdminApp\Views\Order\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card shadow mb-4\">\r\n    <div class=\"card-header py-3\">\r\n        <h6 class=\"m-0 font-weight-bold text-primary\">Data No: ");
#nullable restore
#line 10 "C:\Users\dogan\OneDrive\Masaüstü\BilgeAdam Boost (Doğan)\BasicAdminApp\BasicAdminApp\Views\Order\Index.cshtml"
                                                          Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
    </div>
    <div class=""card-body"">
        <div class=""table-responsive"">
            <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>CustomerID</th>
                        <th>Ship Name</th>
                        <th>Order Date</th>
                        <th>Detail</th>
                    </tr>
                </thead>
                
                <tbody>
");
#nullable restore
#line 26 "C:\Users\dogan\OneDrive\Masaüstü\BilgeAdam Boost (Doğan)\BasicAdminApp\BasicAdminApp\Views\Order\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 29 "C:\Users\dogan\OneDrive\Masaüstü\BilgeAdam Boost (Doğan)\BasicAdminApp\BasicAdminApp\Views\Order\Index.cshtml"
                       Write(item.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 30 "C:\Users\dogan\OneDrive\Masaüstü\BilgeAdam Boost (Doğan)\BasicAdminApp\BasicAdminApp\Views\Order\Index.cshtml"
                       Write(item.customerId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 31 "C:\Users\dogan\OneDrive\Masaüstü\BilgeAdam Boost (Doğan)\BasicAdminApp\BasicAdminApp\Views\Order\Index.cshtml"
                       Write(item.shipName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 32 "C:\Users\dogan\OneDrive\Masaüstü\BilgeAdam Boost (Doğan)\BasicAdminApp\BasicAdminApp\Views\Order\Index.cshtml"
                       Write(item.orderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td><a");
            BeginWriteAttribute("href", " href=\"", 1143, "\"", 1172, 2);
            WriteAttributeValue("", 1150, "/Order/Detail/", 1150, 14, true);
#nullable restore
#line 33 "C:\Users\dogan\OneDrive\Masaüstü\BilgeAdam Boost (Doğan)\BasicAdminApp\BasicAdminApp\Views\Order\Index.cshtml"
WriteAttributeValue("", 1164, item.id, 1164, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button class=\"btn btn-primary\">Go to Detail</button></a></td>\r\n                    </tr>\r\n");
#nullable restore
#line 35 "C:\Users\dogan\OneDrive\Masaüstü\BilgeAdam Boost (Doğan)\BasicAdminApp\BasicAdminApp\Views\Order\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
        </div>
    </div>
</div>
<script src=""/vendor/datatables/jquery.dataTables.min.js""></script>
<script src=""/vendor/datatables/dataTables.bootstrap4.min.js""></script>

<!-- Page level custom scripts -->
<script src=""/js/demo/datatables-demo.js""></script>

");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BasicAdminApp.Models.OrderVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Admin\source\repos\dotNetT1708M1\ProductNetCore\ProductNetCore\Views\Product\GetList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf900ca67c7cd4116da02a690309069842f2132d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_GetList), @"mvc.1.0.view", @"/Views/Product/GetList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/GetList.cshtml", typeof(AspNetCore.Views_Product_GetList))]
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
#line 1 "C:\Users\Admin\source\repos\dotNetT1708M1\ProductNetCore\ProductNetCore\Views\_ViewImports.cshtml"
using ProductNetCore;

#line default
#line hidden
#line 2 "C:\Users\Admin\source\repos\dotNetT1708M1\ProductNetCore\ProductNetCore\Views\_ViewImports.cshtml"
using ProductNetCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf900ca67c7cd4116da02a690309069842f2132d", @"/Views/Product/GetList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"007a8562562bd4c83bd9dc30e203f7dd6b047f09", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_GetList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Admin\source\repos\dotNetT1708M1\ProductNetCore\ProductNetCore\Views\Product\GetList.cshtml"
  
    ViewData["Title"] = "GetList";

#line default
#line hidden
            BeginContext(65, 47, true);
            WriteLiteral("\r\n<h2>GetList</h2>\r\n<div class=\"alert-success\">");
            EndContext();
            BeginContext(113, 19, false);
#line 7 "C:\Users\Admin\source\repos\dotNetT1708M1\ProductNetCore\ProductNetCore\Views\Product\GetList.cshtml"
                      Write(TempData["message"]);

#line default
#line hidden
            EndContext();
            BeginContext(132, 170, true);
            WriteLiteral("</div>\r\n<table>\r\n    <thead>\r\n        <tr>\r\n            <th>Name</th>\r\n            <th>Price</th>\r\n            <th>Handle</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 17 "C:\Users\Admin\source\repos\dotNetT1708M1\ProductNetCore\ProductNetCore\Views\Product\GetList.cshtml"
         foreach(var product in Model)
        {

#line default
#line hidden
            BeginContext(353, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(392, 12, false);
#line 20 "C:\Users\Admin\source\repos\dotNetT1708M1\ProductNetCore\ProductNetCore\Views\Product\GetList.cshtml"
               Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(404, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(432, 13, false);
#line 21 "C:\Users\Admin\source\repos\dotNetT1708M1\ProductNetCore\ProductNetCore\Views\Product\GetList.cshtml"
               Write(product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(445, 51, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 496, "\"", 533, 2);
            WriteAttributeValue("", 503, "/Product/Update?id=", 503, 19, true);
#line 23 "C:\Users\Admin\source\repos\dotNetT1708M1\ProductNetCore\ProductNetCore\Views\Product\GetList.cshtml"
WriteAttributeValue("", 522, product.Id, 522, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(534, 42, true);
            WriteLiteral(">Edit</a>\r\n                    <a href=\"#\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 576, "\"", 592, 1);
#line 24 "C:\Users\Admin\source\repos\dotNetT1708M1\ProductNetCore\ProductNetCore\Views\Product\GetList.cshtml"
WriteAttributeValue("", 581, product.Id, 581, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(593, 56, true);
            WriteLiteral(" >Delete</a>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 27 "C:\Users\Admin\source\repos\dotNetT1708M1\ProductNetCore\ProductNetCore\Views\Product\GetList.cshtml"
        }

#line default
#line hidden
            BeginContext(660, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
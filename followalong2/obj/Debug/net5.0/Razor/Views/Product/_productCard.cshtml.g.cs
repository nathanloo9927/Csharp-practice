#pragma checksum "C:\Users\chees\source\repos\followalong2\Views\Product\_productCard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74e3378f13c178d3da93889a6c1b3281ae1e78a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product__productCard), @"mvc.1.0.view", @"/Views/Product/_productCard.cshtml")]
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
#nullable restore
#line 1 "C:\Users\chees\source\repos\followalong2\Views\_ViewImports.cshtml"
using followalong2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\chees\source\repos\followalong2\Views\_ViewImports.cshtml"
using followalong2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74e3378f13c178d3da93889a6c1b3281ae1e78a1", @"/Views/Product/_productCard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8043c2727e46d48711797ea0d658e1b35eb89fa6", @"/Views/_ViewImports.cshtml")]
    public class Views_Product__productCard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<followalong2.Models.ProductModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\chees\source\repos\followalong2\Views\Product\_productCard.cshtml"
   
    var s = Model.Name;
    var firstWord = s.IndexOf(" ") > -1 ? s.Substring(0, s.IndexOf(" ")) : s;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card\" style=\"width: 18rem;\">\r\n    <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 226, "\"", 289, 4);
            WriteAttributeValue("", 232, "https://loremflickr.com/320/240/", 232, 32, true);
#nullable restore
#line 8 "C:\Users\chees\source\repos\followalong2\Views\Product\_productCard.cshtml"
WriteAttributeValue("", 264, firstWord, 264, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 274, "?lock=", 274, 6, true);
#nullable restore
#line 8 "C:\Users\chees\source\repos\followalong2\Views\Product\_productCard.cshtml"
WriteAttributeValue("", 280, Model.Id, 280, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 290, "\"", 307, 1);
#nullable restore
#line 8 "C:\Users\chees\source\repos\followalong2\Views\Product\_productCard.cshtml"
WriteAttributeValue("", 296, Model.Name, 296, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"card-body\">\r\n        <h5 class=\"card-title\">");
#nullable restore
#line 10 "C:\Users\chees\source\repos\followalong2\Views\Product\_productCard.cshtml"
                          Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <p class=\"card-text\">");
#nullable restore
#line 11 "C:\Users\chees\source\repos\followalong2\Views\Product\_productCard.cshtml"
                        Write(Html.DisplayFor(m => Model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p class=\"card-text\">");
#nullable restore
#line 12 "C:\Users\chees\source\repos\followalong2\Views\Product\_productCard.cshtml"
                        Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 521, "\"", 558, 2);
            WriteAttributeValue("", 528, "/product/ShowDetails/", 528, 21, true);
#nullable restore
#line 13 "C:\Users\chees\source\repos\followalong2\Views\Product\_productCard.cshtml"
WriteAttributeValue("", 549, Model.Id, 549, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Show Details</a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 612, "\"", 642, 2);
            WriteAttributeValue("", 619, "/product/Edit/", 619, 14, true);
#nullable restore
#line 14 "C:\Users\chees\source\repos\followalong2\Views\Product\_productCard.cshtml"
WriteAttributeValue("", 633, Model.Id, 633, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Edit</a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 688, "\"", 720, 2);
            WriteAttributeValue("", 695, "/product/Delete/", 695, 16, true);
#nullable restore
#line 15 "C:\Users\chees\source\repos\followalong2\Views\Product\_productCard.cshtml"
WriteAttributeValue("", 711, Model.Id, 711, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a>\r\n        <!-- Button trigger modal -->\r\n        <button type=\"button\"");
            BeginWriteAttribute("value", " value=\"", 825, "\"", 842, 1);
#nullable restore
#line 17 "C:\Users\chees\source\repos\followalong2\Views\Product\_productCard.cshtml"
WriteAttributeValue("", 833, Model.Id, 833, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary edit-product-button\" data-toggle=\"modal\" data-target=\"#editModal\">\r\n            Modal Edit\r\n        </button>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<followalong2.Models.ProductModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

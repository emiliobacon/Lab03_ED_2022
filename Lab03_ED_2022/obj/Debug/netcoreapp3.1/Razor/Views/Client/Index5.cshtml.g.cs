#pragma checksum "C:\Users\megan\Desktop\Rama3lAB\LAB03_ED_2022\Lab03_ED_2022\Lab03_ED_2022\Views\Client\Index5.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3cb53263caa1c55e749e07b7a26e056ce8d99ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_Index5), @"mvc.1.0.view", @"/Views/Client/Index5.cshtml")]
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
#line 1 "C:\Users\megan\Desktop\Rama3lAB\LAB03_ED_2022\Lab03_ED_2022\Lab03_ED_2022\Views\_ViewImports.cshtml"
using Lab03_ED_2022;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\megan\Desktop\Rama3lAB\LAB03_ED_2022\Lab03_ED_2022\Lab03_ED_2022\Views\_ViewImports.cshtml"
using Lab03_ED_2022.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3cb53263caa1c55e749e07b7a26e056ce8d99ee", @"/Views/Client/Index5.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee8c08269e2417fc37f2d29c1e06df4ce7875d07", @"/Views/_ViewImports.cshtml")]
    public class Views_Client_Index5 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Lab03_ED_2022.Models.ClientModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\megan\Desktop\Rama3lAB\LAB03_ED_2022\Lab03_ED_2022\Lab03_ED_2022\Views\Client\Index5.cshtml"
  
    ViewData["Title"] = "Index5";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>AVL - Ordenado por Correo Electrónico </h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\megan\Desktop\Rama3lAB\LAB03_ED_2022\Lab03_ED_2022\Lab03_ED_2022\Views\Client\Index5.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\megan\Desktop\Rama3lAB\LAB03_ED_2022\Lab03_ED_2022\Lab03_ED_2022\Views\Client\Index5.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\megan\Desktop\Rama3lAB\LAB03_ED_2022\Lab03_ED_2022\Lab03_ED_2022\Views\Client\Index5.cshtml"
           Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\megan\Desktop\Rama3lAB\LAB03_ED_2022\Lab03_ED_2022\Lab03_ED_2022\Views\Client\Index5.cshtml"
           Write(Html.DisplayNameFor(model => model.CarColor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\megan\Desktop\Rama3lAB\LAB03_ED_2022\Lab03_ED_2022\Lab03_ED_2022\Views\Client\Index5.cshtml"
           Write(Html.DisplayNameFor(model => model.CarModel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\megan\Desktop\Rama3lAB\LAB03_ED_2022\Lab03_ED_2022\Lab03_ED_2022\Views\Client\Index5.cshtml"
           Write(Html.DisplayNameFor(model => model.SerialNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 34 "C:\Users\megan\Desktop\Rama3lAB\LAB03_ED_2022\Lab03_ED_2022\Lab03_ED_2022\Views\Client\Index5.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\megan\Desktop\Rama3lAB\LAB03_ED_2022\Lab03_ED_2022\Lab03_ED_2022\Views\Client\Index5.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\megan\Desktop\Rama3lAB\LAB03_ED_2022\Lab03_ED_2022\Lab03_ED_2022\Views\Client\Index5.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\megan\Desktop\Rama3lAB\LAB03_ED_2022\Lab03_ED_2022\Lab03_ED_2022\Views\Client\Index5.cshtml"
           Write(Html.DisplayFor(modelItem => item.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\megan\Desktop\Rama3lAB\LAB03_ED_2022\Lab03_ED_2022\Lab03_ED_2022\Views\Client\Index5.cshtml"
           Write(Html.DisplayFor(modelItem => item.CarColor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\megan\Desktop\Rama3lAB\LAB03_ED_2022\Lab03_ED_2022\Lab03_ED_2022\Views\Client\Index5.cshtml"
           Write(Html.DisplayFor(modelItem => item.CarModel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\megan\Desktop\Rama3lAB\LAB03_ED_2022\Lab03_ED_2022\Lab03_ED_2022\Views\Client\Index5.cshtml"
           Write(Html.DisplayFor(modelItem => item.SerialNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            \r\n        </tr>\r\n");
#nullable restore
#line 56 "C:\Users\megan\Desktop\Rama3lAB\LAB03_ED_2022\Lab03_ED_2022\Lab03_ED_2022\Views\Client\Index5.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Lab03_ED_2022.Models.ClientModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

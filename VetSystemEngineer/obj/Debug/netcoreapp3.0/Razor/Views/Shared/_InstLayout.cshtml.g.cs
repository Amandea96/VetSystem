#pragma checksum "C:\Users\Amanda\Desktop\DODAWANIE PACJENTA\VetSystemEngineer\VetSystemEngineer\Views\Shared\_InstLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b24b00656b852a9b4fa43f993ebc464848671037"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__InstLayout), @"mvc.1.0.view", @"/Views/Shared/_InstLayout.cshtml")]
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
#line 1 "C:\Users\Amanda\Desktop\DODAWANIE PACJENTA\VetSystemEngineer\VetSystemEngineer\Views\_ViewImports.cshtml"
using VetSystemEngineer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Amanda\Desktop\DODAWANIE PACJENTA\VetSystemEngineer\VetSystemEngineer\Views\_ViewImports.cshtml"
using VetSystemEngineer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Amanda\Desktop\DODAWANIE PACJENTA\VetSystemEngineer\VetSystemEngineer\Views\_ViewImports.cshtml"
using VetSystemEngineer.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Amanda\Desktop\DODAWANIE PACJENTA\VetSystemEngineer\VetSystemEngineer\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Amanda\Desktop\DODAWANIE PACJENTA\VetSystemEngineer\VetSystemEngineer\Views\_ViewImports.cshtml"
using VetSystemEngineer.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b24b00656b852a9b4fa43f993ebc464848671037", @"/Views/Shared/_InstLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b29eec520779ec3c8309d1f7432ef073c429e26e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__InstLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Amanda\Desktop\DODAWANIE PACJENTA\VetSystemEngineer\VetSystemEngineer\Views\Shared\_InstLayout.cshtml"
  
    Layout = "_Layout";

    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n<div class=\"card card-image header-img\"");
            BeginWriteAttribute("style", " style=\"", 158, "\"", 237, 5);
            WriteAttributeValue("", 166, "background-image:", 166, 17, true);
            WriteAttributeValue(" ", 183, "url(\'", 184, 6, true);
#nullable restore
#line 11 "C:\Users\Amanda\Desktop\DODAWANIE PACJENTA\VetSystemEngineer\VetSystemEngineer\Views\Shared\_InstLayout.cshtml"
WriteAttributeValue("", 189, ViewBag.Wallpaper, 189, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 207, "\'", 207, 1, true);
            WriteAttributeValue(" ", 208, ");background-position-y:40%;", 209, 29, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n\r\n    <div class=\"text-white text-center rgba-stylish-strong py-5 px-4\">\r\n        <div class=\"py-5 box-c-dark-inst\">\r\n\r\n            <!-- Content -->\r\n\r\n            <h2 class=\"card-title h2 my-4 py-2 \">");
#nullable restore
#line 19 "C:\Users\Amanda\Desktop\DODAWANIE PACJENTA\VetSystemEngineer\VetSystemEngineer\Views\Shared\_InstLayout.cshtml"
                                            Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            <h5 class=\"mb-4 pb-2 px-md-5 mx-md-5\">");
#nullable restore
#line 20 "C:\Users\Amanda\Desktop\DODAWANIE PACJENTA\VetSystemEngineer\VetSystemEngineer\Views\Shared\_InstLayout.cshtml"
                                             Write(ViewBag.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 34 "C:\Users\Amanda\Desktop\DODAWANIE PACJENTA\VetSystemEngineer\VetSystemEngineer\Views\Shared\_InstLayout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n    \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

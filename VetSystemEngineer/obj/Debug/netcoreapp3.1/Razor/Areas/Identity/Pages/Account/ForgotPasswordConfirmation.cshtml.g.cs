#pragma checksum "E:\jeden z ostatnich\VetSystemEngineer\VetSystemEngineer\Areas\Identity\Pages\Account\ForgotPasswordConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39392a51aa5194da3f5464f22e07f8e1b176c60a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_ForgotPasswordConfirmation), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/ForgotPasswordConfirmation.cshtml")]
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
#line 1 "E:\jeden z ostatnich\VetSystemEngineer\VetSystemEngineer\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\jeden z ostatnich\VetSystemEngineer\VetSystemEngineer\Areas\Identity\Pages\_ViewImports.cshtml"
using VetSystemEngineer.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\jeden z ostatnich\VetSystemEngineer\VetSystemEngineer\Areas\Identity\Pages\_ViewImports.cshtml"
using VetSystemEngineer.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\jeden z ostatnich\VetSystemEngineer\VetSystemEngineer\Areas\Identity\Pages\_ViewImports.cshtml"
using VetSystemEngineer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\jeden z ostatnich\VetSystemEngineer\VetSystemEngineer\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using VetSystemEngineer.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39392a51aa5194da3f5464f22e07f8e1b176c60a", @"/Areas/Identity/Pages/Account/ForgotPasswordConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b37d02ae80586c700378eba9a370ef837d5c764", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edc2076d62f183688b8e8796ced12fd92c23bde6", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_ForgotPasswordConfirmation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\jeden z ostatnich\VetSystemEngineer\VetSystemEngineer\Areas\Identity\Pages\Account\ForgotPasswordConfirmation.cshtml"
  
    ViewData["Title"] = "Potwierdzenie wysłania linku na wskazany adres email";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"box-cont  mx-1 mx-lg-5 mx-md-2 text-center\">\r\n        <div class=\"special\" style=\"padding-top:6rem\">\r\n            <span class=\"far icon fa-check-square\"></span>\r\n            <h1>");
#nullable restore
#line 9 "E:\jeden z ostatnich\VetSystemEngineer\VetSystemEngineer\Areas\Identity\Pages\Account\ForgotPasswordConfirmation.cshtml"
           Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            <p>\r\n                Sprawdź swój email w celu zmiany hasła.\r\n            </p>\r\n            </div></div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ForgotPasswordConfirmation> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ForgotPasswordConfirmation> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ForgotPasswordConfirmation>)PageContext?.ViewData;
        public ForgotPasswordConfirmation Model => ViewData.Model;
    }
}
#pragma warning restore 1591

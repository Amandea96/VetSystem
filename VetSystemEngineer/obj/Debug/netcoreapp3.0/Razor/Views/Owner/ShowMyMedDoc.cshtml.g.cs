#pragma checksum "C:\Users\Amanda\Desktop\DODAWANIE PACJENTA\VetSystemEngineer\VetSystemEngineer\Views\Owner\ShowMyMedDoc.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16a175006eaf17a6c472b018909402085d71c20a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Owner_ShowMyMedDoc), @"mvc.1.0.view", @"/Views/Owner/ShowMyMedDoc.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16a175006eaf17a6c472b018909402085d71c20a", @"/Views/Owner/ShowMyMedDoc.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b29eec520779ec3c8309d1f7432ef073c429e26e", @"/Views/_ViewImports.cshtml")]
    public class Views_Owner_ShowMyMedDoc : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<VetSystemEngineer.Models.Patient>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Visit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MedicalDocumentation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Owner", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddPetToInstitution", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PetInInstitutions", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Amanda\Desktop\DODAWANIE PACJENTA\VetSystemEngineer\VetSystemEngineer\Views\Owner\ShowMyMedDoc.cshtml"
  
    ViewData["Title"] = "Moja dokumentacja";
    Layout = "_InstLayout";

    ViewBag.Wallpaper = "../images/Cat.jpg";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

   
    <div class=""container-fluid  "">
        <div class=""box-cont"">
            <div class=""row h-100"">
                <div class=""table-responsive text-center col-7 justify-content-center"">
                    <table class=""table table-hover"">

                        <thead>
                            <tr>

                                <th scope=""col"">Imię</th>
                                <th scope=""col"">Gatunek</th>
                                <th scope=""col"">Rasa</th>
                                <th scope=""col"">Wiek</th>


                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 29 "C:\Users\Amanda\Desktop\DODAWANIE PACJENTA\VetSystemEngineer\VetSystemEngineer\Views\Owner\ShowMyMedDoc.cshtml"
                             foreach (var p in Model)
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n\r\n\r\n                                    <td> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16a175006eaf17a6c472b018909402085d71c20a7208", async() => {
#nullable restore
#line 35 "C:\Users\Amanda\Desktop\DODAWANIE PACJENTA\VetSystemEngineer\VetSystemEngineer\Views\Owner\ShowMyMedDoc.cshtml"
                                                                                                                            Write(p.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "C:\Users\Amanda\Desktop\DODAWANIE PACJENTA\VetSystemEngineer\VetSystemEngineer\Views\Owner\ShowMyMedDoc.cshtml"
                                                                                                       WriteLiteral(p.IdPatient);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 36 "C:\Users\Amanda\Desktop\DODAWANIE PACJENTA\VetSystemEngineer\VetSystemEngineer\Views\Owner\ShowMyMedDoc.cshtml"
                                   Write(p.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 37 "C:\Users\Amanda\Desktop\DODAWANIE PACJENTA\VetSystemEngineer\VetSystemEngineer\Views\Owner\ShowMyMedDoc.cshtml"
                                   Write(p.Breed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 38 "C:\Users\Amanda\Desktop\DODAWANIE PACJENTA\VetSystemEngineer\VetSystemEngineer\Views\Owner\ShowMyMedDoc.cshtml"
                                   Write(p.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n                                    <td>\r\n                                    </td>\r\n\r\n\r\n                                </tr>\r\n");
#nullable restore
#line 46 "C:\Users\Amanda\Desktop\DODAWANIE PACJENTA\VetSystemEngineer\VetSystemEngineer\Views\Owner\ShowMyMedDoc.cshtml"


                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n\r\n\r\n\r\n");
            WriteLiteral(@"

                <div class=""col-5 "">

                    <div class=""m-auto"" style=""background-image:url(../images/Cat.jpg); height:100%;"">
                        <div class=""card-body text-center"">
                            <h5 class=""card-title"">Zarządzaj dokumendacją medyczną swoich pupili</h5>
                            <p class=""card-text"">
                                Tutaj możesz dodać dokumentację medyczną placówki oraz zobaczyć, które placówki mają do niej dostęp
                            </p>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16a175006eaf17a6c472b018909402085d71c20a12039", async() => {
                WriteLiteral("\r\n                                Dodaj dokumentację\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16a175006eaf17a6c472b018909402085d71c20a13596", async() => {
                WriteLiteral("\r\n                                Zobacz dostęp\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n\r\n");
            WriteLiteral(@"
                    </div>
                </div>
            </div>



        </div>
    </div>
       






 <!-- <div class=""row justify-content-center"">
         <div class=""col-md-4 col-4"">
             <div class=""card shadow"" >
                 <div class=""inner"">
                     <img class=""card-img-top"" src=""../images/Cat.jpg"" alt=""Card image cap"">
                 </div>
                 <div class=""card-body text-center"">
                     <h5 class=""card-title"">Design</h5>
                     <p class=""card-text"">
                         Lorem Ipsum is simply dummy text of the printing and typesetting industry.
                         Lorem Ipsum has been the industry's standard dummy text ever since the 1500s
                     </p>
                     <a href=""#"" class=""btn btn-success"">Learn More...</a>
                 </div>
             </div>
         </div>

     </div>-->
   

    
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<VetSystemEngineer.Models.Patient>> Html { get; private set; }
    }
}
#pragma warning restore 1591
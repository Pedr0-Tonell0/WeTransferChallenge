#pragma checksum "C:\Users\ptonello\Desktop\WeTransfer\WeTransfer\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9eca0d57a19a7b6010ec71215f723b1154a221d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\ptonello\Desktop\WeTransfer\WeTransfer\Views\_ViewImports.cshtml"
using WeTransfer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ptonello\Desktop\WeTransfer\WeTransfer\Views\_ViewImports.cshtml"
using WeTransfer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9eca0d57a19a7b6010ec71215f723b1154a221d7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2e46f99fa7564609eb1122433c2097ac88646ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WeTransfer.ViewModel.VMFileUpload>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/tasa.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding: 30px;font-size:15px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Results", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\ptonello\Desktop\WeTransfer\WeTransfer\Views\Home\Index.cshtml"
   ViewData["Title"] = "WeTransfer"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 5 "C:\Users\ptonello\Desktop\WeTransfer\WeTransfer\Views\Home\Index.cshtml"
 if (Model.OkDiv != 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script type=""text/javascript"">
    window.onload = function () {
        swal({
            title: 'Felicidades!',
            html: 'Se ha procesado correctamente el archivo',
            type: 'success',
            confirmButtonText: 'OK',
            confirmButtonColor: ""#F28123"",
        });
    };
</script>");
#nullable restore
#line 17 "C:\Users\ptonello\Desktop\WeTransfer\WeTransfer\Views\Home\Index.cshtml"
         }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 19 "C:\Users\ptonello\Desktop\WeTransfer\WeTransfer\Views\Home\Index.cshtml"
 if (Model.ErrorDiv != 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<script type=\"text/javascript\">\n    window.onload = function () {\n        swal({\n            title: \'Oops...\',\n            html: \'");
#nullable restore
#line 25 "C:\Users\ptonello\Desktop\WeTransfer\WeTransfer\Views\Home\Index.cshtml"
              Write(Model.ListaErrores[Model.ErrorDiv]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\n            type: \'error\',\n            confirmButtonText: \'OK\',\n            confirmButtonColor: \"#F28123\",\n        });\n    };\n</script>");
#nullable restore
#line 31 "C:\Users\ptonello\Desktop\WeTransfer\WeTransfer\Views\Home\Index.cshtml"
         }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""top-header-area"" id=""sticker"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12 col-sm-12 text-center"">
                <div class=""main-menu-wrap"">
                    <!-- logo -->
                    <div class=""site-logo"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9eca0d57a19a7b6010ec71215f723b1154a221d78525", async() => {
                WriteLiteral("\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9eca0d57a19a7b6010ec71215f723b1154a221d78806", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <!-- logo -->
                    <!-- menu start -->
                    <nav class=""main-menu"">
                    </nav>
                    <div class=""mobile-menu""></div>
                    <!-- menu end -->
                </div>
            </div>
        </div>
    </div>
</div> <!-- home page slider -->
<div class=""homepage-slider"">
    <div class=""single-homepage-slider homepage-bg-1"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-12 col-lg-7 offset-lg-1 offset-xl-0"">
                    <div class=""hero-text"">
                        <div style=""margin-top:115px"">
                            <br />
                            <h1>¡Te damos la bienvenida!</h1>
                            <p class=""subtitle"">Selecciona un archivo por favor</p>
                            <br />
                            <div>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9eca0d57a19a7b6010ec71215f723b1154a221d712088", async() => {
                WriteLiteral("\n                                    <div class=\"form-row\">\n                                        <div class=\"form-group col-md-8\">\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9eca0d57a19a7b6010ec71215f723b1154a221d712528", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 69 "C:\Users\ptonello\Desktop\WeTransfer\WeTransfer\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.File);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                        </div>
                                        <div class=""form-group col-md-4"">
                                            <button type=""submit"" class=""boxed-btn"" style=""padding: 20px;""><b>Enviar</b></button>
                                        </div>
                                    </div>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""single-homepage-slider homepage-bg-3"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-12 col-lg-7 offset-lg-1 offset-xl-0"">
                    <div class=""hero-text"">
                        <div style=""margin-top:115px"">
                            <br />
                            <h1>¡Te damos la bienvenida!</h1>
                            <p class=""subtitle"">Selecciona un archivo por favor</p>
                            <br />
                            <div>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9eca0d57a19a7b6010ec71215f723b1154a221d716761", async() => {
                WriteLiteral("\n                                    <div class=\"form-row\">\n                                        <div class=\"form-group col-md-8\">\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9eca0d57a19a7b6010ec71215f723b1154a221d717201", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 97 "C:\Users\ptonello\Desktop\WeTransfer\WeTransfer\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.File);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                        </div>
                                        <div class=""form-group col-md-4"">
                                            <button type=""submit"" class=""boxed-btn"" style=""padding: 20px;""><b>Enviar</b></button>
                                        </div>
                                    </div>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            </div>\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n\n");
#nullable restore
#line 113 "C:\Users\ptonello\Desktop\WeTransfer\WeTransfer\Views\Home\Index.cshtml"
 if (Model.OkDiv != 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""product-section mt-150 mb-150"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-8 offset-lg-2 text-center"">
                <div class=""section-title"">
                    <h3>Challenge <span class=""orange-text"">Pedro Tonello</span></h3>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-12 col-md-12 text-center"">
                <div class=""checkout-accordion-wrap"">
                    <div class=""accordion"" id=""accordionExample"">
                        <div class=""card single-accordion"">
                            <div class=""card-header"" id=""headingOne"">
                                <h5 class=""mb-0"">
                                    <button class=""btn btn-link collapsed"" type=""button"" data-toggle=""collapse"" data-target=""#collapseOne"" aria-expanded=""false"" aria-controls=""collapseOne"">
                                        <h5>Punto 1: <span class=""orange-text""> Cantidad total de registro");
            WriteLiteral(@"s</span></h5>
                                    </button>
                                </h5>
                            </div>
                            <div id=""collapseOne"" class=""collapse"" aria-labelledby=""headingOne"" data-parent=""#accordionExample"">
                                <div class=""container"">
                                    <br />
                                    <h5>La cantidad total es: <span class=""orange-text""> ");
#nullable restore
#line 139 "C:\Users\ptonello\Desktop\WeTransfer\WeTransfer\Views\Home\Index.cshtml"
                                                                                    Write(ViewBag.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></h5>
                                    <br />
                                </div>
                            </div>
                        </div>
                        <div class=""card single-accordion"">
                            <div class=""card-header"" id=""headingTwo"">
                                <h5 class=""mb-0"">
                                    <button class=""btn btn-link collapsed"" type=""button"" data-toggle=""collapse"" data-target=""#collapseTwo"" aria-expanded=""false"" aria-controls=""collapseTwo"">
                                        <h5>Punto 2: <span class=""orange-text""> Promedio de edad de socios de Racing</span></h5>
                                    </button>
                                </h5>
                            </div>
                            <div id=""collapseTwo"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordionExample"">
                                <div class=""container"">
                                    <br />
                 ");
            WriteLiteral("                   <h5>El promedio es: <span class=\"orange-text\"> ");
#nullable restore
#line 155 "C:\Users\ptonello\Desktop\WeTransfer\WeTransfer\Views\Home\Index.cshtml"
                                                                              Write(ViewBag.Promedio);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></h5>
                                    <br />
                                </div>
                            </div>
                        </div>
                        <div class=""card single-accordion"">
                            <div class=""card-header"" id=""headingThree"">
                                <h5 class=""mb-0"">
                                    <button class=""btn btn-link collapsed"" type=""button"" data-toggle=""collapse"" data-target=""#collapseThree"" aria-expanded=""false"" aria-controls=""collapseThree"">
                                        <h5>Punto 3: <span class=""orange-text""> 100 primeras personas casadas, universitarias, ordenadas por edad asc</span></h5>
                                    </button>
                                </h5>
                            </div>
                            <div id=""collapseThree"" class=""collapse"" aria-labelledby=""headingThree"" data-parent=""#accordionExample"">
                                <div class=""container"">
                 ");
            WriteLiteral(@"                   <br />
                                    <table id=""table"" class=""table table-striped table-bordered"" style=""width:100%"">
                                        <thead>
                                            <tr>
                                                <th>Nombre</th>
                                                <th>Edad</th>
                                                <th>Equipo</th>
                                            </tr>
                                        </thead>
                                        <tbody>
");
#nullable restore
#line 180 "C:\Users\ptonello\Desktop\WeTransfer\WeTransfer\Views\Home\Index.cshtml"
                                             foreach (var item in ViewBag.Punto3)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\n                                        <td>\n                                            ");
#nullable restore
#line 184 "C:\Users\ptonello\Desktop\WeTransfer\WeTransfer\Views\Home\Index.cshtml"
                                       Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        </td>\n                                        <th>\n                                            ");
#nullable restore
#line 187 "C:\Users\ptonello\Desktop\WeTransfer\WeTransfer\Views\Home\Index.cshtml"
                                       Write(item.Edad);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        </th>\n                                        <th>\n                                            ");
#nullable restore
#line 190 "C:\Users\ptonello\Desktop\WeTransfer\WeTransfer\Views\Home\Index.cshtml"
                                       Write(item.Equipo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        </th>\n                                    </tr>\n");
#nullable restore
#line 193 "C:\Users\ptonello\Desktop\WeTransfer\WeTransfer\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </tbody>
                                    </table>
                                    <br />
                                </div>
                            </div>
                        </div>

                        <div class=""card single-accordion"">
                            <div class=""card-header"" id=""headingFour"">
                                <h5 class=""mb-0"">
                                    <button class=""btn btn-link collapsed"" type=""button"" data-toggle=""collapse"" data-target=""#collapseFour"" aria-expanded=""false"" aria-controls=""collapseFour"">
                                        <h5>Punto 4: <span class=""orange-text""> 5 nombres mas comunes de los fans de River</span></h5>
                                    </button>
                                </h5>
                            </div>
                            <div id=""collapseFour"" class=""collapse"" aria-labelledby=""headingFour"" data-parent=""#accordionExample"">
                       ");
            WriteLiteral(@"         <div class=""container"">
                                    <br />
                                    <table id=""table"" class=""table table-striped table-bordered"" style=""width:100%"">
                                        <br />
                                        <thead>
                                            <tr>
                                                <th>Nombre</th>
                                                <th>Cantidad</th>
                                            </tr>
                                        </thead>
                                        <tbody>
");
#nullable restore
#line 221 "C:\Users\ptonello\Desktop\WeTransfer\WeTransfer\Views\Home\Index.cshtml"
                                             foreach (var item in ViewBag.Punto4)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\n                                        <td>\n                                            ");
#nullable restore
#line 225 "C:\Users\ptonello\Desktop\WeTransfer\WeTransfer\Views\Home\Index.cshtml"
                                       Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        </td>\n                                        <th>\n                                            ");
#nullable restore
#line 228 "C:\Users\ptonello\Desktop\WeTransfer\WeTransfer\Views\Home\Index.cshtml"
                                       Write(item.Edad);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        </th>\n                                    </tr>");
#nullable restore
#line 230 "C:\Users\ptonello\Desktop\WeTransfer\WeTransfer\Views\Home\Index.cshtml"
                                         }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </tbody>
                                    </table>
                                    <br />
                                </div>
                            </div>
                        </div>

                        <div class=""card single-accordion"">
                            <div class=""card-header"" id=""headingFive"">
                                <h5 class=""mb-0"">
                                    <button class=""btn btn-link collapsed"" type=""button"" data-toggle=""collapse"" data-target=""#collapseFive"" aria-expanded=""false"" aria-controls=""collapseFive"">
                                        <h5>Punto 5: <span class=""orange-text""> Listado de equipos, promedio de edad, menor edad, mayor edad, ordenados de mayor a menor por cantidad de socios</span></h5>
                                    </button>
                                </h5>
                            </div>
                            <div id=""collapseFive"" class=""collapse"" aria-labelledby=""");
            WriteLiteral(@"headingFive"" data-parent=""#accordionExample"">
                                <div class=""container"">
                                    <br />
                                    <table id=""table"" class=""table table-striped table-bordered"" style=""width:100%"">
                                        <thead>
                                            <tr>
                                                <th>Equipo</th>
                                                <th>Cantidad</th>
                                                <th>Promedio</th>
                                                <th>Menor edad</th>
                                                <th>Mayor edad</th>
                                            </tr>
                                        </thead>
                                        <tbody>
");
#nullable restore
#line 260 "C:\Users\ptonello\Desktop\WeTransfer\WeTransfer\Views\Home\Index.cshtml"
                                             foreach (var item in ViewBag.Punto5)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\n                                                <td>\n                                                    ");
#nullable restore
#line 264 "C:\Users\ptonello\Desktop\WeTransfer\WeTransfer\Views\Home\Index.cshtml"
                                               Write(item.Equipo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                                </td>\n                                                <th>\n                                                    ");
#nullable restore
#line 267 "C:\Users\ptonello\Desktop\WeTransfer\WeTransfer\Views\Home\Index.cshtml"
                                               Write(item.Cantidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                                </th>\n                                                <th>\n");
#nullable restore
#line 270 "C:\Users\ptonello\Desktop\WeTransfer\WeTransfer\Views\Home\Index.cshtml"
                                                      double promedio = item.Promedio / item.Cantidad; 

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    ");
#nullable restore
#line 271 "C:\Users\ptonello\Desktop\WeTransfer\WeTransfer\Views\Home\Index.cshtml"
                                               Write(promedio);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                                </th>\n                                                <th>\n                                                    ");
#nullable restore
#line 274 "C:\Users\ptonello\Desktop\WeTransfer\WeTransfer\Views\Home\Index.cshtml"
                                               Write(item.EdadMenor);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                                </th>\n                                                <th>\n                                                    ");
#nullable restore
#line 277 "C:\Users\ptonello\Desktop\WeTransfer\WeTransfer\Views\Home\Index.cshtml"
                                               Write(item.EdadMayor);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                                </th>\n                                            </tr>");
#nullable restore
#line 279 "C:\Users\ptonello\Desktop\WeTransfer\WeTransfer\Views\Home\Index.cshtml"
                                                 }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </tbody>
                                    </table>
                                    <br />
                                </div>
                            </div>
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
");
#nullable restore
#line 293 "C:\Users\ptonello\Desktop\WeTransfer\WeTransfer\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WeTransfer.ViewModel.VMFileUpload> Html { get; private set; }
    }
}
#pragma warning restore 1591
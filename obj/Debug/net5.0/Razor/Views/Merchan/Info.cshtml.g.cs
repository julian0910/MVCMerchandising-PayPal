#pragma checksum "C:\Users\Julian\source\repos\MVCMerchMejorado-main\Views\Merchan\Info.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d888d16ce99399e8684a59fb02318bb5fdfe691c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Merchan_Info), @"mvc.1.0.view", @"/Views/Merchan/Info.cshtml")]
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
#line 1 "C:\Users\Julian\source\repos\MVCMerchMejorado-main\Views\_ViewImports.cshtml"
using MVCMerchandising;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Julian\source\repos\MVCMerchMejorado-main\Views\_ViewImports.cshtml"
using MVCMerchandising.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d888d16ce99399e8684a59fb02318bb5fdfe691c", @"/Views/Merchan/Info.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10c452a2aff352f5ef9c50bfb112f16dd3a2f61f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Merchan_Info : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVCMerchandising.Models.MerchanTalleViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AlCarrito", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Julian\source\repos\MVCMerchMejorado-main\Views\Merchan\Info.cshtml"
  

    ViewData["Title"] = "Informacion";


#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<h1>Tienda</h1>\n\n<table class=\"table\" style=\"background-color:#FFCEA5\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 16 "C:\Users\Julian\source\repos\MVCMerchMejorado-main\Views\Merchan\Info.cshtml"
           Write(Html.DisplayNameFor(model => model.Productos[0].Imagen));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 19 "C:\Users\Julian\source\repos\MVCMerchMejorado-main\Views\Merchan\Info.cshtml"
           Write(Html.DisplayNameFor(model => model.Productos[0].Producto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 22 "C:\Users\Julian\source\repos\MVCMerchMejorado-main\Views\Merchan\Info.cshtml"
           Write(Html.DisplayNameFor(model => model.Productos[0].Talles));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 25 "C:\Users\Julian\source\repos\MVCMerchMejorado-main\Views\Merchan\Info.cshtml"
           Write(Html.DisplayNameFor(model => model.Productos[0].Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 28 "C:\Users\Julian\source\repos\MVCMerchMejorado-main\Views\Merchan\Info.cshtml"
           Write(Html.DisplayNameFor(model => model.Productos[0].Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 31 "C:\Users\Julian\source\repos\MVCMerchMejorado-main\Views\Merchan\Info.cshtml"
           Write(Html.DisplayNameFor(model => model.Productos[0].Colores));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 37 "C:\Users\Julian\source\repos\MVCMerchMejorado-main\Views\Merchan\Info.cshtml"
         foreach (var item in Model.Productos) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n");
#nullable restore
#line 40 "C:\Users\Julian\source\repos\MVCMerchMejorado-main\Views\Merchan\Info.cshtml"
                     if (item.Imagen != "")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img");
            BeginWriteAttribute("src", " src=\"", 1089, "\"", 1107, 1);
#nullable restore
#line 42 "C:\Users\Julian\source\repos\MVCMerchMejorado-main\Views\Merchan\Info.cshtml"
WriteAttributeValue("", 1095, item.Imagen, 1095, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"remeruki\" height=\"100\" width=\"100\"/>\n");
#nullable restore
#line 43 "C:\Users\Julian\source\repos\MVCMerchMejorado-main\Views\Merchan\Info.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h2>No disponible</h2>\n");
#nullable restore
#line 47 "C:\Users\Julian\source\repos\MVCMerchMejorado-main\Views\Merchan\Info.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\n            <td>\n                ");
#nullable restore
#line 50 "C:\Users\Julian\source\repos\MVCMerchMejorado-main\Views\Merchan\Info.cshtml"
           Write(Html.DisplayFor(modelItem => item.Producto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 53 "C:\Users\Julian\source\repos\MVCMerchMejorado-main\Views\Merchan\Info.cshtml"
           Write(Html.DisplayFor(modelItem => item.Talles));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 56 "C:\Users\Julian\source\repos\MVCMerchMejorado-main\Views\Merchan\Info.cshtml"
           Write(Html.DisplayFor(modelItem => item.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 59 "C:\Users\Julian\source\repos\MVCMerchMejorado-main\Views\Merchan\Info.cshtml"
           Write(Html.DisplayFor(modelItem => item.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 62 "C:\Users\Julian\source\repos\MVCMerchMejorado-main\Views\Merchan\Info.cshtml"
           Write(Html.DisplayFor(modelItem => item.Colores));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d888d16ce99399e8684a59fb02318bb5fdfe691c9770", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 65 "C:\Users\Julian\source\repos\MVCMerchMejorado-main\Views\Merchan\Info.cshtml"
                                       WriteLiteral(item.Id);

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
            WriteLiteral(" |\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d888d16ce99399e8684a59fb02318bb5fdfe691c11932", async() => {
                WriteLiteral("Detalles");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 66 "C:\Users\Julian\source\repos\MVCMerchMejorado-main\Views\Merchan\Info.cshtml"
                                          WriteLiteral(item.Id);

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
            WriteLiteral(" |\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d888d16ce99399e8684a59fb02318bb5fdfe691c14100", async() => {
                WriteLiteral("Borrar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 67 "C:\Users\Julian\source\repos\MVCMerchMejorado-main\Views\Merchan\Info.cshtml"
                                         WriteLiteral(item.Id);

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
            WriteLiteral("|\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d888d16ce99399e8684a59fb02318bb5fdfe691c16264", async() => {
                WriteLiteral("Añadir al Carrito");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 68 "C:\Users\Julian\source\repos\MVCMerchMejorado-main\Views\Merchan\Info.cshtml"
                                            WriteLiteral(item.Id);

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
            WriteLiteral("\n            </td>\n            </tr>\n");
#nullable restore
#line 71 "C:\Users\Julian\source\repos\MVCMerchMejorado-main\Views\Merchan\Info.cshtml"
            } 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </tbody>\n</table>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVCMerchandising.Models.MerchanTalleViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

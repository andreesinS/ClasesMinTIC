#pragma checksum "/home/camilinhi/Documentos/CAMILA/Mision TIC/Diseño Software/Desarrollo_Software_Andree/HEnCasa.App/HEnCasa.App.Presentacion/Pages/Medico/Medico.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90d0c818f02c5f44ac4d1cfd356eb07f28b4cbe1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HEnCasa.App.Presentacion.Pages.Medico.Pages_Medico_Medico), @"mvc.1.0.razor-page", @"/Pages/Medico/Medico.cshtml")]
namespace HEnCasa.App.Presentacion.Pages.Medico
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
#line 1 "/home/camilinhi/Documentos/CAMILA/Mision TIC/Diseño Software/Desarrollo_Software_Andree/HEnCasa.App/HEnCasa.App.Presentacion/Pages/_ViewImports.cshtml"
using HEnCasa.App.Presentacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90d0c818f02c5f44ac4d1cfd356eb07f28b4cbe1", @"/Pages/Medico/Medico.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fc3bf8769022b78d49269158efdf59df537fbf1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Medico_Medico : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Medico/ActualizarMedico", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "/home/camilinhi/Documentos/CAMILA/Mision TIC/Diseño Software/Desarrollo_Software_Andree/HEnCasa.App/HEnCasa.App.Presentacion/Pages/Medico/Medico.cshtml"
  
    ViewData["Title"] = "Listado de medicos";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1>Lista de medicos</h1>\r\n</div>\r\n\r\n<table class = \"table\">\r\n    <thead></thead>\r\n        <tr>\r\n            <th scope = \'col\'>Nombre</th>\r\n            <th scope = \'col\'>Apellidos</th>\r\n        </tr>\r\n    </thead>\r\n");
#nullable restore
#line 18 "/home/camilinhi/Documentos/CAMILA/Mision TIC/Diseño Software/Desarrollo_Software_Andree/HEnCasa.App/HEnCasa.App.Presentacion/Pages/Medico/Medico.cshtml"
     foreach(var item in Model.ListaMedicos){

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 20 "/home/camilinhi/Documentos/CAMILA/Mision TIC/Diseño Software/Desarrollo_Software_Andree/HEnCasa.App/HEnCasa.App.Presentacion/Pages/Medico/Medico.cshtml"
           Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "/home/camilinhi/Documentos/CAMILA/Mision TIC/Diseño Software/Desarrollo_Software_Andree/HEnCasa.App/HEnCasa.App.Presentacion/Pages/Medico/Medico.cshtml"
           Write(item.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            \r\n            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90d0c818f02c5f44ac4d1cfd356eb07f28b4cbe15251", async() => {
                WriteLiteral("Ver pacientes");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "/home/camilinhi/Documentos/CAMILA/Mision TIC/Diseño Software/Desarrollo_Software_Andree/HEnCasa.App/HEnCasa.App.Presentacion/Pages/Medico/Medico.cshtml"
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
            WriteLiteral("</td>\r\n            <!--<td><a class=\"btn btn-danger\" asp-page=\"/Medico/Eliminar\" asp-route-id=\"");
#nullable restore
#line 24 "/home/camilinhi/Documentos/CAMILA/Mision TIC/Diseño Software/Desarrollo_Software_Andree/HEnCasa.App/HEnCasa.App.Presentacion/Pages/Medico/Medico.cshtml"
                                                                                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Eliminar</a></td>-->\r\n        </tr>   \r\n");
#nullable restore
#line 26 "/home/camilinhi/Documentos/CAMILA/Mision TIC/Diseño Software/Desarrollo_Software_Andree/HEnCasa.App/HEnCasa.App.Presentacion/Pages/Medico/Medico.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HEnCasa.App.Presentacion.Page.MedicoModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HEnCasa.App.Presentacion.Page.MedicoModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HEnCasa.App.Presentacion.Page.MedicoModel>)PageContext?.ViewData;
        public HEnCasa.App.Presentacion.Page.MedicoModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\HP\source\repos\VARGAS_ROSELL_T3.WEB\VARGAS_ROSELL_T3.WEB\Views\Auth\Registrar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "070409e938fe5ce41212c1b0efc94a8d029c30d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Auth_Registrar), @"mvc.1.0.view", @"/Views/Auth/Registrar.cshtml")]
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
#line 1 "C:\Users\HP\source\repos\VARGAS_ROSELL_T3.WEB\VARGAS_ROSELL_T3.WEB\Views\_ViewImports.cshtml"
using VARGAS_ROSELL_T3.WEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\source\repos\VARGAS_ROSELL_T3.WEB\VARGAS_ROSELL_T3.WEB\Views\_ViewImports.cshtml"
using VARGAS_ROSELL_T3.WEB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"070409e938fe5ce41212c1b0efc94a8d029c30d4", @"/Views/Auth/Registrar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f60d14b8a48aecb799d05512111596ef0232cbe4", @"/Views/_ViewImports.cshtml")]
    public class Views_Auth_Registrar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Auth/Registrar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Formulario"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-12"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"modal-dialog text-center\">\n    <div class=\"col-sm-8 main-section\">\n        <div class=\"modal-content\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "070409e938fe5ce41212c1b0efc94a8d029c30d45127", async() => {
                WriteLiteral("\n\n\n\n                <div class=\"form-group\" id=\"user-group\">\n                    <input type=\"text\" class=\"form-control\" name=\"Nombre\" placeholder=\"Nombre\"");
                BeginWriteAttribute("required", " required=\"", 388, "\"", 399, 0);
                EndWriteAttribute();
                BeginWriteAttribute("autofocus", " autofocus=\"", 400, "\"", 412, 0);
                EndWriteAttribute();
                WriteLiteral(" />\n\n                </div>\n\n                <div class=\"form-group\" id=\"user-group\">\n                    <input type=\"text\" class=\"form-control\" name=\"Direccion\" placeholder=\"Direccion \"");
                BeginWriteAttribute("required", " required=\"", 600, "\"", 611, 0);
                EndWriteAttribute();
                BeginWriteAttribute("autofocus", " autofocus=\"", 612, "\"", 624, 0);
                EndWriteAttribute();
                WriteLiteral(" />\n\n                </div>\n\n                <div class=\"form-group\" id=\"user-group\">\n                    <input type=\"number\" class=\"form-control\" name=\"Telefono\" placeholder=\"Telefono \"");
                BeginWriteAttribute("required", " required=\"", 812, "\"", 823, 0);
                EndWriteAttribute();
                BeginWriteAttribute("autofocus", " autofocus=\"", 824, "\"", 836, 0);
                EndWriteAttribute();
                WriteLiteral(" />\n\n                </div>\n\n                <div class=\"form-group\" id=\"email-group\">\n                    <input type=\"email\" class=\"form-control\" name=\"Email\" placeholder=\"Email\"");
                BeginWriteAttribute("required", " required=\"", 1017, "\"", 1028, 0);
                EndWriteAttribute();
                BeginWriteAttribute("autofocus", " autofocus=\"", 1029, "\"", 1041, 0);
                EndWriteAttribute();
                WriteLiteral(" />\n\n                </div>\n\n                <div class=\"form-group\"");
                BeginWriteAttribute("id", " id=\"", 1110, "\"", 1115, 0);
                EndWriteAttribute();
                WriteLiteral(">\n                    <input type=\"text\" class=\"form-control\" name=\"Username\" placeholder=\"Username\"");
                BeginWriteAttribute("required", " required=\"", 1216, "\"", 1227, 0);
                EndWriteAttribute();
                WriteLiteral(" min=\"1940-05-25\" max=\"2003-11-16\"");
                BeginWriteAttribute("autofocus", " autofocus=\"", 1262, "\"", 1274, 0);
                EndWriteAttribute();
                WriteLiteral(" />\n\n                </div>\n\n                <div class=\"form-group\" id=\"email-group\">\n                    <input type=\"text\" class=\"form-control\" name=\"Password\" placeholder=\"Password\"");
                BeginWriteAttribute("required", " required=\"", 1460, "\"", 1471, 0);
                EndWriteAttribute();
                BeginWriteAttribute("autofocus", " autofocus=\"", 1472, "\"", 1484, 0);
                EndWriteAttribute();
                WriteLiteral(@" minlength=""8"" maxlength=""9"" />

                </div>
                <div class=""form-group"" id=""contrasena-group"">
                    <input type=""password"" class=""form-control"" placeholder=""Confirmar Contrase??a"" name=""passwordConf"" />
                </div>

                <button type=""submit"" class=""btn btn-primary""><i class=""fas fa-sign-in-alt""></i>  Registrar </button>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n    </div>\n</div>");
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

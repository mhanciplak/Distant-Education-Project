#pragma checksum "C:\Users\murat\source\repos\egitim\egitim\Views\ogrencis\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dde520237314b8f5ab774774f4bae50e8e5b9344"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ogrencis_Delete), @"mvc.1.0.view", @"/Views/ogrencis/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ogrencis/Delete.cshtml", typeof(AspNetCore.Views_ogrencis_Delete))]
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
#line 1 "C:\Users\murat\source\repos\egitim\egitim\Views\_ViewImports.cshtml"
using egitim;

#line default
#line hidden
#line 2 "C:\Users\murat\source\repos\egitim\egitim\Views\_ViewImports.cshtml"
using egitim.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dde520237314b8f5ab774774f4bae50e8e5b9344", @"/Views/ogrencis/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c14c9264dec13091842345b9e8ccbfc556c30d2", @"/Views/_ViewImports.cshtml")]
    public class Views_ogrencis_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<egitim.Models.ogrenci>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\murat\source\repos\egitim\egitim\Views\ogrencis\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layoutadmin.cshtml";

#line default
#line hidden
            BeginContext(126, 168, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>ogrenci</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(295, 40, false);
#line 16 "C:\Users\murat\source\repos\egitim\egitim\Views\ogrencis\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.tcno));

#line default
#line hidden
            EndContext();
            BeginContext(335, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(379, 36, false);
#line 19 "C:\Users\murat\source\repos\egitim\egitim\Views\ogrencis\Delete.cshtml"
       Write(Html.DisplayFor(model => model.tcno));

#line default
#line hidden
            EndContext();
            BeginContext(415, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(459, 38, false);
#line 22 "C:\Users\murat\source\repos\egitim\egitim\Views\ogrencis\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ad));

#line default
#line hidden
            EndContext();
            BeginContext(497, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(541, 34, false);
#line 25 "C:\Users\murat\source\repos\egitim\egitim\Views\ogrencis\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ad));

#line default
#line hidden
            EndContext();
            BeginContext(575, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(619, 41, false);
#line 28 "C:\Users\murat\source\repos\egitim\egitim\Views\ogrencis\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.soyad));

#line default
#line hidden
            EndContext();
            BeginContext(660, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(704, 37, false);
#line 31 "C:\Users\murat\source\repos\egitim\egitim\Views\ogrencis\Delete.cshtml"
       Write(Html.DisplayFor(model => model.soyad));

#line default
#line hidden
            EndContext();
            BeginContext(741, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(785, 43, false);
#line 34 "C:\Users\murat\source\repos\egitim\egitim\Views\ogrencis\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.telefon));

#line default
#line hidden
            EndContext();
            BeginContext(828, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(872, 39, false);
#line 37 "C:\Users\murat\source\repos\egitim\egitim\Views\ogrencis\Delete.cshtml"
       Write(Html.DisplayFor(model => model.telefon));

#line default
#line hidden
            EndContext();
            BeginContext(911, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(955, 42, false);
#line 40 "C:\Users\murat\source\repos\egitim\egitim\Views\ogrencis\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.dtarih));

#line default
#line hidden
            EndContext();
            BeginContext(997, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1041, 38, false);
#line 43 "C:\Users\murat\source\repos\egitim\egitim\Views\ogrencis\Delete.cshtml"
       Write(Html.DisplayFor(model => model.dtarih));

#line default
#line hidden
            EndContext();
            BeginContext(1079, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1123, 42, false);
#line 46 "C:\Users\murat\source\repos\egitim\egitim\Views\ogrencis\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.egitim));

#line default
#line hidden
            EndContext();
            BeginContext(1165, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1209, 38, false);
#line 49 "C:\Users\murat\source\repos\egitim\egitim\Views\ogrencis\Delete.cshtml"
       Write(Html.DisplayFor(model => model.egitim));

#line default
#line hidden
            EndContext();
            BeginContext(1247, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1291, 40, false);
#line 52 "C:\Users\murat\source\repos\egitim\egitim\Views\ogrencis\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.burs));

#line default
#line hidden
            EndContext();
            BeginContext(1331, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1375, 36, false);
#line 55 "C:\Users\murat\source\repos\egitim\egitim\Views\ogrencis\Delete.cshtml"
       Write(Html.DisplayFor(model => model.burs));

#line default
#line hidden
            EndContext();
            BeginContext(1411, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1455, 40, false);
#line 58 "C:\Users\murat\source\repos\egitim\egitim\Views\ogrencis\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.onay));

#line default
#line hidden
            EndContext();
            BeginContext(1495, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1539, 36, false);
#line 61 "C:\Users\murat\source\repos\egitim\egitim\Views\ogrencis\Delete.cshtml"
       Write(Html.DisplayFor(model => model.onay));

#line default
#line hidden
            EndContext();
            BeginContext(1575, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1619, 41, false);
#line 64 "C:\Users\murat\source\repos\egitim\egitim\Views\ogrencis\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.kayit));

#line default
#line hidden
            EndContext();
            BeginContext(1660, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1704, 37, false);
#line 67 "C:\Users\murat\source\repos\egitim\egitim\Views\ogrencis\Delete.cshtml"
       Write(Html.DisplayFor(model => model.kayit));

#line default
#line hidden
            EndContext();
            BeginContext(1741, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1785, 40, false);
#line 70 "C:\Users\murat\source\repos\egitim\egitim\Views\ogrencis\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.sube));

#line default
#line hidden
            EndContext();
            BeginContext(1825, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1869, 36, false);
#line 73 "C:\Users\murat\source\repos\egitim\egitim\Views\ogrencis\Delete.cshtml"
       Write(Html.DisplayFor(model => model.sube));

#line default
#line hidden
            EndContext();
            BeginContext(1905, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1949, 43, false);
#line 76 "C:\Users\murat\source\repos\egitim\egitim\Views\ogrencis\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ders_id));

#line default
#line hidden
            EndContext();
            BeginContext(1992, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2036, 39, false);
#line 79 "C:\Users\murat\source\repos\egitim\egitim\Views\ogrencis\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ders_id));

#line default
#line hidden
            EndContext();
            BeginContext(2075, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2119, 39, false);
#line 82 "C:\Users\murat\source\repos\egitim\egitim\Views\ogrencis\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.kul));

#line default
#line hidden
            EndContext();
            BeginContext(2158, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2202, 35, false);
#line 85 "C:\Users\murat\source\repos\egitim\egitim\Views\ogrencis\Delete.cshtml"
       Write(Html.DisplayFor(model => model.kul));

#line default
#line hidden
            EndContext();
            BeginContext(2237, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2281, 41, false);
#line 88 "C:\Users\murat\source\repos\egitim\egitim\Views\ogrencis\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.sifre));

#line default
#line hidden
            EndContext();
            BeginContext(2322, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2366, 37, false);
#line 91 "C:\Users\murat\source\repos\egitim\egitim\Views\ogrencis\Delete.cshtml"
       Write(Html.DisplayFor(model => model.sifre));

#line default
#line hidden
            EndContext();
            BeginContext(2403, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2441, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51bf01ba5a694db4b951321b4db9ccf6", async() => {
                BeginContext(2467, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2477, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a918b0faff1547d2848fd9986f14d1cb", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 96 "C:\Users\murat\source\repos\egitim\egitim\Views\ogrencis\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2513, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(2597, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3e11ef1a3f241bf89c3c62db839eed1", async() => {
                    BeginContext(2619, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2635, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2648, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<egitim.Models.ogrenci> Html { get; private set; }
    }
}
#pragma warning restore 1591

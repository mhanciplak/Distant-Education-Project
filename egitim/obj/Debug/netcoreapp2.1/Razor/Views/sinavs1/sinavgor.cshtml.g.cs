#pragma checksum "C:\Users\murat\source\repos\egitim\egitim\Views\sinavs1\sinavgor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20eb26d6de5135ac582593dd755e173f93f06ce8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_sinavs1_sinavgor), @"mvc.1.0.view", @"/Views/sinavs1/sinavgor.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/sinavs1/sinavgor.cshtml", typeof(AspNetCore.Views_sinavs1_sinavgor))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20eb26d6de5135ac582593dd755e173f93f06ce8", @"/Views/sinavs1/sinavgor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c14c9264dec13091842345b9e8ccbfc556c30d2", @"/Views/_ViewImports.cshtml")]
    public class Views_sinavs1_sinavgor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<egitim.Models.sinav>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vertical/assets/js/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\murat\source\repos\egitim\egitim\Views\sinavs1\sinavgor.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layoutogrenci.cshtml";

#line default
#line hidden
            BeginContext(140, 81, true);
            WriteLiteral("\r\n<h1 class=\"profile-user-box card-box bg-custom\">Konu Testi</h1>\r\n\r\n    <ol>\r\n\r\n");
            EndContext();
#line 12 "C:\Users\murat\source\repos\egitim\egitim\Views\sinavs1\sinavgor.cshtml"
          int i = 1; 

#line default
#line hidden
            BeginContext(245, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 14 "C:\Users\murat\source\repos\egitim\egitim\Views\sinavs1\sinavgor.cshtml"
         foreach (var item in Model)
        {
           

#line default
#line hidden
            BeginContext(309, 87, true);
            WriteLiteral("            <li class=\"card-box ribbon-box\">\r\n                <h5 class=\"text-success\">");
            EndContext();
            BeginContext(397, 35, false);
#line 18 "C:\Users\murat\source\repos\egitim\egitim\Views\sinavs1\sinavgor.cshtml"
                                    Write(Html.DisplayFor(model => item.soru));

#line default
#line hidden
            EndContext();
            BeginContext(432, 23, true);
            WriteLiteral("</h5>\r\n                ");
            EndContext();
            BeginContext(456, 32, false);
#line 19 "C:\Users\murat\source\repos\egitim\egitim\Views\sinavs1\sinavgor.cshtml"
           Write(Html.HiddenFor(model => item.id));

#line default
#line hidden
            EndContext();
            BeginContext(488, 101, true);
            WriteLiteral("\r\n\r\n                <hr>\r\n                <div>\r\n                    <label class=\" control-label\">a)");
            EndContext();
            BeginContext(590, 32, false);
#line 23 "C:\Users\murat\source\repos\egitim\egitim\Views\sinavs1\sinavgor.cshtml"
                                               Write(Html.DisplayFor(model => item.a));

#line default
#line hidden
            EndContext();
            BeginContext(622, 112, true);
            WriteLiteral("</label>\r\n\r\n\r\n                </div>\r\n                <div>\r\n                    <label class=\"control-label\">b)");
            EndContext();
            BeginContext(735, 32, false);
#line 28 "C:\Users\murat\source\repos\egitim\egitim\Views\sinavs1\sinavgor.cshtml"
                                              Write(Html.DisplayFor(model => item.b));

#line default
#line hidden
            EndContext();
            BeginContext(767, 114, true);
            WriteLiteral("</label>\r\n\r\n\r\n                </div>\r\n\r\n                <div>\r\n                    <label class=\"control-label\">c)");
            EndContext();
            BeginContext(882, 32, false);
#line 34 "C:\Users\murat\source\repos\egitim\egitim\Views\sinavs1\sinavgor.cshtml"
                                              Write(Html.DisplayFor(model => item.c));

#line default
#line hidden
            EndContext();
            BeginContext(914, 114, true);
            WriteLiteral("</label>\r\n\r\n\r\n                </div>\r\n\r\n                <div>\r\n                    <label class=\"control-label\">d)");
            EndContext();
            BeginContext(1029, 32, false);
#line 40 "C:\Users\murat\source\repos\egitim\egitim\Views\sinavs1\sinavgor.cshtml"
                                              Write(Html.DisplayFor(model => item.d));

#line default
#line hidden
            EndContext();
            BeginContext(1061, 115, true);
            WriteLiteral("</label>\r\n\r\n\r\n                </div>\r\n\r\n                <div>\r\n                    <label class=\" control-label\">e)");
            EndContext();
            BeginContext(1177, 32, false);
#line 46 "C:\Users\murat\source\repos\egitim\egitim\Views\sinavs1\sinavgor.cshtml"
                                               Write(Html.DisplayFor(model => item.e));

#line default
#line hidden
            EndContext();
            BeginContext(1209, 198, true);
            WriteLiteral("</label>\r\n\r\n\r\n                </div>\r\n                <div>\r\n                    <div class=\"col-md-1\">\r\n                        <input type=\"text\" class=\"cevap form-control\" name=\"cevap\"  data-id=\"");
            EndContext();
            BeginContext(1408, 1, false);
#line 52 "C:\Users\murat\source\repos\egitim\egitim\Views\sinavs1\sinavgor.cshtml"
                                                                                        Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1409, 1, true);
            WriteLiteral("-");
            EndContext();
            BeginContext(1411, 36, false);
#line 52 "C:\Users\murat\source\repos\egitim\egitim\Views\sinavs1\sinavgor.cshtml"
                                                                                           Write(Html.DisplayFor(model => item.cevap));

#line default
#line hidden
            EndContext();
            BeginContext(1447, 104, true);
            WriteLiteral("\" />\r\n                       \r\n                    </div>\r\n                </div>\r\n\r\n            </li>\r\n");
            EndContext();
#line 58 "C:\Users\murat\source\repos\egitim\egitim\Views\sinavs1\sinavgor.cshtml"
            i++;

        }

#line default
#line hidden
            BeginContext(1582, 128, true);
            WriteLiteral("\r\n\r\n    </ol>\r\n    <div>\r\n       \r\n        <input type=\"submit\" value=\"Sonucu Gönder\" class=\"btn btn-default\" />\r\n    </div>\r\n\r\n");
            EndContext();
            BeginContext(1710, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ccf036b86ad4a56aa203ac1973be42b", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1768, 585, true);
            WriteLiteral(@"
<script>
    $(document).ready(function () {
        
        $(""input"").keyup(function () {
            var ayar = $(this).attr(""data-id"");
            var deger = ayar.split(""-"");
            var sonuc = $(this).val();
            if (deger[1] == sonuc) {
                
                $(""input[data-id='""+deger[0]+'-'+deger[1]+""']"").css(""background-color"", ""yellow"");
            }
            else {
                $(""input[data-id='"" + deger[0] + '-' + deger[1] +""']"").css(""background-color"", ""red"");
            }




        });

    });


</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<egitim.Models.sinav>> Html { get; private set; }
    }
}
#pragma warning restore 1591

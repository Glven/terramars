#pragma checksum "D:\terramars\TerraMars\TerraMars\Views\TerraMars\Calculate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cae787f037b16d75c5952975d87dac5ec4df8bca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TerraMars_Calculate), @"mvc.1.0.view", @"/Views/TerraMars/Calculate.cshtml")]
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
#line 1 "D:\terramars\TerraMars\TerraMars\Views\_ViewImports.cshtml"
using TerraMars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\terramars\TerraMars\TerraMars\Views\_ViewImports.cshtml"
using TerraMars.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\terramars\TerraMars\TerraMars\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.TagHelpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cae787f037b16d75c5952975d87dac5ec4df8bca", @"/Views/TerraMars/Calculate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2174448b87b62174decba6f36793aeb82fdc75be", @"/Views/_ViewImports.cshtml")]
    public class Views_TerraMars_Calculate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AllModels>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "TerraMars", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("modal-container__form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "D:\terramars\TerraMars\TerraMars\Views\TerraMars\Calculate.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""section section--dark calculate"">
    <div class=""container"">
        <div class=""row"">
        <div class=""col-12 col-lg-6"">
            <div class=""calculate-ranger ranger"">
                <h2 class=""calculate-ranger__title"">???????????????? ???????????? ?????????????? 100?? = <span>3</span></h2>
                <input type=""range"" min=""10"" max=""20000"" step=""10"" value=""10"" class=""ranger-btn calculate-ranger__width"">
                <input type=""text"" class=""ranger-value calculate-ranger__value"" id=""calculate-ranger__width"" value=""10"">
            </div>
        </div>
        <div class=""col-12 col-lg-6"">
            <div class=""calculate-ranger ranger"">
                <h2 class=""calculate-ranger__title"">???????????????? ?????????? ?????????????? 100?? = <span>3</span></h2>
                <input type=""range"" min=""10"" max=""20000"" step=""10"" value=""10"" class=""ranger-btn calculate-ranger__height"">
                <input type=""text"" class=""ranger-value calculate-ranger__value"" id=""calculate-ranger__height"" value=""10"">
  ");
            WriteLiteral(@"          </div>
        </div>
        </div>
        <div class=""calculate-square"">
        <h2 class=""calculate-square__title"">?????????? ??????????????</h2>
        <div class=""calculate-square__value""></div>
        </div>
        <h2 class=""calculate-title"">???????????????? ???????????????????????????? ????????????</h2>
        <div class=""calculate-services"">
");
#nullable restore
#line 29 "D:\terramars\TerraMars\TerraMars\Views\TerraMars\Calculate.cshtml"
             foreach (var s in Model.Services)
           {

#line default
#line hidden
#nullable disable
            WriteLiteral("               <div class=\"calculate-services__wrap\">\r\n                    <div class=\"calculate-checkbox checkbox\">\r\n                        <input type=\"checkbox\" class=\"calculate-checkbox__btn checkbox-btn\"");
            BeginWriteAttribute("id", " id=\"", 1681, "\"", 1694, 1);
#nullable restore
#line 33 "D:\terramars\TerraMars\TerraMars\Views\TerraMars\Calculate.cshtml"
WriteAttributeValue("", 1686, s.Title, 1686, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                    <label");
            BeginWriteAttribute("for", " for=\"", 1752, "\"", 1766, 1);
#nullable restore
#line 35 "D:\terramars\TerraMars\TerraMars\Views\TerraMars\Calculate.cshtml"
WriteAttributeValue("", 1758, s.Title, 1758, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span class=\"serviceName\">");
#nullable restore
#line 35 "D:\terramars\TerraMars\TerraMars\Views\TerraMars\Calculate.cshtml"
                                                               Write(s.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> - <span class=\"price\">");
#nullable restore
#line 35 "D:\terramars\TerraMars\TerraMars\Views\TerraMars\Calculate.cshtml"
                                                                                                     Write(s.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></label>\r\n                </div>\n");
#nullable restore
#line 37 "D:\terramars\TerraMars\TerraMars\Views\TerraMars\Calculate.cshtml"
           }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
         
        <div class=""calculate-total"">
            <h2 class=""calculate-total__title"">?????????? ??????????: </h2>
            <div class=""calculate-total__value""></div>
        </div>
		<div style=""display: flex; justify-content:center; margin-top: 40px;""> <a class=""btn btn-primary btn-order"">????????????????</a></div>

<!-- /.modal -->
    </div>
    <!-- /.container -->
</section>
<div class=""modal"">
    <div class=""modal-container"">
        <div class=""modal-container__close""><span></span></div>
        <!-- /.modal-container__close -->
        <h2 class=""modal-container__title"">?????????? ??????????????</h2>
        <!-- /.modal-container__title -->
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cae787f037b16d75c5952975d87dac5ec4df8bca9028", async() => {
                WriteLiteral(@"
        <div class=""form-group"">
            <label for=""name"">??????</label>
            <input type=""text"" name=""guestName"" id=""name"" class=""input input-primary"" placeholder=""?????????????? ?????? *"" required>
        </div>
        <div class=""form-group"">
            <label for=""phone"">??????????????</label>
            <input type=""text"" name=""guestPhone"" id=""phone"" class=""input input-primary"" placeholder=""?????????????? ?????????????? *"" required>
        </div>
        <div class=""modal-container__btn"">
            <input type=""submit"" value=""????????????????"" class=""btn btn-primary"">
        </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <!-- /.modal-container__form -->\r\n    </div>\r\n    <!-- /.modal-container -->\r\n</div>\r\n<!-- /.section section--dark calculate -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AllModels> Html { get; private set; }
    }
}
#pragma warning restore 1591

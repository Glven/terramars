#pragma checksum "D:\terramars\TerraMars\TerraMars\Views\Admin\detailsNew.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25a4cccc16b0e495fcc5a55021174c7d3b7373b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_detailsNew), @"mvc.1.0.view", @"/Views/Admin/detailsNew.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25a4cccc16b0e495fcc5a55021174c7d3b7373b3", @"/Views/Admin/detailsNew.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2174448b87b62174decba6f36793aeb82fdc75be", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_detailsNew : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TerraMars.Data.Entities.New>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\terramars\TerraMars\TerraMars\Views\Admin\detailsNew.cshtml"
  
	Layout = "_Admin";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"details section--dark\">\r\n\t<div class=\"container\">\r\n\t<div class=\"details-photo\">\r\n\t\t<img");
            BeginWriteAttribute("src", " src=\"", 163, "\"", 201, 1);
#nullable restore
#line 8 "D:\terramars\TerraMars\TerraMars\Views\Admin\detailsNew.cshtml"
WriteAttributeValue("", 169, Html.DisplayTextFor(m=>m.Photo), 169, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 202, "\"", 208, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n\t</div>\r\n\t<h2>");
#nullable restore
#line 10 "D:\terramars\TerraMars\TerraMars\Views\Admin\detailsNew.cshtml"
   Write(Html.DisplayTextFor(m => m.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\t<p>");
#nullable restore
#line 11 "D:\terramars\TerraMars\TerraMars\Views\Admin\detailsNew.cshtml"
  Write(Html.DisplayTextFor(m=>m.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TerraMars.Data.Entities.New> Html { get; private set; }
    }
}
#pragma warning restore 1591
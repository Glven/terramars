#pragma checksum "D:\terramars\TerraMars\TerraMars\Views\Admin\detailsReview.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2208414df7ab8dc0b92e344537871c998e730b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_detailsReview), @"mvc.1.0.view", @"/Views/Admin/detailsReview.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2208414df7ab8dc0b92e344537871c998e730b5", @"/Views/Admin/detailsReview.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2174448b87b62174decba6f36793aeb82fdc75be", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_detailsReview : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TerraMars.Data.Entities.Review>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\terramars\TerraMars\TerraMars\Views\Admin\detailsReview.cshtml"
  
	Layout = "_Admin";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"details section--dark\">\r\n\t<div class=\"container\">\r\n\t<h2>Имя пользователя: ");
#nullable restore
#line 7 "D:\terramars\TerraMars\TerraMars\Views\Admin\detailsReview.cshtml"
                     Write(Html.DisplayTextFor(m => m.User.Lastname));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 7 "D:\terramars\TerraMars\TerraMars\Views\Admin\detailsReview.cshtml"
                                                                Write(Html.DisplayTextFor(m => m.User.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\t<h3>Оценка: ");
#nullable restore
#line 8 "D:\terramars\TerraMars\TerraMars\Views\Admin\detailsReview.cshtml"
           Write(Html.DisplayTextFor(m => m.Grade));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\t<p style=\"color: #fff; font-size: 14px;\">");
#nullable restore
#line 9 "D:\terramars\TerraMars\TerraMars\Views\Admin\detailsReview.cshtml"
                                        Write(Html.DisplayTextFor(m => m.Comment));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TerraMars.Data.Entities.Review> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "D:\terramars\TerraMars\TerraMars\Views\Admin\adminReviews.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d988997640ab863d7cb0be73916ccfe4871e1ffe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_adminReviews), @"mvc.1.0.view", @"/Views/Admin/adminReviews.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d988997640ab863d7cb0be73916ccfe4871e1ffe", @"/Views/Admin/adminReviews.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2174448b87b62174decba6f36793aeb82fdc75be", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_adminReviews : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\terramars\TerraMars\TerraMars\Views\Admin\adminReviews.cshtml"
  
	Layout = "_Admin";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""adminReviews section--dark"">
    <div class=""container-fluid"">
        <table class=""adminTable"">
            <tr>
                <th>ID отзыва</th>
                <th>ID пользователя</th>
                <th>Фамилия</th>
                <th>Имя</th>
                <th>Оценка</th>
                <th>Действия</th>
            </tr>
            <tr>
                <td>99a82ce4-59ca-44c2-8478-9205ed54c293</td>
                <td>99a82ce4-59ca-44c2-8478-9205ed54c293</td>
                <td>Павлов</td>
                <td>Василий</td>
                <td>4,7</td>
                <td><div class=""adminActions""><a");
            BeginWriteAttribute("href", " href=\"", 681, "\"", 688, 0);
            EndWriteAttribute();
            WriteLiteral(">Детали</a><a");
            BeginWriteAttribute("href", " href=\"", 702, "\"", 709, 0);
            EndWriteAttribute();
            WriteLiteral(">Удалить</a></div></td>\r\n            </tr>\r\n        </table>\r\n    </div>\r\n</section>");
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
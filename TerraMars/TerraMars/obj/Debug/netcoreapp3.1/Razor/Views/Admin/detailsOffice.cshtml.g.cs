#pragma checksum "D:\terramars\TerraMars\TerraMars\Views\Admin\detailsOffice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "349dc155e078fcdbfd62c2e3fab595079edc1d43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_detailsOffice), @"mvc.1.0.view", @"/Views/Admin/detailsOffice.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"349dc155e078fcdbfd62c2e3fab595079edc1d43", @"/Views/Admin/detailsOffice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2174448b87b62174decba6f36793aeb82fdc75be", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_detailsOffice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TerraMars.Data.Entities.Office>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\terramars\TerraMars\TerraMars\Views\Admin\detailsOffice.cshtml"
  
	Layout = "_Admin";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"details section--dark\">\r\n\t<div class=\"container\">\r\n\t<h2>Адрес офиса: ");
#nullable restore
#line 7 "D:\terramars\TerraMars\TerraMars\Views\Admin\detailsOffice.cshtml"
                Write(Html.DisplayTextFor(m => m.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 8 "D:\terramars\TerraMars\TerraMars\Views\Admin\detailsOffice.cshtml"
         if(Model.Description != null)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<p class=\"detailsSquare\">Дополнительная информация: <br /> ");
#nullable restore
#line 10 "D:\terramars\TerraMars\TerraMars\Views\Admin\detailsOffice.cshtml"
                                                                  Write(Html.DisplayTextFor(m=>m.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(" км</p>\r\n");
#nullable restore
#line 11 "D:\terramars\TerraMars\TerraMars\Views\Admin\detailsOffice.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<p class=\"detailsPrice\">Номер офиса: ");
#nullable restore
#line 12 "D:\terramars\TerraMars\TerraMars\Views\Admin\detailsOffice.cshtml"
                                        Write(Html.DisplayTextFor(m=>m.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t<h3>Дни работы:</h3>\r\n\t<ul>\r\n");
#nullable restore
#line 15 "D:\terramars\TerraMars\TerraMars\Views\Admin\detailsOffice.cshtml"
         foreach (var s in Model.Schedules)
	   {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t   <li>");
#nullable restore
#line 17 "D:\terramars\TerraMars\TerraMars\Views\Admin\detailsOffice.cshtml"
          Write(s.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 17 "D:\terramars\TerraMars\TerraMars\Views\Admin\detailsOffice.cshtml"
                 Write(s.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 18 "D:\terramars\TerraMars\TerraMars\Views\Admin\detailsOffice.cshtml"
	   }

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</ul>\r\n</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TerraMars.Data.Entities.Office> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "D:\terramars\TerraMars\TerraMars\Views\Admin\editService.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31fab033553f28e65383aebd37ccfe9b05ecd702"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_editService), @"mvc.1.0.view", @"/Views/Admin/editService.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31fab033553f28e65383aebd37ccfe9b05ecd702", @"/Views/Admin/editService.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2174448b87b62174decba6f36793aeb82fdc75be", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_editService : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TerraMars.Data.Entities.Service>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\terramars\TerraMars\TerraMars\Views\Admin\editService.cshtml"
  
	Layout = "_Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Редактирование услуги</h2>\r\n");
#nullable restore
#line 6 "D:\terramars\TerraMars\TerraMars\Views\Admin\editService.cshtml"
 using(Html.BeginForm()){

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<div class=\"adminEdit\">\r\n\t\t<label>Название услуги</label>\r\n\t\t");
#nullable restore
#line 9 "D:\terramars\TerraMars\TerraMars\Views\Admin\editService.cshtml"
   Write(Html.EditorFor(m => m.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t</div>\r\n\t<div class=\"adminEdit\">\r\n\t\t<label></label>\r\n\t\t");
#nullable restore
#line 13 "D:\terramars\TerraMars\TerraMars\Views\Admin\editService.cshtml"
   Write(Html.EditorFor(m => m.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t</div>\r\n\t<div><input type=\"submit\" value=\"Сохранить изменения\" /></div>\r\n");
#nullable restore
#line 16 "D:\terramars\TerraMars\TerraMars\Views\Admin\editService.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TerraMars.Data.Entities.Service> Html { get; private set; }
    }
}
#pragma warning restore 1591
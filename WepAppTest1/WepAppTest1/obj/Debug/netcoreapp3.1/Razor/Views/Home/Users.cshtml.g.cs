#pragma checksum "/Users/sp/Desktop/C-Sharp-Projects/WepAppTest1/WepAppTest1/Views/Home/Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffd75548130ce851edfd3cefa6e60f4304f011f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Users), @"mvc.1.0.view", @"/Views/Home/Users.cshtml")]
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
#line 1 "/Users/sp/Desktop/C-Sharp-Projects/WepAppTest1/WepAppTest1/Views/_ViewImports.cshtml"
using WepAppTest1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/sp/Desktop/C-Sharp-Projects/WepAppTest1/WepAppTest1/Views/_ViewImports.cshtml"
using WepAppTest1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffd75548130ce851edfd3cefa6e60f4304f011f3", @"/Views/Home/Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"674b762eb981bc82e68ab09a10254da06457aaf1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/sp/Desktop/C-Sharp-Projects/WepAppTest1/WepAppTest1/Views/Home/Users.cshtml"
  
    ViewData["Title"] = "Test";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Test ");
#nullable restore
#line 8 "/Users/sp/Desktop/C-Sharp-Projects/WepAppTest1/WepAppTest1/Views/Home/Users.cshtml"
                          Write(ViewBag.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 9 "/Users/sp/Desktop/C-Sharp-Projects/WepAppTest1/WepAppTest1/Views/Home/Users.cshtml"
      
        foreach (Users user in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>Name: ");
#nullable restore
#line 12 "/Users/sp/Desktop/C-Sharp-Projects/WepAppTest1/WepAppTest1/Views/Home/Users.cshtml"
                Write(user.FullName());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n");
#nullable restore
#line 13 "/Users/sp/Desktop/C-Sharp-Projects/WepAppTest1/WepAppTest1/Views/Home/Users.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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

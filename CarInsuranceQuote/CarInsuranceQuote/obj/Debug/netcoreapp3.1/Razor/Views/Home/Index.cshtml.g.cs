#pragma checksum "/Users/sp/Desktop/C-Sharp-Projects/CarInsuranceQuote/CarInsuranceQuote/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2de76bcd40ac7381b46c9fe9558f509141034a12"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/Users/sp/Desktop/C-Sharp-Projects/CarInsuranceQuote/CarInsuranceQuote/Views/_ViewImports.cshtml"
using CarInsuranceQuote;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/sp/Desktop/C-Sharp-Projects/CarInsuranceQuote/CarInsuranceQuote/Views/_ViewImports.cshtml"
using CarInsuranceQuote.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2de76bcd40ac7381b46c9fe9558f509141034a12", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f03409f109d38ca7c2b505b30e8e6d6891a7465b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/sp/Desktop/C-Sharp-Projects/CarInsuranceQuote/CarInsuranceQuote/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Get Your Car Insurance Quote Now!</h2>\r\n<br />\r\n<div class=\"mx-auto\">\r\n");
#nullable restore
#line 8 "/Users/sp/Desktop/C-Sharp-Projects/CarInsuranceQuote/CarInsuranceQuote/Views/Home/Index.cshtml"
     using (Html.BeginForm("GetQuote", "Home", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""form-group row"">
            <label for=""FirstName"" class=""col-sm-2 col-form-label"">First Name</label>
            <div class=""col-sm-3"">
                <input type=""text"" class=""form-control"" name=""FirstName"" required>
            </div>
        </div>
        <div class=""form-group row"">
            <label for=""LastName"" class=""col-sm-2 col-form-label"">Last Name</label>
            <div class=""col-sm-3"">
                <input type=""text"" class=""form-control"" name=""LastName"" required>
            </div>
        </div>
");
            WriteLiteral(@"        <div class=""form-group row"">
            <label for=""Email"" class=""col-sm-2 col-form-label"">Email</label>
            <div class=""col-sm-3"">
                <input type=""email"" class=""form-control"" name=""Email"" required>
            </div>
        </div>
        <div class=""form-group row"">
            <label for=""DOB"" class=""col-sm-2 col-form-label"">Date of Birth</label>
            <div class=""col-sm-3"">
                <input type=""date"" class=""form-control"" name=""DOB"" required>
            </div>
        </div>
        <div class=""form-group row"">
            <label for=""CarYear"" class=""col-sm-2 col-form-label"">Car Year</label>
            <div class=""col-sm-3"">
                <input type=""text"" class=""form-control"" name=""CarYear"" required>
            </div>
        </div>
        <div class=""form-group row"">
            <label for=""CarMake"" class=""col-sm-2 col-form-label"">Car Make</label>
            <div class=""col-sm-3"">
                <input type=""text"" class=""form-cont");
            WriteLiteral(@"rol"" name=""CarMake"" required>
            </div>
        </div>
        <div class=""form-group row"">
            <label for=""CarModel"" class=""col-sm-2 col-form-label"">Car Model</label>
            <div class=""col-sm-3"">
                <input type=""text"" class=""form-control"" name=""CarModel"" required>
            </div>
        </div>
        <div class=""form-group row"">
            <label for=""DUIbool"" class=""col-sm-2 col-form-label"">Have you ever had a DUI?</label>
            <div class=""col-sm-3"">
                Yes ");
#nullable restore
#line 56 "/Users/sp/Desktop/C-Sharp-Projects/CarInsuranceQuote/CarInsuranceQuote/Views/Home/Index.cshtml"
               Write(Html.RadioButton("DUIbool", "true"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                No ");
#nullable restore
#line 57 "/Users/sp/Desktop/C-Sharp-Projects/CarInsuranceQuote/CarInsuranceQuote/Views/Home/Index.cshtml"
              Write(Html.RadioButton("DUIbool", "false"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>
        <div class=""form-group row"">
            <label for=""Speeding"" class=""col-sm-2 col-form-label"">How many speeding tickets have you had?</label>
            <div class=""col-sm-3"">
                <input type=""number"" min=""0"" class=""form-control"" name=""Speeding"" required>
            </div>
        </div>
        <div class=""form-group row"">
            <label for=""InsuranceType"" class=""col-sm-2 col-form-label"">Insurance Type</label>
            <div class=""col-sm-3"">
                Full Coverage ");
#nullable restore
#line 69 "/Users/sp/Desktop/C-Sharp-Projects/CarInsuranceQuote/CarInsuranceQuote/Views/Home/Index.cshtml"
                         Write(Html.RadioButton("InsuranceType", "true"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                Liability ");
#nullable restore
#line 70 "/Users/sp/Desktop/C-Sharp-Projects/CarInsuranceQuote/CarInsuranceQuote/Views/Home/Index.cshtml"
                     Write(Html.RadioButton("InsuranceType", "false"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n");
#nullable restore
#line 74 "/Users/sp/Desktop/C-Sharp-Projects/CarInsuranceQuote/CarInsuranceQuote/Views/Home/Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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

#pragma checksum "C:\Users\gauba\CD\C#\ASP\MVC\DojoSurvey\Views\Home\SurveyResponse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "027e6a0944debb4d0540800d0efe2670edf31e28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SurveyResponse), @"mvc.1.0.view", @"/Views/Home/SurveyResponse.cshtml")]
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
#line 1 "C:\Users\gauba\CD\C#\ASP\MVC\DojoSurvey\Views\_ViewImports.cshtml"
using DojoSurvey;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gauba\CD\C#\ASP\MVC\DojoSurvey\Views\_ViewImports.cshtml"
using DojoSurvey.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"027e6a0944debb4d0540800d0efe2670edf31e28", @"/Views/Home/SurveyResponse.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a67436b50a8d850d5f878261256993a0b6c9782", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SurveyResponse : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Survey>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\gauba\CD\C#\ASP\MVC\DojoSurvey\Views\Home\SurveyResponse.cshtml"
  
    ViewData["Title"] = "SurveyResponse";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1>Submitted Info</h1>\r\n    <p>Name: ");
#nullable restore
#line 9 "C:\Users\gauba\CD\C#\ASP\MVC\DojoSurvey\Views\Home\SurveyResponse.cshtml"
        Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Dojo Location: ");
#nullable restore
#line 10 "C:\Users\gauba\CD\C#\ASP\MVC\DojoSurvey\Views\Home\SurveyResponse.cshtml"
                 Write(Model.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Favorite Language: ");
#nullable restore
#line 11 "C:\Users\gauba\CD\C#\ASP\MVC\DojoSurvey\Views\Home\SurveyResponse.cshtml"
                     Write(Model.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Comment: ");
#nullable restore
#line 12 "C:\Users\gauba\CD\C#\ASP\MVC\DojoSurvey\Views\Home\SurveyResponse.cshtml"
           Write(Model.Comments);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <a href=\"/\">Back</a>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Survey> Html { get; private set; }
    }
}
#pragma warning restore 1591
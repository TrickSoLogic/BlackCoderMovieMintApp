#pragma checksum "C:\Users\visha\Desktop\Imp\ASP-master\MvcMovie\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39139449337b0fc8a8d3e2ad029fff2dc0672bae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "C:\Users\visha\Desktop\Imp\ASP-master\MvcMovie\Views\_ViewImports.cshtml"
using BlackCoderMovieMintApp;

#line default
#line hidden
#line 2 "C:\Users\visha\Desktop\Imp\ASP-master\MvcMovie\Views\_ViewImports.cshtml"
using BlackCoderMovieMintApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39139449337b0fc8a8d3e2ad029fff2dc0672bae", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a522bb61c801ba0131071ac8aba3984747fa78f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\visha\Desktop\Imp\ASP-master\MvcMovie\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
            BeginContext(38, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(43, 17, false);
#line 4 "C:\Users\visha\Desktop\Imp\ASP-master\MvcMovie\Views\Home\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(60, 10, true);
            WriteLiteral("</h2>\n<h3>");
            EndContext();
            BeginContext(71, 19, false);
#line 5 "C:\Users\visha\Desktop\Imp\ASP-master\MvcMovie\Views\Home\About.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(90, 197, true);
            WriteLiteral("</h3>\n\n\n<div class=\"text-center\">\n    <h1 class=\"display-4\">Hey Coder!! Happy Coding..</h1>\n    <p>Check Out -->> <a href=\"https://www.youtube.com/TrickSoLogic/\">Subscribe for more</a>.</p>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\visha\Desktop\Imp\ASP-master\MvcMovie\Views\HelloWorld\Welcome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "452e0ac670d2caf2ad2c54e85b28e78dccb0f765"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HelloWorld_Welcome), @"mvc.1.0.view", @"/Views/HelloWorld/Welcome.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HelloWorld/Welcome.cshtml", typeof(AspNetCore.Views_HelloWorld_Welcome))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"452e0ac670d2caf2ad2c54e85b28e78dccb0f765", @"/Views/HelloWorld/Welcome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a522bb61c801ba0131071ac8aba3984747fa78f4", @"/Views/_ViewImports.cshtml")]
    public class Views_HelloWorld_Welcome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\visha\Desktop\Imp\ASP-master\MvcMovie\Views\HelloWorld\Welcome.cshtml"
  
    ViewData["Title"] = "Welcome";

#line default
#line hidden
            BeginContext(40, 24, true);
            WriteLiteral("\n<h2>Welcome</h2>\n\n<ul>\n");
            EndContext();
#line 8 "C:\Users\visha\Desktop\Imp\ASP-master\MvcMovie\Views\HelloWorld\Welcome.cshtml"
     for (int i = 0; i < (int)ViewData["number"]; i++)
    {

#line default
#line hidden
            BeginContext(125, 12, true);
            WriteLiteral("        <li>");
            EndContext();
            BeginContext(138, 19, false);
#line 10 "C:\Users\visha\Desktop\Imp\ASP-master\MvcMovie\Views\HelloWorld\Welcome.cshtml"
       Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(157, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 11 "C:\Users\visha\Desktop\Imp\ASP-master\MvcMovie\Views\HelloWorld\Welcome.cshtml"
    }

#line default
#line hidden
            BeginContext(169, 197, true);
            WriteLiteral("</ul>\n\n\n<div class=\"text-center\">\n    <h1 class=\"display-4\">Hey Coder!! Happy Coding..</h1>\n    <p>Check Out -->> <a href=\"https://www.youtube.com/TrickSoLogic/\">Subscribe for more</a>.</p>\n</div>\n");
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

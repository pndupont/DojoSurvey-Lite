#pragma checksum "/home/paul/Documents/CodingDojo/DotNetStack/ASP/DOJOSURVEY/Views/Home/Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e11fc5fdbe985797586904e305dabee8ac161722"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Result), @"mvc.1.0.view", @"/Views/Home/Result.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Result.cshtml", typeof(AspNetCore.Views_Home_Result))]
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
#line 1 "/home/paul/Documents/CodingDojo/DotNetStack/ASP/DOJOSURVEY/Views/_ViewImports.cshtml"
using DOJOSURVEY;

#line default
#line hidden
#line 2 "/home/paul/Documents/CodingDojo/DotNetStack/ASP/DOJOSURVEY/Views/_ViewImports.cshtml"
using DOJOSURVEY.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e11fc5fdbe985797586904e305dabee8ac161722", @"/Views/Home/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee6b92dea306b90bf451fc953beecca3e705ac50", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 426, true);
            WriteLiteral(@"
    <h1>Results</h1>
    <div class=""row"">
        <div class=""col-sm-6"">
            <table class=""table table-hover"">
                <thead>
                    <tr>
                        <th>Name</th>
                        <th>Location</th>
                        <th>Favorite Stack</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>");
            EndContext();
            BeginContext(427, 12, false);
#line 15 "/home/paul/Documents/CodingDojo/DotNetStack/ASP/DOJOSURVEY/Views/Home/Result.cshtml"
                       Write(ViewBag.Name);

#line default
#line hidden
            EndContext();
            BeginContext(439, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(474, 16, false);
#line 16 "/home/paul/Documents/CodingDojo/DotNetStack/ASP/DOJOSURVEY/Views/Home/Result.cshtml"
                       Write(ViewBag.location);

#line default
#line hidden
            EndContext();
            BeginContext(490, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(525, 16, false);
#line 17 "/home/paul/Documents/CodingDojo/DotNetStack/ASP/DOJOSURVEY/Views/Home/Result.cshtml"
                       Write(ViewBag.FavStack);

#line default
#line hidden
            EndContext();
            BeginContext(541, 157, true);
            WriteLiteral("</td>\n                    </tr>\n                </tbody>\n            </table>\n        </div>\n    </div>\n    <br>\n    <div class=\'container mt-5\'>\n        <p>");
            EndContext();
            BeginContext(699, 15, false);
#line 25 "/home/paul/Documents/CodingDojo/DotNetStack/ASP/DOJOSURVEY/Views/Home/Result.cshtml"
      Write(ViewBag.Comment);

#line default
#line hidden
            EndContext();
            BeginContext(714, 16, true);
            WriteLiteral("</p>\n    </div>\n");
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
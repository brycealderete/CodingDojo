#pragma checksum "C:\Users\bryce\Desktop\Dojo_assignments\C#\projects\CRUDelicious\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fba3e1dd4b4eb7d07dc80cf03a568fdf556d800"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\bryce\Desktop\Dojo_assignments\C#\projects\CRUDelicious\Views\_ViewImports.cshtml"
using CRUDelicious;

#line default
#line hidden
#line 2 "C:\Users\bryce\Desktop\Dojo_assignments\C#\projects\CRUDelicious\Views\_ViewImports.cshtml"
using CRUDelicious.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fba3e1dd4b4eb7d07dc80cf03a568fdf556d800", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"815eae4269ab1eac71e8261ccfa9294c33285639", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Dish>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(21, 330, true);
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome to CRUDelicious</h1>
<div class=""container"">
    <div class=""row-mt-10-mb-10"">
        <div class=""col-sm-6"">
            <p>Check out some relcent dishes!</p>
        </div>
    </div>
    <div class=""row-mt-10-mb-10"">
        <div class=""Dishes col-sm-4"">
");
            EndContext();
#line 14 "C:\Users\bryce\Desktop\Dojo_assignments\C#\projects\CRUDelicious\Views\Home\Index.cshtml"
             foreach (Dish item in Model)           
            {

#line default
#line hidden
            BeginContext(420, 21, true);
            WriteLiteral("                <p><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 441, "\"", 470, 2);
            WriteAttributeValue("", 448, "dishinfo/", 448, 9, true);
#line 16 "C:\Users\bryce\Desktop\Dojo_assignments\C#\projects\CRUDelicious\Views\Home\Index.cshtml"
WriteAttributeValue("", 457, item.DishrId, 457, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(471, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(473, 13, false);
#line 16 "C:\Users\bryce\Desktop\Dojo_assignments\C#\projects\CRUDelicious\Views\Home\Index.cshtml"
                                               Write(item.DishName);

#line default
#line hidden
            EndContext();
            BeginContext(486, 8, true);
            WriteLiteral("</a> by ");
            EndContext();
            BeginContext(495, 14, false);
#line 16 "C:\Users\bryce\Desktop\Dojo_assignments\C#\projects\CRUDelicious\Views\Home\Index.cshtml"
                                                                     Write(item.CheifName);

#line default
#line hidden
            EndContext();
            BeginContext(509, 7, true);
            WriteLiteral(" </p>\r\n");
            EndContext();
#line 17 "C:\Users\bryce\Desktop\Dojo_assignments\C#\projects\CRUDelicious\Views\Home\Index.cshtml"
                
            }

#line default
#line hidden
            BeginContext(549, 273, true);
            WriteLiteral(@"            <p></p>
        </div>
        <div class=""col-sm-4"">
            <a href=""addDish"">Add a Dish</a>
        </div>
    </div>
</div>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Dish>> Html { get; private set; }
    }
}
#pragma warning restore 1591

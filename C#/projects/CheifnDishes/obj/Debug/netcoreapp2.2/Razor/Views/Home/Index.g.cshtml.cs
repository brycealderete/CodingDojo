#pragma checksum "C:\Users\bryce\Desktop\Dojo_assignments\C#\projects\CheifnDishes\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2871d8a3957438a26dd98d419b0b2e48d1e3299b"
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
#line 1 "C:\Users\bryce\Desktop\Dojo_assignments\C#\projects\CheifnDishes\Views\_ViewImports.cshtml"
using CheifnDishes;

#line default
#line hidden
#line 2 "C:\Users\bryce\Desktop\Dojo_assignments\C#\projects\CheifnDishes\Views\_ViewImports.cshtml"
using CheifnDishes.Models;

#line default
#line hidden
#line 4 "C:\Users\bryce\Desktop\Dojo_assignments\C#\projects\CheifnDishes\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2871d8a3957438a26dd98d419b0b2e48d1e3299b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"730c40e837b0fa801f8c363dc1527ce6723532ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Chef>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\bryce\Desktop\Dojo_assignments\C#\projects\CheifnDishes\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Chef Page";

#line default
#line hidden
            BeginContext(64, 385, true);
            WriteLiteral(@"
<div class=""text-center"">
    <h1>Chefs   |   <a href=""Dishes"">Dishes</a></h1>
    <a href=""AddChef"">Add a Chef</a>
</div>
<div class=""Container"">
    <h2>Check out our roster of Chefs!</h2>
</div>
<div>
    <table>
        <tr>
            <th class=""w-50"">   Name   </th>
            <th class=""w-45"">   Age   </th>
            <th class=""w-40"">   # of Dishes   </th>
");
            EndContext();
#line 19 "C:\Users\bryce\Desktop\Dojo_assignments\C#\projects\CheifnDishes\Views\Home\Index.cshtml"
             foreach (var item in Model)
            {
                var today=DateTime.Today;
                int Age= today.Year - item.Birthday.Year;

#line default
#line hidden
            BeginContext(608, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(655, 14, false);
#line 24 "C:\Users\bryce\Desktop\Dojo_assignments\C#\projects\CheifnDishes\Views\Home\Index.cshtml"
                   Write(item.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(669, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(671, 13, false);
#line 24 "C:\Users\bryce\Desktop\Dojo_assignments\C#\projects\CheifnDishes\Views\Home\Index.cshtml"
                                   Write(item.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(684, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(716, 3, false);
#line 25 "C:\Users\bryce\Desktop\Dojo_assignments\C#\projects\CheifnDishes\Views\Home\Index.cshtml"
                   Write(Age);

#line default
#line hidden
            EndContext();
            BeginContext(719, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(751, 17, false);
#line 26 "C:\Users\bryce\Desktop\Dojo_assignments\C#\projects\CheifnDishes\Views\Home\Index.cshtml"
                   Write(item.Dishes.Count);

#line default
#line hidden
            EndContext();
            BeginContext(768, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 28 "C:\Users\bryce\Desktop\Dojo_assignments\C#\projects\CheifnDishes\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(813, 37, true);
            WriteLiteral("        </tr>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Chef>> Html { get; private set; }
    }
}
#pragma warning restore 1591

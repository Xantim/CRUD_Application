#pragma checksum "C:\Users\ddkim\Desktop\Coding_Dojo\C#\CSharpORM\AS_CRUDelicious\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b91419903d36659408d110216ab7853fdf0653c"
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
#line 1 "C:\Users\ddkim\Desktop\Coding_Dojo\C#\CSharpORM\AS_CRUDelicious\Views\_ViewImports.cshtml"
using AS_CRUDelicious;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ddkim\Desktop\Coding_Dojo\C#\CSharpORM\AS_CRUDelicious\Views\_ViewImports.cshtml"
using AS_CRUDelicious.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b91419903d36659408d110216ab7853fdf0653c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f8a8ab3de09a3bdb2cdb74ac42cf5462e7eb2d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dish>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ddkim\Desktop\Coding_Dojo\C#\CSharpORM\AS_CRUDelicious\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome to CRUDelicious</h1>
    
    <a href=""Add"">Add a Dish!</a>
    <h2>Check out some of the recent dishes</h2>

    <table class=""table table-bordered"">
        <tr>
            <th>Name</th>
            <th>ChefName</th>
            <th>Calories</th>
            <th>Tastiness</th>
            <th>Description</th>

        </tr>
");
#nullable restore
#line 21 "C:\Users\ddkim\Desktop\Coding_Dojo\C#\CSharpORM\AS_CRUDelicious\Views\Home\Index.cshtml"
          
            foreach (Dish d in ViewBag.AllDishes)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 586, "\"", 602, 1);
#nullable restore
#line 25 "C:\Users\ddkim\Desktop\Coding_Dojo\C#\CSharpORM\AS_CRUDelicious\Views\Home\Index.cshtml"
WriteAttributeValue("", 593, d.DishID, 593, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 25 "C:\Users\ddkim\Desktop\Coding_Dojo\C#\CSharpORM\AS_CRUDelicious\Views\Home\Index.cshtml"
                                       Write(d.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                    <td>By: ");
#nullable restore
#line 26 "C:\Users\ddkim\Desktop\Coding_Dojo\C#\CSharpORM\AS_CRUDelicious\Views\Home\Index.cshtml"
                       Write(d.ChefName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 27 "C:\Users\ddkim\Desktop\Coding_Dojo\C#\CSharpORM\AS_CRUDelicious\Views\Home\Index.cshtml"
                   Write(d.Calories);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "C:\Users\ddkim\Desktop\Coding_Dojo\C#\CSharpORM\AS_CRUDelicious\Views\Home\Index.cshtml"
                   Write(d.Tastiness);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "C:\Users\ddkim\Desktop\Coding_Dojo\C#\CSharpORM\AS_CRUDelicious\Views\Home\Index.cshtml"
                   Write(d.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 31 "C:\Users\ddkim\Desktop\Coding_Dojo\C#\CSharpORM\AS_CRUDelicious\Views\Home\Index.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dish> Html { get; private set; }
    }
}
#pragma warning restore 1591

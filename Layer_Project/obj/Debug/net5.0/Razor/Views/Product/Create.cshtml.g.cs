#pragma checksum "C:\Users\Dominique\Desktop\STUFF\dev\C#\Domain_Layers\Layer_Project\Views\Product\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8616d544a09f6a17569d5064f23c2a1069656e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Create), @"mvc.1.0.view", @"/Views/Product/Create.cshtml")]
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
#line 1 "C:\Users\Dominique\Desktop\STUFF\dev\C#\Domain_Layers\Layer_Project\Views\_ViewImports.cshtml"
using Layer_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dominique\Desktop\STUFF\dev\C#\Domain_Layers\Layer_Project\Views\_ViewImports.cshtml"
using Layer_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8616d544a09f6a17569d5064f23c2a1069656e3", @"/Views/Product/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"274992c040d35bae7f04e9ba035ef81acb6c368c", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Application.ViewModels.ProductViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<table class=""table table-striped"">
    <thead>
        <tr>
            <th scope=""col"">Product Name</th>
            <th scope=""col"">Product Price</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <th scope=""row"">1</th>
            <td>Mark</td>
            <td>Otto</td>
            <td></td>
        </tr>
        <tr>
            <th scope=""row"">2</th>
            <td>Jacob</td>
            <td>Thornton</td>
            <td></td>
        </tr>
        <tr>
            <th scope=""row"">3</th>
            <td>Larry</td>
            <td>the Bird</td>
            <td></td>
        </tr>
    </tbody>
</table>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Application.ViewModels.ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
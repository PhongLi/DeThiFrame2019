#pragma checksum "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\OnThi\Views\CongNhan\ListCNByNum.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "763a19d6c4260ddbd1e4ccdd9af88c3dcd594c86"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CongNhan_ListCNByNum), @"mvc.1.0.view", @"/Views/CongNhan/ListCNByNum.cshtml")]
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
#line 1 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\OnThi\Views\_ViewImports.cshtml"
using OnThi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\OnThi\Views\_ViewImports.cshtml"
using OnThi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"763a19d6c4260ddbd1e4ccdd9af88c3dcd594c86", @"/Views/CongNhan/ListCNByNum.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d30f2d71fb7589b11d41d42e6b15d2e15563936f", @"/Views/_ViewImports.cshtml")]
    public class Views_CongNhan_ListCNByNum : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<object>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\OnThi\Views\CongNhan\ListCNByNum.cshtml"
  
    ViewData["Title"] = "Liệt kê thông tin nhân viên có số triệu chứng";

#line default
#line hidden
#nullable disable
            WriteLiteral("<table border=\"1\">\r\n    <tr>\r\n        <th>Tên Công nhân</th>\r\n        <th>Năm sinh</th>\r\n        <th>Nước về</th>\r\n        <th>Số triệu chứng</th>\r\n    </tr>\r\n");
#nullable restore
#line 12 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\OnThi\Views\CongNhan\ListCNByNum.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 16 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\OnThi\Views\CongNhan\ListCNByNum.cshtml"
           Write(item.GetType().GetProperty("tenCN").GetValue(item, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 19 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\OnThi\Views\CongNhan\ListCNByNum.cshtml"
           Write(item.GetType().GetProperty("NamSinh").GetValue(item, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 22 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\OnThi\Views\CongNhan\ListCNByNum.cshtml"
           Write(item.GetType().GetProperty("Nuocve").GetValue(item, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 25 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\OnThi\Views\CongNhan\ListCNByNum.cshtml"
           Write(item.GetType().GetProperty("SoTC").GetValue(item, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 28 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\OnThi\Views\CongNhan\ListCNByNum.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<object>> Html { get; private set; }
    }
}
#pragma warning restore 1591
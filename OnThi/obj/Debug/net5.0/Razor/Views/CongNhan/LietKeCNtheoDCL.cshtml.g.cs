#pragma checksum "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\Onthi\Views\CongNhan\LietKeCNtheoDCL.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77172e0fb711c9fa2a5700dad2bf368a7db132d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CongNhan_LietKeCNtheoDCL), @"mvc.1.0.view", @"/Views/CongNhan/LietKeCNtheoDCL.cshtml")]
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
#line 1 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\Onthi\Views\_ViewImports.cshtml"
using OnThi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\Onthi\Views\_ViewImports.cshtml"
using OnThi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77172e0fb711c9fa2a5700dad2bf368a7db132d2", @"/Views/CongNhan/LietKeCNtheoDCL.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d30f2d71fb7589b11d41d42e6b15d2e15563936f", @"/Views/_ViewImports.cshtml")]
    public class Views_CongNhan_LietKeCNtheoDCL : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CongNhanModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("<table border=\"1\">\r\n\r\n    <tr>\r\n        <th>Mã công nhân</th>\r\n        <th>Tên công nhân</th>\r\n        <th>Chức năng</th>\r\n    </tr>\r\n");
#nullable restore
#line 13 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\Onthi\Views\CongNhan\LietKeCNtheoDCL.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 17 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\Onthi\Views\CongNhan\LietKeCNtheoDCL.cshtml"
           Write(item.MaCongNhan);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 20 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\Onthi\Views\CongNhan\LietKeCNtheoDCL.cshtml"
           Write(item.TenCongNhan);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 407, "\"", 449, 2);
            WriteAttributeValue("", 414, "DeleteThietBi?MaNV=", 414, 19, true);
#nullable restore
#line 23 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\Onthi\Views\CongNhan\LietKeCNtheoDCL.cshtml"
WriteAttributeValue("", 433, item.MaCongNhan, 433, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Xóa</a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 478, "\"", 518, 2);
            WriteAttributeValue("", 485, "ViewThietBi?MaNV=", 485, 17, true);
#nullable restore
#line 24 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\Onthi\Views\CongNhan\LietKeCNtheoDCL.cshtml"
WriteAttributeValue("", 502, item.MaCongNhan, 502, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">View</a>\r\n            </td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 28 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\Onthi\Views\CongNhan\LietKeCNtheoDCL.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CongNhanModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
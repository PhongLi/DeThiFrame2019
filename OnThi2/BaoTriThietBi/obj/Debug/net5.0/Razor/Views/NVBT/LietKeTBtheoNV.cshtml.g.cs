#pragma checksum "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi2\OnThi2\BaoTriThietBi\Views\NVBT\LietKeTBtheoNV.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bada658a1de433abe85d2b98d5ba8724d62b83a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NVBT_LietKeTBtheoNV), @"mvc.1.0.view", @"/Views/NVBT/LietKeTBtheoNV.cshtml")]
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
#line 1 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi2\OnThi2\BaoTriThietBi\Views\_ViewImports.cshtml"
using BaoTriThietBi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi2\OnThi2\BaoTriThietBi\Views\_ViewImports.cshtml"
using BaoTriThietBi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bada658a1de433abe85d2b98d5ba8724d62b83a", @"/Views/NVBT/LietKeTBtheoNV.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dd7496f5f0d5567ca16c9ea36a852d80675d418", @"/Views/_ViewImports.cshtml")]
    public class Views_NVBT_LietKeTBtheoNV : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BaoTriThietBi.Models.NVBTModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h2>Danh sách thiết bị của nhân viên được chọn sửa</h2>\r\n<table border=\"1\">\r\n\r\n    <tr>\r\n        <th>Mã thiết bị</th>\r\n        <th>Mã căn hộ</th>\r\n        <th>Lần thứ</th>\r\n        <th>Ngày bảo trì</th>\r\n        <th>Chức năng</th>\r\n    </tr>\r\n");
#nullable restore
#line 17 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi2\OnThi2\BaoTriThietBi\Views\NVBT\LietKeTBtheoNV.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 21 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi2\OnThi2\BaoTriThietBi\Views\NVBT\LietKeTBtheoNV.cshtml"
           Write(item.MaThietBi);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 24 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi2\OnThi2\BaoTriThietBi\Views\NVBT\LietKeTBtheoNV.cshtml"
           Write(item.MaCanHo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 27 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi2\OnThi2\BaoTriThietBi\Views\NVBT\LietKeTBtheoNV.cshtml"
           Write(item.LanThu);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 30 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi2\OnThi2\BaoTriThietBi\Views\NVBT\LietKeTBtheoNV.cshtml"
           Write(item.NgayBaoTri);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 668, "\"", 730, 4);
            WriteAttributeValue("", 675, "DeleteThietBi?MaNV=", 675, 19, true);
#nullable restore
#line 33 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi2\OnThi2\BaoTriThietBi\Views\NVBT\LietKeTBtheoNV.cshtml"
WriteAttributeValue("", 694, item.MaNhanVien, 694, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 710, "&LanThu=", 710, 8, true);
#nullable restore
#line 33 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi2\OnThi2\BaoTriThietBi\Views\NVBT\LietKeTBtheoNV.cshtml"
WriteAttributeValue("", 718, item.LanThu, 718, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Xóa</a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 759, "\"", 819, 4);
            WriteAttributeValue("", 766, "ViewThietBi?MaNV=", 766, 17, true);
#nullable restore
#line 34 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi2\OnThi2\BaoTriThietBi\Views\NVBT\LietKeTBtheoNV.cshtml"
WriteAttributeValue("", 783, item.MaNhanVien, 783, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 799, "&LanThu=", 799, 8, true);
#nullable restore
#line 34 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi2\OnThi2\BaoTriThietBi\Views\NVBT\LietKeTBtheoNV.cshtml"
WriteAttributeValue("", 807, item.LanThu, 807, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">View</a>\r\n            </td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 38 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi2\OnThi2\BaoTriThietBi\Views\NVBT\LietKeTBtheoNV.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BaoTriThietBi.Models.NVBTModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

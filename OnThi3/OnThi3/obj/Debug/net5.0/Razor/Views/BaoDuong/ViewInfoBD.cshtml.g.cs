#pragma checksum "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\OnThi3\OnThi3\Views\BaoDuong\ViewInfoBD.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54efbba3c442ff8d3a32e1ac0b00462a7a44f180"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BaoDuong_ViewInfoBD), @"mvc.1.0.view", @"/Views/BaoDuong/ViewInfoBD.cshtml")]
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
#line 1 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\OnThi3\OnThi3\Views\_ViewImports.cshtml"
using OnThi3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\OnThi3\OnThi3\Views\_ViewImports.cshtml"
using OnThi3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54efbba3c442ff8d3a32e1ac0b00462a7a44f180", @"/Views/BaoDuong/ViewInfoBD.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6d99e55048d11278f12ef7f7d39cca85e71040a", @"/Views/_ViewImports.cshtml")]
    public class Views_BaoDuong_ViewInfoBD : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Object>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\OnThi3\OnThi3\Views\BaoDuong\ViewInfoBD.cshtml"
  
    var thanhtien = 0;
    foreach (var item in Model)
    {
        thanhtien += (int)@item.GetType().GetProperty("DONGIA").GetValue(item, null);
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table>\r\n");
#nullable restore
#line 12 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\OnThi3\OnThi3\Views\BaoDuong\ViewInfoBD.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                Ngày nhận xe <input type=\"date\" name=\"NGAYGIONHAN\"");
            BeginWriteAttribute("value", " value=\"", 338, "\"", 403, 1);
#nullable restore
#line 16 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\OnThi3\OnThi3\Views\BaoDuong\ViewInfoBD.cshtml"
WriteAttributeValue("", 346, item.GetType().GetProperty("NGAYGIONHAN").GetValue(item), 346, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />               \r\n            </td>\r\n            <td>\r\n                Ngày trả xe <input type=\"date\" name=\"NGAYGIOTRA\"");
            BeginWriteAttribute("value", " value=\"", 525, "\"", 589, 1);
#nullable restore
#line 19 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\OnThi3\OnThi3\Views\BaoDuong\ViewInfoBD.cshtml"
WriteAttributeValue("", 533, item.GetType().GetProperty("NGAYGIOTRA").GetValue(item), 533, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 22 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\OnThi3\OnThi3\Views\BaoDuong\ViewInfoBD.cshtml"
        break;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <tr>\r\n        <td>\r\n        </td>\r\n        <td>\r\n            Thành tiền <input type=\"text\" name=\"thanhtien\"");
            BeginWriteAttribute("value", " value=\"", 765, "\"", 783, 1);
#nullable restore
#line 29 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\OnThi3\OnThi3\Views\BaoDuong\ViewInfoBD.cshtml"
WriteAttributeValue("", 773, thanhtien, 773, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </td>\r\n    </tr>\r\n</table>\r\n\r\n<table border=\"1\">\r\n    <tr>\r\n        <th>Tên Công việc</th>\r\n        <th>Đơn giá</th>\r\n        <th>Chức năng</th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 41 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\OnThi3\OnThi3\Views\BaoDuong\ViewInfoBD.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 45 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\OnThi3\OnThi3\Views\BaoDuong\ViewInfoBD.cshtml"
           Write(item.GetType().GetProperty("TENCV").GetValue(item, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 48 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\OnThi3\OnThi3\Views\BaoDuong\ViewInfoBD.cshtml"
           Write(item.GetType().GetProperty("DONGIA").GetValue(item, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1272, "\"", 1413, 4);
            WriteAttributeValue("", 1279, "DeleteCTBD?MABD=", 1279, 16, true);
#nullable restore
#line 51 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\OnThi3\OnThi3\Views\BaoDuong\ViewInfoBD.cshtml"
WriteAttributeValue("", 1295, item.GetType().GetProperty("MABD").GetValue(item, null), 1295, 56, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1351, "&MACV=", 1351, 6, true);
#nullable restore
#line 51 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\OnThi3\OnThi3\Views\BaoDuong\ViewInfoBD.cshtml"
WriteAttributeValue("", 1357, item.GetType().GetProperty("MACV").GetValue(item, null), 1357, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Xóa</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 54 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\OnThi3\OnThi3\Views\BaoDuong\ViewInfoBD.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Object>> Html { get; private set; }
    }
}
#pragma warning restore 1591

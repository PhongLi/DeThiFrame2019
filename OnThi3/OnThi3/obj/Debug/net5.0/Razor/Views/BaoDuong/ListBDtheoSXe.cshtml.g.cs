#pragma checksum "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\OnThi3\OnThi3\Views\BaoDuong\ListBDtheoSXe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21fa26360988222fa9303e420e48cb12ab064841"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BaoDuong_ListBDtheoSXe), @"mvc.1.0.view", @"/Views/BaoDuong/ListBDtheoSXe.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21fa26360988222fa9303e420e48cb12ab064841", @"/Views/BaoDuong/ListBDtheoSXe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6d99e55048d11278f12ef7f7d39cca85e71040a", @"/Views/_ViewImports.cshtml")]
    public class Views_BaoDuong_ListBDtheoSXe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BaoDuongModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditInfoBD", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewInfoBD", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <table border=\"1\">\r\n        <tr>\r\n            <th>Ng??y gi??? nh???n</th>\r\n            <th>Ng??y gi??? tr???</th>\r\n            <th>S??? km</th>\r\n            <th>N???i dung</th>\r\n            <th>Ch???c n??ng</th>\r\n        </tr>\r\n\r\n");
#nullable restore
#line 12 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\OnThi3\OnThi3\Views\BaoDuong\ListBDtheoSXe.cshtml"
         foreach(var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 17 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\OnThi3\OnThi3\Views\BaoDuong\ListBDtheoSXe.cshtml"
                   Write(item.NGAYGIONHAN);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 20 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\OnThi3\OnThi3\Views\BaoDuong\ListBDtheoSXe.cshtml"
                   Write(item.NGAYGIOTRA);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 23 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\OnThi3\OnThi3\Views\BaoDuong\ListBDtheoSXe.cshtml"
                   Write(item.SOKM);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 26 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\OnThi3\OnThi3\Views\BaoDuong\ListBDtheoSXe.cshtml"
                   Write(item.SOXE);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
#nullable restore
#line 28 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\OnThi3\OnThi3\Views\BaoDuong\ListBDtheoSXe.cshtml"
                     if (string.IsNullOrEmpty(item.NGAYGIOTRA) == true)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 848, "\"", 881, 2);
            WriteAttributeValue("", 855, "ViewInfoBD?MABD=", 855, 16, true);
#nullable restore
#line 31 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\OnThi3\OnThi3\Views\BaoDuong\ListBDtheoSXe.cshtml"
WriteAttributeValue("", 871, item.MABD, 871, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Xem</a>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21fa26360988222fa9303e420e48cb12ab0648416452", async() => {
                WriteLiteral("S???a");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-MABD", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\OnThi3\OnThi3\Views\BaoDuong\ListBDtheoSXe.cshtml"
                                                           WriteLiteral(item.MABD);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["MABD"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-MABD", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["MABD"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n");
#nullable restore
#line 34 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\OnThi3\OnThi3\Views\BaoDuong\ListBDtheoSXe.cshtml"
                    }
                    else { 

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21fa26360988222fa9303e420e48cb12ab0648418993", async() => {
                WriteLiteral("Xem");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-MABD", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\OnThi3\OnThi3\Views\BaoDuong\ListBDtheoSXe.cshtml"
                                                           WriteLiteral(item.MABD);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["MABD"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-MABD", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["MABD"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <span >S???a</span>\r\n                        </td> \r\n");
#nullable restore
#line 40 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\OnThi3\OnThi3\Views\BaoDuong\ListBDtheoSXe.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n                </tr>\r\n");
#nullable restore
#line 43 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\OnThi3\OnThi3\Views\BaoDuong\ListBDtheoSXe.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BaoDuongModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\OnThi3\OnThi3\Views\BaoDuong\EditInfoBD.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2212f81f84a94048e4be9b2356843bf86447acc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BaoDuong_EditInfoBD), @"mvc.1.0.view", @"/Views/BaoDuong/EditInfoBD.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2212f81f84a94048e4be9b2356843bf86447acc", @"/Views/BaoDuong/EditInfoBD.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6d99e55048d11278f12ef7f7d39cca85e71040a", @"/Views/_ViewImports.cshtml")]
    public class Views_BaoDuong_EditInfoBD : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BaoDuongModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/BaoDuong/updateBD"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2212f81f84a94048e4be9b2356843bf86447acc3924", async() => {
                WriteLiteral("\r\n    Ng??y gi??? nh???n xe <input type=\"date\" name=\"Ngaygionhan\"");
                BeginWriteAttribute("value", " value=\"", 134, "\"", 160, 1);
#nullable restore
#line 5 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\OnThi3\OnThi3\Views\BaoDuong\EditInfoBD.cshtml"
WriteAttributeValue("", 142, Model.NGAYGIONHAN, 142, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" disabled/> <br />\r\n    Ng??y gi??? tr??? xe <input type=\"date\" name=\"Ngaygiotra\"");
                BeginWriteAttribute("value", " value=\"", 237, "\"", 262, 1);
#nullable restore
#line 6 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\OnThi3\OnThi3\Views\BaoDuong\EditInfoBD.cshtml"
WriteAttributeValue("", 245, Model.NGAYGIOTRA, 245, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n    N???i dung <input type=\"text\" name=\"noidung\"");
                BeginWriteAttribute("value", " value=\"", 320, "\"", 342, 1);
#nullable restore
#line 7 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\OnThi3\OnThi3\Views\BaoDuong\EditInfoBD.cshtml"
WriteAttributeValue("", 328, Model.NOIDUNG, 328, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" disabled/><br />\r\n    S??? km <input type=\"text\" name=\"sokm\"");
                BeginWriteAttribute("value", " value=\"", 402, "\"", 421, 1);
#nullable restore
#line 8 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\OnThi3\OnThi3\Views\BaoDuong\EditInfoBD.cshtml"
WriteAttributeValue("", 410, Model.SOKM, 410, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" disabled/><br />\r\n    <input type=\"hidden\" name=\"MABD\"");
                BeginWriteAttribute("value", " value=\"", 477, "\"", 496, 1);
#nullable restore
#line 9 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\OnThi3\OnThi3\Views\BaoDuong\EditInfoBD.cshtml"
WriteAttributeValue("", 485, Model.MABD, 485, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <input type=\"submit\" value=\"c???p nh???t\" name=\"submit\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BaoDuongModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

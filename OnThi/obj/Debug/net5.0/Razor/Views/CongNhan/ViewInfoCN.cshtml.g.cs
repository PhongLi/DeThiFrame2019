#pragma checksum "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\Onthi\Views\CongNhan\ViewInfoCN.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed5a5a6047f1bbc30aa0ce09091f717d86eec40e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CongNhan_ViewInfoCN), @"mvc.1.0.view", @"/Views/CongNhan/ViewInfoCN.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed5a5a6047f1bbc30aa0ce09091f717d86eec40e", @"/Views/CongNhan/ViewInfoCN.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d30f2d71fb7589b11d41d42e6b15d2e15563936f", @"/Views/_ViewImports.cshtml")]
    public class Views_CongNhan_ViewInfoCN : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnThi.Models.CongNhanModel>
    {
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
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h2>View</h2>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed5a5a6047f1bbc30aa0ce09091f717d86eec40e3313", async() => {
                WriteLiteral("\r\n    <label>Mã công nhân</label> <input type=\"text\" name=\"maCN\"");
                BeginWriteAttribute("value", " value=\"", 137, "\"", 162, 1);
#nullable restore
#line 11 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\Onthi\Views\CongNhan\ViewInfoCN.cshtml"
WriteAttributeValue("", 145, Model.MaCongNhan, 145, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" disabled /><br>\r\n    <label>Tên công nhân</label> <input type=\"text\" name=\"tenCN\"");
                BeginWriteAttribute("value", " value=\"", 245, "\"", 271, 1);
#nullable restore
#line 12 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\Onthi\Views\CongNhan\ViewInfoCN.cshtml"
WriteAttributeValue("", 253, Model.TenCongNhan, 253, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" disabled /><br>\r\n    <label>Giới tính</label>\r\n");
#nullable restore
#line 14 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\Onthi\Views\CongNhan\ViewInfoCN.cshtml"
     if (@Model.GioiTinh == true)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <input type=\"checkbox\" checked disabled /><br>\r\n");
#nullable restore
#line 17 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\Onthi\Views\CongNhan\ViewInfoCN.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <input type=\"checkbox\" disabled /><br>\r\n");
#nullable restore
#line 21 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\Onthi\Views\CongNhan\ViewInfoCN.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <label>Năm sinh</label> <input type=\"text\" name=\"Namsinh\"");
                BeginWriteAttribute("value", " value=\"", 558, "\"", 580, 1);
#nullable restore
#line 22 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\Onthi\Views\CongNhan\ViewInfoCN.cshtml"
WriteAttributeValue("", 566, Model.NamSinh, 566, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" disabled /><br>\r\n    <label>Nước về</label> <input type=\"text\" name=\"Nuocve\"");
                BeginWriteAttribute("value", " value=\"", 658, "\"", 679, 1);
#nullable restore
#line 23 "E:\UNIVERSITY\Nam3\framework\Thuchanh\OnThi\Onthi\Views\CongNhan\ViewInfoCN.cshtml"
WriteAttributeValue("", 666, Model.NuocVe, 666, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" disabled /><br>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnThi.Models.CongNhanModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

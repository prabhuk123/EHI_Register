#pragma checksum "C:\PRABU\ServiceRequestAssignment\servicerequestassignment\ServiceRequestApp\ServiceRequestApp\Views\Home\UserInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "743328e4634541211168d8ce339ffce3c18bdb4c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UserInfo), @"mvc.1.0.view", @"/Views/Home/UserInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/UserInfo.cshtml", typeof(AspNetCore.Views_Home_UserInfo))]
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
#line 1 "C:\PRABU\ServiceRequestAssignment\servicerequestassignment\ServiceRequestApp\ServiceRequestApp\Views\_ViewImports.cshtml"
using HomeServiceApp;

#line default
#line hidden
#line 2 "C:\PRABU\ServiceRequestAssignment\servicerequestassignment\ServiceRequestApp\ServiceRequestApp\Views\_ViewImports.cshtml"
using HomeServiceApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"743328e4634541211168d8ce339ffce3c18bdb4c", @"/Views/Home/UserInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"465107e9fd76346d53f6064fc3b23333fadc8041", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UserInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("serviceRequest"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return false;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\PRABU\ServiceRequestAssignment\servicerequestassignment\ServiceRequestApp\ServiceRequestApp\Views\Home\UserInfo.cshtml"
  
    ViewData["Title"] = "User Information";

#line default
#line hidden
            BeginContext(54, 96, true);
            WriteLiteral("\r\n<h2>User Information</h2>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        \r\n        ");
            EndContext();
            BeginContext(150, 1719, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "654aee90ed5545eeb3a54749a9292d60", async() => {
                BeginContext(235, 40, true);
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n");
                EndContext();
                BeginContext(394, 1468, true);
                WriteLiteral(@"                <button id=""btncreatebutton"" name=""btncreatebutton"" value=""Click here to Register "" class=""btn btn-info"">Click here to Register</button>
            </div>
            <div id=""divuserinfo"" hidden>
                <div class=""form-group"">
                    <label for=""exampleInputPassword1"">First Name</label>
                    <input type=""text"" class=""form-control"" id=""txt_FName"" autocomplete=""off"" placeholder=""First Name"" required>
                </div>
                <div class=""form-group"">
                    <label for=""exampleInputPassword1"">Last Name</label>
                    <input type=""text"" class=""form-control"" id=""txt_LName"" autocomplete=""off"" placeholder=""Last Name"" required>
                </div>
                <div class=""form-group"">
                    <label for=""exampleInputPassword1"">Email</label>
                    <input type=""email"" class=""form-control"" id=""txt_Email"" autocomplete=""off"" placeholder=""Email"" required>
                </div>
     ");
                WriteLiteral(@"           <div class=""form-group"">
                    <label for=""exampleInputPassword1"">Work Exp</label>
                    <input type=""text"" class=""form-control"" id=""txt_WorkExp"" autocomplete=""off"" placeholder=""Work Exp"" required>
                </div>

                <div class=""form-group"">
                    <input type=""submit"" value=""Create"" class=""btn btn-success"" />
                </div>
            </div>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1869, 28, true);
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n");
            EndContext();
            BeginContext(1897, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93638a18ae574fdb83eba67244c0588f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1948, 1639, true);
            WriteLiteral(@"
<script type=""text/javascript"">
    $(document).ready(function () {
      $(""#divuserinfo"").hide();
       
    });
    $(""#serviceRequest"").submit(function (evt) {
             submitData();
    });
    $(""#btncreatebutton"").click(function () {
        debugger;
        $(""#divuserinfo"").show();
        $(""#btncreatebutton"").hide();
    });

    //$(""#btncreatebutton"").on(""click"", function () {
    //    alert(""test"");
    //});
    function submitData() {
        debugger;
        var serviceRequest = {};
        serviceRequest.firstname = $('#txt_FName').val();
        serviceRequest.lastname = $('#txt_LName').val();
        serviceRequest.email = $('#txt_Email').val();
        serviceRequest.wrkExp = $('#txt_WorkExp').val();

       
        $.ajax({
            url: ""http://localhost:61804/api/HomeService/userinfo"",
            type: 'POST',
            dataType: 'json',
            async: false,
            data: JSON.stringify(serviceRequest),
            contentType: ");
            WriteLiteral(@"""application/json"",
            success: function (responsive) {
                debugger;
                //localStorage.setItem('regId', 1);
                //window.location.href = '/Home/UserUpload';
                if (responsive.success == 'true') {
                    alert(responsive.message);
                    localStorage.setItem('regId', responsive.id);
                    window.location.href = '/Home/UserUpload';
                }
                else {
                    alert(responsive.message);
                }
                
            }

        });
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
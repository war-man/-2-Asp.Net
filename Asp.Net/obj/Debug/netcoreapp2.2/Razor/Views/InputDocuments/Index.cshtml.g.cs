#pragma checksum "C:\Users\vital\OneDrive\Рабочий стол\БД\Kursach1\Views\InputDocuments\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "378c7ee72cfbd62bca86a72acbc9373a3dab4631"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_InputDocuments_Index), @"mvc.1.0.view", @"/Views/InputDocuments/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/InputDocuments/Index.cshtml", typeof(AspNetCore.Views_InputDocuments_Index))]
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
#line 1 "C:\Users\vital\OneDrive\Рабочий стол\БД\Kursach1\Views\_ViewImports.cshtml"
using Kursach;

#line default
#line hidden
#line 2 "C:\Users\vital\OneDrive\Рабочий стол\БД\Kursach1\Views\_ViewImports.cshtml"
using Kursach.Models;

#line default
#line hidden
#line 1 "C:\Users\vital\OneDrive\Рабочий стол\БД\Kursach1\Views\InputDocuments\Index.cshtml"
using Kursach.Data.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"378c7ee72cfbd62bca86a72acbc9373a3dab4631", @"/Views/InputDocuments/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f25e4126cf7b940ec7a958fe707d1fe1887186ff", @"/Views/_ViewImports.cshtml")]
    public class Views_InputDocuments_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Kursach.Models.PagempViewmodel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "InputDocuments", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PreCreate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "OutputDocuments", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Indexing", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:flex"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "interiordocuments", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Downloading", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "inputdocuments", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteDoc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditStatus", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration:none;color:white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "outputdocuments", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\vital\OneDrive\Рабочий стол\БД\Kursach1\Views\InputDocuments\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(114, 8, true);
            WriteLiteral("<html>\r\n");
            EndContext();
            BeginContext(122, 17, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "378c7ee72cfbd62bca86a72acbc9373a3dab46318544", async() => {
                BeginContext(128, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(139, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(141, 4470, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "378c7ee72cfbd62bca86a72acbc9373a3dab46319730", async() => {
                BeginContext(147, 83, true);
                WriteLiteral("\r\n    <div class=\"text-center\">\r\n        <div style=\"display: flex;\">\r\n            ");
                EndContext();
                BeginContext(230, 209, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "378c7ee72cfbd62bca86a72acbc9373a3dab463110202", async() => {
                    BeginContext(288, 147, true);
                    WriteLiteral("\r\n                <button type=\"button\" class=\"btn btn-primary\">\r\n                    Create InputDocument\r\n                </button>\r\n            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(439, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(453, 496, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "378c7ee72cfbd62bca86a72acbc9373a3dab463112043", async() => {
                    BeginContext(548, 202, true);
                    WriteLiteral("\r\n                <input type=\"text\" class=\"form-control\" placeholder=\"search\" style=\"width: 180px; margin-left: 18px;\" id=\"serarch-text\" name=\"sort\" />\r\n                <input type=\"hidden\" name=\"page\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 750, "\"", 786, 1);
#line 20 "C:\Users\vital\OneDrive\Рабочий стол\БД\Kursach1\Views\InputDocuments\Index.cshtml"
WriteAttributeValue("", 758, Model.pagination.PageNumber, 758, 28, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(787, 155, true);
                    WriteLiteral(" />\r\n                <button type=\"submit\" id=\"serarch\" class=\"btn btn-outline-info\" style=\"height: 38px; margin-left: 12px;\">Search</button>\r\n            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(949, 824, true);
                WriteLiteral(@"
            <input type=""button"" class=""btn btn-outline-primary"" value=""Clean search"" id=""text2"" style=""margin-left:10px;"" onclick=""SearchClean()"" />
        </div><br />
        <table class=""table table-striped"" style=""margin-top:30px"">
            <thead>
                <tr>
                    <th>Id</th>
                    <th>Имя утвердителя</th>
                    <th>Компания, которая получает документ</th>
                    <th>Уровень доступа</th>
                    <th>Тип документа</th>
                    <th>Статус документа</th>
                    <th>Название файла</th>
                    <th>Время выпуска</th>
                    <th>Дедлайн</th>
                    <th></th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
                EndContext();
#line 42 "C:\Users\vital\OneDrive\Рабочий стол\БД\Kursach1\Views\InputDocuments\Index.cshtml"
                 foreach (var i in Model.input_Documents)
                {

#line default
#line hidden
                BeginContext(1851, 46, true);
                WriteLiteral("                <tr>\r\n                    <td>");
                EndContext();
                BeginContext(1898, 19, false);
#line 45 "C:\Users\vital\OneDrive\Рабочий стол\БД\Kursach1\Views\InputDocuments\Index.cshtml"
                   Write(i.Input_DocumentsId);

#line default
#line hidden
                EndContext();
                BeginContext(1917, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(1949, 24, false);
#line 46 "C:\Users\vital\OneDrive\Рабочий стол\БД\Kursach1\Views\InputDocuments\Index.cshtml"
                   Write(i.Approver.employee_name);

#line default
#line hidden
                EndContext();
                BeginContext(1973, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(2005, 28, false);
#line 47 "C:\Users\vital\OneDrive\Рабочий стол\БД\Kursach1\Views\InputDocuments\Index.cshtml"
                   Write(i.department.Department_name);

#line default
#line hidden
                EndContext();
                BeginContext(2033, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(2065, 14, false);
#line 48 "C:\Users\vital\OneDrive\Рабочий стол\БД\Kursach1\Views\InputDocuments\Index.cshtml"
                   Write(i.Access_Level);

#line default
#line hidden
                EndContext();
                BeginContext(2079, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(2111, 16, false);
#line 49 "C:\Users\vital\OneDrive\Рабочий стол\БД\Kursach1\Views\InputDocuments\Index.cshtml"
                   Write(i.Type.type_name);

#line default
#line hidden
                EndContext();
                BeginContext(2127, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(2159, 8, false);
#line 50 "C:\Users\vital\OneDrive\Рабочий стол\БД\Kursach1\Views\InputDocuments\Index.cshtml"
                   Write(i.Status);

#line default
#line hidden
                EndContext();
                BeginContext(2167, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(2199, 10, false);
#line 51 "C:\Users\vital\OneDrive\Рабочий стол\БД\Kursach1\Views\InputDocuments\Index.cshtml"
                   Write(i.FileHref);

#line default
#line hidden
                EndContext();
                BeginContext(2209, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(2241, 15, false);
#line 52 "C:\Users\vital\OneDrive\Рабочий стол\БД\Kursach1\Views\InputDocuments\Index.cshtml"
                   Write(i.Data_register);

#line default
#line hidden
                EndContext();
                BeginContext(2256, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(2288, 10, false);
#line 53 "C:\Users\vital\OneDrive\Рабочий стол\БД\Kursach1\Views\InputDocuments\Index.cshtml"
                   Write(i.DeadLine);

#line default
#line hidden
                EndContext();
                BeginContext(2298, 57, true);
                WriteLiteral("</td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(2355, 127, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "378c7ee72cfbd62bca86a72acbc9373a3dab463119928", async() => {
                    BeginContext(2447, 31, true);
                    WriteLiteral("<i class=\"fas fa-download\"></i>");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-file", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 55 "C:\Users\vital\OneDrive\Рабочий стол\БД\Kursach1\Views\InputDocuments\Index.cshtml"
                                                                                           WriteLiteral(i.FileHref);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["file"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-file", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["file"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2482, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(2561, 126, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "378c7ee72cfbd62bca86a72acbc9373a3dab463122768", async() => {
                    BeginContext(2655, 28, true);
                    WriteLiteral("<i class=\"fas fa-trash\"></i>");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 58 "C:\Users\vital\OneDrive\Рабочий стол\БД\Kursach1\Views\InputDocuments\Index.cshtml"
                                                                                    WriteLiteral(i.Input_DocumentsId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2687, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(2766, 132, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "378c7ee72cfbd62bca86a72acbc9373a3dab463125599", async() => {
                    BeginContext(2861, 33, true);
                    WriteLiteral("<i class=\"fas fa-pencil-alt\"></i>");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 61 "C:\Users\vital\OneDrive\Рабочий стол\БД\Kursach1\Views\InputDocuments\Index.cshtml"
                                                                                     WriteLiteral(i.Input_DocumentsId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2898, 74, true);
                WriteLiteral("\r\n                    </td>\r\n                    \r\n                </tr>\r\n");
                EndContext();
#line 65 "C:\Users\vital\OneDrive\Рабочий стол\БД\Kursach1\Views\InputDocuments\Index.cshtml"
                }

#line default
#line hidden
                BeginContext(2991, 40, true);
                WriteLiteral("            </tbody>\r\n        </table>\r\n");
                EndContext();
#line 68 "C:\Users\vital\OneDrive\Рабочий стол\БД\Kursach1\Views\InputDocuments\Index.cshtml"
         if (Model.pagination.HasPreviousPage)
        {

#line default
#line hidden
                BeginContext(3090, 12, true);
                WriteLiteral("            ");
                EndContext();
                BeginContext(3102, 331, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "378c7ee72cfbd62bca86a72acbc9373a3dab463129047", async() => {
                    BeginContext(3280, 149, true);
                    WriteLiteral("\r\n                <button class=\"btn btn-info\">\r\n                    <i class=\"fas fa-arrow-left\"></i> Назад\r\n                </button>\r\n            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_12.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_13.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 70 "C:\Users\vital\OneDrive\Рабочий стол\БД\Kursach1\Views\InputDocuments\Index.cshtml"
                                                                                                              WriteLiteral(Model.sortparam);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 70 "C:\Users\vital\OneDrive\Рабочий стол\БД\Kursach1\Views\InputDocuments\Index.cshtml"
                                                                                                                                                 WriteLiteral(Model.pagination.PageNumber-1);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3433, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 75 "C:\Users\vital\OneDrive\Рабочий стол\БД\Kursach1\Views\InputDocuments\Index.cshtml"

        }
        else
        {

#line default
#line hidden
                BeginContext(3473, 213, true);
                WriteLiteral("            <a style=\"text-decoration:none;color:white\">\r\n                <button class=\"btn btn-info\">\r\n                    <i class=\"fas fa-arrow-left\"></i> Назад\r\n\r\n                </button>\r\n            </a>\r\n");
                EndContext();
#line 85 "C:\Users\vital\OneDrive\Рабочий стол\БД\Kursach1\Views\InputDocuments\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(3697, 8, true);
                WriteLiteral("        ");
                EndContext();
#line 86 "C:\Users\vital\OneDrive\Рабочий стол\БД\Kursach1\Views\InputDocuments\Index.cshtml"
         if (Model.pagination.HasNextPage)
        {

#line default
#line hidden
                BeginContext(3752, 12, true);
                WriteLiteral("            ");
                EndContext();
                BeginContext(3764, 333, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "378c7ee72cfbd62bca86a72acbc9373a3dab463133926", async() => {
                    BeginContext(3942, 151, true);
                    WriteLiteral("\r\n                <button class=\"btn btn-info\">\r\n                    Вперед <i class=\"fas fa-arrow-right\"></i>\r\n                </button>\r\n            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_12.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_13.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 88 "C:\Users\vital\OneDrive\Рабочий стол\БД\Kursach1\Views\InputDocuments\Index.cshtml"
                                                                                                              WriteLiteral(Model.sortparam);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 88 "C:\Users\vital\OneDrive\Рабочий стол\БД\Kursach1\Views\InputDocuments\Index.cshtml"
                                                                                                                                                 WriteLiteral(Model.pagination.PageNumber+1);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4097, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 93 "C:\Users\vital\OneDrive\Рабочий стол\БД\Kursach1\Views\InputDocuments\Index.cshtml"
        }
        else
        {

#line default
#line hidden
                BeginContext(4135, 215, true);
                WriteLiteral("            <a style=\"text-decoration:none;color:white\">\r\n                <button class=\"btn btn-info\">\r\n                    Вперед <i class=\"fas fa-arrow-right\"></i>\r\n\r\n                </button>\r\n            </a>\r\n");
                EndContext();
#line 102 "C:\Users\vital\OneDrive\Рабочий стол\БД\Kursach1\Views\InputDocuments\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(4361, 243, true);
                WriteLiteral("\r\n\r\n\r\n    </div>\r\n    <script src=\"../../lib/FontAwesome/all.min.js\"></script>\r\n    <script>\r\n        function SearchClean() {\r\n        var elem = document.getElementById(\"serarch-text\");\r\n\r\n        elem.value = \"\";\r\n        }\r\n    </script>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4611, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Kursach.Models.PagempViewmodel> Html { get; private set; }
    }
}
#pragma warning restore 1591

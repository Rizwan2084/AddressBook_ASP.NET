#pragma checksum "C:\Users\rizwan.b\source\repos\Technovert\Technovert\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8428c70ad8af24262a43ec697c52be27869aee26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\rizwan.b\source\repos\Technovert\Technovert\Views\_ViewImports.cshtml"
using Technovert;

#line default
#line hidden
#line 2 "C:\Users\rizwan.b\source\repos\Technovert\Technovert\Views\_ViewImports.cshtml"
using Technovert.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8428c70ad8af24262a43ec697c52be27869aee26", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b1d57f33dfbbf6084ab7189bd93ff930ca27392", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Technovert.Models.ContactList>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("image-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Edit-icon.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("image-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/delete1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\rizwan.b\source\repos\Technovert\Technovert\Views\Home\Index.cshtml"
  
	ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(80, 64, true);
            WriteLiteral("\r\n\r\n\r\n\r\n<div id=\"completeContainer\">\r\n\t<div id=\"contactsList\">\r\n");
            EndContext();
#line 11 "C:\Users\rizwan.b\source\repos\Technovert\Technovert\Views\Home\Index.cshtml"
         if (Model.Contacts.Count != 0)
		{

#line default
#line hidden
            BeginContext(184, 22, true);
            WriteLiteral("\t\t\t<h4>CONTACTS</h4>\r\n");
            EndContext();
#line 14 "C:\Users\rizwan.b\source\repos\Technovert\Technovert\Views\Home\Index.cshtml"
		}

#line default
#line hidden
            BeginContext(211, 2, true);
            WriteLiteral("\t\t");
            EndContext();
#line 15 "C:\Users\rizwan.b\source\repos\Technovert\Technovert\Views\Home\Index.cshtml"
         foreach (var item in Model.Contacts)
		{

#line default
#line hidden
            BeginContext(257, 5, true);
            WriteLiteral("\t\t\t<a");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 262, "\"", 275, 1);
#line 17 "C:\Users\rizwan.b\source\repos\Technovert\Technovert\Views\Home\Index.cshtml"
WriteAttributeValue("", 267, item.ID, 267, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(276, 27, true);
            WriteLiteral(" class=\"side-contacts-list\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 303, "\"", 359, 1);
#line 17 "C:\Users\rizwan.b\source\repos\Technovert\Technovert\Views\Home\Index.cshtml"
WriteAttributeValue("", 310, Url.Action("Index", "Home", new { ID = item.ID}), 310, 49, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(360, 53, true);
            WriteLiteral(">\r\n\t\t\t\t<div class=\"contact\">\r\n\t\t\t\t\t<h1 class=\"pname\">");
            EndContext();
            BeginContext(414, 9, false);
#line 19 "C:\Users\rizwan.b\source\repos\Technovert\Technovert\Views\Home\Index.cshtml"
                                 Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(423, 30, true);
            WriteLiteral("</h1>\r\n\t\t\t\t\t<p class=\"pemail\">");
            EndContext();
            BeginContext(454, 10, false);
#line 20 "C:\Users\rizwan.b\source\repos\Technovert\Technovert\Views\Home\Index.cshtml"
                                 Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(464, 30, true);
            WriteLiteral("</p>\r\n\t\t\t\t\t<p class=\"pmobile\">");
            EndContext();
            BeginContext(495, 11, false);
#line 21 "C:\Users\rizwan.b\source\repos\Technovert\Technovert\Views\Home\Index.cshtml"
                                  Write(item.Mobile);

#line default
#line hidden
            EndContext();
            BeginContext(506, 27, true);
            WriteLiteral("</p>\r\n\t\t\t\t</div>\r\n\t\t\t</a>\r\n");
            EndContext();
#line 24 "C:\Users\rizwan.b\source\repos\Technovert\Technovert\Views\Home\Index.cshtml"
		}

#line default
#line hidden
            BeginContext(538, 15, true);
            WriteLiteral("\t</div>\r\n\r\n\r\n\r\n");
            EndContext();
#line 29 "C:\Users\rizwan.b\source\repos\Technovert\Technovert\Views\Home\Index.cshtml"
     if ((bool)ViewData["isClicked"] == true)
	{

#line default
#line hidden
            BeginContext(601, 142, true);
            WriteLiteral("\t\t<div id=\"contact-info\" runat =\"server\">\r\n\t\t\t<div class=\"contact-container\">\r\n\t\t\t\t<div class=\"display-contact\">\r\n\t\t\t\t\t<h1 id=\"display-name\"> ");
            EndContext();
            BeginContext(744, 25, false);
#line 34 "C:\Users\rizwan.b\source\repos\Technovert\Technovert\Views\Home\Index.cshtml"
                                      Write(Model.clickedContact.Name);

#line default
#line hidden
            EndContext();
            BeginContext(769, 41, true);
            WriteLiteral("</h1>\r\n\t\t\t\t\t<p id=\"display-email\">Email: ");
            EndContext();
            BeginContext(811, 26, false);
#line 35 "C:\Users\rizwan.b\source\repos\Technovert\Technovert\Views\Home\Index.cshtml"
                                            Write(Model.clickedContact.Email);

#line default
#line hidden
            EndContext();
            BeginContext(837, 61, true);
            WriteLiteral("</p> <br />\r\n\t\t\t\t\t<div>\r\n\t\t\t\t\t\t<p id=\"display-phone\">Mobile: ");
            EndContext();
            BeginContext(899, 27, false);
#line 37 "C:\Users\rizwan.b\source\repos\Technovert\Technovert\Views\Home\Index.cshtml"
                                                 Write(Model.clickedContact.Mobile);

#line default
#line hidden
            EndContext();
            BeginContext(926, 47, true);
            WriteLiteral("</p>\r\n\t\t\t\t\t\t<p id=\"display-landline\">Landline: ");
            EndContext();
            BeginContext(974, 29, false);
#line 38 "C:\Users\rizwan.b\source\repos\Technovert\Technovert\Views\Home\Index.cshtml"
                                                      Write(Model.clickedContact.Landline);

#line default
#line hidden
            EndContext();
            BeginContext(1003, 70, true);
            WriteLiteral("</p>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<br />\r\n\t\t\t\t\t<p id=\"display-website\">Website: ");
            EndContext();
            BeginContext(1074, 28, false);
#line 41 "C:\Users\rizwan.b\source\repos\Technovert\Technovert\Views\Home\Index.cshtml"
                                                Write(Model.clickedContact.Website);

#line default
#line hidden
            EndContext();
            BeginContext(1102, 57, true);
            WriteLiteral("</p>\r\n\t\t\t\t\t<br />\r\n\t\t\t\t\t<p id=\"display-address\">Address: ");
            EndContext();
            BeginContext(1160, 28, false);
#line 43 "C:\Users\rizwan.b\source\repos\Technovert\Technovert\Views\Home\Index.cshtml"
                                                Write(Model.clickedContact.Address);

#line default
#line hidden
            EndContext();
            BeginContext(1188, 71, true);
            WriteLiteral("</p>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"icons\">\r\n\t\t\t\t\t<div id=\"edit\">\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(1259, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "01931cd8163a47959003b3be05e1e062", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1317, 2, true);
            WriteLiteral("<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1319, "\"", 1390, 1);
#line 47 "C:\Users\rizwan.b\source\repos\Technovert\Technovert\Views\Home\Index.cshtml"
WriteAttributeValue("", 1326, Url.Action("Edit", "Home", new { ID = Model.clickedContact.ID}), 1326, 64, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1391, 54, true);
            WriteLiteral(">EDIT</a>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div id=\"delete\">\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(1445, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d9e25f69db9d47e9ad83994baa88cf19", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1503, 2, true);
            WriteLiteral("<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1505, "\"", 1578, 1);
#line 50 "C:\Users\rizwan.b\source\repos\Technovert\Technovert\Views\Home\Index.cshtml"
WriteAttributeValue("", 1512, Url.Action("Delete", "Home", new { ID = Model.clickedContact.ID}), 1512, 66, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1579, 59, true);
            WriteLiteral(">DELETE</a>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n");
            EndContext();
#line 55 "C:\Users\rizwan.b\source\repos\Technovert\Technovert\Views\Home\Index.cshtml"
	}

#line default
#line hidden
            BeginContext(1642, 16, true);
            WriteLiteral("\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Technovert.Models.ContactList> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\rizwan.b\source\repos\Technovert\Technovert\Views\ContactDetails\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1bc42dfb25128face671925da2fb1d9ff4bd5cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ContactDetails_Index), @"mvc.1.0.view", @"/Views/ContactDetails/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ContactDetails/Index.cshtml", typeof(AspNetCore.Views_ContactDetails_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1bc42dfb25128face671925da2fb1d9ff4bd5cf", @"/Views/ContactDetails/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b1d57f33dfbbf6084ab7189bd93ff930ca27392", @"/Views/_ViewImports.cshtml")]
    public class Views_ContactDetails_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Technovert.Models.ContactList>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\rizwan.b\source\repos\Technovert\Technovert\Views\ContactDetails\Index.cshtml"
  
	ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(80, 36, true);
            WriteLiteral("\r\n<h4>CONTACTS</h4>\r\n\r\n\r\n\r\n\r\n<div>\r\n");
            EndContext();
#line 12 "C:\Users\rizwan.b\source\repos\Technovert\Technovert\Views\ContactDetails\Index.cshtml"
     foreach (var item in Model.Contacts)
	{

#line default
#line hidden
            BeginContext(160, 22, true);
            WriteLiteral("\t\t<div class=\"contact\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 182, "\"", 225, 1);
#line 14 "C:\Users\rizwan.b\source\repos\Technovert\Technovert\Views\ContactDetails\Index.cshtml"
WriteAttributeValue("", 187, Html.DisplayFor(modelItem => item.ID), 187, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(226, 24, true);
            WriteLiteral(">\r\n\t\t\t<h1 class=\"pname\">");
            EndContext();
            BeginContext(251, 39, false);
#line 15 "C:\Users\rizwan.b\source\repos\Technovert\Technovert\Views\ContactDetails\Index.cshtml"
                         Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(290, 28, true);
            WriteLiteral("</h1>\r\n\t\t\t<p class=\"pemail\">");
            EndContext();
            BeginContext(319, 40, false);
#line 16 "C:\Users\rizwan.b\source\repos\Technovert\Technovert\Views\ContactDetails\Index.cshtml"
                         Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(359, 28, true);
            WriteLiteral("</p>\r\n\t\t\t<p class=\"pmobile\">");
            EndContext();
            BeginContext(388, 41, false);
#line 17 "C:\Users\rizwan.b\source\repos\Technovert\Technovert\Views\ContactDetails\Index.cshtml"
                          Write(Html.DisplayFor(modelItem => item.Mobile));

#line default
#line hidden
            EndContext();
            BeginContext(429, 16, true);
            WriteLiteral("</p>\r\n\t\t</div>\r\n");
            EndContext();
#line 19 "C:\Users\rizwan.b\source\repos\Technovert\Technovert\Views\ContactDetails\Index.cshtml"
	}

#line default
#line hidden
            BeginContext(449, 10, true);
            WriteLiteral("</div>\r\n\r\n");
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
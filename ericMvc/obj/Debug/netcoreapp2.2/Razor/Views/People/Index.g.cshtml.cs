#pragma checksum "C:\Users\erict\Desktop\recycle practice\ericMvc\Views\People\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "394e4b1dada994ad502ce3c767e66a9d4f1760b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_People_Index), @"mvc.1.0.view", @"/Views/People/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/People/Index.cshtml", typeof(AspNetCore.Views_People_Index))]
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
#line 1 "C:\Users\erict\Desktop\recycle practice\ericMvc\Views\_ViewImports.cshtml"
using ericMvc;

#line default
#line hidden
#line 2 "C:\Users\erict\Desktop\recycle practice\ericMvc\Views\_ViewImports.cshtml"
using ericMvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"394e4b1dada994ad502ce3c767e66a9d4f1760b2", @"/Views/People/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbdfc2ba917e43f5967127a331dccafffb255d24", @"/Views/_ViewImports.cshtml")]
    public class Views_People_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ericMvc.Models.PeopleModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 58, true);
            WriteLiteral("\r\n<h1 class=\"display-4\">People Controller view</h1>\r\n\r\n<p>");
            EndContext();
            BeginContext(107, 39, false);
#line 5 "C:\Users\erict\Desktop\recycle practice\ericMvc\Views\People\Index.cshtml"
Write(Html.ActionLink("Create New", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(146, 49, true);
            WriteLiteral("\r\n</p>\r\n\r\n<table class=\"table\">\r\n<tr>\r\n<th>\r\n    ");
            EndContext();
            BeginContext(196, 44, false);
#line 11 "C:\Users\erict\Desktop\recycle practice\ericMvc\Views\People\Index.cshtml"
Write(Html.DisplayNameFor(model=> model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(240, 19, true);
            WriteLiteral("\r\n</th>\r\n<th>\r\n    ");
            EndContext();
            BeginContext(260, 43, false);
#line 14 "C:\Users\erict\Desktop\recycle practice\ericMvc\Views\People\Index.cshtml"
Write(Html.DisplayNameFor(model=> model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(303, 19, true);
            WriteLiteral("\r\n</th>\r\n<th>\r\n    ");
            EndContext();
            BeginContext(323, 38, false);
#line 17 "C:\Users\erict\Desktop\recycle practice\ericMvc\Views\People\Index.cshtml"
Write(Html.DisplayNameFor(model=> model.Age));

#line default
#line hidden
            EndContext();
            BeginContext(361, 18, true);
            WriteLiteral("\r\n</th>\r\n</tr>\r\n\r\n");
            EndContext();
#line 21 "C:\Users\erict\Desktop\recycle practice\ericMvc\Views\People\Index.cshtml"
 foreach(var item in Model){

#line default
#line hidden
            BeginContext(409, 36, true);
            WriteLiteral("    <tr>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(446, 43, false);
#line 24 "C:\Users\erict\Desktop\recycle practice\ericMvc\Views\People\Index.cshtml"
       Write(Html.DisplayFor(ModelItem=> item.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(489, 57, true);
            WriteLiteral("\r\n        </td>\r\n    \r\n     <\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(547, 42, false);
#line 29 "C:\Users\erict\Desktop\recycle practice\ericMvc\Views\People\Index.cshtml"
       Write(Html.DisplayFor(ModelItem=> item.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(589, 56, true);
            WriteLiteral("\r\n        </td>\r\n    \r\n     \r\n        <td>\r\n            ");
            EndContext();
            BeginContext(646, 37, false);
#line 34 "C:\Users\erict\Desktop\recycle practice\ericMvc\Views\People\Index.cshtml"
       Write(Html.DisplayFor(ModelItem=> item.Age));

#line default
#line hidden
            EndContext();
            BeginContext(683, 28, true);
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n");
            EndContext();
#line 37 "C:\Users\erict\Desktop\recycle practice\ericMvc\Views\People\Index.cshtml"
}

#line default
#line hidden
            BeginContext(714, 8, true);
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ericMvc.Models.PeopleModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

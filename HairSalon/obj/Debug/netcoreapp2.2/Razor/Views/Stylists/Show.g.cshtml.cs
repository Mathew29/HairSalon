#pragma checksum "/Users/Guest/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69f75156be917b221488c86edccc1b2f87614f06"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stylists_Show), @"mvc.1.0.view", @"/Views/Stylists/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Stylists/Show.cshtml", typeof(AspNetCore.Views_Stylists_Show))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69f75156be917b221488c86edccc1b2f87614f06", @"/Views/Stylists/Show.cshtml")]
    public class Views_Stylists_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 58, true);
            WriteLiteral("<h3>Here are all the Clients for this Stylist:</h3>\n\n<ol>\n");
            EndContext();
#line 4 "/Users/Guest/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Show.cshtml"
 foreach (var client in @Model["clients"])
{

#line default
#line hidden
            BeginContext(103, 6, true);
            WriteLiteral("  <li>");
            EndContext();
            BeginContext(110, 16, false);
#line 6 "/Users/Guest/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Show.cshtml"
 Write(client.GetName());

#line default
#line hidden
            EndContext();
            BeginContext(126, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 7 "/Users/Guest/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Show.cshtml"
}

#line default
#line hidden
            BeginContext(134, 12, true);
            WriteLiteral("</ol>\n\n<p><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 146, "\'", 200, 3);
            WriteAttributeValue("", 153, "/stylists/", 153, 10, true);
#line 10 "/Users/Guest/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Show.cshtml"
WriteAttributeValue("", 163, Model["stylist"].GetId(), 163, 25, false);

#line default
#line hidden
            WriteAttributeValue("", 188, "/clients/new", 188, 12, true);
            EndWriteAttribute();
            BeginContext(201, 124, true);
            WriteLiteral(">Add a New Client</a></p>\n<p><a href=\'/stylists\'>Return to Stylists Page</a></p>\n<p><a href=\'/\'>Return to Main Page</a></p>\n");
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
#pragma checksum "C:\Users\prane\source\repos\CincinnatiAccidents\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d264837101620c674284e72400db75d32899d4c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CincinnatiAccidents.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(CincinnatiAccidents.Pages.Pages_Index), null)]
namespace CincinnatiAccidents.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\prane\source\repos\CincinnatiAccidents\Pages\_ViewImports.cshtml"
using CincinnatiAccidents;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d264837101620c674284e72400db75d32899d4c9", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f788070d5cd5ab1e4224cda2ce1cc60f83207622", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\prane\source\repos\CincinnatiAccidents\Pages\Index.cshtml"
  
    ViewData["Title"] = "Cincinnati Accidents";
    var trafficaccidents = (QuickTypeTraffic.TrafficAccident[])ViewData["TrafficAccidents"];
    var fireaccidents = (QuickTypeFire.FireAccident[])ViewData["FireAccidents"];

#line default
#line hidden
            BeginContext(258, 403, true);
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Cincinnati Accident Report</h1>
    <p>list of accidents occured in and around city of cincinnati</p>
</div>

<table>
    <thead>
        <tr>
            <th>Date</th>
            <th>Address</th>
            <th>Neighbourhood</th>
            <th>Longitude</th>
            <th>Latitude</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 25 "C:\Users\prane\source\repos\CincinnatiAccidents\Pages\Index.cshtml"
         foreach(QuickTypeFire.FireAccident fireAccident in fireaccidents)
        {

#line default
#line hidden
            BeginContext(748, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(787, 31, false);
#line 28 "C:\Users\prane\source\repos\CincinnatiAccidents\Pages\Index.cshtml"
               Write(fireAccident.CreateTimeIncident);

#line default
#line hidden
            EndContext();
            BeginContext(818, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(846, 21, false);
#line 29 "C:\Users\prane\source\repos\CincinnatiAccidents\Pages\Index.cshtml"
               Write(fireAccident.AddressX);

#line default
#line hidden
            EndContext();
            BeginContext(867, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(895, 25, false);
#line 30 "C:\Users\prane\source\repos\CincinnatiAccidents\Pages\Index.cshtml"
               Write(fireAccident.Neighborhood);

#line default
#line hidden
            EndContext();
            BeginContext(920, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(948, 23, false);
#line 31 "C:\Users\prane\source\repos\CincinnatiAccidents\Pages\Index.cshtml"
               Write(fireAccident.LongitudeX);

#line default
#line hidden
            EndContext();
            BeginContext(971, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(999, 22, false);
#line 32 "C:\Users\prane\source\repos\CincinnatiAccidents\Pages\Index.cshtml"
               Write(fireAccident.LatitudeX);

#line default
#line hidden
            EndContext();
            BeginContext(1021, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 34 "C:\Users\prane\source\repos\CincinnatiAccidents\Pages\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1058, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 35 "C:\Users\prane\source\repos\CincinnatiAccidents\Pages\Index.cshtml"
         foreach (QuickTypeTraffic.TrafficAccident trafficAccident in trafficaccidents)
        {

#line default
#line hidden
            BeginContext(1158, 40, true);
            WriteLiteral("             <tr>\r\n                 <td>");
            EndContext();
            BeginContext(1199, 33, false);
#line 38 "C:\Users\prane\source\repos\CincinnatiAccidents\Pages\Index.cshtml"
                Write(trafficAccident.Datecrashreported);

#line default
#line hidden
            EndContext();
            BeginContext(1232, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1260, 24, false);
#line 39 "C:\Users\prane\source\repos\CincinnatiAccidents\Pages\Index.cshtml"
               Write(trafficAccident.AddressX);

#line default
#line hidden
            EndContext();
            BeginContext(1284, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1312, 31, false);
#line 40 "C:\Users\prane\source\repos\CincinnatiAccidents\Pages\Index.cshtml"
               Write(trafficAccident.CpdNeighborhood);

#line default
#line hidden
            EndContext();
            BeginContext(1343, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1371, 26, false);
#line 41 "C:\Users\prane\source\repos\CincinnatiAccidents\Pages\Index.cshtml"
               Write(trafficAccident.LongitudeX);

#line default
#line hidden
            EndContext();
            BeginContext(1397, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1425, 25, false);
#line 42 "C:\Users\prane\source\repos\CincinnatiAccidents\Pages\Index.cshtml"
               Write(trafficAccident.LatitudeX);

#line default
#line hidden
            EndContext();
            BeginContext(1450, 27, true);
            WriteLiteral("</td>\r\n             </tr>\r\n");
            EndContext();
#line 44 "C:\Users\prane\source\repos\CincinnatiAccidents\Pages\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1488, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

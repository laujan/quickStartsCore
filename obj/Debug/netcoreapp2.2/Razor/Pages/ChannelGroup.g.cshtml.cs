#pragma checksum "C:\Users\v-laujan\3_msteams-test-dotnet\quickStartPersonalTab\Pages\ChannelGroup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3291bd368f90c0f681334d841328442025ea34fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_ChannelGroup), @"mvc.1.0.razor-page", @"/Pages/ChannelGroup.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/ChannelGroup.cshtml", typeof(AspNetCore.Pages_ChannelGroup), @"/channelGroup")]
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
#line 2 "C:\Users\v-laujan\3_msteams-test-dotnet\quickStartPersonalTab\Pages\ChannelGroup.cshtml"
using quickStartPersonalTab;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/channelGroup")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3291bd368f90c0f681334d841328442025ea34fa", @"/Pages/ChannelGroup.cshtml")]
    public class Pages_ChannelGroup : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\v-laujan\3_msteams-test-dotnet\quickStartPersonalTab\Pages\ChannelGroup.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(87, 1143, true);
            WriteLiteral(@"
<script src=""https://ajax.aspnetcdn.com/ajax/jQuery/jquery-3.4.1.min.js""></script>
<script src='https://statics.teams.microsoft.com/sdk/v1.4.3/js/MicrosoftTeams.min.js'></script>

<script>
    microsoftTeams.initialize();
</script>

<script>
    let saveRed = () => {
        microsoftTeams.settings.registerOnSaveHandler(function (saveEvent) {
            microsoftTeams.settings.setSettings({
                websiteUrl: ""https://f79cb79e.ngrok.io"",
                contentUrl: ""https://f79cb79e.ngrok.io/red/"",
                entityId: ""tabby"",
                suggestedDisplayName: ""tabby""
            });
            saveEvent.notifySuccess();
        });
    }

    let saveGray = () => {
        microsoftTeams.settings.registerOnSaveHandler(function (saveEvent) {
            microsoftTeams.settings.setSettings({
                websiteUrl: ""https://f79cb79e.ngrok.io"",
                contentUrl: ""https://f79cb79e.ngrok.io/gray/"",
                entityId: ""tabby"",
                su");
            WriteLiteral("ggestedDisplayName: \"tabby\"\r\n            });\r\n            saveEvent.notifySuccess();\r\n        });\r\n    }\r\n</script>\r\n\r\n");
            EndContext();
            BeginContext(1234, 152, true);
            WriteLiteral("    <section style=\"width: 100%; display: table\">\r\n        <div style=\"display:table-row\">\r\n            <div style=\"width: auto; display:table-cell;\">\r\n");
            EndContext();
#line 45 "C:\Users\v-laujan\3_msteams-test-dotnet\quickStartPersonalTab\Pages\ChannelGroup.cshtml"
                   ChannelGroup gray = new ChannelGroup();
                    string g = ($"{@gray.GetColor()} gray!'");

#line default
#line hidden
            BeginContext(1510, 57, true);
            WriteLiteral("                    <div id=\"gray\" style=\"display:none;\">");
            EndContext();
            BeginContext(1568, 1, false);
#line 47 "C:\Users\v-laujan\3_msteams-test-dotnet\quickStartPersonalTab\Pages\ChannelGroup.cshtml"
                                                    Write(g);

#line default
#line hidden
            EndContext();
            BeginContext(1569, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
            BeginContext(1596, 69, true);
            WriteLiteral("            </div>\r\n\r\n            <div style=\"display: table-cell\">\r\n");
            EndContext();
#line 52 "C:\Users\v-laujan\3_msteams-test-dotnet\quickStartPersonalTab\Pages\ChannelGroup.cshtml"
                   ChannelGroup red = new ChannelGroup();
                    string r = ($"{@red.GetColor()} red!'");

#line default
#line hidden
            BeginContext(1786, 56, true);
            WriteLiteral("                    <div id=\"red\" style=\"display:none;\">");
            EndContext();
            BeginContext(1843, 1, false);
#line 54 "C:\Users\v-laujan\3_msteams-test-dotnet\quickStartPersonalTab\Pages\ChannelGroup.cshtml"
                                                   Write(r);

#line default
#line hidden
            EndContext();
            BeginContext(1844, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
            BeginContext(1871, 56, true);
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n    </section>\r\n");
            EndContext();
            BeginContext(1930, 885, true);
            WriteLiteral(@"
<script>
    let gr = document.getElementById(""gray"").style;
    let rd = document.getElementById(""red"").style;

    const colorClickGray = () => {
        gr.display = ""block"";
        rd.display = ""none"";
        microsoftTeams.settings.setValidityState(true);
        saveGray()
    }

    const colorClickRed = () => {
        rd.display = ""block"";
        gr.display = ""none"";
        microsoftTeams.settings.setValidityState(true);
        saveRed();
    }
</script>

<p>
    <h2>Configure your tab:</h2>
    <br />
    <br />
</p>

<button onclick=""(document.getElementById('icon').src = '/images/iconGray.png'); colorClickGray()"">Select Gray</button>

<img id=""icon"" src=""/images/teamsLogo.png"" alt=""icon"" style=""width:100px"" />

<button onclick=""(document.getElementById('icon').src = '/images/iconRed.png'); colorClickRed()"">Select Red</button>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_ChannelGroup> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_ChannelGroup> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_ChannelGroup>)PageContext?.ViewData;
        public Pages_ChannelGroup Model => ViewData.Model;
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\michaeldobler\Documents\Deltek Insight 2020\API\code\VantagepointAPI_BlazorWebApp\VantagepointAPI_BlazorWebApp\Pages\ListProjects.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f349c2845cc7e885163286f9582aac8b53b054f4"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace VantagepointAPI_BlazorWebApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\michaeldobler\Documents\Deltek Insight 2020\API\code\VantagepointAPI_BlazorWebApp\VantagepointAPI_BlazorWebApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\michaeldobler\Documents\Deltek Insight 2020\API\code\VantagepointAPI_BlazorWebApp\VantagepointAPI_BlazorWebApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\michaeldobler\Documents\Deltek Insight 2020\API\code\VantagepointAPI_BlazorWebApp\VantagepointAPI_BlazorWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\michaeldobler\Documents\Deltek Insight 2020\API\code\VantagepointAPI_BlazorWebApp\VantagepointAPI_BlazorWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\michaeldobler\Documents\Deltek Insight 2020\API\code\VantagepointAPI_BlazorWebApp\VantagepointAPI_BlazorWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\michaeldobler\Documents\Deltek Insight 2020\API\code\VantagepointAPI_BlazorWebApp\VantagepointAPI_BlazorWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\michaeldobler\Documents\Deltek Insight 2020\API\code\VantagepointAPI_BlazorWebApp\VantagepointAPI_BlazorWebApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\michaeldobler\Documents\Deltek Insight 2020\API\code\VantagepointAPI_BlazorWebApp\VantagepointAPI_BlazorWebApp\_Imports.razor"
using VantagepointAPI_BlazorWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\michaeldobler\Documents\Deltek Insight 2020\API\code\VantagepointAPI_BlazorWebApp\VantagepointAPI_BlazorWebApp\_Imports.razor"
using VantagepointAPI_BlazorWebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\michaeldobler\Documents\Deltek Insight 2020\API\code\VantagepointAPI_BlazorWebApp\VantagepointAPI_BlazorWebApp\Pages\ListProjects.razor"
using VantagepointAPI_BlazorWebApp.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/listprojects")]
    public partial class ListProjects : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "C:\Users\michaeldobler\Documents\Deltek Insight 2020\API\code\VantagepointAPI_BlazorWebApp\VantagepointAPI_BlazorWebApp\Pages\ListProjects.razor"
           
        private ProjectsResponse projectList { get; set; } = new ProjectsResponse();
        private string searchText { get; set; } = "";
        private int limit { get; set; } = 10;

        private void Search()
        {
            projectList = APIService.searchProjects(searchText, limit);
        }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private VantagepointAPIService APIService { get; set; }
    }
}
#pragma warning restore 1591

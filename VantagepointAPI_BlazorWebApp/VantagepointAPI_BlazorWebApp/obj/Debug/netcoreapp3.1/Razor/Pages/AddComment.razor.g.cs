#pragma checksum "C:\Users\michaeldobler\Documents\Deltek Insight 2020\API\code\VantagepointAPI_BlazorWebApp\VantagepointAPI_BlazorWebApp\Pages\AddComment.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2aa05e6f6d43ce156ceb00571741056cef92fdc0"
// <auto-generated/>
#pragma warning disable 1591
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
#line 3 "C:\Users\michaeldobler\Documents\Deltek Insight 2020\API\code\VantagepointAPI_BlazorWebApp\VantagepointAPI_BlazorWebApp\Pages\AddComment.razor"
using VantagepointAPI_BlazorWebApp.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addcomment/{WBS1}")]
    public partial class AddComment : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, @"<div class=""px-3 py-3 pt-md-5 pb-md-4 mx-auto text-center"">
        <h1 class=""display-4"">Add A Custom Comment</h1>
        <p class=""lead"">
            Comments are added to the user defined hub ""Comments"". Please
            make sure that the hub has been created and has the following
            fields:
        </p>
        <ul class=""lead"">
            <li>Number (Default)</li>
            <li>Name (Default)</li>
            <li>Project (Type: Project)</li>
            <li>Email (Type: Character)</li>
            <li>Comment (Type: Memo)</li>
        </ul>
    </div>
    <hr>

    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-md-12");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "form-group");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.AddMarkupContent(13, "<label name=\"number\" class=\"control-label\">Number</label>\r\n                ");
            __builder.OpenElement(14, "input");
            __builder.AddAttribute(15, "name", "number");
            __builder.AddAttribute(16, "class", "form-control");
            __builder.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "C:\Users\michaeldobler\Documents\Deltek Insight 2020\API\code\VantagepointAPI_BlazorWebApp\VantagepointAPI_BlazorWebApp\Pages\AddComment.razor"
                                                                 comment.CustNumber

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => comment.CustNumber = __value, comment.CustNumber));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n\r\n            ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "form-group");
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.AddMarkupContent(24, "<label name=\"name\" class=\"control-label\">Name</label>\r\n                ");
            __builder.OpenElement(25, "input");
            __builder.AddAttribute(26, "name", "name");
            __builder.AddAttribute(27, "class", "form-control");
            __builder.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "C:\Users\michaeldobler\Documents\Deltek Insight 2020\API\code\VantagepointAPI_BlazorWebApp\VantagepointAPI_BlazorWebApp\Pages\AddComment.razor"
                                                               comment.CustName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => comment.CustName = __value, comment.CustName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n\r\n            ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "form-group");
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.AddMarkupContent(35, "<label name=\"name\" class=\"control-label\">Project</label>\r\n                ");
            __builder.OpenElement(36, "input");
            __builder.AddAttribute(37, "name", "name");
            __builder.AddAttribute(38, "class", "form-control");
            __builder.AddAttribute(39, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 38 "C:\Users\michaeldobler\Documents\Deltek Insight 2020\API\code\VantagepointAPI_BlazorWebApp\VantagepointAPI_BlazorWebApp\Pages\AddComment.razor"
                                                               comment.CustProject

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => comment.CustProject = __value, comment.CustProject));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n\r\n            ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "form-group");
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.AddMarkupContent(46, "<label name=\"name\" class=\"control-label\">Email</label>\r\n                ");
            __builder.OpenElement(47, "input");
            __builder.AddAttribute(48, "name", "name");
            __builder.AddAttribute(49, "class", "form-control");
            __builder.AddAttribute(50, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 43 "C:\Users\michaeldobler\Documents\Deltek Insight 2020\API\code\VantagepointAPI_BlazorWebApp\VantagepointAPI_BlazorWebApp\Pages\AddComment.razor"
                                                               comment.CustEmail

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => comment.CustEmail = __value, comment.CustEmail));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n\r\n            ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "form-group");
            __builder.AddMarkupContent(56, "\r\n                ");
            __builder.AddMarkupContent(57, "<label name=\"name\" class=\"control-label\">Comment</label>\r\n                ");
            __builder.OpenElement(58, "input");
            __builder.AddAttribute(59, "name", "name");
            __builder.AddAttribute(60, "class", "form-control");
            __builder.AddAttribute(61, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 48 "C:\Users\michaeldobler\Documents\Deltek Insight 2020\API\code\VantagepointAPI_BlazorWebApp\VantagepointAPI_BlazorWebApp\Pages\AddComment.razor"
                                                               comment.CustComment

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(62, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => comment.CustComment = __value, comment.CustComment));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n\r\n            ");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "form-group");
            __builder.AddMarkupContent(67, "\r\n                ");
            __builder.OpenElement(68, "span");
            __builder.AddAttribute(69, "class", "text-muted small");
            __builder.AddContent(70, 
#nullable restore
#line 52 "C:\Users\michaeldobler\Documents\Deltek Insight 2020\API\code\VantagepointAPI_BlazorWebApp\VantagepointAPI_BlazorWebApp\Pages\AddComment.razor"
                                                Status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n\r\n            ");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "class", "form-group");
            __builder.AddMarkupContent(75, "\r\n                ");
            __builder.AddMarkupContent(76, "<span class=\"text-muted small\">Last Updated By: </span>\r\n                ");
            __builder.OpenElement(77, "span");
            __builder.AddAttribute(78, "class", "text-muted small");
            __builder.AddContent(79, 
#nullable restore
#line 57 "C:\Users\michaeldobler\Documents\Deltek Insight 2020\API\code\VantagepointAPI_BlazorWebApp\VantagepointAPI_BlazorWebApp\Pages\AddComment.razor"
                                                comment.ModUser

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n\r\n            ");
            __builder.OpenElement(82, "div");
            __builder.AddAttribute(83, "class", "form-group");
            __builder.AddMarkupContent(84, "\r\n                ");
            __builder.AddMarkupContent(85, "<span class=\"text-muted small\">Last Updated At: </span>\r\n                ");
            __builder.OpenElement(86, "span");
            __builder.AddAttribute(87, "class", "text-muted small");
            __builder.AddContent(88, 
#nullable restore
#line 62 "C:\Users\michaeldobler\Documents\Deltek Insight 2020\API\code\VantagepointAPI_BlazorWebApp\VantagepointAPI_BlazorWebApp\Pages\AddComment.razor"
                                                comment.ModDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n\r\n    ");
            __builder.OpenElement(93, "div");
            __builder.AddAttribute(94, "class", "row");
            __builder.AddMarkupContent(95, "\r\n        ");
            __builder.OpenElement(96, "div");
            __builder.AddAttribute(97, "class", "col-md-3");
            __builder.AddMarkupContent(98, "\r\n            ");
            __builder.OpenElement(99, "div");
            __builder.AddAttribute(100, "class", "form-group");
            __builder.AddMarkupContent(101, "\r\n                ");
            __builder.OpenElement(102, "button");
            __builder.AddAttribute(103, "class", "btn btn-primary");
            __builder.AddAttribute(104, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 70 "C:\Users\michaeldobler\Documents\Deltek Insight 2020\API\code\VantagepointAPI_BlazorWebApp\VantagepointAPI_BlazorWebApp\Pages\AddComment.razor"
                                                          Save

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(105, "Save Comment");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 79 "C:\Users\michaeldobler\Documents\Deltek Insight 2020\API\code\VantagepointAPI_BlazorWebApp\VantagepointAPI_BlazorWebApp\Pages\AddComment.razor"
       
    [Parameter]
    public string WBS1 { get; set; }

    private string Status { get; set; } = "";

private UDIC_Comment comment { get; set; } = new UDIC_Comment();

    protected override void OnInitialized()
    {
        base.OnInitialized();
        comment = new UDIC_Comment();
        comment.CustProject = WBS1;
        comment.CustNumber = DateTime.Now.ToString("yyyyMMddhhmmss");
        comment.CustName = $"Comment {comment.CustNumber}";
    }

    private void Save()
    {
        if (string.IsNullOrWhiteSpace(comment.CustNumber))
        {
            comment.CustNumber = DateTime.Now.ToString("yyyyMMddhhmmss");
        }

        if (string.IsNullOrWhiteSpace(comment.CustName))
        {
            comment.CustName = $"Comment {comment.CustNumber}";
        }

        var result = APIService.postComment(comment);

        if (result?.Count < 1)
        {
            Status = "Error. No comment was saved";
        }
        else
        {
            Status = "Comment added successfully!";
            comment = result.First();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private VantagepointAPIService APIService { get; set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Shared\Notification.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4b7e988976d67b2f74c0b9e62b502a32b5f6238"
// <auto-generated/>
#pragma warning disable 1591
namespace WithTeachers.Shared
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\_Imports.razor"
using WithTeachers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\_Imports.razor"
using WithTeachers.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\_Imports.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\_Imports.razor"
using WithTeachers.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\_Imports.razor"
using WithTeachers.Data.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\_Imports.razor"
using WithTeachers.Pages.Videoconference;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\_Imports.razor"
using WithTeachers.Pages.Scheduler;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\_Imports.razor"
using WithTeachers.Pages.Courses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\_Imports.razor"
using WithTeachers.Pages.Classes;

#line default
#line hidden
#nullable disable
    public partial class Notification : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "alert" + " " + (
#nullable restore
#line 1 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Shared\Notification.razor"
                    Success ? "alert-success" : "alert-danger"

#line default
#line hidden
#nullable disable
            ) + " alert-dismissible" + " fade" + " show");
            __builder.AddAttribute(2, "role", "alert");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddContent(4, 
#nullable restore
#line 2 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Shared\Notification.razor"
      (MarkupString)Message

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.AddMarkupContent(6, "<button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n        <span aria-hidden=\"true\">&times;</span>\r\n    </button>\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Shared\Notification.razor"
       
    [Parameter]
    public string Message { get; set; }

    [Parameter]
    public bool Success { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

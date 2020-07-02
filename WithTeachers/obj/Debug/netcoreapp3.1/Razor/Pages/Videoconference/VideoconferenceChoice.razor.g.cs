#pragma checksum "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Videoconference\VideoconferenceChoice.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8271790e9957d41e2762729aec6ed1f48083a9dd"
// <auto-generated/>
#pragma warning disable 1591
namespace WithTeachers.Pages.Videoconference
{
    #line hidden
    using System;
    using System.Collections.Generic;
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
#line 6 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Videoconference\VideoconferenceChoice.razor"
using WithTeachers.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Videoconference\VideoconferenceChoice.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/videoconferenceChoice")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/{videoconferenceId}")]
    public partial class VideoconferenceChoice : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 14 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Videoconference\VideoconferenceChoice.razor"
 if (!String.IsNullOrEmpty(VideoconferenceId))
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "h1");
            __builder.AddContent(2, "Videoconference ");
            __builder.AddContent(3, 
#nullable restore
#line 16 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Videoconference\VideoconferenceChoice.razor"
                         VideoconferenceId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenComponent<WithTeachers.Pages.Videoconference.VideoconferenceLaunch>(5);
            __builder.AddAttribute(6, "VideoconferenceId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Videoconference\VideoconferenceChoice.razor"
                                               VideoconferenceId

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n");
#nullable restore
#line 18 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Videoconference\VideoconferenceChoice.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "    ");
            __builder.AddMarkupContent(9, "<h1>Videoconference</h1>\r\n");
            __builder.AddContent(10, "    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-deck col-lg-8 mx-auto py-5");
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "card");
            __builder.AddMarkupContent(16, "\r\n            <img src=\"img/website/meeting.svg\" class=\"card-img-top mx-auto\" alt=\"New meeting\">\r\n            ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "card-body");
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.AddMarkupContent(20, "<h5 class=\"card-title\">Start a videoconference</h5>\r\n                ");
            __builder.AddMarkupContent(21, "<p class=\"card-text\">Send your students a link to meet with you.</p>\r\n                ");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "class", "btn stretched-link");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Videoconference\VideoconferenceChoice.razor"
                                                             HandleClickStart

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(25, "Start");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.AddMarkupContent(29, @"<div class=""card"">
            <img src=""img/website/schedule.svg"" class=""card-img-top mx-auto"" alt=""Schedule a meeting"">
            <div class=""card-body"">
                <h5 class=""card-title"">Schedule a meeting</h5>
                <p class=""card-text"">Set the date and prepare your meeting.</p>
                <button class=""btn stretched-link"">Schedule</button>
            </div>
        </div>
    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
            __builder.AddContent(31, "    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(32);
            __builder.AddAttribute(33, "class", "blackground");
            __builder.AddAttribute(34, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 44 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Videoconference\VideoconferenceChoice.razor"
                                          videoconferenceToAdd

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 44 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Videoconference\VideoconferenceChoice.razor"
                                                                               HandleValidSubmitAddVideoconference

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(36, "hidden", 
#nullable restore
#line 44 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Videoconference\VideoconferenceChoice.razor"
                                                                                                                              !startIsSelected

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(38, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(39);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "\r\n\r\n        ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "form-group");
                __builder2.AddMarkupContent(43, "\r\n            ");
                __builder2.AddMarkupContent(44, "<label for=\"videoconferencePassword\">Videoconference password (optional)</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(45);
                __builder2.AddAttribute(46, "type", "password");
                __builder2.AddAttribute(47, "id", "videoconferencePassword");
                __builder2.AddAttribute(48, "class", "form-control");
                __builder2.AddAttribute(49, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 49 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Videoconference\VideoconferenceChoice.razor"
                                                                                                      videoconferenceToAdd.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => videoconferenceToAdd.Password = __value, videoconferenceToAdd.Password))));
                __builder2.AddAttribute(51, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => videoconferenceToAdd.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(52, "\r\n            ");
                __Blazor.WithTeachers.Pages.Videoconference.VideoconferenceChoice.TypeInference.CreateValidationMessage_0(__builder2, 53, 54, 
#nullable restore
#line 50 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Videoconference\VideoconferenceChoice.razor"
                                      () => videoconferenceToAdd.Password

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(55, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n\r\n        ");
                __builder2.AddMarkupContent(57, "<button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(58, "\r\n");
#nullable restore
#line 61 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Videoconference\VideoconferenceChoice.razor"
                    
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Videoconference\VideoconferenceChoice.razor"
       
    [Parameter]
    public string VideoconferenceId { get; set; }

    ApplicationUser currentUser;
    Videoconference videoconferenceToAdd = new Videoconference();

    protected override async void OnInitialized()
    {
        currentUser = await ApplicationUserService.GetCurrentUser();
        startIsSelected = false;
    }

    bool startIsSelected;

    private void HandleClickStart()
    {
        startIsSelected = true;
    }

    private async Task HandleValidSubmitAddVideoconference()
    {
        string guid = Guid.NewGuid().ToString("N").ToUpper();
        videoconferenceToAdd.VideoconferenceId = guid;
        videoconferenceToAdd.Ongoing = true;
        videoconferenceToAdd.CreationDate = DateTime.Now;
        videoconferenceToAdd.User = currentUser;

        await VideoconferenceService.CreateAsync(videoconferenceToAdd);

        NavigationManager.NavigateTo("/" + guid);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApplicationUserService ApplicationUserService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private VideoconferenceService VideoconferenceService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
namespace __Blazor.WithTeachers.Pages.Videoconference.VideoconferenceChoice
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab6c63c8ff78a996fb83c783871995c0dd5f15ad"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace OnlineEducation.Pages.Videoconference
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\_Imports.razor"
using OnlineEducation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\_Imports.razor"
using OnlineEducation.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\_Imports.razor"
using OnlineEducation.Data.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\_Imports.razor"
using OnlineEducation.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\_Imports.razor"
using OnlineEducation.Pages.Videoconference;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\_Imports.razor"
using OnlineEducation.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(Videoboard))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/{RoomId}")]
    public partial class RoomIdCheck : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 107 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
       
    [Parameter]
    public string RoomId { get; set; }

    ApplicationUser currentUser;
    Videoconference videoconference;
    string inputVideoconferencePassword;
    string inputGuestName;
    bool userExists;

    // Once connected to the videoconference
    bool userHasJoinedVideoconference = false;
    ApplicationUser userJoiningTheVideoconference; //can be the host, a connected guest or an anonymous guest

    protected override async Task OnInitializedAsync()
    {
        currentUser = await ApplicationUserService.GetCurrentUser();

        if (!String.IsNullOrEmpty(RoomId))
            videoconference = await VideoconferenceService.GetByRoomAsync(RoomId);
    }

    private bool videoconferenceExists(string roomId)
        => videoconference != null;

    private void JoinVideoconferenceAsHost()
    {
        userHasJoinedVideoconference = true;
        userJoiningTheVideoconference = currentUser;
        StateHasChanged();
    }

    private async Task JoinVideoconferenceAsHostAsync()
    {
        userHasJoinedVideoconference = true;
        userJoiningTheVideoconference = currentUser;
        videoconference.IsOngoing = true;
        await VideoconferenceService.UpdateAsync(videoconference);
        StateHasChanged();
    }

    private void JoinVideoconferenceAsGuest()
    {
        userHasJoinedVideoconference = true;
        StateHasChanged();
    }

    private async Task InputGuestName(ChangeEventArgs args)
    {
        inputGuestName = args.Value.ToString();
        await UserExistsAsync(inputGuestName);
    }

    private async Task UserExistsAsync(string userName)
    {
        ApplicationUser user = await ApplicationUserService.GetUserByName(userName);
        userExists = user != null;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private VideoconferenceService VideoconferenceService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApplicationUserService ApplicationUserService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService Modal { get; set; }
    }
}
#pragma warning restore 1591

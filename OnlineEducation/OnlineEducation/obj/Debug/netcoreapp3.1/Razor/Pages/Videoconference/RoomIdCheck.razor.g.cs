#pragma checksum "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7989311a47b4275132134a56f7c3ffaaa795977e"
// <auto-generated/>
#pragma warning disable 1591
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
#nullable restore
#line 14 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
 if (userHasJoinedVideoconference)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenComponent<OnlineEducation.Pages.Videoconference.Videos>(1);
            __builder.AddAttribute(2, "Videoconference", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OnlineEducation.Data.Models.Videoconference>(
#nullable restore
#line 16 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                              videoconference

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n");
#nullable restore
#line 17 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "centered-div");
            __builder.AddMarkupContent(7, "\r\n");
#nullable restore
#line 21 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
         if (!videoconferenceExists(RoomId))
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "            ");
            __builder.AddMarkupContent(9, "<h1>Page not found</h1>\r\n            ");
            __builder.AddMarkupContent(10, "<p>There is nothing associated with the URL.</p>\r\n            ");
            __builder.AddMarkupContent(11, "<button class=\"btn\">Go to home page</button>\r\n");
#nullable restore
#line 26 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
             if (videoconference.IsHost(currentUser))
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "                ");
            __builder.OpenElement(13, "h1");
            __builder.OpenElement(14, "strong");
            __builder.AddContent(15, 
#nullable restore
#line 31 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                             videoconference.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(16, " videoconference");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.OpenElement(18, "ul");
            __builder.AddAttribute(19, "class", "list-unstyled");
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.OpenElement(21, "li");
            __builder.AddContent(22, "Hosted by ");
            __builder.OpenElement(23, "strong");
            __builder.AddContent(24, 
#nullable restore
#line 33 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                                           videoconference.User.UserName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "li");
            __builder.AddContent(27, "Scheduled for ");
            __builder.OpenElement(28, "strong");
            __builder.AddContent(29, 
#nullable restore
#line 34 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                                               videoconference.ScheduledFor.ToShortTimeString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(30, ", ");
            __builder.AddContent(31, 
#nullable restore
#line 34 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                                                                                                  videoconference.ScheduledFor.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                    ");
            __builder.OpenElement(33, "li");
            __builder.AddContent(34, "Length: ");
            __builder.AddContent(35, 
#nullable restore
#line 35 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                                 videoconference.TimeSpan.ToString(@"hh\:mm")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                    ");
            __builder.OpenElement(37, "li");
            __builder.AddContent(38, "Description: ");
            __builder.AddContent(39, 
#nullable restore
#line 36 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                                      videoconference.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
#nullable restore
#line 39 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                 if (videoconference.IsOngoing)
                {
                    JoinVideoconferenceAsHost();
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(42, "                    ");
            __builder.OpenElement(43, "button");
            __builder.AddAttribute(44, "class", "btn");
            __builder.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                                                  JoinVideoconferenceAsHostAsync

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(46, "Start the videoconference");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n");
#nullable restore
#line 46 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                 
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(48, "                ");
            __builder.OpenElement(49, "h1");
            __builder.OpenElement(50, "strong");
            __builder.AddContent(51, 
#nullable restore
#line 50 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                             videoconference.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(52, " videoconference");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                ");
            __builder.OpenElement(54, "ul");
            __builder.AddAttribute(55, "class", "list-unstyled");
            __builder.AddMarkupContent(56, "\r\n                    ");
            __builder.OpenElement(57, "li");
            __builder.AddContent(58, "Hosted by ");
            __builder.OpenElement(59, "strong");
            __builder.AddContent(60, 
#nullable restore
#line 52 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                                           videoconference.User.UserName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                    ");
            __builder.OpenElement(62, "li");
            __builder.AddContent(63, "Scheduled for ");
            __builder.OpenElement(64, "strong");
            __builder.AddContent(65, 
#nullable restore
#line 53 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                                               videoconference.ScheduledFor.ToShortTimeString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(66, ", ");
            __builder.AddContent(67, 
#nullable restore
#line 53 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                                                                                                  videoconference.ScheduledFor.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                    ");
            __builder.OpenElement(69, "li");
            __builder.AddContent(70, "Length: ");
            __builder.AddContent(71, 
#nullable restore
#line 54 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                                 videoconference.TimeSpan.ToString(@"hh\:mm")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                    ");
            __builder.OpenElement(73, "li");
            __builder.AddContent(74, "Description: ");
            __builder.AddContent(75, 
#nullable restore
#line 55 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                                      videoconference.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n");
#nullable restore
#line 58 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                 if (videoconference.IsCompleted)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(78, "                    ");
            __builder.AddMarkupContent(79, "<div class=\"alert alert-info\"><p>This videoconference has <strong>finished</strong>.</p></div>\r\n");
#nullable restore
#line 61 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                }
                else if (videoconference.HasToOccurLater)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(80, "                    ");
            __builder.AddMarkupContent(81, "<div class=\"alert alert-info\"><p>This videoconference has <strong>not begun yet</strong>.</p></div>\r\n");
#nullable restore
#line 65 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                }
                else if (videoconference.IsOngoing)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                     if (videoconference.HasPassword && !videoconference.PasswordIsCorrect(inputVideoconferencePassword))
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(82, "                        ");
            __builder.AddMarkupContent(83, "<div class=\"alert alert-info mb-3\"><p>A <strong>password</strong> is needed to access the videoconference.</p></div>\r\n");
            __builder.AddContent(84, "                        ");
            __builder.OpenElement(85, "div");
            __builder.AddAttribute(86, "class", "form-inline");
            __builder.AddMarkupContent(87, "\r\n                            ");
            __builder.OpenElement(88, "input");
            __builder.AddAttribute(89, "type", "password");
            __builder.AddAttribute(90, "class", "form-control text-center mb-3 mb-sm-0 mr-2");
            __builder.AddAttribute(91, "placeholder", "Enter the password to join");
            __builder.AddAttribute(92, "autofocus", true);
            __builder.AddAttribute(93, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 73 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                                                                                                             inputVideoconferencePassword

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(94, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => inputVideoconferencePassword = __value, inputVideoconferencePassword));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n                            ");
            __builder.AddMarkupContent(96, "<button class=\"btn\">Submit</button>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n");
#nullable restore
#line 76 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                    }
                    else
                    {
                        //here it's just another user of the platform but not the one who created the videoconf so we don't ask for other name
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                         if (currentUser != null)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(98, "                            ");
            __builder.OpenElement(99, "button");
            __builder.AddAttribute(100, "class", "btn");
            __builder.AddAttribute(101, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 82 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                                                          JoinVideoconferenceAsGuest

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(102, "Join as ");
            __builder.AddContent(103, 
#nullable restore
#line 82 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                                                                                               currentUser.UserName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n");
#nullable restore
#line 83 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(105, "                            ");
            __builder.OpenElement(106, "div");
            __builder.AddAttribute(107, "class", "form-inline");
            __builder.AddMarkupContent(108, "\r\n                                ");
            __builder.OpenElement(109, "input");
            __builder.AddAttribute(110, "type", "text");
            __builder.AddAttribute(111, "class", "form-control text-center mb-3 mb-sm-0 mr-2");
            __builder.AddAttribute(112, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 87 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                                                                                                                InputGuestName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(113, "placeholder", "Write your name");
            __builder.AddAttribute(114, "autofocus", true);
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n                                ");
            __builder.OpenElement(116, "a");
            __builder.AddAttribute(117, "href", "Identity/Account/LoginShort?userName=" + (
#nullable restore
#line 89 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                                                                               inputGuestName

#line default
#line hidden
#nullable disable
            ) + "&returnUrl=/" + (
#nullable restore
#line 89 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                                                                                                          RoomId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(118, "class", "mr-3");
            __builder.AddContent(119, "JoinTest");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n");
#nullable restore
#line 92 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                             if (!String.IsNullOrEmpty(inputGuestName))
                            {
                                if (userExists)
                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(122, "                                    ");
            __builder.AddMarkupContent(123, "<p>CA EXISTE DEJA t\'es sur que tu veux te connecter avec?</p>\r\n");
#nullable restore
#line 97 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(124, "                                    ");
            __builder.AddMarkupContent(125, "<p><b>ALL GOOD</b></p>\r\n");
#nullable restore
#line 101 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                                }
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 102 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                             
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 103 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                         
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                     
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 105 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                 
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 106 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(126, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n");
#nullable restore
#line 109 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 111 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
       
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
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b744ecd9f82d60b5b5bd35558367ea599dbd212d"
// <auto-generated/>
#pragma warning disable 1591
namespace OnlineEducation
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
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n    ");
                __builder2.OpenComponent<Blazored.Modal.CascadingBlazoredModal>(3);
                __builder2.AddAttribute(4, "Animation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazored.Modal.ModalAnimation>(
#nullable restore
#line 2 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\App.razor"
                                        ModalAnimation.FadeIn(0.5)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(6, "\r\n        ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(7);
                    __builder3.AddAttribute(8, "AppAssembly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#nullable restore
#line 3 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\App.razor"
                              typeof(Program).Assembly

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(9, "Found", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder4) => {
                        __builder4.AddMarkupContent(10, "\r\n                ");
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeRouteView>(11);
                        __builder4.AddAttribute(12, "RouteData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 5 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\App.razor"
                                                routeData

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(13, "DefaultLayout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 5 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\App.razor"
                                                                           typeof(MainLayout)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(14, "\r\n            ");
                    }
                    ));
                    __builder3.AddAttribute(15, "NotFound", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(16, "\r\n                ");
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.LayoutView>(17);
                        __builder4.AddAttribute(18, "Layout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 8 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\App.razor"
                                     typeof(MainLayout)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(20, "\r\n                    ");
                            __builder5.AddMarkupContent(21, "<p>Sorry, there\'s nothing at this address.</p>\r\n                ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(22, "\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(23, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
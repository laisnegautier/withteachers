#pragma checksum "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "000740aea893f777231d7979c720550b128acf1b"
// <auto-generated/>
#pragma warning disable 1591
namespace WithTeachers.Pages.Courses
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
#nullable restore
#line 21 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
    public partial class CoursesHistory : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Your courses</h3>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
 if (courses == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 12 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
}
else if (courses.Count == 0)
{
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "btn-toolbar mb-3");
            __builder.AddAttribute(5, "role", "toolbar");
            __builder.AddAttribute(6, "aria-label", "Toolbar with button groups");
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "btn-group btn-group-sm mr-2");
            __builder.AddAttribute(10, "role", "group");
            __builder.AddAttribute(11, "aria-label", "First group");
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.AddMarkupContent(13, "<div class=\"input-group-prepend\">\r\n            <div class=\"input-group-text\" id=\"btnGroupAddon\">Sort by:</div>\r\n        </div>\r\n        ");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "type", "button");
            __builder.AddAttribute(16, "class", "btn btn-secondary");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
                                                                  SortByCreationDateDescending

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(18, "Name");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "type", "button");
            __builder.AddAttribute(22, "class", "btn btn-secondary");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
                                                                  SortByCreationDateDescending

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(24, "Update date");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "type", "button");
            __builder.AddAttribute(28, "class", "btn btn-secondary");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
                                                                  SortByCreationDateDescending

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(30, "Creation date");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n    ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "btn-group btn-group-sm mr-2");
            __builder.AddAttribute(35, "role", "group");
            __builder.AddAttribute(36, "aria-label", "First group");
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.AddMarkupContent(38, "<div class=\"input-group-prepend\">\r\n            <div class=\"input-group-text\" id=\"btnGroupAddon\">Order:</div>\r\n        </div>\r\n        ");
            __builder.OpenElement(39, "button");
            __builder.AddAttribute(40, "type", "button");
            __builder.AddAttribute(41, "class", "btn btn-secondary");
            __builder.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
                                                                  SortByCreationDateDescending

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(43, "<span class=\"oi oi-arrow-thick-bottom\" aria-hidden=\"true\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n        ");
            __builder.OpenElement(45, "button");
            __builder.AddAttribute(46, "type", "button");
            __builder.AddAttribute(47, "class", "btn btn-secondary");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
                                                                  SortByCreationDateAscending

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(49, "<span class=\"oi oi-arrow-thick-top\" aria-hidden=\"true\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n    ");
            __builder.AddMarkupContent(52, "<div class=\"input-group\">\r\n        <input type=\"text\" class=\"form-control\" placeholder=\"Search by name\" aria-label=\"Input group example\" aria-describedby=\"btnGroupAddon\">\r\n    </div>\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n");
            __builder.AddContent(54, "    ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "card-columns");
            __builder.AddMarkupContent(57, "\r\n");
#nullable restore
#line 40 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
         foreach (Course course in courses)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(58, "            ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "card");
            __builder.AddMarkupContent(61, "\r\n                ");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "card-body");
            __builder.AddMarkupContent(64, "\r\n                    ");
            __builder.OpenElement(65, "h5");
            __builder.AddAttribute(66, "class", "card-title");
            __builder.AddContent(67, 
#nullable restore
#line 44 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
                                            course.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n");
#nullable restore
#line 45 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
                     if (!String.IsNullOrEmpty(course.Password))
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(69, "                        ");
            __builder.AddMarkupContent(70, "<span>Password required.</span>\r\n");
#nullable restore
#line 48 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(71, "                    ");
            __builder.OpenElement(72, "p");
            __builder.AddAttribute(73, "class", "small text-muted");
            __builder.AddContent(74, "Created on ");
            __builder.AddContent(75, 
#nullable restore
#line 49 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
                                                            course.CreationDate

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(76, " ");
            __builder.AddContent(77, 
#nullable restore
#line 49 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
                                                                                  course.UpdateDate.ToShortDateString() != course.CreationDate.ToShortDateString() ? "(updated " + @course.UpdateDate + ")" : ""

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                    ");
            __builder.OpenElement(79, "p");
            __builder.AddAttribute(80, "class", "card-text");
            __builder.AddContent(81, 
#nullable restore
#line 50 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
                                          course.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n");
#nullable restore
#line 52 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
                 if (course.Documents != null && course.Documents.Count > 0)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(84, "                    ");
            __builder.OpenElement(85, "ul");
            __builder.AddAttribute(86, "class", "list-group list-group-flush");
            __builder.AddMarkupContent(87, "\r\n");
#nullable restore
#line 55 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
                         foreach (CourseDocument document in course.Documents)
                        {
                            string link = "uploads/" + document.FileUrl;

#line default
#line hidden
#nullable disable
            __builder.AddContent(88, "                            ");
            __builder.OpenElement(89, "li");
            __builder.AddAttribute(90, "class", "list-group-item");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(91);
            __builder.AddAttribute(92, "href", 
#nullable restore
#line 58 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
                                                                        link

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(93, "target", "_blank");
            __builder.AddAttribute(94, "title", "Open this document");
            __builder.AddAttribute(95, "alt", "Open this document");
            __builder.AddAttribute(96, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(97, "<span class=\"oi oi-document\" aria-hidden=\"true\"></span> ");
                __builder2.AddContent(98, 
#nullable restore
#line 58 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
                                                                                                                                                                                                           document.Title

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n");
#nullable restore
#line 59 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(100, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n");
#nullable restore
#line 61 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(102, "                ");
            __builder.OpenElement(103, "div");
            __builder.AddAttribute(104, "class", "card-body d-flex justify-content-between");
            __builder.AddMarkupContent(105, "\r\n");
#nullable restore
#line 63 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
                     if (copiedLink == NavigationManager.Uri + "/" + course.Slug)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(106, "                        ");
            __builder.AddMarkupContent(107, "<button class=\"btn btn-sm\"><span class=\"oi oi-check\" aria-hidden=\"true\"></span> Link copied</button>\r\n");
#nullable restore
#line 66 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(108, "                        ");
            __builder.OpenElement(109, "button");
            __builder.AddAttribute(110, "class", "btn btn-sm");
            __builder.AddAttribute(111, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 69 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
                                                               () => CopyTextToClipboard(NavigationManager.Uri + "/" + course.Slug)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(112, "Share link");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n");
#nullable restore
#line 70 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(114, "\r\n                    ");
            __builder.OpenElement(115, "div");
            __builder.AddMarkupContent(116, "\r\n                        ");
            __builder.AddMarkupContent(117, "<button class=\"btn btn-sm\">Edit</button>\r\n                        ");
            __builder.OpenElement(118, "button");
            __builder.AddAttribute(119, "class", "btn btn-danger btn-sm");
            __builder.AddAttribute(120, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 74 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
                                                                          () => DeleteCourse(course)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(121, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n");
#nullable restore
#line 78 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(126, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n");
#nullable restore
#line 80 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 82 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
       
    [Parameter]
    public EventCallback<bool> CoursesExist { get; set; }

    [Parameter]
    public bool Refresh { get; set; }

    ApplicationUser currentUser;
    List<Course> courses = null;
    string copiedLink = null;

    protected override async Task OnParametersSetAsync()
    {
        currentUser = await ApplicationUserService.GetCurrentUser();
        courses = await CourseService.ReadAllAsync(currentUser);
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (courses != null && courses.Count > 0)
            await CoursesExist.InvokeAsync(true);

        if (firstRender && (courses == null || courses.Count == 0))
            await CoursesExist.InvokeAsync(false);
    }

    private async Task SortByCreationDateAscending()
        => courses = await CourseService.ReadAllOrderByCreationDateAscendingAsync(currentUser);

    private async Task SortByCreationDateDescending()
        => courses = await CourseService.ReadAllOrderByCreationDateDescendingAsync(currentUser);

    private async Task CopyTextToClipboard(string link)
    {
        copiedLink = link;
        await JSRuntime.InvokeVoidAsync("clipboardCopy.copyText", link);
    }

    private async Task DeleteCourse(Course course)
    {
        foreach (CourseDocument document in course.Documents)
            FileUploadService.Delete(document.FileUrl);

        await CourseService.DeleteAsync(course);

        courses.Remove(course);

        if (courses == null || courses.Count == 0) await CoursesExist.InvokeAsync(false);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileUpload FileUploadService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CourseService CourseService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApplicationUserService ApplicationUserService { get; set; }
    }
}
#pragma warning restore 1591

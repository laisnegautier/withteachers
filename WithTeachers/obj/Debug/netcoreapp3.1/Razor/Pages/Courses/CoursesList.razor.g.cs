#pragma checksum "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab2da1d76418985e9c6eff7cd65bf0e755a8b24d"
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
    public partial class CoursesList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card-columns");
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 7 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesList.razor"
     foreach (Course course in Courses)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card");
            __builder.AddMarkupContent(6, "\r\n            ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card-body");
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.OpenElement(10, "h5");
            __builder.AddAttribute(11, "class", "card-title");
            __builder.AddContent(12, 
#nullable restore
#line 11 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesList.razor"
                                        course.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
#nullable restore
#line 12 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesList.razor"
                 if (!String.IsNullOrEmpty(course.Password))
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "                    ");
            __builder.AddMarkupContent(15, "<span>Password required.</span>\r\n");
#nullable restore
#line 15 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesList.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "                ");
            __builder.OpenElement(17, "p");
            __builder.AddAttribute(18, "class", "small text-muted");
            __builder.AddContent(19, "Created on ");
            __builder.AddContent(20, 
#nullable restore
#line 16 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesList.razor"
                                                        course.CreationDate

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(21, " ");
            __builder.AddContent(22, 
#nullable restore
#line 16 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesList.razor"
                                                                              course.UpdateDate.ToShortDateString() != course.CreationDate.ToShortDateString() ? "(updated " + @course.UpdateDate + ")" : ""

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.AddMarkupContent(24, "<p class=\"card-text\">Some quick example text to build on the card title and make up the bulk of the card\'s content.</p>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
#nullable restore
#line 19 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesList.razor"
             if (course.Documents != null && course.Documents.Count > 0)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(26, "                ");
            __builder.OpenElement(27, "ul");
            __builder.AddAttribute(28, "class", "list-group list-group-flush");
            __builder.AddMarkupContent(29, "\r\n");
#nullable restore
#line 22 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesList.razor"
                     foreach (CourseDocument document in course.Documents)
                    {
                        string link = "uploads/" + document.FileUrl;

#line default
#line hidden
#nullable disable
            __builder.AddContent(30, "                        ");
            __builder.OpenElement(31, "li");
            __builder.AddAttribute(32, "class", "list-group-item");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(33);
            __builder.AddAttribute(34, "href", 
#nullable restore
#line 25 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesList.razor"
                                                                    link

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(35, "target", "_blank");
            __builder.AddAttribute(36, "title", "Open this document");
            __builder.AddAttribute(37, "alt", "Open this document");
            __builder.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(39, "<span class=\"oi oi-document\" aria-hidden=\"true\"></span> ");
                __builder2.AddContent(40, 
#nullable restore
#line 25 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesList.razor"
                                                                                                                                                                                                       document.Title

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
#nullable restore
#line 26 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesList.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(42, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
#nullable restore
#line 28 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(44, "            ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "card-body d-flex justify-content-between");
            __builder.AddMarkupContent(47, "\r\n");
#nullable restore
#line 30 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesList.razor"
                 if (copiedLink == NavigationManager.Uri + "/" + course.Slug)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(48, "                    ");
            __builder.AddMarkupContent(49, "<button class=\"btn btn-sm\"><span class=\"oi oi-check\" aria-hidden=\"true\"></span> Link copied</button>\r\n");
#nullable restore
#line 33 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesList.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(50, "                    ");
            __builder.OpenElement(51, "button");
            __builder.AddAttribute(52, "class", "btn btn-sm");
            __builder.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesList.razor"
                                                           () => CopyTextToClipboard(NavigationManager.Uri + "/" + course.Slug)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(54, "Share link");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n");
#nullable restore
#line 37 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesList.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(56, "\r\n                ");
            __builder.OpenElement(57, "div");
            __builder.AddMarkupContent(58, "\r\n                    ");
            __builder.AddMarkupContent(59, "<button class=\"btn btn-sm\">Edit</button>\r\n                    ");
            __builder.OpenElement(60, "button");
            __builder.AddAttribute(61, "class", "btn btn-danger btn-sm");
            __builder.AddAttribute(62, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesList.razor"
                                                                      () => DeleteCourse(course)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(63, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n");
#nullable restore
#line 45 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesList.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesList.razor"
       
    [Parameter]
    public List<Course> Courses { get; set; }

    private string copiedLink = null;

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
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileUpload FileUploadService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CourseService CourseService { get; set; }
    }
}
#pragma warning restore 1591

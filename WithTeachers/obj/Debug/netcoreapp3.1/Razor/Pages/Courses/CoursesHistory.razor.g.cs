#pragma checksum "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d94b5c9ac588abcad40d14dbae30b75c3be75cc7"
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
using WithTeachers.Pages.Courses.Modals;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\_Imports.razor"
using WithTeachers.Pages.Classes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
    public partial class CoursesHistory : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 8 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
 if (courses == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 11 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
}
else if (courses.Count == 0)
{
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "btn-toolbar mb-3");
            __builder.AddAttribute(5, "role", "toolbar");
            __builder.AddAttribute(6, "aria-label", "Toolbar with button groups");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "btn-group btn-group-sm mr-2");
            __builder.AddAttribute(10, "role", "group");
            __builder.AddAttribute(11, "aria-label", "Sorting group");
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.AddMarkupContent(13, "<div class=\"input-group-prepend\">\r\n                <div class=\"input-group-text\" id=\"btnGroupAddon\">Sort by</div>\r\n            </div>\r\n            ");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "type", "button");
            __builder.AddAttribute(16, "class", "btn btn-secondary");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
                                                                      () => ChooseSortingFilter(SortingFilter.Title)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "disabled", 
#nullable restore
#line 22 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
                                                                                                                                SelectedSortingFilter(SortingFilter.Title)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(19, "Course title");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.OpenElement(21, "button");
            __builder.AddAttribute(22, "type", "button");
            __builder.AddAttribute(23, "class", "btn btn-secondary");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
                                                                      () => ChooseSortingFilter(SortingFilter.UpdateDate)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "disabled", 
#nullable restore
#line 23 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
                                                                                                                                     SelectedSortingFilter(SortingFilter.UpdateDate)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(26, "Update date");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.OpenElement(28, "button");
            __builder.AddAttribute(29, "type", "button");
            __builder.AddAttribute(30, "class", "btn btn-secondary");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
                                                                      () => ChooseSortingFilter(SortingFilter.CreationDate)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "disabled", 
#nullable restore
#line 24 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
                                                                                                                                       SelectedSortingFilter(SortingFilter.CreationDate)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(33, "Creation date");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "btn-group btn-group-sm mr-2");
            __builder.AddAttribute(38, "role", "group");
            __builder.AddAttribute(39, "aria-label", "Order group");
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.AddMarkupContent(41, "<div class=\"input-group-prepend\">\r\n                <div class=\"input-group-text\" id=\"btnGroupAddon\">Order</div>\r\n            </div>\r\n            ");
            __builder.OpenElement(42, "button");
            __builder.AddAttribute(43, "type", "button");
            __builder.AddAttribute(44, "class", "btn btn-secondary");
            __builder.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
                                                                      () => ChooseOrderFilter(OrderFilter.Descending)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "disabled", 
#nullable restore
#line 30 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
                                                                                                                                 SelectedOrderFilter(OrderFilter.Descending)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(47, "<span class=\"oi oi-arrow-thick-bottom\" aria-hidden=\"true\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n            ");
            __builder.OpenElement(49, "button");
            __builder.AddAttribute(50, "type", "button");
            __builder.AddAttribute(51, "class", "btn btn-secondary");
            __builder.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
                                                                      () => ChooseOrderFilter(OrderFilter.Ascending)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(53, "disabled", 
#nullable restore
#line 31 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
                                                                                                                                SelectedOrderFilter(OrderFilter.Ascending)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(54, "<span class=\"oi oi-arrow-thick-top\" aria-hidden=\"true\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n        ");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "input-group");
            __builder.AddMarkupContent(59, "\r\n            ");
            __builder.OpenElement(60, "input");
            __builder.AddAttribute(61, "type", "text");
            __builder.AddAttribute(62, "class", "form-control");
            __builder.AddAttribute(63, "placeholder", "Search by name");
            __builder.AddAttribute(64, "aria-label", "Input group example");
            __builder.AddAttribute(65, "aria-describedby", "btnGroupAddon");
            __builder.AddAttribute(66, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
                                                                                                                                                             SearchCourseByTitle

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n");
            __builder.AddContent(70, "    ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "card-columns");
            __builder.AddMarkupContent(73, "\r\n");
#nullable restore
#line 39 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
         foreach (Course course in coursesToDisplay)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(74, "            ");
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "class", "card");
            __builder.AddMarkupContent(77, "\r\n                ");
            __builder.OpenElement(78, "div");
            __builder.AddAttribute(79, "class", "card-body");
            __builder.AddMarkupContent(80, "\r\n                    ");
            __builder.OpenElement(81, "h5");
            __builder.AddAttribute(82, "class", "card-title");
            __builder.AddContent(83, 
#nullable restore
#line 43 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
                                            course.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n");
#nullable restore
#line 44 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
                     if (!String.IsNullOrEmpty(course.Password))
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(85, "                        ");
            __builder.AddMarkupContent(86, "<span>Password required.</span>\r\n");
#nullable restore
#line 47 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(87, "                    ");
            __builder.OpenElement(88, "p");
            __builder.AddAttribute(89, "class", "small text-muted");
            __builder.AddContent(90, "Created on ");
            __builder.AddContent(91, 
#nullable restore
#line 48 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
                                                            course.CreationDate

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(92, " ");
            __builder.AddContent(93, 
#nullable restore
#line 48 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
                                                                                  course.UpdateDate.ToShortDateString() != course.CreationDate.ToShortDateString() ? "(updated " + @course.UpdateDate + ")" : ""

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n                    ");
            __builder.OpenElement(95, "p");
            __builder.AddAttribute(96, "class", "card-text");
            __builder.AddContent(97, 
#nullable restore
#line 49 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
                                          course.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n");
#nullable restore
#line 51 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
                 if (course.Documents != null && course.Documents.Count > 0)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(100, "                    ");
            __builder.OpenElement(101, "ul");
            __builder.AddAttribute(102, "class", "list-group list-group-flush");
            __builder.AddMarkupContent(103, "\r\n");
#nullable restore
#line 54 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
                         foreach (CourseDocument document in course.Documents)
                        {
                            string link = "uploads/" + document.FileUrl;

#line default
#line hidden
#nullable disable
            __builder.AddContent(104, "                            ");
            __builder.OpenElement(105, "li");
            __builder.AddAttribute(106, "class", "list-group-item");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(107);
            __builder.AddAttribute(108, "href", 
#nullable restore
#line 57 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
                                                                        link

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(109, "target", "_blank");
            __builder.AddAttribute(110, "title", "Open this document");
            __builder.AddAttribute(111, "alt", "Open this document");
            __builder.AddAttribute(112, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(113, "<span class=\"oi oi-document\" aria-hidden=\"true\"></span> ");
                __builder2.AddContent(114, 
#nullable restore
#line 57 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
                                                                                                                                                                                                           document.Title

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n");
#nullable restore
#line 58 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(116, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n");
#nullable restore
#line 60 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(118, "                ");
            __builder.OpenElement(119, "div");
            __builder.AddAttribute(120, "class", "card-body d-flex justify-content-between");
            __builder.AddMarkupContent(121, "\r\n");
#nullable restore
#line 62 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
                     if (copiedLink == NavigationManager.Uri + "/" + course.Slug)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(122, "                        ");
            __builder.AddMarkupContent(123, "<button class=\"btn btn-sm\"><span class=\"oi oi-check\" aria-hidden=\"true\"></span> Link copied</button>\r\n");
#nullable restore
#line 65 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(124, "                        ");
            __builder.OpenElement(125, "button");
            __builder.AddAttribute(126, "class", "btn btn-sm");
            __builder.AddAttribute(127, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 68 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
                                                               () => CopyTextToClipboard(NavigationManager.Uri + "/" + course.Slug)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(128, "Share link");
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n");
#nullable restore
#line 69 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(130, "\r\n                    ");
            __builder.OpenElement(131, "div");
            __builder.AddMarkupContent(132, "\r\n                        ");
            __builder.OpenElement(133, "button");
            __builder.AddAttribute(134, "class", "btn btn-sm");
            __builder.AddAttribute(135, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 72 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
                                                             () => EditCourse(course)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(136, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n                        ");
            __builder.OpenElement(138, "button");
            __builder.AddAttribute(139, "class", "btn btn-danger btn-sm");
            __builder.AddAttribute(140, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
                                                                        () => DeleteCourse(course)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(141, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(142, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(143, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(144, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(145, "\r\n");
#nullable restore
#line 77 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(146, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(147, "\r\n");
#nullable restore
#line 79 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 81 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\CoursesHistory.razor"
       
    [Parameter]
    public EventCallback<bool> CoursesExist { get; set; }

    [Parameter]
    public bool Refresh { get; set; }

    ApplicationUser currentUser;
    List<Course> courses = null;
    List<Course> coursesToDisplay = null;
    string copiedLink = null;

    protected override async Task OnParametersSetAsync()
    {
        currentUser = await ApplicationUserService.GetCurrentUser();
        await LoadCoursesAsync();
    }

    private async Task LoadCoursesAsync()
    {
        courses = await CourseService.ReadAllAsync(currentUser);

        // To keep track of the full first query
        coursesToDisplay = SortList(courses);
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            if (courses != null && courses.Count > 0)
                await CoursesExist.InvokeAsync(true);
            else
                await CoursesExist.InvokeAsync(false);
        }
    }

    private async Task CopyTextToClipboard(string link)
    {
        copiedLink = link;
        await JSRuntime.InvokeVoidAsync("clipboardCopy.copyText", link);
    }

    private async Task EditCourse(Course course)
    {
        var parameters = new ModalParameters();
        parameters.Add("Course", course);

        var modalOpened = Modal.Show<ModalEditCourse>("Edit course", parameters);
        var result = await modalOpened.Result;

        if (!result.Cancelled)
            await LoadCoursesAsync();
    }

    private async Task DeleteCourse(Course course)
    {
        var parameters = new ModalParameters();
        parameters.Add("CourseTitle", course.Title);

        var modalOpened = Modal.Show<ModalDeleteCourse>("Delete course", parameters);
        var result = await modalOpened.Result;

        if (!result.Cancelled)
        {
            //var r = result.Data;

            foreach (CourseDocument document in course.Documents)
                FileUploadService.Delete(document.FileUrl);

            await CourseService.DeleteAsync(course);

            courses.Remove(course);
            coursesToDisplay.Remove(course);

            if (courses == null || courses.Count == 0) await CoursesExist.InvokeAsync(false);
        }
    }

    // SORTING RESULTS
    enum SortingFilter { Title, CreationDate, UpdateDate };
    enum OrderFilter { Ascending, Descending };
    SortingFilter chosenSortingFilter = SortingFilter.UpdateDate;
    OrderFilter chosenOrderFilter = OrderFilter.Descending;

    private void ChooseSortingFilter(SortingFilter sortingFilter)
    {
        chosenSortingFilter = sortingFilter;
        coursesToDisplay = SortList(courses);
    }

    private void ChooseOrderFilter(OrderFilter orderFilter)
    {
        chosenOrderFilter = orderFilter;
        coursesToDisplay = SortList(courses);
    }

    private List<Course> SortList(List<Course> _courses)
    {
        if (chosenSortingFilter == SortingFilter.Title)
            return (chosenOrderFilter == OrderFilter.Ascending ? _courses.OrderBy(x => x.Title) : _courses.OrderByDescending(x => x.Title)).ToList();
        else if (chosenSortingFilter == SortingFilter.UpdateDate)
            return (chosenOrderFilter == OrderFilter.Ascending ? _courses.OrderBy(x => x.UpdateDate) : _courses.OrderByDescending(x => x.UpdateDate)).ToList();
        else if (chosenSortingFilter == SortingFilter.CreationDate)
            return (chosenOrderFilter == OrderFilter.Ascending ? _courses.OrderBy(x => x.CreationDate) : _courses.OrderByDescending(x => x.CreationDate)).ToList();
        else return null;
    }

    private void SearchCourseByTitle(ChangeEventArgs inputText)
    {
        coursesToDisplay = courses.Where(x => x.Title.ToLower().Contains(inputText.Value.ToString().ToLower())).ToList();
        coursesToDisplay = SortList(coursesToDisplay);
    }

    private bool SelectedSortingFilter(SortingFilter sortingFilter)
        => sortingFilter == chosenSortingFilter;

    private bool SelectedOrderFilter(OrderFilter orderFilter)
        => orderFilter == chosenOrderFilter;

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService Modal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileUpload FileUploadService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CourseService CourseService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApplicationUserService ApplicationUserService { get; set; }
    }
}
#pragma warning restore 1591

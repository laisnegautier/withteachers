#pragma checksum "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\AddCourseForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6145af2d044bb35f89af7f992bd04e5fd0ec0adb"
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
#line 1 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\AddCourseForm.razor"
using Slugify;

#line default
#line hidden
#nullable disable
    public partial class AddCourseForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h4 class=\"form-title small\"><span class=\"oi oi-plus\" aria-hidden=\"true\"></span> Add a course with documents</h4>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "class", "form-section");
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\AddCourseForm.razor"
                                       model

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 8 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\AddCourseForm.razor"
                                                             HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ObjectGraphDataAnnotationsValidator>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n\r\n    ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "row add-class");
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "col-12 col-md-5");
                __builder2.AddMarkupContent(14, "\r\n            ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "input-group mb-2");
                __builder2.AddMarkupContent(17, "\r\n                ");
                __builder2.AddMarkupContent(18, "<label for=\"nameCourse\" class=\"col-4\">Course title:</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(19);
                __builder2.AddAttribute(20, "id", "nameCourse");
                __builder2.AddAttribute(21, "placeholder", "Calculus Course 1...");
                __builder2.AddAttribute(22, "class", "form-control");
                __builder2.AddAttribute(23, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\AddCourseForm.razor"
                                                                                                                model.Course.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Course.Title = __value, model.Course.Title))));
                __builder2.AddAttribute(25, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.Course.Title));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n\r\n            ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "input-group mb-2 mb-md-0");
                __builder2.AddMarkupContent(30, "\r\n                ");
                __builder2.AddMarkupContent(31, "<label for=\"password\" class=\"col-4\">Password (optional):</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(32);
                __builder2.AddAttribute(33, "type", "password");
                __builder2.AddAttribute(34, "id", "password");
                __builder2.AddAttribute(35, "class", "form-control");
                __builder2.AddAttribute(36, "placeholder", "Password");
                __builder2.AddAttribute(37, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\AddCourseForm.razor"
                                                                                                                  model.Course.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Course.Password = __value, model.Course.Password))));
                __builder2.AddAttribute(39, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.Course.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n\r\n        ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "col-12 col-md-7 textarea-container");
                __builder2.AddMarkupContent(45, "\r\n            ");
                __builder2.AddMarkupContent(46, "<label for=\"courseDescription\" class=\"sr-only\">Description</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(47);
                __builder2.AddAttribute(48, "id", "courseDescription");
                __builder2.AddAttribute(49, "class", "form-control col-12");
                __builder2.AddAttribute(50, "placeholder", "Description");
                __builder2.AddAttribute(51, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\AddCourseForm.razor"
                                                                                                                     model.Course.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Course.Description = __value, model.Course.Description))));
                __builder2.AddAttribute(53, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.Course.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(54, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n\r\n    ");
                __builder2.AddMarkupContent(57, @"<div class=""row mb-2"">
        <div class=""col-12"">
            <label>Documents</label>

            <table class=""col-12 add-elements"">
                <thead>
                    <tr>
                        <th>Name</th>
                        <th>Lastname</th>
                        <th>Comments</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
                </tbody>
            </table>
        </div>
    </div>

    ");
                __builder2.AddMarkupContent(58, "<p><strong>Add a PDF document (optional)</strong></p>\r\n    ");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "form-group");
                __builder2.AddMarkupContent(61, "\r\n        ");
                __builder2.AddMarkupContent(62, "<label for=\"title\">Document title*</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(63);
                __builder2.AddAttribute(64, "id", "title");
                __builder2.AddAttribute(65, "class", "form-control");
                __builder2.AddAttribute(66, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 87 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\AddCourseForm.razor"
                                                                model.CourseDocument.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(67, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.CourseDocument.Title = __value, model.CourseDocument.Title))));
                __builder2.AddAttribute(68, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.CourseDocument.Title));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(69, "\r\n        ");
                __Blazor.WithTeachers.Pages.Courses.AddCourseForm.TypeInference.CreateValidationMessage_0(__builder2, 70, 71, 
#nullable restore
#line 88 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\AddCourseForm.razor"
                                  () => model.CourseDocument.Title

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(72, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n\r\n    ");
                __builder2.OpenElement(74, "div");
                __builder2.AddAttribute(75, "class", "form-group");
                __builder2.AddMarkupContent(76, "\r\n        ");
                __builder2.AddMarkupContent(77, "<label for=\"document\">Document upload*</label>\r\n        ");
                __builder2.OpenComponent<BlazorInputFile.InputFile>(78);
                __builder2.AddAttribute(79, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorInputFile.IFileListEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 93 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\AddCourseForm.razor"
                             HandleSelection

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(80, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n    ");
                __builder2.OpenElement(82, "p");
                __builder2.OpenElement(83, "strong");
                __builder2.AddContent(84, 
#nullable restore
#line 95 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\AddCourseForm.razor"
                fileStatus

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n\r\n    ");
                __builder2.AddMarkupContent(86, "<div class=\"row\">\r\n        <button type=\"submit\" class=\"btn mx-auto offset-lg-1\">Add this course</button>\r\n    </div>\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 102 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\AddCourseForm.razor"
       
    ApplicationUser currentUser;
    CourseCourseDocument model = new CourseCourseDocument();
    SlugHelper slugHelper = new SlugHelper();

    [Parameter]
    public EventCallback<string> OnSubmitValidated { get; set; }

    protected override async void OnInitialized()
    {
        currentUser = await ApplicationUserService.GetCurrentUser();
    }

    private async Task HandleValidSubmit()
    {
        // Course
        model.Course.Slug = slugHelper.GenerateSlug(model.Course.Title);
        model.Course.CreationDate = DateTime.Now;
        model.Course.UpdateDate = DateTime.Now;
        model.Course.User = currentUser;

        await CourseService.CreateAsync(model.Course);

        // CourseDocument
        model.CourseDocument.FileUrl = "test";
        model.CourseDocument.UploadDate = DateTime.Now;
        model.CourseDocument.Course = model.Course;

        await CourseDocumentService.CreateAsync(model.CourseDocument);

        // Reset
        model = new CourseCourseDocument();

        // Notifier
        await OnSubmitValidated.InvokeAsync("The course <strong>" + model.Course.Title + "</strong> has been added to your courses!");
    }

    private string fileStatus;

    async Task HandleSelection(IFileListEntry[] files)
    {
        var file = files.FirstOrDefault();
        if (file != null)
        {
            await FileUploadService.UploadAsync(file);

            fileStatus = $"Finished loading {file.Size} bytes from {file.Name}";
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileUpload FileUploadService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CourseDocumentService CourseDocumentService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CourseService CourseService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApplicationUserService ApplicationUserService { get; set; }
    }
}
namespace __Blazor.WithTeachers.Pages.Courses.AddCourseForm
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

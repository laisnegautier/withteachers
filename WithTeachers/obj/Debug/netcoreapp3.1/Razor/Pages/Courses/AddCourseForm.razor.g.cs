#pragma checksum "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\AddCourseForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0fd9f4024010efe04aa07778a7d3702ea500eea"
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
                __builder2.AddAttribute(34, "autocomplete", "new-password");
                __builder2.AddAttribute(35, "id", "password");
                __builder2.AddAttribute(36, "class", "form-control");
                __builder2.AddAttribute(37, "placeholder", "Password");
                __builder2.AddAttribute(38, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\AddCourseForm.razor"
                                                                                                                                              model.Course.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Course.Password = __value, model.Course.Password))));
                __builder2.AddAttribute(40, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.Course.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(41, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n\r\n        ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "col-12 col-md-7 textarea-container");
                __builder2.AddMarkupContent(46, "\r\n            ");
                __builder2.AddMarkupContent(47, "<label for=\"courseDescription\" class=\"sr-only\">Description</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(48);
                __builder2.AddAttribute(49, "id", "courseDescription");
                __builder2.AddAttribute(50, "class", "form-control col-12");
                __builder2.AddAttribute(51, "placeholder", "Description");
                __builder2.AddAttribute(52, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\AddCourseForm.razor"
                                                                                                                     model.Course.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(53, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Course.Description = __value, model.Course.Description))));
                __builder2.AddAttribute(54, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.Course.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(55, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n\r\n    ");
                __builder2.OpenElement(58, "div");
                __builder2.AddAttribute(59, "class", "row mb-2");
                __builder2.AddMarkupContent(60, "\r\n        ");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "col-12");
                __builder2.AddMarkupContent(63, "\r\n\r\n");
#nullable restore
#line 33 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\AddCourseForm.razor"
             if (model.CourseDocuments.Count > 0)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(64, "                ");
                __builder2.AddMarkupContent(65, "<label>Documents</label>\r\n");
                __builder2.AddContent(66, "                ");
                __builder2.OpenElement(67, "table");
                __builder2.AddAttribute(68, "class", "col-12 add-elements");
                __builder2.AddMarkupContent(69, "\r\n                    ");
                __builder2.AddMarkupContent(70, "<thead>\r\n                        <tr>\r\n                            <th>Title</th>\r\n                            <th>Upload</th>\r\n                            <th></th>\r\n                        </tr>\r\n                    </thead>\r\n                    ");
                __builder2.OpenElement(71, "tbody");
                __builder2.AddMarkupContent(72, "\r\n\r\n");
#nullable restore
#line 47 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\AddCourseForm.razor"
                         foreach (CourseDocument document in model.CourseDocuments)
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(73, "                            ");
                __builder2.OpenElement(74, "tr");
                __builder2.AddMarkupContent(75, "\r\n                                ");
                __builder2.OpenElement(76, "td");
                __builder2.AddMarkupContent(77, "\r\n                                    ");
                __builder2.AddMarkupContent(78, "<label for=\"titleDocument\" class=\"sr-only\">Title:</label>\r\n                                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(79);
                __builder2.AddAttribute(80, "id", "titleDocument");
                __builder2.AddAttribute(81, "class", "form-control");
                __builder2.AddAttribute(82, "placeholder", "Enter title");
                __builder2.AddAttribute(83, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 52 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\AddCourseForm.razor"
                                                                                                                              document.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(84, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => document.Title = __value, document.Title))));
                __builder2.AddAttribute(85, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => document.Title));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(86, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\r\n\r\n                                ");
                __builder2.OpenElement(88, "td");
                __builder2.AddAttribute(89, "class", "file-upload");
                __builder2.AddMarkupContent(90, "\r\n                                    ");
                __builder2.OpenComponent<WithTeachers.Pages.Courses.FileUpload>(91);
                __builder2.AddAttribute(92, "Document", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<WithTeachers.Data.CourseDocument>(
#nullable restore
#line 56 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\AddCourseForm.razor"
                                                           document

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(93, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n\r\n                                ");
                __builder2.OpenElement(95, "td");
                __builder2.AddAttribute(96, "class", "delete");
                __builder2.AddAttribute(97, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\AddCourseForm.razor"
                                                               () => DeleteDocument(document)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(98, "\r\n                                    <span class=\"oi oi-x\" aria-hidden=\"true\"></span>\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(99, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(100, "\r\n");
#nullable restore
#line 63 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\AddCourseForm.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(101, "                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\r\n");
#nullable restore
#line 66 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\AddCourseForm.razor"
            }

            

#line default
#line hidden
#nullable disable
                __builder2.AddContent(104, "            ");
                __builder2.OpenElement(105, "p");
                __builder2.AddAttribute(106, "class", "mt-2" + " btn" + " btn-add-element" + " small" + " " + (
#nullable restore
#line 69 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\AddCourseForm.razor"
                                                       addBtnDisabled ? "disabled-add-btn" : ""

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(107, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 69 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\AddCourseForm.razor"
                                                                                                              () => { if (!addBtnDisabled) model.CourseDocuments.Add(new CourseDocument()); }

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(108, "<span class=\"oi oi-plus mr-1\" aria-hidden=\"true\"></span> Add document");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(109, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(110, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(111, "\r\n\r\n    ");
                __builder2.AddMarkupContent(112, "<div class=\"row\">\r\n        <button type=\"submit\" class=\"btn mx-auto offset-lg-1\">Add this course</button>\r\n    </div>\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 78 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\AddCourseForm.razor"
       
    [Parameter]
    public EventCallback<string> OnSubmit { get; set; }

    ApplicationUser currentUser;
    CourseCourseDocument model = new CourseCourseDocument();
    SlugHelper slugHelper = new SlugHelper();
    bool addBtnDisabled = false;
    bool uploading = false;

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
        foreach (CourseDocument document in model.CourseDocuments)
        {
            document.Index = model.CourseDocuments.IndexOf(document);
            document.UploadDate = DateTime.Now;
            document.Course = model.Course;
            await CourseDocumentService.CreateAsync(document);
        }

        // Reset
        model = new CourseCourseDocument();

        // Notifier
        await OnSubmit.InvokeAsync("The course <strong>" + model.Course.Title + "</strong> has been added to your courses!");
    }

    private void DeleteDocument(CourseDocument document)
    {
        if(!String.IsNullOrEmpty(document.FileUrl))
            FileUploadService.Delete(document.FileUrl);

        model.CourseDocuments.Remove(document);
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
#pragma warning restore 1591

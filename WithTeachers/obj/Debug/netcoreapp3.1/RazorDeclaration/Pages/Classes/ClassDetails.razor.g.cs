#pragma checksum "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Classes\ClassDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "780aa2f784e4b995b93039aa984ac35f1b73b2cb"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WithTeachers.Pages.Classes
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
    public partial class ClassDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 133 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Classes\ClassDetails.razor"
           
        [Parameter]
        public bool Refresh { get; set; }

        [Parameter]
        public EventCallback<bool> ClassesExist { get; set; }

        bool loading;

        ApplicationUser currentUser;
        List<int> years = null;
        int selectedYear;
        Class selectedClass;
        List<Class> classes = null;
        List<Class> allClasses = null;
        List<Student> students = null;
        Student studentToAdd = new Student();

        protected override async Task OnInitializedAsync()
        {
            loading = true;
        }

        protected override async Task OnParametersSetAsync()
        {
            currentUser = await ApplicationUserService.GetCurrentUser();
            years = await GetYears();
            allClasses = await GetAllClasses();

            // Automatic selection
            if (years != null && years.Count > 0)
                selectYear(years.Max());
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (years != null && years.Count > 0)
                await ClassesExist.InvokeAsync(true);
            else
                await ClassesExist.InvokeAsync(false);
        }

        async void selectYear(int year)
        {
            selectedYear = year;
            classes = await GetClasses();

            if (classes != null && classes.Count > 0)
            {
                selectedClass = classes.First();
                if (selectedClass.Students != null && selectedClass.Students.Count > 0)
                    students = await GetStudents();
            }
        }

        async void selectClass(Class cl)
        {
            selectedClass = cl;
            students = await GetStudents();
        }

        bool tabSelected(int year) => selectedYear == year;
        bool classSelected(Class cl) => selectedClass == cl;

        async void HandleValidSubmitAddStudent()
        {
            // Adding data
            studentToAdd.ClassId = selectedClass.ClassId;
            await StudentService.CreateAsync(studentToAdd);

            // Refreshing components
            students = await GetStudents();

            // Formatting form
            studentToAdd = new Student();
        }

        async void DeleteStudent(Student student)
        {
            await StudentService.Delete(student);

            // Refreshing components
            students = await GetStudents();
        }

        async void DeleteSelectedClass()
        {
            await ClassService.Delete(selectedClass);

            // Refreshing components
            years = await GetYears();
            allClasses = await GetAllClasses();
            classes = await GetClasses();

            // Automatic selection
            if (years != null && years.Count > 0)
            {
                if (years.Contains(selectedYear))
                    selectYear(selectedYear);
                else
                    selectYear(years.Max());
            }

            students = await GetStudents();
        }

        // PROPERTY UPDATES
        async Task<List<int>> GetYears() => await ClassService.ReadYearsAsync(currentUser);
        async Task<List<Class>> GetClasses() => await ClassService.ReadAllAsync(currentUser, selectedYear);
        async Task<List<Class>> GetAllClasses() => await ClassService.ReadAllAsync(currentUser);
        async Task<List<Student>> GetStudents() => await StudentService.ReadAllAsync(selectedClass);
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private StudentService StudentService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ClassService ClassService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApplicationUserService ApplicationUserService { get; set; }
    }
}
#pragma warning restore 1591

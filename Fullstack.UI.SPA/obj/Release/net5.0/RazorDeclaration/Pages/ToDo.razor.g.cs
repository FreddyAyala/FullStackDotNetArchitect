// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Fullstack.UI.SPA.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Freddy\source\repos\FullStackToDoListCourse\Fullstack.UI.SPA\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Freddy\source\repos\FullStackToDoListCourse\Fullstack.UI.SPA\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Freddy\source\repos\FullStackToDoListCourse\Fullstack.UI.SPA\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Freddy\source\repos\FullStackToDoListCourse\Fullstack.UI.SPA\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Freddy\source\repos\FullStackToDoListCourse\Fullstack.UI.SPA\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Freddy\source\repos\FullStackToDoListCourse\Fullstack.UI.SPA\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Freddy\source\repos\FullStackToDoListCourse\Fullstack.UI.SPA\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Freddy\source\repos\FullStackToDoListCourse\Fullstack.UI.SPA\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Freddy\source\repos\FullStackToDoListCourse\Fullstack.UI.SPA\_Imports.razor"
using Fullstack.UI.SPA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Freddy\source\repos\FullStackToDoListCourse\Fullstack.UI.SPA\_Imports.razor"
using Fullstack.UI.SPA.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Freddy\source\repos\FullStackToDoListCourse\Fullstack.UI.SPA\Pages\ToDo.razor"
using FullStack.Domain.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Freddy\source\repos\FullStackToDoListCourse\Fullstack.UI.SPA\Pages\ToDo.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/todos")]
    public partial class ToDo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\Freddy\source\repos\FullStackToDoListCourse\Fullstack.UI.SPA\Pages\ToDo.razor"
       
    private TodoViewModel todos;

    protected override async Task OnInitializedAsync()
    {

        todos = await Http.GetFromJsonAsync<TodoViewModel>(Configuration["ApiUrl"] + "todo");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration Configuration { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591

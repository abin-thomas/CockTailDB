#pragma checksum "d:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09ec9436fc96ee38d61f984f09874820b0fb54eb"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CockTailBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "d:\OneDrive_Trios\C# Blazor\CockTailBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "d:\OneDrive_Trios\C# Blazor\CockTailBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "d:\OneDrive_Trios\C# Blazor\CockTailBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "d:\OneDrive_Trios\C# Blazor\CockTailBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "d:\OneDrive_Trios\C# Blazor\CockTailBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "d:\OneDrive_Trios\C# Blazor\CockTailBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "d:\OneDrive_Trios\C# Blazor\CockTailBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "d:\OneDrive_Trios\C# Blazor\CockTailBlazor\_Imports.razor"
using CockTailBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "d:\OneDrive_Trios\C# Blazor\CockTailBlazor\_Imports.razor"
using CockTailBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "d:\OneDrive_Trios\C# Blazor\CockTailBlazor\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "d:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\Index.razor"
using CockTailBlazor.CustomAPI;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "d:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\Index.razor"
     
        string drinkIDClicked;
        protected override async Task OnInitializedAsync()
        {
            Program.MakeAllNull();
            await Program.fetch.RandomDrinkAsync();
        }
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
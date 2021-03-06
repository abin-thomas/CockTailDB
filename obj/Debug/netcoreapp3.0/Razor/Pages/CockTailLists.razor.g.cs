#pragma checksum "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\CockTailLists.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccad76d2bd0d47a78dfcef423b66675f3908e772"
// <auto-generated/>
#pragma warning disable 1591
namespace CockTailBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\_Imports.razor"
using CockTailBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\_Imports.razor"
using CockTailBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\CockTailLists.razor"
using CockTailBlazor.CustomAPI;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/cocktaillists")]
    public partial class CockTailLists : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "\r\n        ");
            __builder.OpenElement(2, "input");
            __builder.AddAttribute(3, "type", "text");
            __builder.AddAttribute(4, "class", "form-control form-control-lg");
            __builder.AddAttribute(5, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 5 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\CockTailLists.razor"
                                                                        searchTerm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => searchTerm = __value, searchTerm));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "type", "button");
            __builder.AddAttribute(10, "class", "btn btn-primary btn-block");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\CockTailLists.razor"
                            e=>GetDrinksByAlphabet(@searchTerm)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "style", "margin:4px;");
            __builder.AddMarkupContent(13, "\r\n            Search\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        (You can search by either drink\'s name or by just entering first alphabet only to see all the drinks starting with that alphabet.)\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n    \r\n");
#nullable restore
#line 14 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\CockTailLists.razor"
 if (Program.ctDetails != null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\CockTailLists.razor"
     foreach (Drinks drink in Program.ctDetails.drinks)
    {
        drinkIDClicked = drink.idDrink;

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "        ");
            __builder.OpenElement(17, "a");
            __builder.AddAttribute(18, "href", "/Details/" + (
#nullable restore
#line 19 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\CockTailLists.razor"
                           drinkIDClicked

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "master");
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "drinkThumb");
            __builder.AddAttribute(25, "style", "background:" + " url(" + (
#nullable restore
#line 22 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\CockTailLists.razor"
                                             drink.strDrinkThumb

#line default
#line hidden
#nullable disable
            ) + ");" + "\r\n                                background-size:" + " cover;" + "\r\n                                background-position:" + " center" + " center;");
            __builder.AddMarkupContent(26, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenElement(28, "p");
            __builder.AddAttribute(29, "class", "text-center");
            __builder.AddContent(30, 
#nullable restore
#line 27 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\CockTailLists.razor"
                                        drink.strDrink

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
#nullable restore
#line 30 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\CockTailLists.razor"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\CockTailLists.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\CockTailLists.razor"
       

    string drinkIDClicked;
    string searchTerm;

    
    protected override async Task OnParametersSetAsync()
    {
        Program.MakeAllNull();
    }

    private async Task GetDrinksByAlphabet(string searchValue)
    {
        Program.ctDetails = null;
        await Program.fetch.DrinksByAlphabetAsync(searchValue);
    }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\AlcoholicLists.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9ca9bfb98c5c88daab64c7d54bf7d33b1f2a6a3"
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
#line 2 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\AlcoholicLists.razor"
using CockTailBlazor.CustomAPI;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/alcoholiclists")]
    public partial class AlcoholicLists : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.OpenElement(2, "label");
            __builder.AddAttribute(3, "class", "labels");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\AlcoholicLists.razor"
                                      e=>GetDrinksAlcoholic("Alcoholic")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(5, "Alcoholic");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.AddMarkupContent(7, "<label>//</label>\r\n    ");
            __builder.OpenElement(8, "label");
            __builder.AddAttribute(9, "class", "labels");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\AlcoholicLists.razor"
                                      e=>GetDrinksAlcoholic("Non_Alcoholic")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(11, "Non-Alcoholic");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n\r\n");
#nullable restore
#line 12 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\AlcoholicLists.razor"
 if (Program.ctDetails != null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\AlcoholicLists.razor"
     foreach (Drinks drink in Program.ctDetails.drinks)
    {
        drinkIDClicked = drink.idDrink;

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "        ");
            __builder.OpenElement(15, "a");
            __builder.AddAttribute(16, "href", "/Details/" + (
#nullable restore
#line 17 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\AlcoholicLists.razor"
                           drinkIDClicked

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "master");
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "drinkThumb");
            __builder.AddAttribute(23, "style", "background:" + " url(" + (
#nullable restore
#line 20 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\AlcoholicLists.razor"
                                             drink.strDrinkThumb

#line default
#line hidden
#nullable disable
            ) + ");" + "\r\n                                background-size:" + " cover;" + "\r\n                                background-position:" + " center" + " center;");
            __builder.AddMarkupContent(24, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.OpenElement(26, "p");
            __builder.AddAttribute(27, "class", "text-center");
            __builder.AddContent(28, 
#nullable restore
#line 25 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\AlcoholicLists.razor"
                                        drink.strDrink

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
#nullable restore
#line 28 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\AlcoholicLists.razor"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\AlcoholicLists.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\AlcoholicLists.razor"
       

        string drinkIDClicked;

    protected override async Task OnParametersSetAsync()
    {
        Program.MakeAllNull();        
    }

    private async Task GetDrinksAlcoholic(string alcoholicType)
    {
        await Program.fetch.DrinksByAlcoholicAsync(alcoholicType);
    }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

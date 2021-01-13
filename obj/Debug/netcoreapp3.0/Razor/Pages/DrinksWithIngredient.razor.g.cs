#pragma checksum "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\DrinksWithIngredient.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d02a73bc4ab7b1f5f3c3259907e2fe793bca81ea"
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
#line 2 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\DrinksWithIngredient.razor"
using CockTailBlazor.CustomAPI;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/drinkswithingredient/{ingredientClicked}")]
    public partial class DrinksWithIngredient : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\DrinksWithIngredient.razor"
 if (Program.ctDetails != null)
{
    
    string ingredientPath = "https://www.thecocktaildb.com/images/ingredients/" + @ingredientClicked + ".png";
    

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "master");
            __builder.AddAttribute(2, "style", "max-width:350px; max-height: 400px;");
            __builder.AddMarkupContent(3, "\r\n\r\n        ");
            __builder.OpenElement(4, "img");
            __builder.AddAttribute(5, "src", 
#nullable restore
#line 12 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\DrinksWithIngredient.razor"
                  ingredientPath

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(6, "class", "img-thumbnail");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "p");
            __builder.AddAttribute(10, "class", "ingredientDesc");
            __builder.AddContent(11, 
#nullable restore
#line 15 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\DrinksWithIngredient.razor"
                               Program.ingredientDesc.ingredients[0].strDescription

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(12, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
            __builder.AddContent(14, "    ");
            __builder.OpenElement(15, "h2");
            __builder.OpenElement(16, "u");
            __builder.AddContent(17, "Drinks Having ");
            __builder.AddContent(18, 
#nullable restore
#line 17 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\DrinksWithIngredient.razor"
                          Program.ingredientDesc.ingredients[0].strIngredient

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(19, " .");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
#nullable restore
#line 18 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\DrinksWithIngredient.razor"
     foreach (Drinks drink in Program.ctDetails.drinks)
    {
        drinkIDClicked = drink.idDrink;

#line default
#line hidden
#nullable disable
            __builder.AddContent(21, "        ");
            __builder.OpenElement(22, "a");
            __builder.AddAttribute(23, "href", "/Details/" + (
#nullable restore
#line 21 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\DrinksWithIngredient.razor"
                           drinkIDClicked

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(24, "\r\n\r\n            ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "master");
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenElement(28, "img");
            __builder.AddAttribute(29, "src", 
#nullable restore
#line 24 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\DrinksWithIngredient.razor"
                           drink.strDrinkThumb

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(30, "alt", 
#nullable restore
#line 24 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\DrinksWithIngredient.razor"
                                                      drink.strDrink

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(31, "width", "200");
            __builder.AddAttribute(32, "height", "200");
            __builder.AddAttribute(33, "style", "border-radius:5%; margin:3px;");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.OpenElement(35, "p");
            __builder.AddAttribute(36, "class", "font-weight-bolder text-center");
            __builder.AddContent(37, 
#nullable restore
#line 26 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\DrinksWithIngredient.razor"
                                                           drink.strDrink

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
#nullable restore
#line 29 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\DrinksWithIngredient.razor"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\DrinksWithIngredient.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\DrinksWithIngredient.razor"
       

    [Parameter]
    public string ingredientClicked { get; set; }

    string drinkIDClicked;

    protected override async Task OnParametersSetAsync()
    {
        Program.MakeAllNull();
        await Program.fetch.DrinksWithIngredientAsync(ingredientClicked);



    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
#pragma checksum "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\Details.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e6e62e45ff05098f542302c585714888720e10d"
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
#line 2 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\Details.razor"
using CockTailBlazor.CustomAPI;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/details/{drinkIDClicked}")]
    public partial class Details : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\Details.razor"
 if (Program.singleDrink != null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\Details.razor"
     foreach (Drinks drink in Program.singleDrink.drinks)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "        ");
            __builder.OpenElement(1, "div");
            __builder.AddMarkupContent(2, "\r\n            ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "master");
            __builder.AddMarkupContent(5, "\r\n                ");
            __builder.OpenElement(6, "img");
            __builder.AddAttribute(7, "src", 
#nullable restore
#line 12 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\Details.razor"
                           drink.strDrinkThumb

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(8, "alt", 
#nullable restore
#line 12 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\Details.razor"
                                                      drink.strDrink

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(9, "width", "400");
            __builder.AddAttribute(10, "height", "400");
            __builder.AddAttribute(11, "style", "border-radius:5%");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "p");
            __builder.AddAttribute(14, "class", "font-weight-bolder text-center");
            __builder.AddContent(15, 
#nullable restore
#line 14 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\Details.razor"
                                                           drink.strDrink

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "div");
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.AddMarkupContent(20, "<p class=\"text-lg-center font-weight-bolder\">Ingredients:</p>\r\n                \r\n");
#nullable restore
#line 19 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\Details.razor"
                 for(int i=0;i<ingredientCount;i++)
                {
                    if (ingredients[i] != null)
                    {
                        ingredientPath = "https://www.thecocktaildb.com/images/ingredients/" + ingredients[i] + "-medium.png";

#line default
#line hidden
#nullable disable
            __builder.AddContent(21, "                        ");
            __builder.OpenElement(22, "a");
            __builder.AddAttribute(23, "href", "/DrinksWithIngredient/" + (
#nullable restore
#line 24 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\Details.razor"
                                                        ingredients[i]

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(24, "                            \r\n                            ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "ingredientsThumb");
            __builder.AddMarkupContent(27, "\r\n                                ");
            __builder.OpenElement(28, "img");
            __builder.AddAttribute(29, "src", 
#nullable restore
#line 26 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\Details.razor"
                                           ingredientPath

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(30, "alt", 
#nullable restore
#line 27 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\Details.razor"
                                           ingredients[i]

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(31, "style", "width:200px; height:200px;");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                                ");
            __builder.OpenElement(33, "p");
            __builder.AddAttribute(34, "class", "text-center");
            __builder.AddContent(35, 
#nullable restore
#line 29 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\Details.razor"
                                                        ingredientsMeasures[i]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(36, " ");
            __builder.AddContent(37, 
#nullable restore
#line 29 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\Details.razor"
                                                                                ingredients[i]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
#nullable restore
#line 32 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\Details.razor"
                    }

                }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n            ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "id", "divInstructions");
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.AddMarkupContent(46, "<u>Preparation Guide:</u>\r\n                ");
            __builder.OpenElement(47, "p");
            __builder.AddContent(48, 
#nullable restore
#line 39 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\Details.razor"
                    drink.strInstructions

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n            \r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n");
#nullable restore
#line 43 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\Details.razor"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\Details.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\Details.razor"
       

    [Parameter]
    public string drinkIDClicked { get; set; }

    int ingredientCount = 7;
    public string[] ingredients = new string[7];
    public string[] ingredientsMeasures = new string[7];

    public string ingredientPath;

    protected override async Task OnParametersSetAsync()
    {
        Program.MakeAllNull();
        await Program.fetch.DrinkDetailAsync(drinkIDClicked);


        if (Program.singleDrink.drinks[0].strIngredient1 != null)
        {
            ingredients[0] = Program.singleDrink.drinks[0].strIngredient1;
            ingredientsMeasures[0] = Program.singleDrink.drinks[0].strMeasure1;
        }
        if (Program.singleDrink.drinks[0].strIngredient2 != null)
        {
            ingredients[1] = Program.singleDrink.drinks[0].strIngredient2;
            ingredientsMeasures[1] = Program.singleDrink.drinks[0].strMeasure2;
        }
        if (Program.singleDrink.drinks[0].strIngredient3 != null)
        {
            ingredients[2] = Program.singleDrink.drinks[0].strIngredient3;
            ingredientsMeasures[2] = Program.singleDrink.drinks[0].strMeasure3;
        }
        if (Program.singleDrink.drinks[0].strIngredient4 != null)
        {
            ingredients[3] = Program.singleDrink.drinks[0].strIngredient4;
            ingredientsMeasures[3] = Program.singleDrink.drinks[0].strMeasure4;
        }
        if (Program.singleDrink.drinks[0].strIngredient5 != null)
        {
            ingredients[4] = Program.singleDrink.drinks[0].strIngredient5;
            ingredientsMeasures[4] = Program.singleDrink.drinks[0].strMeasure5;
        }
        if (Program.singleDrink.drinks[0].strIngredient6 != null)
        {
            ingredients[5] = Program.singleDrink.drinks[0].strIngredient6;
            ingredientsMeasures[5] = Program.singleDrink.drinks[0].strMeasure6;
        }
        if (Program.singleDrink.drinks[0].strIngredient7 != null)
        {
            ingredients[6] = Program.singleDrink.drinks[0].strIngredient7;
            ingredientsMeasures[6] = Program.singleDrink.drinks[0].strMeasure7;
        }
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

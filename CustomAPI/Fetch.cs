using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace CockTailBlazor.CustomAPI
{
    public class Fetch
    {
        public HttpClient client = new HttpClient();
        public string Data { get; set; }
        

        
        public async Task DrinksByAlphabetAsync(string search)
        {
            HttpResponseMessage drinksData = null;
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("applicationException/json"));
            
            if(search.Length>1)
            {
                drinksData = await client.GetAsync(
                             "https://www.thecocktaildb.com/api/json/v1/1/search.php?s=" + search);

            }
            else if(search.Length==1)
            {
                drinksData = await client.GetAsync(
                             "https://www.thecocktaildb.com/api/json/v1/1/search.php?f=" + search);

            }



            if (drinksData.IsSuccessStatusCode)
            {
                Data = await drinksData.Content.ReadAsStringAsync();
                /*If Data ends with null} it means that there is no
                record to show */
                if(Data.Substring(Data.Length - 5)!="null}")
                { 
                    Program.ctDetails = JsonConvert.DeserializeObject<CockTails>(Data);
                }
            }
            else
            {
                Data = null;
            }
        }

        public async Task RandomDrinkAsync()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("applicationException/json"));


            HttpResponseMessage drinksData =
                await client.GetAsync(
                    "https://www.thecocktaildb.com/api/json/v1/1/random.php");


            if (drinksData.IsSuccessStatusCode)
            {
                Data = await drinksData.Content.ReadAsStringAsync();

                Program.singleDrink = JsonConvert.DeserializeObject<CockTails>(Data);
            }
            else
            {
                Data = null;
            }
        }
        public async Task DrinksByAlcoholicAsync(string search)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("applicationException/json"));


            HttpResponseMessage drinksData =
                await client.GetAsync(
                    "https://www.thecocktaildb.com/api/json/v1/1/filter.php?a=" + search);


            if (drinksData.IsSuccessStatusCode)
            {
                Data = await drinksData.Content.ReadAsStringAsync();
                
                Program.ctDetails = JsonConvert.DeserializeObject<CockTails>(Data);
            }
            else
            {
                Data = null;
            }
        }

        public async Task CategoryListsAsync()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("applicationException/json"));


            HttpResponseMessage categoryData =
                await client.GetAsync(
                    "https://www.thecocktaildb.com/api/json/v1/1/list.php?c=list");


            if (categoryData.IsSuccessStatusCode)
            {
                Data = await categoryData.Content.ReadAsStringAsync();

                Program.categoryTypes = JsonConvert.DeserializeObject<Categories>(Data);
            }
            else
            {
                Data = null;
            }
        }

        public async Task GlassListsAsync()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("applicationException/json"));


            HttpResponseMessage glassData =
                await client.GetAsync(
                    "https://www.thecocktaildb.com/api/json/v1/1/list.php?g=list");


            if (glassData.IsSuccessStatusCode)
            {
                Data = await glassData.Content.ReadAsStringAsync();

                Program.glassTypes = JsonConvert.DeserializeObject<Glasses>(Data);
            }
            else
            {
                Data = null;
            }
        }

        public async Task GetIngredientListsAsync()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("applicationException/json"));


            HttpResponseMessage ingredientsData =
                await client.GetAsync(
                    "https://www.thecocktaildb.com/api/json/v1/1/list.php?i=list");


            if (ingredientsData.IsSuccessStatusCode)
            {
                Data = await ingredientsData.Content.ReadAsStringAsync();

                Program.ingredientNames = JsonConvert.DeserializeObject<Ingredients>(Data);
            }
            else
            {
                Data = null;
            }
        }

        public async Task DrinksWithIngredientAsync(string ingredient)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("applicationException/json"));


            HttpResponseMessage drinksWithIngredientData =
                await client.GetAsync(
                    "https://www.thecocktaildb.com/api/json/v1/1/filter.php?i=" + ingredient);

            HttpResponseMessage IngredientDescription =
                await client.GetAsync(
                    "https://www.thecocktaildb.com/api/json/v1/1/search.php?i=" + ingredient);


            if (drinksWithIngredientData.IsSuccessStatusCode)
            {
                Data = await drinksWithIngredientData.Content.ReadAsStringAsync();

                Program.ctDetails = JsonConvert.DeserializeObject<CockTails>(Data);
            }
            else
            {
                Data = null;
            }

            string ingredientData = await IngredientDescription.Content.ReadAsStringAsync();

            Program.ingredientDesc = JsonConvert.DeserializeObject<IngredientDescription>(ingredientData);
        }
        public async Task DrinksInSingleGlassAsync(string glassType)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("applicationException/json"));


            HttpResponseMessage drinksInGlassData =
                await client.GetAsync(
                    "https://www.thecocktaildb.com/api/json/v1/1/filter.php?g=" + glassType);


            if (drinksInGlassData.IsSuccessStatusCode)
            {
                Data = await drinksInGlassData.Content.ReadAsStringAsync();

                Program.ctDetails = JsonConvert.DeserializeObject<CockTails>(Data);
            }
            else
            {
                Data = null;
            }
        }
        public async Task DrinksInCategoryAsync(string category)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("applicationException/json"));


            HttpResponseMessage drinksInCategoryData =
                await client.GetAsync(
                    "https://www.thecocktaildb.com/api/json/v1/1/filter.php?c="+category);


            if (drinksInCategoryData.IsSuccessStatusCode)
            {
                Data = await drinksInCategoryData.Content.ReadAsStringAsync();

                Program.ctDetails = JsonConvert.DeserializeObject<CockTails>(Data);
            }
            else
            {
                Data = null;
            }
        }

        

        public async Task DrinkDetailAsync(string drinkID)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("applicationException/json"));


            HttpResponseMessage drinkDetail =
                await client.GetAsync(
                    "https://www.thecocktaildb.com/api/json/v1/1/lookup.php?i=" + drinkID);


            if (drinkDetail.IsSuccessStatusCode)
            {
                Data = await drinkDetail.Content.ReadAsStringAsync();
                
                Program.singleDrink = JsonConvert.DeserializeObject<CockTails>(Data);
            }
            
        }
    }
}

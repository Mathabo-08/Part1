using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Recipe_Application
{
    internal class Recipe_App
    {
        public static void Main(string[] args)
        {
            
                // Object
                Recipe recipe = new Recipe();
                string recipeName = "";

            while (true)
            {
                Console.WriteLine("\n------ Please choose an option ------");
                Console.WriteLine("1. Enter recipe details");
                Console.WriteLine("2. Display recipe");
                Console.WriteLine("3. Clear recipe");
                Console.WriteLine("4. Exit");
                
                Console.Write("\nEnter your choice of option: ");
                string choice = Console.ReadLine();
                
                switch (choice) {
                    case "1":

                        // Method to call the GetRecipeName 
                        recipeName = recipe.GetRecipeName();

                        // Method to collect all the recipe details    
                        recipe.GetRecipeDetails();
                        break;
                    case "2":
                        // Method to call a recipe after collecting all the details and display it  
                        if(string.IsNullOrEmpty(recipeName))
                        { 
                            Console.WriteLine("\nPlease ensure that you enter the recipe details first, before displaying the recipe!");
                        }
                        else
                        { 
                            recipe.DisplayRecipe(recipeName);
                        // Method to call to scale the recipe by factors like 0.5, 2, 3
                            recipe.RecipeScale();
                        // Method to call to reset the quantities to the original values
                            recipe.QuantityReset();
                        }
                        break;

                    case "3":
                        // Method to call to clear the full recipe
                        recipe.ClearRecipe();
                        Console.WriteLine("\nRecipe cleared!");
                        break;

                    case "4":
                        // exit application
                        return;
                        
                        
                    default:
                        Console.WriteLine("\nInvalid choice.Please enter one of the choices from the list of options!");
                        break;
                        
                }
            }
        }
    }
}

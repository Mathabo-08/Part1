using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe_Application
{
    internal class Recipe
    {
    // Declare variables
        private Ingredients ingredients;
        private Steps steps;
        

        // Constructor -> Allows Recipe class to have access to the properties and methods of the Ingredients Class and Steps Class
        public Recipe() 
        {
            ingredients = new Ingredients();
            steps = new Steps();
        }

        // Method to prompt user to enter recipe name
        public string GetRecipeName()
        {
            Console.Write("\nEnter the recipe name: ");
            string recipeName = Console.ReadLine();
            return recipeName;
        }

        // Method to ask user to enter input for the recipe details
        public void GetRecipeDetails() 
        {
            ingredients.GetIngreDetails();
            steps.GetStepsDetails();
        }

        // Method to print the the full recipe
        public void DisplayRecipe(string recipeName) 
        {
            Console.WriteLine("\n-------- Recipe -------");
            Console.WriteLine("\nRecipe Name: " + recipeName);
            
            Console.WriteLine("\n ***** Ingredients *****");
            ingredients.DisplayIngredients();
            
            Console.WriteLine("\n ***** Steps ***** ");
            steps.DisplaySteps();
        }

        // Method to scale the recipe ingredients by factors (0.5, 2, 3)
        public void RecipeScale() 
        {
            Console.Write("\n------ Scaling Factors ------\n0.5\n2\n3\nEnter the scaling factor of your choice:");
            double factor = Convert.ToDouble(Console.ReadLine());
            ingredients.IngredientsScale(factor);
        }
        // Method resetting the ingredient quantities to the original values
        public void QuantityReset() 
        {
            Console.WriteLine("\n----- Quantity Reset -----");
            ingredients.QuantityReset();
        }

        // Method to display the steps
        public void GetStepsDetails() 
        {
            steps.GetStepsDetails();
        }

        // Method to clear the full recipe
        public void ClearRecipe() 
        {
            ingredients.ClearIngredients();
            steps.ClearSteps();
        }
    }
}

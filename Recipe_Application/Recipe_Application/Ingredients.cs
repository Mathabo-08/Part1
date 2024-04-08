using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Recipe_Application
{
    internal class Ingredients
    {
    // Declare array variables 
        private string[] ingredientName;
        private double[] origIngredientQuan;
        private double[] ingredientQuantity;
        private string[] ingredientUnitsMeasurement;

        // Method to prompt the user to enter the ingredient details
        public void GetIngreDetails() 
        {
            Console.Write("\nEnter the number of ingredients: ");
            int ingredientNum = Convert.ToInt32(Console.ReadLine());

            ingredientName = new string[ingredientNum];
            ingredientQuantity = new double[ingredientNum];
            origIngredientQuan = new double[ingredientNum];
            ingredientUnitsMeasurement = new string[ingredientNum];

            for (int i = 0; i < ingredientNum; i++) 
            {
                Console.Write("\nEnter the name of the Ingredient: ");
                ingredientName[i] = Console.ReadLine();
                
                Console.Write("\nEnter the quantity of the ingredients: ");
                ingredientQuantity[i] = Convert.ToDouble(Console.ReadLine());

                // Store the original ingredient quantity
                origIngredientQuan[i] = ingredientQuantity[i];

                Console.Write("\nEnter the unit of measurement: ");
                ingredientUnitsMeasurement[i] = Console.ReadLine();

            }
        }

        // Method to print the ingredients
        public void DisplayIngredients() 
        {
            for (int i = 0; i < ingredientName.Length; i++ ) 
            {
                Console.WriteLine($"\nIngredient {i + 1}:  \n{ "Ingredient Name: "  + ingredientName[i]} \n{"Quantity: " + ingredientQuantity[i]} \n{"Unit of measurement: " + ingredientUnitsMeasurement[i]}");
            }
        }

        // Method to scale the ingredients quantities by factors (0.5, 2, 3)
        public void IngredientsScale(double factor)
        {
            Console.WriteLine("\n------ Scaled Ingredients ------");

            for (int i = 0; i < ingredientQuantity.Length; i++) 
            {
                ingredientQuantity[i] *= factor;
            }
            DisplayIngredients();
        }

        // Method to reset the ingredients quantities to original values
        public void QuantityReset() 
        {

            for (int i = 0; i < ingredientQuantity.Length; i++)
            {
                ingredientQuantity[i] = origIngredientQuan[i]; 
            }
            DisplayIngredients();
        }

        // Method to clear all the ingredients
        public void ClearIngredients()
        {
            ingredientName = null;
            ingredientQuantity = null;
            ingredientUnitsMeasurement = null;
        }
    }
}

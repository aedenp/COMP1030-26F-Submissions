
using System;

namespace FlooringCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Commit 1 (step 1): Declare variables for the three flooring types and their prices
            // Three flooring types with price per square foot
            string bamboo = "Bamboo ($7.25/sq.ft.)";
            string slate = "Slate Tile ($11.50/sq.ft.)";
            string cork = "Cork ($6.40/sq.ft.)";

            // Prices as decimals so step 10 can do the math
            decimal bambooPrice = 7.25m;
            decimal slatePrice = 11.50m;
            decimal corkPrice = 6.40m;

            // Holds the user's flooring choice: "A", "B", or "C"
            string floorChoice = "";
 
            //2.Declare two variables to represent the length and width of a room (using feet measured to one decimal point). (Aedem)

            double length = 0;
            double width = 0;

            //3.Ask the user the length of the room they are looking to install the new flooring. (Aeden)

            Console.Write("Enter the length of the room in feet: ");
            string lengthInput = Console.ReadLine();

            //4.Check to see that the user has inputted a number - if yes, then store this value in the length variable created in step 4, if no then output an appropriate error message to the console. (Aeden)

            if (double.TryParse(lengthInput, out length) && length > 0)
            {
                // Successfully stored in the 'length' variable
            }
            else
            {
                Console.WriteLine("Error: That is not a valid number for length.");
                return;
            }

            //5.Ask the user the width of the room they are looking to install the new flooring.(Aeden)

            Console.Write("Enter the width of the room in feet: ");
            string widthInput = Console.ReadLine();

            //6.Check to see that the user has inputted a number - if yes, then store this value in the width variable created in step 4, if no then output an appropriate error message to the console.(Aeden)

            if (double.TryParse(widthInput, out width) && width > 0)
            {

            }
            else
            {
                Console.WriteLine("Error: That is not a valid number for width.");
                return;
            }

            //7.Ask the user what type of flooring they would like, by building a sentence using the variables created in step 2 - to make it easy for the user, perhaps assign letters to each choice.(Aeden)

            // added the strings for the wood here as it looked better to me. I can move them if you woulf like me to. (Aeden)
            string floorA = "Oak Hardwood ($8.50/sq.ft.)";
            string floorB = "Ceramic Tile ($12.75/sq.ft.)";
            string floorC = "Carpet ($5.25/sq.ft.)";

            Console.WriteLine("\nWhich type of flooring would you like?");
            Console.WriteLine($"  A) {floorA}");
            Console.WriteLine($"  B) {floorB}");
            Console.WriteLine($"  C) {floorC}");
            Console.Write("Enter A, B, or C: ");
            string choiceInput = Console.ReadLine();

            //8.Check to see that the user has inputted a letter (one of the three choices for flooring) - if yes, then store this value in the variable created in step 3, if no then output an appropriate error message to the console.
            
            //9.Create a series of if() statements that correspond to each choice of flooring.
           
            //10.Make sure the user entered one of the three letters, and store it
            
            //11.Output the floor type, area, and final cost
           
            //12.Be sure to include helpful and appropriate comments throughout your program

            //13.Have fun!

        }
    }
}
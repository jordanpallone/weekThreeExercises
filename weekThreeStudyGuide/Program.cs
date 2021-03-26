using System;
using System.Collections.Generic;
using System.Linq;

namespace WeekThreeAdditionalExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercise 31
            /*
            int[] e31Nums = { 2, 8, 0, 24, 51 }; // declare array values
            Console.Write("Enter an index of the array: "); // take user input  
            int index = Int32.Parse(Console.ReadLine()); // parse user input and save it to index
            Console.WriteLine(e31Nums[index]); // use index value to display that value in the array
            */

            //exercise 32
            /*
            int[] e32Nums = { 2, 8, 0, 24, 51 };
            Console.WriteLine("Enter a number: ");
            int choosenNum = Int32.Parse(Console.ReadLine());
            int caseSwitch = choosenNum;
            switch (caseSwitch)
            {
                case 2:
                    Console.WriteLine("The value 2 is at index 0.");
                    break;
                case 8:
                    Console.WriteLine("The value 8 is at index 1.");
                    break;
                case 0:
                    Console.WriteLine("The value 0 is at index 2.");
                    break;
                case 24:
                    Console.WriteLine("The value 24 is at index 3.");
                    break;
                case 51:
                    Console.WriteLine("The value 51 is at index 4.");
                    break;
                default:
                    Console.WriteLine("Value is not in the array");
                    break;
            }
            */

            //exercise 33
            /*
            int[] e33Nums = { 2, 8, 0, 24, 51 };
            */

            //exercise 34
            /*
            bool cont = true;
            int[] e34Nums = { 16, 32, 64, 128, 256 };
            do
            {
                Console.WriteLine("Choose half or double: ");
                string e34Ans = Console.ReadLine().ToLower();
                if (e34Ans == "half")
                {
                    foreach (int num in e34Nums)
                    {
                        Console.WriteLine(num / 2);
                    }
                }
                else if (e34Ans == "double")
                {
                    foreach (int num in e34Nums)
                    {
                        Console.WriteLine(num * 2);
                    }
                }
                else
                {
                    Console.WriteLine("That's invalid");
                }
                Console.WriteLine("Continue? (y/n)");
                string contAns34 = Console.ReadLine().ToLower();
                if (contAns34 == "n")
                {
                    cont = false;
                }
            }
            while (cont);
            {
                Console.WriteLine("Goodbye!");
            }
            */

            //exercise 35
            /*
            string[] animals = { "cow", "elephant", "jaguar", "horse", "crow" }; // declare array of strings
            Console.WriteLine("Enter two indexes seperated by a space: "); // ask user to choose two indexes
            string[] tokens = Console.ReadLine().Split(); // take user input and turn into a string array 'tokens'
            int a = Int32.Parse(tokens[0]); // parse user entered number at index 0 save to variable 'a'
            int b = Int32.Parse(tokens[1]); // parse user entered number at index 1 save to variable 'b'
            Console.WriteLine(animals[a]); // print animal at position 'a'
            char[] chars = animals[a].ToCharArray(); // turn animal at position 'a' and make an array of char save to variable chars
            Console.WriteLine(chars[b]); // print char at position 'b' of the animal at position 'a'
            */

            //exercise 36
            /*
            int[] e36Nums = { 12, 11, 10, 9, 8 }; // create an int array of numbers
            string[] people = {"Drummers Drumming", "Pipers Piping", "Lords a-Leaping", "Ladies Dancing", "Maids a-Milking"}; // create a string array of people and verbs
            for (int i = 0; i < e36Nums.Length; i++) // for each element (i) in the int array print an element from int array followed by a space and then an element from the string array, continue until no more int array items
            {
                Console.WriteLine(e36Nums[i] + " " + people[i]);
            }
            */

            //exercise 37
            /*
            Console.Write("Enter a number: "); // take user input
            int a = Int32.Parse(Console.ReadLine()); // parse input and save it to the int variable 
            Console.Write("Enter a number: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            int c = Int32.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            int d = Int32.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            int e = Int32.Parse(Console.ReadLine());
            int[] array = { a, b, c, d, e }; // create an int array of the collected variables
            int total = a + b + c + d + e; // create int total that is the sum of the array elements
            Console.Write($"{a} + {b} + {c} + {d} + {e} = {total}"); // print on a single line the variables + other variables = to total
            */

            //exercise 38
            /*
            Console.Write("Enter a number: "); // take user input
            int v = Int32.Parse(Console.ReadLine()); // parse input and save it to the variable
            Console.Write("Enter a number: ");
            int w = Int32.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            int x = Int32.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            int y = Int32.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            int z = Int32.Parse(Console.ReadLine());
            int[] array38 = { v, w, x, y, z }; // create an int array of the collected variables
            double avg = (v + w + x + y + z) / array38.Length; // first add variables then divide by the amount of variables save this as avg
            Console.Write($"{v} + {w} + {x} + {y} + {z} / {array38.Length} = {avg}"); // print on a single line the variables + eachother / number of variables = avg
            */

            //exercise 39
            /*
            Console.Write("Enter a number: "); // take user input
            int a = Int32.Parse(Console.ReadLine()); // parse input and save it to the int variable 
            Console.Write("Enter a number: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            int c = Int32.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            int d = Int32.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            int e = Int32.Parse(Console.ReadLine());
            int[] array39 = { a, b, c, d, e }; // create an int array of the collected variables
            Array.Sort(array39); // sort variables from least to most
            for (int i = 0; i < array39.Length; i++) // for each element (i) of array39 print them until there is no more elements
            {
                Console.WriteLine(array39[i]);
            }
            */

            //exercise 40
            /*
            Console.Write("Enter a number: "); // take user input
            int a = Int32.Parse(Console.ReadLine()); // parse input and save it to the int variable 
            Console.Write("Enter a number: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            int c = Int32.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            int d = Int32.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            int e = Int32.Parse(Console.ReadLine());
            int[] array40 = { a, b, c, d, e }; // create an array of the collected variables
            int arrayLength = array40.Length; // get and save the total number of elements in the array to an int variable 
            Array.Sort(array40); // sort the array from least to most
            for (int i = 0; i < array40.Length; i++) // for each element (i) of array 40 print them until there is no more elements
            {
                Console.WriteLine(array40[i]);
            }
            int median = array40[(arrayLength / 2)]; // divide the total number of elements of the array by 2 to get the middle index save to median
            Console.WriteLine($"The median is: {median}"); // print the median
            */

            //exercise 41
            /*
            Console.Write("Enter a number: "); // take and parse user input
            decimal uno = Int32.Parse(Console.ReadLine()); // use a decimal type since we want 2 spots after the decimal
            Console.Write("Enter another number: ");
            decimal dos = Int32.Parse(Console.ReadLine());
            decimal div = uno / dos; // divide the two variables save total to variable
            Console.WriteLine($"{uno}/{dos} is approx. {div.ToString("0.00")}."); // print the solution change div to string and declare the format
            */

            //exercise 47
            /*
            bool cont = true; // bool for my while loop
            List<string> myWords = new List<string>(); // create a list called my words to hold user entered strings
            while (cont == true) //while cont is true keep running this code
            {
                Console.WriteLine("Enter some text: ");  // ask user to enter text
                string text = Console.ReadLine(); // add user input to text variable
                myWords.Add(text); // add text to the my words list
                Console.WriteLine("You have entered: "); // start of the out put outside o for loop so it only displays once
                for (int i = 0; i < myWords.Count; i++) // for every element in my words list display each element until none are left
                {
                    Console.Write($"{myWords[i]} ");
                }
                Console.WriteLine("\nContinue? (y/n)"); // ask user if they want to add more words
                string userAns = Console.ReadLine().ToLower(); // add users answer to a variable  
                    if (userAns == "n" || userAns == "y") // identify that user entered a correct response
                    {
                        if (userAns == "n") // if user said no change cont to false and exit while loop
                        {
                            cont = false;
                        }
                    }
                    else // if user entered something other than y or n break
                    {
                        Console.WriteLine("Invaid response");
                    }               
            }
            Console.WriteLine("Goodbye!"); // on exit of while loop display this message
            */

            //exercise 48
            /*
            bool cont = true; // bool for while loop
            List<int> numQ = new List<int>(); // declare a list to collect user entry
            while (cont == true) // while cont is true continue to loop
            {
                Console.Write("Enter a number (Q to quit): "); // prompt user to enter a number or q to quit
                string userInput = Console.ReadLine().ToUpper(); // take user response save it to user input
                int value; // declare an int variable for tryparse 
                if (int.TryParse(userInput, out value)) // use try parse to check if user entered an in if so save to value 
                {
                    numQ.Add(value); // add int to numQ list
                }
                else if (userInput == "Q") // if user enters q exit while loop
                {
                    break; // exits while loop
                }
                else // if user entered something else tell them response is invalid, loop will start over
                {
                    Console.WriteLine("That is not a valid response.");
                }
            }
            for (int i = 0; i < numQ.Count; i++) // print every item in numQ list until there are no more items
            {
                Console.Write($"{numQ[i]} + "); // display all list items followed by a plus sign IDK HOW TO DO LAST ONE WITHOUT PLUS SIGN :(
            }
            int sum = numQ.Take(numQ.Count).Sum(); //take all numQ values and add them together save sum
            Console.WriteLine($"= {sum}"); // display an equals sign and the sum of the numbers
            */

            //exercise 51
            /*
            Dictionary<string, string> lang = new Dictionary<string, string>(); // declare a dictionry of 2 strings called lang
            lang.Add("hello", "hola"); // add items containing two strings to lang dictionary
            lang.Add("food", "comida");
            lang.Add("world", "mundo");
            lang.Add("computer", "computadora");
            lang.Add("exercise", "ejercicio");
            Console.WriteLine("Enter a word in English: "); // ask the user for a word
            string input = Console.ReadLine(); // save the user input to input
            if (lang.ContainsKey(input) == false) // if dictionary doesnt contain this word as a first string (key) let user know
            {
                Console.WriteLine($"{input} cannot be translated.");
            }
            else // if dictionary contains the word output the second string (value)
            {
                Console.WriteLine($"{input} in spanish is {lang[input]}");
            }
            */
        }
        //exercise 58
        /// Enumerations: were not taught this week this is how they look though
        enum Suit
        {
            Diamonds,
            Hearts,
            Clubs,
            Spades
        }

        enum Browser
        {
            Chrome,
            Firefox,
            IE,
            Opera
        }

        enum Brand
        {
            Polo,
            Gucci,
            Armani,
            Athleta
        }

        enum Day
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
    }
}

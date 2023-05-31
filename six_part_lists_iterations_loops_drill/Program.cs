using System;
using System.Collections.Generic;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        /*
        // Part 1
        //Created a one-dimensional Array of strings.
        string[] wordstart = {
      "You graduated from the ",
      "Your nickname among your peers was, ",
      "The future is "
    };
        string[] wordend = {
       " College.",
       "!",
       "for you."
    };
        List<string> responses = new List<string>();
        //Asked the user to input some text.
        Console.WriteLine("Please enter a noun: ");
        responses.Add(Console.ReadLine());
        Console.WriteLine("Please enter the name of someone infamous: ");
        responses.Add(Console.ReadLine());
        Console.WriteLine("Please enter an adjective");
        responses.Add(Console.ReadLine());
        //Create a loop that goes through each string in the Array, adding the user's text to the string.
        for (int i = 0; i < wordstart.Length; i++)
        {
            wordstart[i] += responses[i]; Console.WriteLine(wordstart[i] + wordend[i]);
        }
        Console.ReadLine();
        Console.WriteLine("The strings we used: ");
        //Then create a loop that prints off each string in the Array on a separate line.
        for (int i = 0; i < wordstart.Length; i++)
        {
            Console.WriteLine(wordstart[i] + wordend[i]);
            
            //Part 2
            // Created an infinite loop
            //Uncomment "i--;" to run
            //i--;
            Console.ReadLine();
        
        //Part 3
        Console.WriteLine("Wanna get a gift?!");
        StringBuilder gift = new StringBuilder();
        gift.Append("Y");
        //Created a loop where the comparison that's used to determine whether to continue iterating
        //the loop is a "<" operator.
        while (gift.Length < 20)
        {
            gift.Append("a");
        }
        gift.Append("y!");
        Console.ReadLine();
        Console.WriteLine(gift);
        Console.ReadLine();
        StringBuilder oh = new StringBuilder();
        oh.Append("O");
        //Added a loop where the comparison that's used to determine whether to continue iterating the
        //loop is a "<=" operator.
        while (oh.Length <= 20)
        {
            oh.Append("o");
        }
        oh.Append("h!");
        Console.WriteLine(oh);
        Console.ReadLine();
    }
}

        //Part 4
        //Created a List of strings where each item in the list is unique.
        List<string> teams = new List<string>() { "Red Bull Racing", "Aston Martin", "Mercedes", "Ferrari", "McLaren",
        "Alpine", "Haas F1 Team", "Alfa Romeo", "AlphaTauri", "Williams" };
        Console.WriteLine("Formula 1 Teams");
        //Asked the user to input text to search for in the List.
        Console.WriteLine("Enter Formula 1 team name: ");
        int status = 0;
        bool isValid = false;
        int index = 0;
        //Created a loop that iterates through the list and then displays
        //the index of the array that contains matching text on the screen.
        while (!isValid)
        {
            int i2 = 0;
            string teamrequest = Console.ReadLine();
            foreach (string team in teams)
            {
                if (teamrequest == team)
                {
                    status = i2 + 1;
                    index = i2;
                }
                i2++;
            }
                //Added code to that above loop that tells a user if they put in text that isn't in the List.
                if (status == 0)
                {
                    Console.WriteLine("That is not a valid team name. Enter again: ");
                } 
                //Added code to that above loop that stops it from executing once a
                //match has been found.
                else
                {
                    isValid =  true;
                }
            }
            Console.WriteLine("Processing... Index is: " + index + ". So...");
            Console.WriteLine("Status is:" + status); Console.ReadLine();
        
        // Part 5
        // Created a List of strings that has at least two identical strings in the List.
        List<string> tables = new List<string>() { "Reserved", "Vacant", "Taken", "Vacant", "Vacant", "Reserved", "Taken" }; 
        Console.WriteLine("Welcome to the Escape Room Games! \nTo comply with the sanitization rules we have a computerized check -in.\nIf you have booked an appointment with us type " + "\"Reserved\".\nIf you are joining a party that is already here type \"Taken\" .\nOtherwise type \"Vacant\".");
        //Asked the user to select text to search for in the List.
        Console.WriteLine("Enter selection: ");
        string selection = Console.ReadLine();
        while (!(selection == "Vacant" || selection == "Reserved" || selection == "Taken"))
        { 
        //Added code that tells a user if they put in text that isn't in the List.
        Console.WriteLine("Please enter one of the 3 choices: ");
        selection = Console.ReadLine();
        
        }
        Console.WriteLine("The gaming rooms that match your selection are numbered: ");
        //Created a loop that iterates through the loop and then
        //displays the indices of the array that contain
        //matching text on the screen.
        for (int i3 = 0; i3 < tables.Count; i3++)
        {
            if (selection == tables[i3])
            {
                Console.WriteLine(i3);
            }
        }
        Console.ReadLine(); 
        */
        //Part 6
        //Created a List of strings that has at least two identical strings in the List.
        List<string> names = new List<string>() {"Buddy", "Bella", "Charlie", "Luna", "Max", "Daisy", "Bailey", "Bella", "Charlie", };
        List<string> repeatCheck = new List<string>();
        Console.WriteLine("Dogs Roster:");
        //Create a foreach loop that evaluates each item in the list, and displays a message showing
        //the string and whether or not it has already appear
        foreach (string name in names)
        {
            Console.WriteLine(name);
            if (repeatCheck.Contains(name))
            {
                Console.WriteLine("This name has been repeated. \nUse the owner's last name referring to this dog.");
            }
            else
            {
                Console.WriteLine("This name has not been reported");
            }
            repeatCheck.Add(name);
        }
        Console.ReadLine();
    }
}

    


            
using System;
using System.Linq;

class Program {
  public static void Main (string[] args) {

    //arrays containing names, initials, and sale number
    string [,] nameData = { {"Danielle", "D"},
                            {"Edward", "E"},
                            {"Francis", "F"} };
    int [] saleData = { 0,
                        0,
                        0 };

    //prompt user for input of initial
    Console.Write("Enter a salesperson's initial, or 'Z' to end: ");
    string userInput = Console.ReadLine().ToUpper();
    Console.WriteLine();

    while (userInput != "Z")
    {
      switch (userInput)
      {
        case "D":
        //prompt user for input of sale number
        Console.Write("Enter the sale value to the nearest $: ");
        userInput = Console.ReadLine();
        Console.WriteLine();

        //ensures sale input is an integer, returns 0 if it is not, and adds it to the local sale total
        saleData[0] += IsInputNumber.GetInt(userInput) ?? 0;
        break;

        
        case "E":
        //prompt user for input of sale number
        Console.Write("Enter the sale value to the nearest $: ");
        userInput = Console.ReadLine();
        Console.WriteLine();

        //ensures sale input is an integer, returns 0 if it is not, and adds it to the local sale total
        saleData[1] += IsInputNumber.GetInt(userInput) ?? 0;
        break;


        case "F":
        //prompt user for input of sale number
        Console.Write("Enter the sale value to the nearest $: ");
        userInput = Console.ReadLine();
        Console.WriteLine();

        //ensures sale input is an integer, returns 0 if it is not, and adds it to the local sale total
        saleData[2] += IsInputNumber.GetInt(userInput) ?? 0;
        break;
        
        default:
        Console.WriteLine("Invalid input");
        Console.WriteLine();
        break;
      }

      //prompt user for input of initial after inputting a sale number
      Console.Write("Enter a salesperson's initial, or 'Z' to end: ");
      userInput = Console.ReadLine().ToUpper();
      Console.WriteLine();
    }

    //prints out the total sales for each salesperson, the grand total, and the person with the highest sales
    for(int i = 0; i < nameData.GetLength(0); i++)
    {
      Console.WriteLine(nameData[i,0] + ": " + saleData[i]);
    }

    Console.WriteLine("Grand Total: " + saleData.Sum());

    Console.WriteLine("Highest Sale: " + nameData[Array.IndexOf(saleData, saleData.Max()), 1]);
  }
}
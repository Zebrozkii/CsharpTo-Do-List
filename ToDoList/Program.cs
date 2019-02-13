using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the To Do List!");
      ListFunctions();
    }
    public static void ListFunctions()
    {
      Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~");
      Console.WriteLine("Would you like to ADD an item or VIEW your list?");
      string userAddOrView = Console.ReadLine().ToUpper();
      Console.WriteLine("-----");

      if ((userAddOrView == "ADD") || (userAddOrView == "A"))
      {
        Console.WriteLine("Please enter a description for your new item:");
        new Item(Console.ReadLine());
        ListFunctions();
      }
      else if ((userAddOrView == "VIEW") || (userAddOrView == "V"))
      {
        List<Item> result = Item.GetAll();

        int i = 1;
        foreach (Item thisItem in result)
        {
          Console.WriteLine($"{i++}. {thisItem.GetDescription()}");
        }
        i = 1;

        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Clear your list?");
        string userClearList = Console.ReadLine().ToUpper();

        if ((userClearList == "YES") || (userClearList == "Y"))
        {
          Item.ClearAll();
          ListFunctions();
        }
        else
        {
          ListFunctions();
        }
      }
      else
      {
        Console.WriteLine("I'm sorry, I didn't understand that. Return to menu?");
        string userReturnToMenu = Console.ReadLine().ToUpper();

        if ((userReturnToMenu == "YES") || (userReturnToMenu == "Y"))
        {
          ListFunctions();
        }
      }
    }
  }
}

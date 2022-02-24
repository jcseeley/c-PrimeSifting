using System;
using System.Collections.Generic;

public class Program
{
  public static List<int> intList = new List<int> {};

  public static void Main()
  {
    Console.WriteLine("Please enter a number:");
    int response = int.Parse(Console.ReadLine());
    
    for(int i = 2; i < response; i++)
    {
      if (i <= response)
      {
        intList.Add(i);
      }
    }
    for (int i = 0; i < intList.Count; i++)
    {
      int prime = i + 2;
      for (int j = i; j < intList.Count; j++)
      {
        if (intList[j] != 2 && intList[j] != 3 && intList[j] % prime == 0)
        {
          intList.Remove(intList[j]);
        }
      }
    }
    foreach(int num in intList)
    {
      Console.WriteLine(num);
    }
  }
}
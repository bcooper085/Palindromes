using System;
using System.Collections.Generic;

namespace Palin.Objects
{
  public class Palins
  {
    char[] userInput;
    char[] reverseInput;

    public bool ReverseString(string stringInput)
    {
      userInput = new char[stringInput.Length];
      userInput = stringInput.ToCharArray();
      int inputLength = userInput.Length - 1;
      reverseInput = new char[userInput.Length];
      for (int i = 0; i < userInput.Length; i++)
      {
        reverseInput[i] = userInput[inputLength];
        inputLength--;
      }
      string a = new string(userInput);
      string b = new string(reverseInput);
      if (a == b)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}

using System;

namespace Palindromes
{
  public class Palin
  {
    public bool IsPalindrome(string word)
    { 
      if (word[word.Length - 1] == word[0]) 
      {
        string[] reverseArray = new string[word.Length];
        // word = "abcd"
        for (int i = 0; i <= word.Length - 1 ; i++) 
        {
          int x = i;
          int y = word.Length - (1 + i);
          reverseArray[x] = word[y].ToString();
        }
        return string.Join("", reverseArray) == word; 
      }
      else 
      {
        return false;
      }
    }

    public bool IsPalindrome(int number)
    {
      return IsPalindrome(number.ToString());
    }
  }
} 

/*
give input into array.reverse
compare reverse array to original with bool

put input into array
use array.split to split every element in array 
throw new array in for loop with length as conditional


0 1 2 3 4 5
1 2 3 3 2 1
*/
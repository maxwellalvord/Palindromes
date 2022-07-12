namespace Palindromes
{
  public class Palin
  {
    public bool IsPalindrome(string word)
    { 
      if (word[word.Length - 1] == word[0]) 
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
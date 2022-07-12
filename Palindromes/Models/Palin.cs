namespace Palindromes
{
  public class Palin
  {
    public bool IsPalindrome(string word)
    { 
      string[] reverseArray = new string[word.Length];
      for (int i = 0; i <= word.Length - 1 ; i++) 
      {
        int x = i;
        int y = word.Length - (1 + i);
        reverseArray[x] = word[y].ToString();
      }
      return string.Join("", reverseArray) == word; 
    }

    public bool IsPalindrome(int number)
    {
      return IsPalindrome(number.ToString());
    }
  }
} 

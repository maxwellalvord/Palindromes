using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindromes;

namespace Palindromes.Tests
{
  [TestClass]
  public class PalinTests
  {
    [TestMethod]
    public void IsPalindrome_HasSameEnds_True()
    {
      Palin testPalin = new Palin();
      Assert.AreEqual(true, testPalin.IsPalindrome("1221"));
    }

    [TestMethod]
    public void IsPalindrome_AStringPalindrome_False()
    {
      Palin testPalin = new Palin();
      Assert.AreEqual(false, testPalin.IsPalindrome("1231"));
    }

    [TestMethod]
    public void IsPalindrome_AIntPalindrome_False()
    {
      Palin testPalin = new Palin();
      Assert.AreEqual(false, testPalin.IsPalindrome(1231));
    }
  }
}
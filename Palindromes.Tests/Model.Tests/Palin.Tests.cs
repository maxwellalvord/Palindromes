using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    public void IsPalindrome_AnIntPalindrome_False()
    {
      Palin testPalin = new Palin();
      Assert.AreEqual(false, testPalin.IsPalindrome(1231));
    }

    [TestMethod]
    public void IsPalindrome_AStringPalindrome_True()
    {
      Palin testPalin = new Palin();
      Assert.AreEqual(true, testPalin.IsPalindrome("abba"));
    }

    [TestMethod]
    public void IsPalindrome_AnIntPalindrome_True()
    {
      Palin testPalin = new Palin();
      Assert.AreEqual(true, testPalin.IsPalindrome(1221));
    }
  }
}
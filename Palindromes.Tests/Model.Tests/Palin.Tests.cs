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
      Assert.AreEqual(true, testPalin.IsPalindrome("121"));
    }
  }
}
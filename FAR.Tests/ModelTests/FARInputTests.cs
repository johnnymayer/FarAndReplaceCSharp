using Microsoft.VisualStudio.TestTools.UnitTesting;
using Far.Models;

namespace Far.Tests
{
  [TestClass]
  public class FarTest
  {
    [TestMethod]
    public void GetPhraseTest_ReturnsPhrase()
    {

      //Arrange
      string testPhrase = "This is a test phrase.";
      string testFind = "test";
      string testReplace = "comical";
      FarInputs newFarInputs = new FarInputs("This is a test phrase.", "test", "comical");

      //Act
      string result = newFarInputs.GetPhrase();
      string result2 = newFarInputs.GetFind();
      string result3 = newFarInputs.GetReplace();

      //Assert
      Assert.AreEqual(result, testPhrase);
      Assert.AreEqual(result2, testFind);
      Assert.AreEqual(result3, testReplace);
    }

    [TestMethod]
    public void FindAndReplaceTest_WillReplaceFound_String()
    {
      //Arrange
      string controlPhrase = "This is a comical phrase.";
      FarInputs newFarInputs = new FarInputs("This is a test phrase.", "test", "comical");

      //Act
      string target = newFarInputs.FindAndReplace();

      //Assert
      Assert.AreEqual(target, controlPhrase);
    }

  }
}

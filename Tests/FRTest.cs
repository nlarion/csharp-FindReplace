using Xunit;
using System;
// using System.Linq;
using System.Collections.Generic;
namespace  FinderReplacer
{
  public class FRTest
  {
    [Fact]
    public void ReturnUniverseForWorld()
    {
      string newFindReplace = FindReplace.FindAndReplace("Hello World","world","universe");
      Assert.Equal("Hello universe", newFindReplace);
    }
    [Fact]
    public void ReturnUniverseForLowerCaseWorld()
    {
      string newFindReplace = FindReplace.FindAndReplace("I am walking my cat to the cathedral","cat","dog");
      Assert.Equal("I am walking my dog to the doghedral", newFindReplace);
    }
  }
}
